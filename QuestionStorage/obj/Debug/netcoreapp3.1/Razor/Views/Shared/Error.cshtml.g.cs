#pragma checksum "/Users/maria/Documents/University/coursework/QuestionStorage/QuestionStorage/Views/Shared/Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cc9f5b68e3ebeb22645c20a8320e2a2618f2547"
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
#line 1 "/Users/maria/Documents/University/coursework/QuestionStorage/QuestionStorage/Views/_ViewImports.cshtml"
using QuestionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/maria/Documents/University/coursework/QuestionStorage/QuestionStorage/Views/_ViewImports.cshtml"
using QuestionStorage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc9f5b68e3ebeb22645c20a8320e2a2618f2547", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de651716945de7d2a5e15f0b428a494276bb77c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionStorage.Models.ViewModels.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/maria/Documents/University/coursework/QuestionStorage/QuestionStorage/Views/Shared/Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""text-align: center; vertical-align: middle; position: absolute; top: 50%; left: 50%;
            margin-right: -50%; transform: translate(-50%, -50%);"">
    <h1 class=""text-danger"">Error.</h1>
    <h2 class=""text-danger"">An error occurred while processing your request :(</h2>
    
");
#nullable restore
#line 11 "/Users/maria/Documents/University/coursework/QuestionStorage/QuestionStorage/Views/Shared/Error.cshtml"
     if (Model != null && Model.ShowRequestId)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\n            <strong>Request ID:</strong> <code>");
#nullable restore
#line 14 "/Users/maria/Documents/University/coursework/QuestionStorage/QuestionStorage/Views/Shared/Error.cshtml"
                                          Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\n        </p>\n");
#nullable restore
#line 16 "/Users/maria/Documents/University/coursework/QuestionStorage/QuestionStorage/Views/Shared/Error.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionStorage.Models.ViewModels.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591