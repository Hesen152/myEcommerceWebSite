#pragma checksum "C:\Users\User\Desktop\myproject\clicker.webui\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3f0c1303e2e2c999ba12994ad92a3c40412a0b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\User\Desktop\myproject\clicker.webui\Views\_ViewImports.cshtml"
using clicker.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\myproject\clicker.webui\Views\_ViewImports.cshtml"
using clicker.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\myproject\clicker.webui\Views\_ViewImports.cshtml"
using clicker.webui.Extend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\myproject\clicker.webui\Views\_ViewImports.cshtml"
using clicker.webui.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\myproject\clicker.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3f0c1303e2e2c999ba12994ad92a3c40412a0b8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e1c69efd376f1830288135e579caa4485717bc9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_section1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_section2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_section3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n\t\t\t\t\t    ");
#nullable restore
#line 20 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Home\Index.cshtml"
                   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n\r\n\t\t\t\t");
            }
            );
            WriteLiteral("\t              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3f0c1303e2e2c999ba12994ad92a3c40412a0b85482", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("   \r\n\t              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3f0c1303e2e2c999ba12994ad92a3c40412a0b86618", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("   \r\n\t              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3f0c1303e2e2c999ba12994ad92a3c40412a0b87754", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("   \r\n\t              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3f0c1303e2e2c999ba12994ad92a3c40412a0b88890", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"   
					  

					  
		<!-- container -->
		<div class=""container"">
			<!-- row -->
			<div class=""row"">
				<!-- section title -->
				<div class=""col-md-12"">
					<div class=""section-title"">
						<h2 class=""title"">Latest Products</h2>
					</div>
				</div>
	
			</div>
			<!-- /row -->

			<!-- row -->
			<div class=""row"">
				<!-- banner -->
				<div class=""col-md-3 col-sm-6 col-xs-6"">
					<div class=""banner banner-2"">
						<img src=""./img/banner15.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1111, "\"", 1117, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						<div class=""banner-caption"">
							<h2 class=""white-color"">NEW<br>COLLECTION</h2>
							<button class=""primary-btn"">Shop Now</button>
						</div>
					</div> 
					
				</div>
				<!-- /banner -->

				<!-- Product Single -->
				<div class=""col-md-3 col-sm-6 col-xs-6"">
					<div class=""product product-single"">
						<div class=""product-thumb"">
							<div class=""product-label"">
								<span>New</span>
								<span class=""sale"">-20%</span>
							</div>
							<button class=""main-btn quick-view""><i class=""fa fa-search-plus""></i> Quick view</button>
							<img src=""./img/product07.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1742, "\"", 1748, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						</div>
						<div class=""product-body"">
							<h3 class=""product-price"">$32.50 <del class=""product-old-price"">$45.00</del></h3>
							<div class=""product-rating"">
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star-o empty""></i>
							</div>
							<h2 class=""product-name""><a href=""#"">Product Name Goes Here</a></h2>
							<div class=""product-btns"">
								<button class=""main-btn icon-btn""><i class=""fa fa-heart""></i></button>
								<button class=""main-btn icon-btn""><i class=""fa fa-exchange""></i></button>
								<button class=""primary-btn add-to-cart""><i class=""fa fa-shopping-cart""></i> Add to Cart</button>
							</div>
						</div>
					</div> 

");
            WriteLiteral(@"
					
					
					
				</div>
				<!-- /Product Single -->

				<!-- Product Single -->
				<div class=""col-md-3 col-sm-6 col-xs-6"">
					<div class=""product product-single"">
						<div class=""product-thumb"">
							<div class=""product-label"">
								<span>New</span>
								<span class=""sale"">-20%</span>
							</div>
							<button class=""main-btn quick-view""><i class=""fa fa-search-plus""></i> Quick view</button>
							<img src=""./img/product06.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3178, "\"", 3184, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						</div>
						<div class=""product-body"">
							<h3 class=""product-price"">$32.50 <del class=""product-old-price"">$45.00</del></h3>
							<div class=""product-rating"">
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star-o empty""></i>
							</div>
							<h2 class=""product-name""><a href=""#"">Product Name Goes Here</a></h2>
							<div class=""product-btns"">
								<button class=""main-btn icon-btn""><i class=""fa fa-heart""></i></button>
								<button class=""main-btn icon-btn""><i class=""fa fa-exchange""></i></button>
								<button class=""primary-btn add-to-cart""><i class=""fa fa-shopping-cart""></i> Add to Cart</button>
							</div>
						</div>
					</div>
				</div>
				<!-- /Product Single -->

				<!-- Product Single -->
				<div class=""col-md-3 col-sm-6 col-xs-6"">
					<div class=""product product-single"">
						<div class=""product-thumb"">
							<div class=""prod");
            WriteLiteral("uct-label\">\r\n\t\t\t\t\t\t\t\t<span>New</span>\r\n\t\t\t\t\t\t\t\t<span class=\"sale\">-20%</span>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<button class=\"main-btn quick-view\"><i class=\"fa fa-search-plus\"></i> Quick view</button>\r\n\t\t\t\t\t\t\t<img src=\"./img/product05.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4438, "\"", 4444, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						</div>
						<div class=""product-body"">
							<h3 class=""product-price"">$32.50 <del class=""product-old-price"">$45.00</del></h3>
							<div class=""product-rating"">
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star""></i>
								<i class=""fa fa-star-o empty""></i>
							</div>
							<h2 class=""product-name""><a href=""#"">Product Name Goes Here</a></h2>
							<div class=""product-btns"">
								<button class=""main-btn icon-btn""><i class=""fa fa-heart""></i></button>
								<button class=""main-btn icon-btn""><i class=""fa fa-exchange""></i></button>
								<button class=""primary-btn add-to-cart""><i class=""fa fa-shopping-cart""></i> Add to Cart</button>
							</div>
						</div>
					</div>
				</div>
				<!-- /Product Single -->
			</div>
			<!-- /row -->

			<!-- row -->
			
			<!-- /row -->
		</div>
		<!-- /container -->
	</div>
					  





");
            WriteLiteral("\t             \r\n\r\n\t         \r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
