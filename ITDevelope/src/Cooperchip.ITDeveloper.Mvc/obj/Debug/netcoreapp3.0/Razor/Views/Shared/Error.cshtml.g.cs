#pragma checksum "C:\Users\Diogo\Desktop\original\DoZero-v3.0.100\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "220642ef4396aaa807c658ddbcd52e3d1667d5c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\Diogo\Desktop\original\DoZero-v3.0.100\src\Cooperchip.ITDeveloper.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDeveloper.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Diogo\Desktop\original\DoZero-v3.0.100\src\Cooperchip.ITDeveloper.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDeveloper.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"220642ef4396aaa807c658ddbcd52e3d1667d5c7", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab047a4d674c214c15db459a584c05f98bae6169", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Diogo\Desktop\original\DoZero-v3.0.100\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-danger"">Erro Encontrado.</h1>
<h2 class=""text-danger"">Um erro foi encontrado enquanto era processada a sua Request.</h2>

<div class=""row col-lg-12 col-md-12 col-sm-12 col-xs-12"">
    <div class=""panel panelClose panelRefresh"">
        <div class=""panel-heading"">
            <h3 class=""panel-title"">Política de Privacidade</h3>
        </div>

        <div class=""panel-body"">

");
#nullable restore
#line 17 "C:\Users\Diogo\Desktop\original\DoZero-v3.0.100\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Error.cshtml"
             if (Model.ShowRequestId)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>\r\n                    <strong>Request ID:</strong> <code>");
#nullable restore
#line 20 "C:\Users\Diogo\Desktop\original\DoZero-v3.0.100\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Error.cshtml"
                                                  Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\r\n                </p>\r\n");
#nullable restore
#line 22 "C:\Users\Diogo\Desktop\original\DoZero-v3.0.100\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Error.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <h3>Modo Desenvolvimento</h3>
            <p>
                Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
            </p>
            <p>
                <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
                It can result in displaying sensitive information from exceptions to end users.
                For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
                and restarting the app.
            </p>
        </div>

    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591