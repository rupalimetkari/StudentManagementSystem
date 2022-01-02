#pragma checksum "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\DeleteStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "757e36c49cf07f058a7d39fc17ab615b5c80047f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_DeleteStudent), @"mvc.1.0.view", @"/Views/Students/DeleteStudent.cshtml")]
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
#line 1 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\_ViewImports.cshtml"
using StudentManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\_ViewImports.cshtml"
using StudentManagementSystem.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\_ViewImports.cshtml"
using StudentManagementSystem.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"757e36c49cf07f058a7d39fc17ab615b5c80047f", @"/Views/Students/DeleteStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff63092842a4a4a3d53837fdabcb1aa96b2130d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_DeleteStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManagementSystem.Entities.Students>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "getall", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Students", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\DeleteStudent.cshtml"
  
    ViewData["Title"] = "DeleteStudent";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>DeleteStudent</h1>\r\n\r\n\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js\" type=\"text/javascript\"></script>\r\n\r\n<script>\r\n    var sid = \'");
#nullable restore
#line 13 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\DeleteStudent.cshtml"
          Write(ViewBag.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    $(document).ready(function () {
        $.ajax({
            type: ""GET"",
            url: ""/api/students/getstudent/"" + sid,
            contentType: ""json"",
            dataType: ""json"",
            success: function (data) {
                console.log(data);
                //stringify
                var jsonData = JSON.stringify(data);
                //Parse JSON
                var objData = $.parseJSON(jsonData);
                var fname = objData.fname;
                var lname = objData.lname;
                var email = objData.email;
                var phone = objData.phone;
                var password = objData.password;
                $('<tr><td>' + fname + '</td><td>' + lname + '</td><td>' + email + '</td><td>' + phone + '</td><td>' + password + '</td></tr>').appendTo('#Table');
            },

            failure: function (data) {
                alert(data.responseText);
            }, //End of AJAX failure function
            error: function (data) {
 ");
            WriteLiteral("               alert(data.responseText);\r\n            } //End of AJAX error function\r\n        });\r\n    });\r\n</script>\r\n\r\n\r\n<script>\r\n    var sid = \'");
#nullable restore
#line 46 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\DeleteStudent.cshtml"
          Write(ViewBag.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    $(document).ready(function () {
        $(""#btndelete"").click(function () {
            console.log(""clicked"");
            $.ajax(
                {
                    type: ""DELETE"",
                    url: ""/api/students/deletestudent/"" + sid,
                    contentType: ""application/json"",
                    success: function () {
                        alert(""Student deleted successfully."");
                        
                    },
                    error: function () {
                    }

                });

        });
    });

</script>


<h3>Are you sure you want to delete this?</h3>
<h4>Students</h4>
<div>

    <hr />
    <div class=""panel panel-primary"">
        <div class=""panel-heading"">
            Test Data from API
        </div>   <!--en dof panel-heading -->
        <div class=""panel-body"">
            <table class=""table table-bordered"" id=""Table"">
                <tr>

                    <th>Fname</th>
                    ");
            WriteLiteral(@"<th>Lname</th>
                    <th>Email</th>
                    <th>password</th>
                    <th>phone</th>
                </tr>
            </table>
        </div>
    </div>

    <div>
        <input class=""btn-default"" type=""button"" id=""btndelete"" value=""Delete"" />
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "757e36c49cf07f058a7d39fc17ab615b5c80047f7591", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
