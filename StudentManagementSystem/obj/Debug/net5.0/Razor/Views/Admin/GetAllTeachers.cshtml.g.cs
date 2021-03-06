#pragma checksum "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Admin\GetAllTeachers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "311ef4c804f8438f011e4fb57973766df3e6efd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetAllTeachers), @"mvc.1.0.view", @"/Views/Admin/GetAllTeachers.cshtml")]
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
using StudentManagementSystem.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Admin\GetAllTeachers.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"311ef4c804f8438f011e4fb57973766df3e6efd8", @"/Views/Admin/GetAllTeachers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b39fed964580b5d09fb1321d43974e260469927e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetAllTeachers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Admin\GetAllTeachers.cshtml"
  
    ViewData["Title"] = "GetAllTeachers";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";
    ViewData["PersonName"] = HttpContextAccessor.HttpContext.Session.GetString("SessionKeyFname");
    ViewData["PersonEmail"] = HttpContextAccessor.HttpContext.Session.GetString("SessionKeyEmail");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"" type=""text/javascript""></script>

<script>
    $(document).ready(function () {

        $.ajax({
            type: ""GET"",
            url: ""/api/teacher/getallteachers"",
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (data) {
                var table = $(""#Tableteacher"").DataTable();
                table.clear();
                $.each(data, function (index, record) {
                    table.row.add([record.fname, record.lname, record.email, record.phone, '<a href=""getteacher/' + record.id + '"">Detail</a>']);
                });
                table.draw();
            },
            failure: function (data) {
                alert(data.responseText);
            },
            error: function (data) {
                alert(data.responseText);
            }

        });
    });
</script>

<h1>Teachers</h1>

<div class=""row c");
            WriteLiteral(@"learfix"">
    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
        <div class=""card"">

            <div class=""body"">
                <div class=""table-responsive"" style=""overflow-x:visible !important"">
                    <table class=""table table-bordered table-striped table-hover dataTable js-basic-example"" id=""Tableteacher"">
                        <thead>
                            <tr>
                                <th>First Name</th>
                                <th>Last Name</th>
                                <th>Email</th>
                                <th>Phone</th>
                                <th></th>

                            </tr>
                        </thead>
                       

                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- #END# Exportable Table -->
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
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
