#pragma checksum "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "270588ff88ce2f9c1206256536e7cadd43f11bf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trading_List), @"mvc.1.0.view", @"/Views/Trading/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"270588ff88ce2f9c1206256536e7cadd43f11bf1", @"/Views/Trading/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e1c69efd376f1830288135e579caa4485717bc9", @"/Views/_ViewImports.cshtml")]
    public class Views_Trading_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- container -->


<!-- BREADCRUMB -->
<div id=""breadcrumb"">
<div class=""container"">
<ul class=""breadcrumb"">
<li><a href=""#"">Home</a></li>
<li class=""active"">Products</li>
</ul>
</div>
</div> 
<!-- /BREADCRUMB -->

<!-- section -->
<div class=""section"">
<!-- container -->
<div class=""container"">
<!-- row -->
<div class=""row"">
<!-- ASIDE -->
<div id=""aside"" class=""col-md-3"">
	 <div class=""card mt-3"">
  <div class=""card-header"">
      <h5>Search</h5>
  </div>
  <div class=""card-body"">
       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "270588ff88ce2f9c1206256536e7cadd43f11bf15596", async() => {
                WriteLiteral("\r\n       <div class=\"form-group\">\r\n            <input name=\"search\" type=\"text\" class=\"form-control\" placeholder=\"Search\">\r\n       </div>\r\n      <button type=\"submit\" class=\"btn btn-danger btn-sm btn-block\">Axtar</button>\r\n\r\n\r\n      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  </div>\r\n\r\n </div>\r\n \r\n<!-- aside widget -->\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<!-- /aside widget -->\r\n\r\n<!-- aside widget -->\r\n");
            WriteLiteral(@"<!-- aside widget -->

<!-- aside widget -->
<div class=""aside"">
<h3 class=""aside-title"">Filter By Color:</h3>
<ul class=""color-option"">
	<li><a href=""#"" style=""background-color:#475984;""></a></li>
	<li><a href=""#"" style=""background-color:#8A2454;""></a></li>
	<li class=""active""><a href=""#"" style=""background-color:#BF6989;""></a></li>
	<li><a href=""#"" style=""background-color:#9A54D8;""></a></li>
	<li><a href=""#"" style=""background-color:#675F52;""></a></li>
	<li><a href=""#"" style=""background-color:#050505;""></a></li>
	<li><a href=""#"" style=""background-color:#D5B47B;""></a></li>
</ul>
</div>
<!-- /aside widget -->

<!-- aside widget -->
<div class=""aside"">
<h3 class=""aside-title"">Filter By Size:</h3>
<ul class=""size-option"">
	<li class=""active""><a href=""#"">S</a></li>
	<li class=""active""><a href=""#"">XL</a></li>
	<li><a href=""#"">SL</a></li>
</ul>
</div>
<!-- /aside widget -->

<!-- aside widget -->
<div class=""aside"">
<h3 class=""aside-title"">Filter by Brand</h3>
<ul class=""list-links"">
");
            WriteLiteral(@"	<li><a href=""#"">Nike</a></li>
	<li><a href=""#"">Adidas</a></li>
	<li><a href=""#"">Polo</a></li>
	<li><a href=""#"">Lacost</a></li>
</ul>
</div>
<!-- /aside widget -->

<!-- aside widget -->
<div class=""aside"">
<h3 class=""aside-title"">Filter by Gender</h3>
<ul class=""list-links"">
	<li class=""active""><a href=""#"">Men</a></li>
	<li><a href=""#"">Women</a></li>
</ul>
</div>
<!-- /aside widget -->

<!-- aside widget -->
<div class=""aside"">
<h3 class=""aside-title"">Top Rated Product</h3>
<!-- widget product -->
<div class=""product product-widget"">
	<div class=""product-thumb"">
		<img src=""/img/thumb-product01.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3674, "\"", 3680, 0);
            EndWriteAttribute();
            WriteLiteral(@">
	</div>
	<div class=""product-body"">
		<h2 class=""product-name""><a href=""#"">Product Name Goes Here</a></h2>
		<h3 class=""product-price"">$32.50 <del class=""product-old-price"">$45.00</del></h3>
		<div class=""product-rating"">
			<i class=""fa fa-star""></i>
			<i class=""fa fa-star""></i>
			<i class=""fa fa-star""></i>
			<i class=""fa fa-star""></i>
			<i class=""fa fa-star-o empty""></i>
		</div>
	</div>
</div>
<!-- /widget product -->

<!-- widget product -->
<div class=""product product-widget"">
	<div class=""product-thumb"">
		<img src=""/img/thumb-product01.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4259, "\"", 4265, 0);
            EndWriteAttribute();
            WriteLiteral(@">
	</div>
	<div class=""product-body"">
		<h2 class=""product-name""><a href=""#"">Product Name Goes Here</a></h2>
		<h3 class=""product-price"">$32.50</h3>
		<div class=""product-rating"">
			<i class=""fa fa-star""></i>
			<i class=""fa fa-star""></i>
			<i class=""fa fa-star""></i>
			<i class=""fa fa-star""></i>
			<i class=""fa fa-star-o empty""></i>
		</div>
	</div>
</div>
<!-- /widget product -->
</div>
<!-- /aside widget -->
</div>
<!-- /ASIDE -->

<!-- MAIN -->
<div id=""main"" class=""col-md-9"">
<!-- store top filter -->
<div class=""store-filter clearfix"">
<div class=""pull-left"">
	<div class=""row-filter"">
		<a href=""#""><i class=""fa fa-th-large""></i></a>
		<a href=""#"" class=""active""><i class=""fa fa-bars""></i></a>
	</div>
	<div class=""sort-filter"">
		<span class=""text-uppercase"">Sort By:</span>
		<select class=""input"">
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "270588ff88ce2f9c1206256536e7cadd43f11bf110934", async() => {
                WriteLiteral("Position");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "270588ff88ce2f9c1206256536e7cadd43f11bf112104", async() => {
                WriteLiteral("Price");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "270588ff88ce2f9c1206256536e7cadd43f11bf113271", async() => {
                WriteLiteral("Rating");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</select>\r\n\t\t<a href=\"#\" class=\"main-btn icon-btn\"><i class=\"fa fa-arrow-down\"></i></a>\r\n\t</div>\r\n</div>\r\n<div class=\"pull-right\">\r\n");
            WriteLiteral("\t<div class=\"row\">\r\n\t\t <div class=\"col\">\r\n\t\t <nav aria-label=\"Page navigation example\">\r\n\t\t<ul class=\"pagination\">\r\n\t\t<li><span class=\"text-uppercase\">Page:</span></li>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 212 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
          for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
		 {
			 if (String.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
			 {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t <li");
            BeginWriteAttribute("class", " class=\"", 6151, "\"", 6215, 2);
            WriteAttributeValue("", 6159, "page-item", 6159, 9, true);
#nullable restore
#line 216 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
WriteAttributeValue(" ", 6168, Model.PageInfo.CurrentPage==i+1?"active":"", 6169, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                 <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6256, "\"", 6284, 2);
            WriteAttributeValue("", 6263, "/products?page=", 6263, 15, true);
#nullable restore
#line 217 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
WriteAttributeValue("", 6278, i+1, 6278, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 217 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
                                                               Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n\t\t\t\t </li>\r\n");
#nullable restore
#line 220 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
			 }

			 else
			 {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t <li");
            BeginWriteAttribute("class", " class=\"", 6346, "\"", 6410, 2);
            WriteAttributeValue("", 6354, "page-item", 6354, 9, true);
#nullable restore
#line 224 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
WriteAttributeValue(" ", 6363, Model.PageInfo.CurrentPage==i+1?"active":"", 6364, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6439, "\"", 6499, 4);
            WriteAttributeValue("", 6446, "/products/", 6446, 10, true);
#nullable restore
#line 225 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
WriteAttributeValue("", 6456, Model.PageInfo.CurrentCategory, 6456, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6487, "?page=", 6487, 6, true);
#nullable restore
#line 225 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
WriteAttributeValue("", 6493, i+1, 6493, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 225 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
                                                                                              Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("+1</a></li>\r\n");
#nullable restore
#line 226 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
			 }



			 
		 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</ul>\r\n\t</nav>\r\n\t</div>\r\n\t\t</div>\r\n");
            WriteLiteral("</div>\r\n</div>\r\n<!-- /store top filter -->\r\n\r\n<!-- STORE -->\r\n<div id=\"store\">\r\n<!-- row -->\r\n<div class=\"row\">\r\n");
#nullable restore
#line 252 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
     foreach (var product in Model.Products)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral(" <div class=\"col-md-4 col-sm-6 col-xs-6\">\r\n\r\n     \r\n\t ");
#nullable restore
#line 256 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
Write(await Html.PartialAsync("_product",product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n     \r\n\t </div>\r\n");
#nullable restore
#line 260 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
	<div class=""clearfix visible-sm visible-xs""></div>
     
	<!-- Product Single -->
	
	
	
	<!-- /Product Single -->
</div>


<!-- /row -->
</div>
<!-- /STORE -->

<!-- store bottom filter -->
<div class=""store-filter clearfix"">
<div class=""pull-left"">
	<div class=""row-filter"">
		<a href=""#""><i class=""fa fa-th-large""></i></a>
		<a href=""#"" class=""active""><i class=""fa fa-bars""></i></a>
	</div>
	<div class=""sort-filter"">
		<span class=""text-uppercase"">Sort By:</span>
		<select class=""input"">
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "270588ff88ce2f9c1206256536e7cadd43f11bf119901", async() => {
                WriteLiteral("Position");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "270588ff88ce2f9c1206256536e7cadd43f11bf121071", async() => {
                WriteLiteral("Price");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "270588ff88ce2f9c1206256536e7cadd43f11bf122238", async() => {
                WriteLiteral("Rating");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</select>\r\n\t\t<a href=\"#\" class=\"main-btn icon-btn\"><i class=\"fa fa-arrow-down\"></i></a>\r\n\t</div>\r\n</div>\r\n<div class=\"pull-right\">\r\n");
            WriteLiteral("\t\t<div class=\"row\">\r\n\t\t <div class=\"col\">\r\n\t\t <nav aria-label=\"Page navigation example\">\r\n\t\t<ul class=\"pagination\">\r\n\t\t<li><span class=\"text-uppercase\">Page:</span></li>\r\n");
#nullable restore
#line 312 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
          for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
		 {
			 if (String.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
			 {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t <li");
            BeginWriteAttribute("class", " class=\"", 8615, "\"", 8679, 2);
            WriteAttributeValue("", 8623, "page-item", 8623, 9, true);
#nullable restore
#line 316 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
WriteAttributeValue(" ", 8632, Model.PageInfo.CurrentPage==i+1?"active":"", 8633, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "270588ff88ce2f9c1206256536e7cadd43f11bf124612", async() => {
#nullable restore
#line 317 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
                                                                Write(i+1);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8727, "~/products?page=", 8727, 16, true);
#nullable restore
#line 317 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
AddHtmlAttributeValue("", 8743, i+1, 8743, 6, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t\t\t\t </li>\r\n");
#nullable restore
#line 320 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
			 }

			 else
			 {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t <li");
            BeginWriteAttribute("class", " class=\"", 8811, "\"", 8875, 2);
            WriteAttributeValue("", 8819, "page-item", 8819, 9, true);
#nullable restore
#line 324 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
WriteAttributeValue(" ", 8828, Model.PageInfo.CurrentPage==i+1?"active":"", 8829, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "270588ff88ce2f9c1206256536e7cadd43f11bf127126", async() => {
#nullable restore
#line 325 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
                                                                                               Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("+1");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8911, "~/products/", 8911, 11, true);
#nullable restore
#line 325 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
AddHtmlAttributeValue("", 8922, Model.PageInfo.CurrentCategory, 8922, 31, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 8953, "?page=", 8953, 6, true);
#nullable restore
#line 325 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
AddHtmlAttributeValue("", 8959, i+1, 8959, 6, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 326 "C:\Users\User\Desktop\myproject\clicker.webui\Views\Trading\List.cshtml"
			 }



			 
		 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</ul>\r\n\t</nav>\r\n\t</div>\r\n\t\t</div>\r\n</div>\r\n</div>\r\n</div>\r\n</div>\r\n\r\n</div>\r\n</div>\r\n\r\n");
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
