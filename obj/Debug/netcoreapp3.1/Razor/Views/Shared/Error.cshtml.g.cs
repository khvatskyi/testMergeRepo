#pragma checksum "D:\#Programming\C#\#TestSprints\Sprint12_MVC\task-1-slobodian-fesh\Sprint12\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61d4b114d3782d3db03b57d250e270ab788b16df"
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
#line 1 "D:\#Programming\C#\#TestSprints\Sprint12_MVC\task-1-slobodian-fesh\Sprint12\Views\_ViewImports.cshtml"
using Sprint12_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\#Programming\C#\#TestSprints\Sprint12_MVC\task-1-slobodian-fesh\Sprint12\Views\_ViewImports.cshtml"
using Sprint12_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61d4b114d3782d3db03b57d250e270ab788b16df", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a4ed8cbea0b72c141ec35dcf87b54f22b684964", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\#Programming\C#\#TestSprints\Sprint12_MVC\task-1-slobodian-fesh\Sprint12\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2><br />\r\n\r\n");
#nullable restore
#line 8 "D:\#Programming\C#\#TestSprints\Sprint12_MVC\task-1-slobodian-fesh\Sprint12\Views\Shared\Error.cshtml"
 foreach (var errorPair in ViewData.ModelState)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\#Programming\C#\#TestSprints\Sprint12_MVC\task-1-slobodian-fesh\Sprint12\Views\Shared\Error.cshtml"
     if (errorPair.Value.Errors.Count > 0)
    {
        var Errors = errorPair.Value.Errors;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>\r\n            <u>");
#nullable restore
#line 15 "D:\#Programming\C#\#TestSprints\Sprint12_MVC\task-1-slobodian-fesh\Sprint12\Views\Shared\Error.cshtml"
          Write(errorPair.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u>:\r\n");
#nullable restore
#line 16 "D:\#Programming\C#\#TestSprints\Sprint12_MVC\task-1-slobodian-fesh\Sprint12\Views\Shared\Error.cshtml"
             for (int i = 0; i < Errors.Count; i++)
            {
                string Message = i < Errors.Count - 1 ? Errors[i].ErrorMessage + "; " : Errors[i].ErrorMessage;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 19 "D:\#Programming\C#\#TestSprints\Sprint12_MVC\task-1-slobodian-fesh\Sprint12\Views\Shared\Error.cshtml"
                 Write(Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 20 "D:\#Programming\C#\#TestSprints\Sprint12_MVC\task-1-slobodian-fesh\Sprint12\Views\Shared\Error.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </h3>\r\n");
#nullable restore
#line 22 "D:\#Programming\C#\#TestSprints\Sprint12_MVC\task-1-slobodian-fesh\Sprint12\Views\Shared\Error.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\#Programming\C#\#TestSprints\Sprint12_MVC\task-1-slobodian-fesh\Sprint12\Views\Shared\Error.cshtml"
     
}

#line default
#line hidden
#nullable disable
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
