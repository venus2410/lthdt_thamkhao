#pragma checksum "C:\Users\Administrator\source\repos\LapTrinhHDT\LTHDT_web\Pages\MH_TinhChuViTamGiac.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc06f395d9dacad398e25958cb3a707c8d7b5e00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LTHDT_web.Pages.Pages_MH_TinhChuViTamGiac), @"mvc.1.0.razor-page", @"/Pages/MH_TinhChuViTamGiac.cshtml")]
namespace LTHDT_web.Pages
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
#line 1 "C:\Users\Administrator\source\repos\LapTrinhHDT\LTHDT_web\Pages\_ViewImports.cshtml"
using LTHDT_web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc06f395d9dacad398e25958cb3a707c8d7b5e00", @"/Pages/MH_TinhChuViTamGiac.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d7ce48d0635d981cf6f52062904c0aaa61c5feb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_TinhChuViTamGiac : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 6 "C:\Users\Administrator\source\repos\LapTrinhHDT\LTHDT_web\Pages\MH_TinhChuViTamGiac.cshtml"
Write(Model.chuoi);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LTHDT_web.Pages.MH_TinhChuViTamGiacModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LTHDT_web.Pages.MH_TinhChuViTamGiacModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LTHDT_web.Pages.MH_TinhChuViTamGiacModel>)PageContext?.ViewData;
        public LTHDT_web.Pages.MH_TinhChuViTamGiacModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
