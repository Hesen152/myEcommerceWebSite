using System.Reflection.Emit;
using System.Reflection;
using System.Xml.Schema;
using System;
using System.Reflection.Metadata;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using clicker.webui.EmaiLService;
using clicker.webui.Extend;
using clicker.webui.Identity;
using clicker.webui.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace clicker.webui.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;

        private SignInManager<User> _signInManager;

        private IEmail _emailSender;



        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager,
         IEmail emailSender)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _emailSender = emailSender;



        }

        // string ReturnUrl=null

        public IActionResult Login()

        {
            return View(
            // new LoginModel(){ReturnUrl=ReturnUrl}

            );
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);

            }

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Bele Bir istifadeci yoxdur");
                return View();

            }

            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Email hesabiniz ile tesdiq edin!");
                return View(model);

            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);

             if (result.Succeeded)
             {
                 //return Redirect(model.ReturnUrl??"~/");
                return RedirectToAction("Index","Home");
              }
           
            ModelState.AddModelError("", "Istifadeci adi ve yaxud parol yalnisdir");

            return View(model);
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            TempData.Put("message", new MessageExplanation(){
                Title="Closed Session",
                Message="Session Baglandi",
                AlertType="success"
                
            });

            return Redirect("~/");
        }


         [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();

        }

        [HttpPost]
        public   async Task<IActionResult> ForgotPassword(string Email)
        {

            if (string.IsNullOrEmpty(Email))
            {
                return View();
                
            }
            var user= await _userManager.FindByEmailAsync(Email);

            if (user==null)
            {
                return View();

                
            }
            //generate token
            var code= await _userManager.GeneratePasswordResetTokenAsync(user);
             var url=Url.Action("ResetPassword","Account",
             new{
                 userId=user.Id,
                 token=code

             });


             await _emailSender.SendEmailAsync(Email,"ResetPassword",$"Parolunuz Yenilemek ucun <a href='http://localhost:5000{url}'></a> klikleyin");
            return View();

               



        }


        public IActionResult ResetPassword(string userId,string token)
        {
            if (userId==null || token==null)
            {
                return RedirectToAction("Home","Index");
                
            }

            var model=new PasswordResetModel{Token=token};

            return View();



        }

         [HttpPost]

         public async Task<IActionResult> ResetPassword(PasswordResetModel model)
        {
            if (!ModelState.IsValid)
            {

                return View(model);
                
            }

            var user=await _userManager.FindByEmailAsync(model.Email);
            if (user==null)
            {
                return RedirectToAction("Home","Index");
                
            }

            var result=await _userManager.ResetPasswordAsync(user,model.Token,model.Password);
            if (result.Succeeded)
            {
                     return RedirectToAction("Login" ,"Account");
                
            }

             return View(model);


        }



 






        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);

            }

            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email

            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var osnc = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("EmailConfirm", "Account", new
                {
                    userId = user.Id,
                    token = osnc
                });

                await _emailSender.SendEmailAsync(model.Email, "Hesabiniz Tesdiqleyin", $"Emaili tesdiq etmek ucu inke <a href='http://localhost:5000{url}'>Klikleyin</a>");
                return RedirectToAction("Login", "Account");


            }

            ModelState.AddModelError("", "Parol ve ya Email yalnisdir");
            return View(model);




        }


        public async Task<IActionResult> EmailConfirm(string userId, string token)
        {
            if (userId == null || token == null)
            {
                TempData.Put("message", new MessageExplanation()
                {
                    Title = "Yanlis Token",
                    Message = "Yalnis Token",
                    AlertType = "warning"
                });

                return View();


            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {

                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {

                    TempData.Put("message", new MessageExplanation()
                    {
                        Title = "Hesab Tesdiq",
                        Message = "Hesabiniz Tesdilendi",
                        AlertType = "success"
                    });

                    return View();


                }


            }

            TempData.Put("message", new MessageExplanation()
            {
                Title = "Hesab Tesdiq",
                Message = "Hesabiniz Tesdilendi",
                AlertType = "success"
            });

            return View();
        }


    }
}