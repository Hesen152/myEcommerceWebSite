#pragma checksum "C:\Users\User\Desktop\myproject\clicker.webui\Views\Shared\_home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e506a204fe3e30f1281946fb4111e7615d6152ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__home), @"mvc.1.0.view", @"/Views/Shared/_home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e506a204fe3e30f1281946fb4111e7615d6152ba", @"/Views/Shared/_home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd4949d55e9290a3bc63b89e44593b9de4d6f4d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""home"">
		<!-- container -->
		<div class=""container"">
			<!-- home wrap -->
			<div class=""home-wrap"">
				<!-- home slick -->
				<div id=""home-slick"" class=""slick-initialized slick-slider""><button class=""slick-prev slick-arrow"" aria-label=""Previous"" type=""button"" style=""display: block;"">Previous</button>
					<!-- banner -->
					<div class=""slick-list draggable""><div class=""slick-track"" style=""opacity: 1; width: 6090px; transform: translate3d(-2610px, 0px, 0px); transition: transform 300ms ease 0s;""><div class=""banner banner-1 slick-slide slick-cloned"" data-slick-index=""-1"" aria-hidden=""true"" tabindex=""-1"" style=""width: 870px;"">
						<img src=""./img/banner03.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 693, "\"", 699, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						<div class=""banner-caption"">
							<h1 class=""white-color"">New Product <span>Collection</span></h1>
							<button class=""primary-btn"" tabindex=""-1"">Shop Now</button>
						</div>
					</div><div class=""banner banner-1 slick-slide"" data-slick-index=""0"" aria-hidden=""true"" tabindex=""-1"" style=""width: 870px;"">
						<img src=""./img/banner01.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1059, "\"", 1065, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						<div class=""banner-caption text-center"">
							<h1>Bags sale</h1>
							<h3 class=""white-color font-weak"">Up to 50% Discount</h3>
							<button class=""primary-btn"" tabindex=""-1"">Shop Now</button>
						</div>
					</div><div class=""banner banner-1 slick-slide"" data-slick-index=""1"" aria-hidden=""true"" tabindex=""0"" style=""width: 870px;"">
						<img src=""./img/banner02.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1456, "\"", 1462, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						<div class=""banner-caption"">
							<h1 class=""primary-color"">HOT DEAL<br><span class=""white-color font-weak"">Up to 50% OFF</span></h1>
							<button class=""primary-btn"" tabindex=""0"">Shop Now</button>
						</div>
					</div><div class=""banner banner-1 slick-slide slick-current slick-active"" data-slick-index=""2"" aria-hidden=""false"" tabindex=""-1"" style=""width: 870px;"">
						<img src=""./img/banner03.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1884, "\"", 1890, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						<div class=""banner-caption"">
							<h1 class=""white-color"">New Product <span>Collection</span></h1>
							<button class=""primary-btn"" tabindex=""-1"">Shop Now</button>
						</div>
					</div><div class=""banner banner-1 slick-slide slick-cloned"" data-slick-index=""3"" aria-hidden=""true"" tabindex=""-1"" style=""width: 870px;"">
						<img src=""./img/banner01.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2263, "\"", 2269, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						<div class=""banner-caption text-center"">
							<h1>Bags sale</h1>
							<h3 class=""white-color font-weak"">Up to 50% Discount</h3>
							<button class=""primary-btn"" tabindex=""-1"">Shop Now</button>
						</div>
					</div><div class=""banner banner-1 slick-slide slick-cloned"" data-slick-index=""4"" aria-hidden=""true"" tabindex=""-1"" style=""width: 870px;"">
						<img src=""./img/banner02.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2674, "\"", 2680, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						<div class=""banner-caption"">
							<h1 class=""primary-color"">HOT DEAL<br><span class=""white-color font-weak"">Up to 50% OFF</span></h1>
							<button class=""primary-btn"" tabindex=""-1"">Shop Now</button>
						</div>
					</div><div class=""banner banner-1 slick-slide slick-cloned"" data-slick-index=""5"" aria-hidden=""true"" tabindex=""-1"" style=""width: 870px;"">
						<img src=""./img/banner03.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3088, "\"", 3094, 0);
            EndWriteAttribute();
            WriteLiteral(@">
						<div class=""banner-caption"">
							<h1 class=""white-color"">New Product <span>Collection</span></h1>
							<button class=""primary-btn"" tabindex=""-1"">Shop Now</button>
						</div>
					</div></div></div>
					<!-- /banner -->

					<!-- banner -->
					
					<!-- /banner -->

					<!-- banner -->
					
					<!-- /banner -->
				<button class=""slick-next slick-arrow"" aria-label=""Next"" type=""button"" style=""display: block;"">Next</button></div>
				<!-- /home slick -->
			</div>
			<!-- /home wrap -->
		</div>
		<!-- /container -->
	</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
