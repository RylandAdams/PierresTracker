#pragma checksum "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37bea74f63afe8c52bde7cf34afadab7326ef736"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Delete), @"mvc.1.0.view", @"/Views/Vendors/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendors/Delete.cshtml", typeof(AspNetCore.Views_Vendors_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37bea74f63afe8c52bde7cf34afadab7326ef736", @"/Views/Vendors/Delete.cshtml")]
    public class Views_Vendors_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<h1>The orders belonging ");
            EndContext();
            BeginContext(26, 10, false);
#line 1 "C:\Users\Ryland\Desktop\PierresTracker.Solution\PierresTracker\Views\Vendors\Delete.cshtml"
                    Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(36, 119, true);
            WriteLiteral(" has been cleared!</h1>\r\n\r\n<p><a href=\"/vendors\">Back to Vendors Page</a></p>\r\n<p><a href=\"/\">Back to Home Page</a></p>");
            EndContext();
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
