#pragma checksum "C:\Users\Diogo\Desktop\original\DoZero-v3.0.100\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9897668ee0059056e969fce0d7f53ddd0c1a0aaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho_Index), @"mvc.1.0.view", @"/Views/Carrinho/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9897668ee0059056e969fce0d7f53ddd0c1a0aaf", @"/Views/Carrinho/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab047a4d674c214c15db459a584c05f98bae6169", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cooperchip.ITDeveloper.Mvc.ViewModels.CarrinhoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Diogo\Desktop\original\DoZero-v3.0.100\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
  
    ViewData["Title"] = "Carrinho de Compras";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""row"">
    <div class=""panel panel-heading"">
        <h3>Carrinho de Compras</h3>
    </div>
    <div class=""panel panel-body"">
        <table class=""table table-hover"">
            <caption>Produtos no Carrinho</caption>
            <thead>
                <tr>
                    <th>Produtos</th>
                    <th>Valor</th>
                    <th>Estoque</th>
                    <th>Validade</th>
                    <th>Tem em Estoque</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 27 "C:\Users\Diogo\Desktop\original\DoZero-v3.0.100\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                 foreach (var prod in Model.Produtos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\Diogo\Desktop\original\DoZero-v3.0.100\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                       Write(prod.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\Diogo\Desktop\original\DoZero-v3.0.100\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                       Write(prod.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\Diogo\Desktop\original\DoZero-v3.0.100\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                       Write(prod.Estoque);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\Diogo\Desktop\original\DoZero-v3.0.100\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                       Write(prod.Validade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\Diogo\Desktop\original\DoZero-v3.0.100\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                       Write(prod.TemEmEstoque);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Diogo\Desktop\original\DoZero-v3.0.100\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n            <tfoot>\r\n                <tr>\r\n                    <td><strong>Total: </strong></td>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\Diogo\Desktop\original\DoZero-v3.0.100\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                   Write(Model.TotalCarrinho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </tfoot>\r\n        </table>\r\n        <h3>\r\n            ");
#nullable restore
#line 46 "C:\Users\Diogo\Desktop\original\DoZero-v3.0.100\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
       Write(Model.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cooperchip.ITDeveloper.Mvc.ViewModels.CarrinhoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591