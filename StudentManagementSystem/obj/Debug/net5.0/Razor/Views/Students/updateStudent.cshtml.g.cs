#pragma checksum "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\updateStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90b1373724d620c842aa80225e0905bf943db833"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_updateStudent), @"mvc.1.0.view", @"/Views/Students/updateStudent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90b1373724d620c842aa80225e0905bf943db833", @"/Views/Students/updateStudent.cshtml")]
    public class Views_Students_updateStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManagementSystem.Entities.Students>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\updateStudent.cshtml"
  
    ViewData["Title"] = "updateStudent";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>updateStudent</h1>

<h4>Students</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""updateStudent"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""id"" class=""control-label""></label>
                <input asp-for=""id"" class=""form-control"" />
                <span asp-validation-for=""id"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Fname"" class=""control-label""></label>
                <input asp-for=""Fname"" class=""form-control"" />
                <span asp-validation-for=""Fname"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Lname"" class=""control-label""></label>
                <input asp-for=""Lname"" class=""form-control"" />
                <span asp-validation-for=""Lname"" class=""text-danger""></span>
            </d");
            WriteLiteral(@"iv>
            <div class=""form-group"">
                <label asp-for=""Email"" class=""control-label""></label>
                <input asp-for=""Email"" class=""form-control"" />
                <span asp-validation-for=""Email"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""password"" class=""control-label""></label>
                <input asp-for=""password"" class=""form-control"" />
                <span asp-validation-for=""password"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""phone"" class=""control-label""></label>
                <input asp-for=""phone"" class=""form-control"" />
                <span asp-validation-for=""phone"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-acti");
            WriteLiteral("on=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 57 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\updateStudent.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentManagementSystem.Entities.Students> Html { get; private set; }
    }
}
#pragma warning restore 1591
