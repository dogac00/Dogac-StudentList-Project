#pragma checksum "C:\Users\Lab1\Desktop\website\College-Website-Project-MVC\DogacProject\Views\Students\Detay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ad767e4b0102f99c252a4f3b927436970d38661"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Detay), @"mvc.1.0.view", @"/Views/Students/Detay.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Detay.cshtml", typeof(AspNetCore.Views_Students_Detay))]
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
#line 1 "C:\Users\Lab1\Desktop\website\College-Website-Project-MVC\DogacProject\Views\_ViewImports.cshtml"
using DogacProject;

#line default
#line hidden
#line 2 "C:\Users\Lab1\Desktop\website\College-Website-Project-MVC\DogacProject\Views\_ViewImports.cshtml"
using DogacProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ad767e4b0102f99c252a4f3b927436970d38661", @"/Views/Students/Detay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"767a5c4da691260ec019eacdae5dc71354063d63", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Detay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Lab1\Desktop\website\College-Website-Project-MVC\DogacProject\Views\Students\Detay.cshtml"
  
    ViewData["Title"] = "Detay";

#line default
#line hidden
            BeginContext(57, 681, true);
            WriteLiteral(@"
<html>

<style>

    #customers {
        font-family: ""Trebuchet MS"", Arial, Helvetica, sans-serif;
        border-collapse: collapse;
        width: 100%;
    }

        #customers td, #customers th {
            border: 1px solid #ddd;
            padding: 8px;
        }

        #customers tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        #customers tr:hover {
            background-color: #ddd;
        }

        #customers th {
            padding-top: 12px;
            padding-bottom: 12px;
            text-align: left;
            background-color: #1E68B0;
            color: white;
        }
</style>

");
            EndContext();
            BeginContext(738, 489, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ad767e4b0102f99c252a4f3b927436970d386614120", async() => {
                BeginContext(744, 316, true);
                WriteLiteral(@"

    <header class=""w3-display-container w3-content w3-wide"" style=""max-width:1500px;"" id=""home"">
        <table id=""customers"">
            <tr>
                <th>Name</th>
                <th>Department</th>
                <th>Student ID</th>
            </tr>

            <tr>
                <td>");
                EndContext();
                BeginContext(1061, 10, false);
#line 49 "C:\Users\Lab1\Desktop\website\College-Website-Project-MVC\DogacProject\Views\Students\Detay.cshtml"
               Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1071, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1099, 21, false);
#line 50 "C:\Users\Lab1\Desktop\website\College-Website-Project-MVC\DogacProject\Views\Students\Detay.cshtml"
               Write(Model.Department.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1120, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1148, 11, false);
#line 51 "C:\Users\Lab1\Desktop\website\College-Website-Project-MVC\DogacProject\Views\Students\Detay.cshtml"
               Write(Model.StuID);

#line default
#line hidden
                EndContext();
                BeginContext(1159, 61, true);
                WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    </header>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1227, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
