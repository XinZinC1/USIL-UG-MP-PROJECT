#pragma checksum "C:\Users\insaw\Documents\Visual Studio\Visual Studio Community\USIL-UG-MP-PROJECT\USIL-UG-MP-PROJECT\Views\MetodoPago\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe241764442784d3e944ebc62f3b5c0a152d306c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MetodoPago_Index), @"mvc.1.0.view", @"/Views/MetodoPago/Index.cshtml")]
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
#line 1 "C:\Users\insaw\Documents\Visual Studio\Visual Studio Community\USIL-UG-MP-PROJECT\USIL-UG-MP-PROJECT\Views\_ViewImports.cshtml"
using USIL_UG_MP_PROJECT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\insaw\Documents\Visual Studio\Visual Studio Community\USIL-UG-MP-PROJECT\USIL-UG-MP-PROJECT\Views\_ViewImports.cshtml"
using USIL_UG_MP_PROJECT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe241764442784d3e944ebc62f3b5c0a152d306c", @"/Views/MetodoPago/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d97508d249762109808d2ffe009a8081b271235b", @"/Views/_ViewImports.cshtml")]
    public class Views_MetodoPago_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<USIL_UG_MP_PROJECT.Models.MetodoPago>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Insert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\insaw\Documents\Visual Studio\Visual Studio Community\USIL-UG-MP-PROJECT\USIL-UG-MP-PROJECT\Views\MetodoPago\Index.cshtml"
  
    ViewData["Title"] = "Métodos de Pago";
    int counter = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <h1>Listado de Métodos de Pago</h1>\r\n\r\n    <h2>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe241764442784d3e944ebc62f3b5c0a152d306c4030", async() => {
                WriteLiteral("Nuevo Método de Pago");
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
            WriteLiteral(@"</h2>

    <div>
        <input class=""form-control"" id=""myInput"" type=""text"" placeholder=""Search..."" />
    </div>
    <br />
    <table class=""table table-bordered"">
        <thead>

            <tr>
                <td scope=""col"">ID Método Pago</td>
                <td scope=""col"">Empresa</td>
                <td scope=""col"">Descripción</td>
            </tr>

        </thead>

        <tbody id=""myTable"">

");
#nullable restore
#line 35 "C:\Users\insaw\Documents\Visual Studio\Visual Studio Community\USIL-UG-MP-PROJECT\USIL-UG-MP-PROJECT\Views\MetodoPago\Index.cshtml"
             foreach (var row in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\insaw\Documents\Visual Studio\Visual Studio Community\USIL-UG-MP-PROJECT\USIL-UG-MP-PROJECT\Views\MetodoPago\Index.cshtml"
                   Write(row.IdMetodo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "C:\Users\insaw\Documents\Visual Studio\Visual Studio Community\USIL-UG-MP-PROJECT\USIL-UG-MP-PROJECT\Views\MetodoPago\Index.cshtml"
                   Write(row.Empresa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\insaw\Documents\Visual Studio\Visual Studio Community\USIL-UG-MP-PROJECT\USIL-UG-MP-PROJECT\Views\MetodoPago\Index.cshtml"
                   Write(row.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\insaw\Documents\Visual Studio\Visual Studio Community\USIL-UG-MP-PROJECT\USIL-UG-MP-PROJECT\Views\MetodoPago\Index.cshtml"
                counter++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<h2>Hay ");
#nullable restore
#line 49 "C:\Users\insaw\Documents\Visual Studio\Visual Studio Community\USIL-UG-MP-PROJECT\USIL-UG-MP-PROJECT\Views\MetodoPago\Index.cshtml"
    Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" registro(s)!</h2>

<script>
    $(document).ready(function () {
        $(""#myInput"").on(""keyup"", function () {
            var value = $(this).val().toLowerCase();
            $(""#myTable tr"").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<USIL_UG_MP_PROJECT.Models.MetodoPago>> Html { get; private set; }
    }
}
#pragma warning restore 1591