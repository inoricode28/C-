#pragma checksum "C:\Users\Nova\Desktop\Idat2\HP2-IV.07-MARTES\Semana_04\SlnNeptunoCoreMVC\ProyNeptunoCoreMVC\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5494d085eafd760919d2fb8472be5d304d6b1020"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Index), @"mvc.1.0.view", @"/Views/Menu/Index.cshtml")]
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
#line 1 "C:\Users\Nova\Desktop\Idat2\HP2-IV.07-MARTES\Semana_04\SlnNeptunoCoreMVC\ProyNeptunoCoreMVC\Views\_ViewImports.cshtml"
using ProyNeptunoCoreMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nova\Desktop\Idat2\HP2-IV.07-MARTES\Semana_04\SlnNeptunoCoreMVC\ProyNeptunoCoreMVC\Views\_ViewImports.cshtml"
using ProyNeptunoCoreMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5494d085eafd760919d2fb8472be5d304d6b1020", @"/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef15392671a088f81666aa99dac86bc550ce3d0d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Nova\Desktop\Idat2\HP2-IV.07-MARTES\Semana_04\SlnNeptunoCoreMVC\ProyNeptunoCoreMVC\Views\Menu\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Nova\Desktop\Idat2\HP2-IV.07-MARTES\Semana_04\SlnNeptunoCoreMVC\ProyNeptunoCoreMVC\Views\Menu\Index.cshtml"
Write(Html.ActionLink("Pedidos por Cliente", "PedidosPorCliente", "Consultas"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n");
#nullable restore
#line 9 "C:\Users\Nova\Desktop\Idat2\HP2-IV.07-MARTES\Semana_04\SlnNeptunoCoreMVC\ProyNeptunoCoreMVC\Views\Menu\Index.cshtml"
Write(Html.ActionLink("Pedidos por Fecha", "PedidosPorFecha", "Consultas"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
