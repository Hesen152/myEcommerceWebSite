using System.Net.Http;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace clicker.webui.EmaiLService
{
    public class SmptSender:IEmail
    {
        private string _host;

        private int _port;

        private bool _enableSSSL;

        private string _userName;

        private string _password;


        public SmptSender(string host,int port,bool enableSSSL,string userName,string password)
        {
            _host=host;
             _port=port;
             _enableSSSL=enableSSSL;
             _userName=userName;
              _password=password;
            
        }

     

        public Task SendEmailAsync(string email, string subject, string messagehtml)
        {
             var cli=new SmtpClient(this._host,this._port)
           {
               Credentials=new NetworkCredential(_userName,_password),
               EnableSsl=_enableSSSL

           };

           return cli.SendMailAsync(
               new MailMessage(this._userName,email,subject,messagehtml)
           );
        }
    }
}