#pragma checksum "D:\EF Samples\MyWebApp01\MyWebApp01\Pages\Homepage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b128bfbc2da7772f4ef8f2c00f27be8fdfd57aa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyWebApp01.Pages.Pages_Homepage), @"mvc.1.0.razor-page", @"/Pages/Homepage.cshtml")]
namespace MyWebApp01.Pages
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
#line 1 "D:\EF Samples\MyWebApp01\MyWebApp01\Pages\_ViewImports.cshtml"
using MyWebApp01;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b128bfbc2da7772f4ef8f2c00f27be8fdfd57aa3", @"/Pages/Homepage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3748a077a6f0eb59ad440c4e862f31dd66448a66", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Homepage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\EF Samples\MyWebApp01\MyWebApp01\Pages\Homepage.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("}\r\n<div class=\"text-center\">\r\n    <h1>Hello, world!</h1>\r\n    <p>The time on the server is ");
#nullable restore
#line 8 "D:\EF Samples\MyWebApp01\MyWebApp01\Pages\Homepage.cshtml"
                            Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyWebApp01.Pages.HomepageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyWebApp01.Pages.HomepageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyWebApp01.Pages.HomepageModel>)PageContext?.ViewData;
        public MyWebApp01.Pages.HomepageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591