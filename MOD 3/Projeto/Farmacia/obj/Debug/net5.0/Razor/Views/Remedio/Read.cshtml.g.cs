#pragma checksum "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2495390d0acc89132654f248b688795e1e1fa37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Remedio_Read), @"mvc.1.0.view", @"/Views/Remedio/Read.cshtml")]
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
#line 1 "C:\blue\MOD 3\Projeto\Farmacia\Views\_ViewImports.cshtml"
using Farmacia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\blue\MOD 3\Projeto\Farmacia\Views\_ViewImports.cshtml"
using Farmacia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2495390d0acc89132654f248b688795e1e1fa37", @"/Views/Remedio/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71497ad7aa79d8154948264ed88d88beb5a2f4a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Remedio_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Remedio>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n<br />\r\n\r\n<center><h1>Remédio de registro ");
#nullable restore
#line 7 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1></center>\r\n<br />\r\n<dl class=\"row\">\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 10 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayNameFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">");
#nullable restore
#line 11 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 12 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayNameFor(Model => Model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">");
#nullable restore
#line 13 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayFor(Model => Model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 14 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayNameFor(Model => Model.Fabricante));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">");
#nullable restore
#line 15 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayFor(Model => Model.Fabricante));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 16 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayNameFor(Model => Model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">R$");
#nullable restore
#line 17 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                      Write(Html.DisplayFor(Model => Model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    <dt class=\"col-sm-3\">");
#nullable restore
#line 18 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayNameFor(Model => Model.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n    <dd class=\"col-sm-9\">");
#nullable restore
#line 19 "C:\blue\MOD 3\Projeto\Farmacia\Views\Remedio\Read.cshtml"
                    Write(Html.DisplayFor(Model => Model.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Unidades</dd>\r\n</dl>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Remedio> Html { get; private set; }
    }
}
#pragma warning restore 1591