#pragma checksum "D:\GitHub\Tch\Tch\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e0598dcb02a54db64a7691855ccc724443c95c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "D:\GitHub\Tch\Tch\Views\_ViewImports.cshtml"
using Tch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\Tch\Tch\Views\_ViewImports.cshtml"
using Tch.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0598dcb02a54db64a7691855ccc724443c95c1", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c65cee8c87447d3bc65083a633802601485448aa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tch.Models.User>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("checkbox-slider yesno"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "useCan_Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("useCan_Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("form21401"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form21401"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e0598dcb02a54db64a7691855ccc724443c95c16846", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"doupdate_User_Details\" id=\"doupdate_User_Details\" value=\"yes\" alt=\"text\">\r\n        <input type=\"hidden\" name=\"useID_NewID\" id=\"useID_NewID\"");
                BeginWriteAttribute("value", " value=\"", 437, "\"", 445, 0);
                EndWriteAttribute();
                WriteLiteral(@" alt=""text"">
        <div class=""row"">
            <section class=""panel panel-primary"">
                <header class=""panel-heading"">
                    <div class=""panel-actions"">
                    </div>
                    <h2 class=""panel-title"">Basic Info</h2>
                </header>
                <div class=""panel-body"">
                    <div class=""form-group"">

                        <div class=""col-sm-6"">
                            ");
#nullable restore
#line 23 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Id, "", new { @class = "form-control focused", @id = "useId", @name = "useId", @value = "", @type = "hidden", @alt = "text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""col-sm-3 control-label"">Friendly Name: </label>
                        <div class=""col-sm-6"">
                            ");
#nullable restore
#line 29 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Friendly_Name, "", new { @class = "form-control focused", @id = "useFriendly_Name", @name = "useFriendly_Name", @value = "", @type = "text", @alt = "text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""col-sm-3 control-label"">Name: </label>
                        <div class=""col-sm-6"">
                            ");
#nullable restore
#line 36 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Name, "", new { @class = "form-control focused", @id = "useName", @name = "useName", @value = "", @type = "text", @alt = "text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""col-sm-3 control-label"">Surname: </label>
                        <div class=""col-sm-6"">
                            ");
#nullable restore
#line 43 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Surname, "", new { @class = "form-control focused", @id = "useSurname", @name = "useSurname", @value = "", @type = "text", @alt = "text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""col-sm-3 control-label"">Contact Number: </label>
                        <div class=""col-sm-6"">
                            ");
#nullable restore
#line 50 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Contact_Number, "", new { @class = "form-control focused", @id = "useContact_Number", @name = "useContact_Number", @value = "", @type = "text", @alt = "text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""col-sm-3 control-label"">Email Address: </label>
                        <div class=""col-sm-6"">
                            ");
#nullable restore
#line 57 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Email_Address, "", new { @class = "form-control focused", @id = "useEmail_Address", @name = "useEmail_Address", @value = "", @type = "text", @alt = "text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label class=\"col-sm-3 control-label\">Date of Birth: </label>\r\n                        <div class=\"col-sm-6\">\r\n");
#nullable restore
#line 64 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                             if (Model != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                           Write(Html.TextBoxFor(m => m.Date_of_Birth, Model.Date_of_Birth.ToString("dd MMM yyyy"), new { @class = "form-control", @data_plugin_datepicker = "", @id = "useDate_of_Birth", @name = "useDate_of_Birth", @value = "blank", @type = "text", @alt = "date", @data_date_format = "dd M yyyy" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                                                                                                                                                                                                                                                                                                                          
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                           Write(Html.TextBoxFor(m => m.Date_of_Birth, "", new { @class = "form-control", @data_plugin_datepicker = "", @id = "useDate_of_Birth", @name = "useDate_of_Birth", @value = "blank", @type = "text", @alt = "date", @data_date_format = "dd M yyyy" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                                                                                                                                                                                                                                                                                 
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""col-sm-3 control-label"">Age: </label>
                        <div class=""col-sm-6"">
                            ");
#nullable restore
#line 79 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Age, "", new { @class = "form-control focused", @id = "useAge", @name = "useAge", @value = "", @type = "text", @alt = "numeric" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""col-sm-3 control-label"">Company: </label>
                        <div class=""col-sm-6"">

                            ");
#nullable restore
#line 87 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                       Write(Html.DropDownListFor(m => m.Company.Name, new SelectList(ViewBag.CompanyToList, "Value", "Text"), new { @data_plugin_selecttwo = "", @class = "form-control populate select2-hidden-accessible", @name = "useCompany", @id = "useCompany", @alt = "dropdown", @data_rel = "chosen", @tabindex = "-1", @aria_hidden = "true", @value = "", @onChange = "selectedtext(this)" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                            ");
#nullable restore
#line 95 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.CompanyId, "", new { @id = "txt", @name = "company", @value = "", @type = "hidden" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("\r\n");
                WriteLiteral(@"                        </div>

                    </div>
                </div>
            </section>
        </div>
        <div class=""row"">
            <section class=""panel panel-primary"">
                <header class=""panel-heading"">
                    <div class=""panel-actions"">
                    </div>
                    <h2 class=""panel-title"">Login Details</h2>
                </header>
                <div class=""panel-body"">
                    <div class=""form-group"">
                        <label class=""col-sm-3 control-label"">Username: </label>
                        <div class=""col-sm-6"">
                            ");
#nullable restore
#line 116 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Username, "", new { @class = "form-control focused", @id = "useUsername", @name = "useUsername", @value = "", @type = "text", @alt = "text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""col-sm-3 control-label"">Password: </label>
                        <div class=""col-sm-6"">
                            ");
#nullable restore
#line 123 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Password, "", new { @class = "form-control focused", @id = "usePassword", @name = "usePassword", @value = "", @type = "text", @alt = "text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""col-sm-3 control-label"">Can Login: </label>
                        <div class=""col-sm-6"">
                            <div style=""padding-top:5px;"">
                                ");
#nullable restore
#line 131 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                           Write(Html.CheckBoxFor(m => m.Can_Login));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e0598dcb02a54db64a7691855ccc724443c95c118335", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 132 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Can_Login);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("   \r\n                            </div>\r\n                            <input type=\"hidden\" name=\"useCan_Login_Other\" id=\"useCan_Login_Other\"");
                BeginWriteAttribute("value", " value=\"", 10045, "\"", 10053, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                </div>
            </section>
        </div>
        <div class=""row"">
            <section class=""panel panel-primary"">
                <header class=""panel-heading"">
                    <div class=""panel-actions"">
                    </div>
                    <h2 class=""panel-title"">Profile Image</h2>
                </header>
                <div class=""panel-body"">
                    <div class=""form-group"">
                        <label class=""col-sm-3 control-label"">Picture: </label>
                        <div class=""col-sm-6"">
");
                WriteLiteral("                            <u onclick=\"openWindow();\">\r\n");
#nullable restore
#line 153 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                                 if (Model !=null)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <img id=\"ThumbImage_usePicture\" style=\"display:normal\"");
                BeginWriteAttribute("src", " src=\"", 11144, "\"", 11172, 1);
#nullable restore
#line 155 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
WriteAttributeValue("", 11150, Model.PictureFileName, 11150, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 156 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </u>\r\n");
                WriteLiteral("                            <u onclick=\"openWindow();\">Upload Now</u>\r\n                        </div>\r\n                        ");
#nullable restore
#line 162 "D:\GitHub\Tch\Tch\Views\User\Index.cshtml"
                   Write(Html.TextBoxFor(m => m.PictureFileName, "", new { @class = "form-control focused", @id = "usePic", @name = "usePic",  @type = "hidden", @alt = "text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                    </div>
                </div>
                <footer class=""panel-footer"" style=""text-align: center"">
                    <button type=""submit"" class=""btn btn-primary"" onclick=""{ window.location = '/Home/Index'; }"">Save</button>
                    <button type=""reset"" class=""btn btn-default"" onclick=""if(confirm('Changes will be lost, continue?')){window.location='/Home/Index';}"">Cancel</button>
                </footer>
            </section>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script >
        function openWindow() {
            var uid = document.getElementById(""useId"").value;
            var Fname = document.getElementById(""useFriendly_Name"").value;
            var name = document.getElementById(""useName"").value;
            var sname = document.getElementById(""useSurname"").value;
            var cont = document.getElementById(""useContact_Number"").value;
            var email = document.getElementById(""useEmail_Address"").value;
            var dob = document.getElementById(""useDate_of_Birth"").value;
            var age = document.getElementById(""useAge"").value;
            var Cname = document.getElementById(""useCompany"").value;
            var Cid = document.getElementById(""txt"").value;
            var Username = document.getElementById(""useUsername"").value;
            var Password = document.getElementById(""usePassword"").value;
            var login = document.getElementById(""useCan_Login"").value;
            window.open('/UpLoadImg/Index?id=' + uid + '&F");
                WriteLiteral(@"name=' + Fname + '&name=' + name + '&sname=' + sname + '&cont=' + cont + '&email=' + email + '&dob=' + dob + '&age=' + age + '&Cname=' + Cname + '&Cid=' + Cid + '&Username=' + Username + '&Pass=' + Password + '&Canlogin=' + login, 'uploadwindow', 'menubar=no,width=430,height=200,toolbar=no');
        }
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tch.Models.User> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
