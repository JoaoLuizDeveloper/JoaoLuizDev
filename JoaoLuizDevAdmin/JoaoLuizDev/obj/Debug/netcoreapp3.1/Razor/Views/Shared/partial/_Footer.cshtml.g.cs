#pragma checksum "C:\Users\JuninhoDRZ\source\repos\JoaoluizDev\JoaoLuizDev\JoaoLuizDevAdmin\JoaoLuizDev\Views\Shared\partial\_Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3f7a814312f63fd4b6c6b85dfbc73060969a900"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_partial__Footer), @"mvc.1.0.view", @"/Views/Shared/partial/_Footer.cshtml")]
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
#line 1 "C:\Users\JuninhoDRZ\source\repos\JoaoluizDev\JoaoLuizDev\JoaoLuizDevAdmin\JoaoLuizDev\Views\_ViewImports.cshtml"
using JoaoLuizDev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JuninhoDRZ\source\repos\JoaoluizDev\JoaoLuizDev\JoaoLuizDevAdmin\JoaoLuizDev\Views\_ViewImports.cshtml"
using JoaoLuizDev.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3f7a814312f63fd4b6c6b85dfbc73060969a900", @"/Views/Shared/partial/_Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42cc826d2502726bb62242c3133be54369678eb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_partial__Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("footer-contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-work-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""up-footer"">
    <div class=""row"">

        <div class=""col-md-4"">
            <div class=""widget footer-widgets flickr-widget"">
                <h4>Flickr Gallery</h4>
                <ul class=""flickr-list"">
                    <li><a href=""#""><img");
            BeginWriteAttribute("alt", " alt=\"", 268, "\"", 274, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"images/flickr1.png\"></a></li>\r\n                    <li><a href=\"#\"><img");
            BeginWriteAttribute("alt", " alt=\"", 352, "\"", 358, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"images/flickr2.png\"></a></li>\r\n                    <li><a href=\"#\"><img");
            BeginWriteAttribute("alt", " alt=\"", 436, "\"", 442, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"images/flickr3.png\"></a></li>\r\n                    <li><a href=\"#\"><img");
            BeginWriteAttribute("alt", " alt=\"", 520, "\"", 526, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"images/flickr4.png\"></a></li>\r\n                    <li><a href=\"#\"><img");
            BeginWriteAttribute("alt", " alt=\"", 604, "\"", 610, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"images/flickr5.png\"></a></li>\r\n                    <li><a href=\"#\"><img");
            BeginWriteAttribute("alt", " alt=\"", 688, "\"", 694, 0);
            EndWriteAttribute();
            WriteLiteral(" src=\"images/flickr6.png\"></a></li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-4\">\r\n            <div class=\"widget footer-widgets message-widget\">\r\n                <h4>Send Message</h4>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3f7a814312f63fd4b6c6b85dfbc73060969a9005856", async() => {
                WriteLiteral(@"
                    <input type=""text"" name=""name"" id=""name"" placeholder=""Name"" />
                    <input type=""text"" name=""mail"" id=""mail"" placeholder=""Email"" />
                    <textarea name=""comment"" id=""comment"" placeholder=""Message""></textarea>
                    <button type=""submit"" name=""contact-submit"" class=""submit_contact"">
                        <i class=""fa fa-envelope""></i> Send
                    </button>
                    <div class=""msg""></div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>

        <div class=""col-md-4"">
            <div class=""widget footer-widgets info-widget"">
                <h4>Contact Us</h4>
                <ul class=""contact-list"">
                    <li><a class=""phone"" href=""#""><i class=""fa fa-phone""></i>9930 1234 5679</a></li>
                    <li><a class=""mail"" href=""#""><i class=""fa fa-envelope""></i> contact@yourdomain.com</a></li>
                    <li><a class=""address"" href=""#""><i class=""fa fa-home""></i> street address example</a></li>
                </ul>
            </div>
        </div>
    </div>
</div>

<div class=""footer-line"">
    <p>&#169; 2020 João Luiz Developer,  All Rights Reserved</p>
    <a class=""go-top"" href=""#""></a>
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
