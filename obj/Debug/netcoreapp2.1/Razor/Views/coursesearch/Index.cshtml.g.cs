#pragma checksum "S:\100000000\B2_PrjtExcp\A1_Dotnet\A1_CMS2\Views\coursesearch\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "363270cf3b9dd7370f5755c7be5aba0e9a4d5d51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_coursesearch_Index), @"mvc.1.0.view", @"/Views/coursesearch/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/coursesearch/Index.cshtml", typeof(AspNetCore.Views_coursesearch_Index))]
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
#line 1 "S:\100000000\B2_PrjtExcp\A1_Dotnet\A1_CMS2\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "S:\100000000\B2_PrjtExcp\A1_Dotnet\A1_CMS2\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"363270cf3b9dd7370f5755c7be5aba0e9a4d5d51", @"/Views/coursesearch/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fda46ac6a24f19109ebb784fda558b061b2e80b", @"/Views/_ViewImports.cshtml")]
    public class Views_coursesearch_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CMS.Models.B1_View.SearchView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Computer Science", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Information and Technology", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Semester - 01", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Semester - 02", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Semester - 03", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "coursesearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "S:\100000000\B2_PrjtExcp\A1_Dotnet\A1_CMS2\Views\coursesearch\Index.cshtml"
  
    ViewData["Title"] = "College Management Services";

#line default
#line hidden
            BeginContext(103, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(107, 680, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "363270cf3b9dd7370f5755c7be5aba0e9a4d5d516278", async() => {
                BeginContext(176, 99, true);
                WriteLiteral("\r\n    <label for=\"deptnameid\">Dept:</label>\r\n    <select name=\"deptname\" id=\"department\">\r\n        ");
                EndContext();
                BeginContext(275, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "363270cf3b9dd7370f5755c7be5aba0e9a4d5d516767", async() => {
                    BeginContext(308, 16, true);
                    WriteLiteral("Computer Science");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(333, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(343, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "363270cf3b9dd7370f5755c7be5aba0e9a4d5d518248", async() => {
                    BeginContext(386, 26, true);
                    WriteLiteral("Information and Technology");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(421, 110, true);
                WriteLiteral("\r\n    </select>\r\n    <label for=\"semnameid\">Dept:</label>\r\n    <select name=\"semname\" id=\"semester\">\r\n        ");
                EndContext();
                BeginContext(531, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "363270cf3b9dd7370f5755c7be5aba0e9a4d5d519852", async() => {
                    BeginContext(561, 13, true);
                    WriteLiteral("Semester - 01");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(583, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(593, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "363270cf3b9dd7370f5755c7be5aba0e9a4d5d5111330", async() => {
                    BeginContext(623, 13, true);
                    WriteLiteral("Semester - 02");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(645, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(655, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "363270cf3b9dd7370f5755c7be5aba0e9a4d5d5112809", async() => {
                    BeginContext(685, 13, true);
                    WriteLiteral("Semester - 03");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(707, 73, true);
                WriteLiteral("\r\n    </select>\r\n\r\n    <input type=\"submit\" value=\"Search\" id=\"search\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(787, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "S:\100000000\B2_PrjtExcp\A1_Dotnet\A1_CMS2\Views\coursesearch\Index.cshtml"
  
    if (TempData["Result_coursesearch_search"] != null)
    {
        var res = TempData["Result_coursesearch_search"];
        if (@res.ToString() == "Positive")
        {

#line default
#line hidden
            BeginContext(971, 144, true);
            WriteLiteral("            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1116, 76, false);
#line 33 "S:\100000000\B2_PrjtExcp\A1_Dotnet\A1_CMS2\Views\coursesearch\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.CourseList_Var.FirstOrDefault().CourseId));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1284, 78, false);
#line 36 "S:\100000000\B2_PrjtExcp\A1_Dotnet\A1_CMS2\Views\coursesearch\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.CourseList_Var.FirstOrDefault().CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 111, true);
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 41 "S:\100000000\B2_PrjtExcp\A1_Dotnet\A1_CMS2\Views\coursesearch\Index.cshtml"
                      var count = 0;

#line default
#line hidden
#line 42 "S:\100000000\B2_PrjtExcp\A1_Dotnet\A1_CMS2\Views\coursesearch\Index.cshtml"
                     foreach (var table in Model.CourseList_Var)
                    {
                        count = count + 1;

#line default
#line hidden
            BeginContext(1645, 30, true);
            WriteLiteral("                        <tr>\r\n");
            EndContext();
#line 46 "S:\100000000\B2_PrjtExcp\A1_Dotnet\A1_CMS2\Views\coursesearch\Index.cshtml"
                               var id1 = "courseId"+count.ToString();

#line default
#line hidden
            BeginContext(1747, 31, true);
            WriteLiteral("                            <td");
            EndContext();
            BeginWriteAttribute("id", " id=", 1778, "", 1786, 1);
#line 47 "S:\100000000\B2_PrjtExcp\A1_Dotnet\A1_CMS2\Views\coursesearch\Index.cshtml"
WriteAttributeValue("", 1782, id1, 1782, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1786, 37, true);
            WriteLiteral("  >\r\n                                ");
            EndContext();
            BeginContext(1824, 14, false);
#line 48 "S:\100000000\B2_PrjtExcp\A1_Dotnet\A1_CMS2\Views\coursesearch\Index.cshtml"
                           Write(table.CourseId);

#line default
#line hidden
            EndContext();
            BeginContext(1838, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
#line 50 "S:\100000000\B2_PrjtExcp\A1_Dotnet\A1_CMS2\Views\coursesearch\Index.cshtml"
                               var id2 = "courseName"+count.ToString();

#line default
#line hidden
            BeginContext(1949, 31, true);
            WriteLiteral("                            <td");
            EndContext();
            BeginWriteAttribute("id", " id=", 1980, "", 1988, 1);
#line 51 "S:\100000000\B2_PrjtExcp\A1_Dotnet\A1_CMS2\Views\coursesearch\Index.cshtml"
WriteAttributeValue("", 1984, id2, 1984, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1988, 36, true);
            WriteLiteral(" >\r\n                                ");
            EndContext();
            BeginContext(2025, 16, false);
#line 52 "S:\100000000\B2_PrjtExcp\A1_Dotnet\A1_CMS2\Views\coursesearch\Index.cshtml"
                           Write(table.CourseName);

#line default
#line hidden
            EndContext();
            BeginContext(2041, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 55 "S:\100000000\B2_PrjtExcp\A1_Dotnet\A1_CMS2\Views\coursesearch\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2132, 48, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 58 "S:\100000000\B2_PrjtExcp\A1_Dotnet\A1_CMS2\Views\coursesearch\Index.cshtml"
        }
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CMS.Models.B1_View.SearchView> Html { get; private set; }
    }
}
#pragma warning restore 1591
