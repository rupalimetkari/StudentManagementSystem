#pragma checksum "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c85235577fa35c113d9dfd498f735f55d4eab7bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Profile), @"mvc.1.0.view", @"/Views/Students/Profile.cshtml")]
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
#line 2 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\Profile.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c85235577fa35c113d9dfd498f735f55d4eab7bf", @"/Views/Students/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b39fed964580b5d09fb1321d43974e260469927e", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user-lg.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("AdminBSB - Profile Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    ViewData["PersonName"] = HttpContextAccessor.HttpContext.Session.GetString("SessionKeyFname");
    ViewData["PersonEmail"] = HttpContextAccessor.HttpContext.Session.GetString("SessionKeyEmail");
    Layout = "~/Views/Shared/_LayoutStudent.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js\" type=\"text/javascript\"></script>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c85235577fa35c113d9dfd498f735f55d4eab7bf6122", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script>\r\n\r\n\r\n\r\n\r\n    $(document).ready(function () {\r\n        $(\"#btndelete\").on(\'click\', function (e) {\r\n            $.ajax({\r\n                type: \"DELETE\",\r\n                url: \"/api/students/deletestudent/\" + ");
#nullable restore
#line 26 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\Profile.cshtml"
                                                 Write(HttpContextAccessor.HttpContext.Session.GetInt32("SessionKeyId"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                dataType: ""html"",
                success: function () {
                    alert(""Account Deleted Successfully"");
                    window.location = ""/login"";
                },
                failure: function () {
                    alert(""failure"");
                },
                error: function () {
                    alert(""error"");
                }
            });
            e.preventDefault();
        });

        $(""#btnedit"").on('click', function (e) {
            var data = {
                Fname: $(""#txtfirstname"").val(),
                Lname: $(""#txtlastname"").val(),
                phone: $(""#txtphone"").val()
            };


            var msg = ValidateProfileUpdate(data.Fname, data.Lname, data.phone);

            if (msg != ""allset"") {
                alert(msg);
                return false;
            }
            


            $.ajax({
                type: ""PUT"",
                url: ""/api/students/updateStudent/"" + ");
#nullable restore
#line 61 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\Profile.cshtml"
                                                 Write(HttpContextAccessor.HttpContext.Session.GetInt32("SessionKeyId"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                data: data,
                dataType: ""html"",
                success: function () {
                    alert(""Data Updated Successfully"");
                },
                failure: function () {
                    alert(""failure"");
                },
                error: function () {
                    alert(""error"");
                }
            });
            e.preventDefault();
        });

        $(""#btnpassword"").on('click', function (e) {
            var data = {
                id: ");
#nullable restore
#line 79 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\Profile.cshtml"
               Write(HttpContextAccessor.HttpContext.Session.GetInt32("SessionKeyId"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                password: $(""#txtNewPassword"").val(),
            };
            var confirm = document.getElementById(""txtNewPasswordConfirm"").value;

            var msg = ValidatePassword(data.password, confirm);

            if (msg != ""allset"") {
                alert(msg);
                return false;
            }


            if (data.password == confirm) {
               
                 $.ajax({
                    type: ""PUT"",
                    url: ""/api/students/UpdatePasswordStudent"", 
                    data: data,
                    dataType: ""html"",
                    success: function () {
                        alert(""Password Updated Successfully"");
                        document.getElementById(""txtNewPassword"").value = """";
                        document.getElementById(""txtNewPasswordConfirm"").value = """";  ,
                    },
                    failure: function () {
                        alert(""failure"");
                    },
          ");
            WriteLiteral(@"          error: function () {
                        alert(""error"");
                    }
                });
            } else {
                alert(""Password did not match"");
                document.getElementById(""txtNewPassword"").value = """";
                document.getElementById(""txtNewPasswordConfirm"").value = """";
            };

            e.preventDefault();
        });


    });





</script>

<div class=""row clearfix"">
    <div class=""col-xs-12 col-sm-3"">
        <div class=""card profile-card"">
            <div class=""profile-header"">&nbsp;</div>
            <div class=""profile-body"">
                <div class=""image-area"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c85235577fa35c113d9dfd498f735f55d4eab7bf11857", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"content-area\">\r\n                    <h3>   ");
#nullable restore
#line 138 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\Profile.cshtml"
                      Write(HttpContextAccessor.HttpContext.Session.GetString("SessionKeyFname"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 138 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\Profile.cshtml"
                                                                                             Write(HttpContextAccessor.HttpContext.Session.GetString("SessionKeyLname"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h3>
                    <p>Student</p>

                </div>
            </div>

        </div>

        <div class=""card card-about-me"">
            <div class=""header"">
                <h2>ABOUT ME</h2>
            </div>
            <div class=""body"">
                <ul>
                    <li>
                        <div class=""title"">
                            <i class=""material-icons"">library_books</i>
                            Education
                        </div>
                        <div class=""content"">
                            M.S. in Analytics from Northeastern University, Boston
                        </div>
                    </li>
                    <li>
                        <div class=""title"">
                            <i class=""material-icons"">location_on</i>
                            Location
                        </div>
                        <div class=""content"">
                            Boston, Massachusetts
              ");
            WriteLiteral(@"          </div>
                    </li>
                    <li>
                        <div class=""title"">
                            <i class=""material-icons"">edit</i>
                            Skills
                        </div>
                        <div class=""content"">
                            <span class=""label bg-red"">C#</span>
                            <span class=""label bg-teal"">JavaScript</span>
                            <span class=""label bg-blue"">SQL</span>
                            <span class=""label bg-amber"">Python</span>
                        </div>
                    </li>
                    <li>
                        <div class=""title"">
                            <i class=""material-icons"">notes</i>
                            Description
                        </div>
                        <div class=""content"">
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam fermentum enim neque.
                   ");
            WriteLiteral(@"     </div>
                    </li>
                </ul>
            </div>
        </div>
    </div>
    <div class=""col-xs-12 col-sm-9"">
        <div class=""card"">
            <div class=""body"">
                <div>
                    <ul class=""nav nav-tabs"" role=""tablist"">

                        <li role=""presentation"" class=""active""><a href=""#profile_settings"" aria-controls=""settings"" role=""tab"" data-toggle=""tab"">Profile Settings</a></li>
                        <li role=""presentation""><a href=""#change_password_settings"" aria-controls=""settings"" role=""tab"" data-toggle=""tab"">Change Password</a></li>
                        <li role=""presentation""><a href=""#delete_settings"" aria-controls=""settings"" role=""tab"" data-toggle=""tab"">Delete Account</a></li>
                    </ul>

                    <div class=""tab-content"">
                        <div role=""tabpanel"" class=""tab-pane fade in active"" id=""profile_settings"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c85235577fa35c113d9dfd498f735f55d4eab7bf16955", async() => {
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <label for=""NameSurname"" class=""col-sm-2 control-label"">First Name</label>
                                    <div class=""col-sm-10"">
                                        <div class=""form-line"">
                                            <input type=""text"" class=""form-control"" id=""txtfirstname"" name=""firstname""");
                BeginWriteAttribute("value", " value=\"", 8087, "\"", 8164, 1);
#nullable restore
#line 213 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\Profile.cshtml"
WriteAttributeValue("", 8095, HttpContextAccessor.HttpContext.Session.GetString("SessionKeyFname"), 8095, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                        </div>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label for=""NameSurname"" class=""col-sm-2 control-label"">Last Name</label>
                                    <div class=""col-sm-10"">
                                        <div class=""form-line"">
                                            <input type=""text"" class=""form-control"" id=""txtlastname"" name=""lastname""");
                BeginWriteAttribute("value", " value=\"", 8711, "\"", 8788, 1);
#nullable restore
#line 221 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\Profile.cshtml"
WriteAttributeValue("", 8719, HttpContextAccessor.HttpContext.Session.GetString("SessionKeyLname"), 8719, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                        </div>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label for=""Email"" class=""col-sm-2 control-label"">Email</label>
                                    <div class=""col-sm-10"">
                                        <div class=""form-line"">
                                            <input type=""email"" class=""form-control"" id=""txtEmail"" name=""Email""");
                BeginWriteAttribute("value", " value=\"", 9320, "\"", 9397, 1);
#nullable restore
#line 229 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\Profile.cshtml"
WriteAttributeValue("", 9328, HttpContextAccessor.HttpContext.Session.GetString("SessionKeyEmail"), 9328, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly>
                                        </div>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label for=""NameSurname"" class=""col-sm-2 control-label"">Phone</label>
                                    <div class=""col-sm-10"">
                                        <div class=""form-line"">
                                            <input type=""text"" class=""form-control"" id=""txtphone"" name=""phone""");
                BeginWriteAttribute("value", " value=\"", 9943, "\"", 10020, 1);
#nullable restore
#line 237 "E:\New folder (2)\StudentManagementSystem\StudentManagementSystem\Views\Students\Profile.cshtml"
WriteAttributeValue("", 9951, HttpContextAccessor.HttpContext.Session.GetString("SessionKeyphone"), 9951, 69, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                        </div>
                                    </div>
                                </div>




                                <div class=""form-group"">
                                    <div class=""col-sm-offset-2 col-sm-10"">
                                        <button type=""submit"" class=""btn btn-danger""  id=""btnedit"">Update</button>
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div role=\"tabpanel\" class=\"tab-pane fade in\" id=\"change_password_settings\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c85235577fa35c113d9dfd498f735f55d4eab7bf22874", async() => {
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <label for=""NewPassword"" class=""col-sm-3 control-label"">New Password</label>
                                    <div class=""col-sm-9"">
                                        <div class=""form-line"">
                                            <input type=""password"" class=""form-control"" id=""txtNewPassword"" name=""NewPassword"" placeholder=""New Password"" required>
                                        </div>
                                    </div>
                                </div>
                                <div class=""form-group"">
                                    <label for=""NewPasswordConfirm"" class=""col-sm-3 control-label"">New Password (Confirm)</label>
                                    <div class=""col-sm-9"">
                                        <div class=""form-line"">
                                            <input type=""password"" class=""form-control"" id=""txtNewPasswordConfirm""");
                WriteLiteral(@" name=""NewPasswordConfirm"" placeholder=""New Password (Confirm)"" required>
                                        </div>
                                    </div>
                                </div>

                                <div class=""form-group"">
                                    <div class=""col-sm-offset-3 col-sm-9"">
                                        <button type=""submit"" class=""btn btn-danger""  id=""btnpassword"">Update</button>
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div role=\"tabpanel\" class=\"tab-pane fade in\" id=\"delete_settings\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c85235577fa35c113d9dfd498f735f55d4eab7bf26034", async() => {
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <div class=""col-sm-3"">

                                    </div>
                                    <div class=""col-sm-9"">
                                        <h4>Do you want to delete account?</h4>
                                    </div>

                                </div>


                                <div class=""form-group"">
                                    <div class=""col-sm-offset-3 col-sm-9"">
                                        <button type=""submit"" class=""btn btn-danger"" id=""btndelete"">Yes</button>
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
