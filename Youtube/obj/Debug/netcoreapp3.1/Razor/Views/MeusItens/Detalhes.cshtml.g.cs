#pragma checksum "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d33547d0a7c0a5b77fa5211eb6e7b4a6556d51c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MeusItens_Detalhes), @"mvc.1.0.view", @"/Views/MeusItens/Detalhes.cshtml")]
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
#line 1 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\_ViewImports.cshtml"
using Youtube;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\_ViewImports.cshtml"
using Youtube.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d33547d0a7c0a5b77fa5211eb6e7b4a6556d51c0", @"/Views/MeusItens/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"340e001e5d569f7e7581106f15aa0889296c14b9", @"/Views/_ViewImports.cshtml")]
    public class Views_MeusItens_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Youtube.Models.YoutubeResult>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalhes</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Thumbnails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 16 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
             if (Model.Type == TypeItem.Video)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 367, "\"", 422, 2);
            WriteAttributeValue("", 374, "https://www.youtube.com/watch?v=", 374, 32, true);
#nullable restore
#line 18 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
WriteAttributeValue("", 406, Model.YoutubeId, 406, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><img");
            BeginWriteAttribute("src", " src=\"", 444, "\"", 477, 1);
#nullable restore
#line 18 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
WriteAttributeValue("", 450, Html.Raw(Model.Thumbnails), 450, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n");
#nullable restore
#line 19 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 555, "\"", 588, 1);
#nullable restore
#line 22 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
WriteAttributeValue("", 561, Html.Raw(Model.Thumbnails), 561, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 23 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.YoutubeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.YoutubeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.ChannelTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.ChannelTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.LiveBroadcastContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.LiveBroadcastContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.PublishedAtRaw));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.PublishedAtRaw));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.PublishedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.PublishedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.ETag));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.ETag));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\renatorv\Desktop\Youtube\Youtube\Views\MeusItens\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d33547d0a7c0a5b77fa5211eb6e7b4a6556d51c011715", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Youtube.Models.YoutubeResult> Html { get; private set; }
    }
}
#pragma warning restore 1591
