#pragma checksum "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2041b421d1c552dd34f4a7ea57f88734905e0af0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VicuñaEC01_PapeletasFechas), @"mvc.1.0.view", @"/Views/VicuñaEC01/PapeletasFechas.cshtml")]
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
#line 1 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\_ViewImports.cshtml"
using ec_01_Vicuñawebapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\_ViewImports.cshtml"
using ec_01_Vicuñawebapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2041b421d1c552dd34f4a7ea57f88734905e0af0", @"/Views/VicuñaEC01/PapeletasFechas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"724770fdf4f540851089872210a85e51609d2e13", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_VicuñaEC01_PapeletasFechas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ec_01_Vicuñawebapp.Models.Papeleta>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
  
    ViewData["Title"] = "PapeletasFechas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>PapeletasFechas</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        Ingrese el primera Nropap: ");
#nullable restore
#line 12 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
                              Write(Html.TextBox("dato"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        Ingrese el segunda Nropap: ");
#nullable restore
#line 14 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
                              Write(Html.TextBox("dato2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <button class=\"btn btn-success\">Consultar</button>\r\n        ");
#nullable restore
#line 17 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
   Write(Html.ActionLink("Regreas al Menu","Index","MenuVicuñaEC01",null, new {@class = "btn btn-warning"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 19 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"alert alert-success\">\r\n    Cantidad de Registros: ");
#nullable restore
#line 22 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
                      Write(ViewBag.cantidad_registros);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>\r\n    Numero ultima papeleta: ");
#nullable restore
#line 23 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
                       Write(ViewBag.ultima_papeleta);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2041b421d1c552dd34f4a7ea57f88734905e0af07140", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
           Write(Html.DisplayNameFor(model => model.Nropap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
           Write(Html.DisplayNameFor(model => model.Fechapap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
           Write(Html.DisplayNameFor(model => model.NroplaNavigation.Nropla));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
           Write(Html.DisplayNameFor(model => model.CodpolNavigation.Codpol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
           Write(Html.DisplayNameFor(model => model.CodpolNavigation.Patrullero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
           Write(Html.DisplayNameFor(model => model.CodinfNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 51 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
           Write(Html.DisplayNameFor(model => model.Fechapago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 57 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nropap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fechapap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
           Write(Html.DisplayFor(modelItem => item.NroplaNavigation.Nropla));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
           Write(Html.DisplayFor(modelItem => item.CodpolNavigation.Nompol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
           Write(Html.DisplayFor(modelItem => item.CodpolNavigation.Patrullero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
           Write(Html.DisplayFor(modelItem => item.CodinfNavigation.Codinf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fechapago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2041b421d1c552dd34f4a7ea57f88734905e0af013803", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
                                       WriteLiteral(item.Nropap);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2041b421d1c552dd34f4a7ea57f88734905e0af016008", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
                                          WriteLiteral(item.Nropap);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2041b421d1c552dd34f4a7ea57f88734905e0af018219", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
                                         WriteLiteral(item.Nropap);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 86 "C:\IDAT\CICLO IV\PROYECT-PERSONAL\Slnec-01-Vicuñawebapp\ec-01-Vicuñawebapp\Views\VicuñaEC01\PapeletasFechas.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ec_01_Vicuñawebapp.Models.Papeleta>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
