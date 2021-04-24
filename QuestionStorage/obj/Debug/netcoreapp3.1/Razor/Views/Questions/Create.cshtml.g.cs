#pragma checksum "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cfaf0b8a7553849ecaaab8bd9901741210dc3a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_Create), @"mvc.1.0.view", @"/Views/Questions/Create.cshtml")]
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
#line 1 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/_ViewImports.cshtml"
using QuestionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/_ViewImports.cshtml"
using QuestionStorage.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml"
using QuestionStorage.Models.Tags;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cfaf0b8a7553849ecaaab8bd9901741210dc3a9", @"/Views/Questions/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de651716945de7d2a5e15f0b428a494276bb77c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionStorage.Models.ViewModels.QuestionViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml"
  
    ViewData["Title"] = "Create";
    var qTypes = new Dictionary<string, string>
    {
        {"mc", "Multiple choice"},
        {"sc", "Single choice"},
        {"oa", "Open answer"}
    };

    var selectList = new SelectList(qTypes.Select(
        x => new {Value = x.Key, Text = x.Value}), "Value", "Text");

    HashSet<Tag> tags = ViewBag.Tags;
    var tagList = new SelectList(tags.Select(t => new {Value = $"ŧ{t.Id}", Text = t.Name}),
        "Value", "Text");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<meta charset=\"utf-8\">\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cfaf0b8a7553849ecaaab8bd9901741210dc3a94263", async() => {
                WriteLiteral("\r\n    <title>Create</title>\r\n    <link rel=\"stylesheet\" href=\"/lib/bootstrap/dist/css/custom-stylesheet.css\">\r\n    <script src=\"/js/add-to-table.js\"></script>\r\n    <script src=\"/js/display-answer-variants.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<style>\r\n    .select2-container--default .select2-selection--multiple {\r\n        height: calc(1.5em + 0.75rem + 1px)\r\n    }\r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cfaf0b8a7553849ecaaab8bd9901741210dc3a95598", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 37 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml"
 using (Html.BeginForm("Create", "Questions", FormMethod.Post))
{                                                                                     
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml"
Write(Html.ValidationSummary("Please provide the details below and then click submit.",
        new {@class = "text-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("    <h1 class=\"page-header\">Create question</h1>\r\n");
#nullable restore
#line 45 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml"
Write(Html.Partial("_TextTitle"));

#line default
#line hidden
#nullable disable
                WriteLiteral("    <p class=\"less-bottom-space\">Template\r\n        <input type=\"hidden\" value=\"off\" name=\"IsTemplate\"> \r\n        <input name=\"IsTemplate\" type=\"checkbox\" value=\"on\">\r\n    </p>   \r\n");
                WriteLiteral("    <hr/>\r\n");
#nullable restore
#line 54 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml"
Write(Html.Label("Question type"));

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br/>\r\n");
#nullable restore
#line 56 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml"
Write(Html.DropDownListFor(model => model.Question.Type.Name, selectList,
        new {@class = "select", onchange = "displayAnswerVariants()", id = "typeOfQuestionSelector"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("    <hr/>\r\n");
                WriteLiteral("    <p id=\"answerInfo\"></p>\r\n    <table id=\"answerTable\">\r\n        <thead>\r\n        <tr>\r\n        <th style=\"font-weight: normal\">Response options*</th>\r\n        <th style=\"font-weight: normal\">Correct</th>\r\n        <th>\r\n        <tbody>\r\n");
#nullable restore
#line 68 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml"
          
            for (var i = 0; i <= 4; ++i)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 73 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml"
                   Write(Html.TextAreaFor(model => model.AnswerOption.Text, 1, 60,
                            new {@class = "textarea long resizable"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </td>
                    <td style=""text-align: center; vertical-align: center"">
                        <input type=""hidden"" value=""off"" name=""IsCorrect"">
                        <input name=""IsCorrect"" type=""checkbox"" value=""on"">
                    </td>
");
#nullable restore
#line 80 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml"
                     if (i > 1)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td style=\"text-align: center; vertical-align: central\">\r\n                            <button class=\"button remove\" id=\"addResponseOptions\" onclick=\"removeRow(this, \'answerTable\')\">✕</button>\r\n                        </td>\r\n");
#nullable restore
#line 85 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>\r\n                        </td>\r\n");
#nullable restore
#line 90 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    \r\n                    \r\n                </tr>\r\n");
#nullable restore
#line 94 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
                WriteLiteral("    <p>\r\n        <button class=\"button add\" id=\"addResponseOptions\" type=\"button\" onclick=\"addNewRow(\'answerTable\')\">\r\n            Add option\r\n        </button>\r\n    </p>\r\n");
                WriteLiteral("    <hr/>\r\n");
#nullable restore
#line 106 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml"
Write(Html.Label("Tags"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml"
Write(Html.DropDownList("Tags", tagList, new {id = "tagView", multiple = "multiple"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br/>\r\n");
                WriteLiteral("    <br/>\r\n    <input type=\"submit\" class=\"submit\" value=\"Create question\"/>\r\n");
#nullable restore
#line 112 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml"
}

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</html>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
    $(function() {
        $('#tagView').select2({
        width : ""100%"",
        tags: true,
        });
    });
    </script>
    
    <script>
    function pasteFromClipboard(text) {
        document.getElementById('QuestionText').textContent = text;
    }
    </script>

    <script>
        let textAreas = document.getElementsByTagName('textarea');
        let count = textAreas.length;
        for (let i = 0; i < count; ++i) {
            textAreas[i].onkeydown = function(e) {
                if (e.key === 'Tab' || e.code === 'Tab' || e.keyCode === 9) {
                    e.preventDefault();
                    let s = this.selectionStart;
                    this.value = this.value.substring(
                        0, this.selectionStart) + ""\t"" + this.value.substring(this.selectionEnd);
                    this.selectionEnd = s + 1;
                }
            }
        }
        </script>

");
#nullable restore
#line 148 "/Users/mmanakhova/Documents/[QSTORAGE]/QuestionStorage/QuestionStorage/Views/Questions/Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionStorage.Models.ViewModels.QuestionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
