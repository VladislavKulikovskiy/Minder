#pragma checksum "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02f234b6e825f324103ff2b4125451f6b4e75cba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserPage_UserPage), @"mvc.1.0.view", @"/Views/UserPage/UserPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserPage/UserPage.cshtml", typeof(AspNetCore.Views_UserPage_UserPage))]
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
#line 1 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\_ViewImports.cshtml"
using MinderXAuth;

#line default
#line hidden
#line 2 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\_ViewImports.cshtml"
using MinderXAuth.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02f234b6e825f324103ff2b4125451f6b4e75cba", @"/Views/UserPage/UserPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1981613dfb43f41e20a580550cacec64841520ab", @"/Views/_ViewImports.cshtml")]
    public class Views_UserPage_UserPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MinderXAuth.ViewModels.UserPageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/UserPage/AddToFriend"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/UserPage/removeFromFriend"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/addLike"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-mode", new global::Microsoft.AspNetCore.Html.HtmlString("replace-with"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/addComment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
  
    ViewData["Title"] = "UserPage";

#line default
#line hidden
            BeginContext(89, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(92, 41, false);
#line 6 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
Write(Html.Partial("_GetUser", @Model.userPage));

#line default
#line hidden
            EndContext();
            BeginContext(133, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
  
    if (Convert.ToUInt32(User.Identity.Name) == Model.userPage.UserId)
    {

#line default
#line hidden
            BeginContext(220, 26, true);
            WriteLiteral("        <h1>My Page</h1>\r\n");
            EndContext();
#line 12 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(270, 15, true);
            WriteLiteral("        <div>\r\n");
            EndContext();
#line 16 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
             if (!Model.myFriend)
            {

#line default
#line hidden
            BeginContext(335, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(351, 231, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "099b4fa7636d4ea3b29ddac3970c4d0f", async() => {
                BeginContext(402, 42, true);
                WriteLiteral("\r\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 444, "\"", 474, 1);
#line 19 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
WriteAttributeValue("", 452, Model.userPage.UserId, 452, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(475, 100, true);
                WriteLiteral(" name=\"friendId\">\r\n                    <input type=\"submit\" value=\"add to friend\">\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(582, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(632, 49, true);
            WriteLiteral("                <h2>Friend</h2>\r\n                ");
            EndContext();
            BeginContext(681, 241, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68f130b4abe34101a5cf83b62a423a78", async() => {
                BeginContext(737, 42, true);
                WriteLiteral("\r\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 779, "\"", 809, 1);
#line 27 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
WriteAttributeValue("", 787, Model.userPage.UserId, 787, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(810, 105, true);
                WriteLiteral(" name=\"friendId\">\r\n                    <input type=\"submit\" value=\"remove from friend\">\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(922, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 30 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
            }

#line default
#line hidden
            BeginContext(939, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 33 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
    }

#line default
#line hidden
            BeginContext(967, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(974, 19, false);
#line 36 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(993, 118, true);
            WriteLiteral("</h2>\r\n\r\n<div style=\"position:center; left:50px; right:50px\">\r\n    <table border=\"1\" width=\"100%\" cellpadding=\"5\">\r\n\r\n");
            EndContext();
#line 41 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
         foreach (var mind in Model.userPageMinds)
        {


            string commentBlock = "comment" + mind.MindId.ToString();
            Mind k = new Mind { NumOfLikes = mind.NumOfLikes, MindId = mind.MindId };



#line default
#line hidden
            BeginContext(1340, 40, true);
            WriteLiteral("            <tr>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1380, "\"", 1421, 2);
            WriteAttributeValue("", 1387, "/UserPage/UserPage?id=", 1387, 22, true);
#line 50 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
WriteAttributeValue("", 1409, mind.UserId, 1409, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1422, 6, true);
            WriteLiteral("> <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1428, "\"", 1447, 1);
#line 50 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
WriteAttributeValue("", 1434, mind.UserPic, 1434, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1448, 76, true);
            WriteLiteral(" class=\"img-circle\" height=\"100\" width=\"100\"></a></td>\r\n                <td>");
            EndContext();
            BeginContext(1525, 11, false);
#line 51 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
               Write(mind.MindId);

#line default
#line hidden
            EndContext();
            BeginContext(1536, 30, true);
            WriteLiteral("</td>\r\n                <td><p>");
            EndContext();
            BeginContext(1567, 13, false);
#line 52 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
                  Write(mind.MindMess);

#line default
#line hidden
            EndContext();
            BeginContext(1580, 31, true);
            WriteLiteral("</p></td>\r\n                <td>");
            EndContext();
            BeginContext(1612, 11, false);
#line 53 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
               Write(mind.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(1623, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1651, 15, false);
#line 54 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
               Write(mind.DateOfMind);

#line default
#line hidden
            EndContext();
            BeginContext(1666, 29, true);
            WriteLiteral("</td>\r\n                <td>\r\n");
            EndContext();
#line 56 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
                      
                        string nameBlock = "numOfLike" + mind.MindId.ToString();
                        string formblock = "formblock" + mind.MindId.ToString();
                    

#line default
#line hidden
            BeginContext(1906, 51, true);
            WriteLiteral("                    <div>\r\n                        ");
            EndContext();
            BeginContext(1957, 344, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b44671001e2948988de45a48246cf0ee", async() => {
                BeginContext(2104, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2270, 24, true);
                WriteLiteral("                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 61 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
AddHtmlAttributeValue("", 1967, formblock, 1967, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
            WriteLiteral("#");
#line 61 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
                                                                                                                                  Write(nameBlock);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-ajax-update", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2301, 32, true);
            WriteLiteral("\r\n\r\n                        <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2333, "\"", 2348, 1);
#line 66 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
WriteAttributeValue("", 2338, nameBlock, 2338, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2349, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(2381, 49, false);
#line 67 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
                       Write(Html.Partial("~/Views/Home/addLike.cshtml", mind));

#line default
#line hidden
            EndContext();
            BeginContext(2430, 201, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n\r\n                    <div>\r\n\r\n                        ");
            EndContext();
            BeginContext(2631, 393, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd2bd302e12c48d886d611d71f7f5443", async() => {
                BeginContext(2768, 203, true);
                WriteLiteral("\r\n                            <input type=\"submit\" value=\"add comment\">\r\n                            <input type=\"text\" name=\"commentText\">\r\n                            <input type=\"hidden\" name=\"MindId\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 2971, "", 2990, 1);
#line 81 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
WriteAttributeValue("", 2978, mind.MindId, 2978, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2990, 27, true);
                WriteLiteral(">\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
            WriteLiteral("#");
#line 78 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
                                                                                                                     Write(commentBlock);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-ajax-update", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3024, 32, true);
            WriteLiteral("\r\n\r\n                        <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3056, "\"", 3074, 1);
#line 84 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
WriteAttributeValue("", 3061, commentBlock, 3061, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3075, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(3107, 51, false);
#line 85 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
                       Write(Html.Partial("~/Views/Home/_Comments.cshtml", mind));

#line default
#line hidden
            EndContext();
            BeginContext(3158, 104, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 90 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\UserPage\UserPage.cshtml"
        }

#line default
#line hidden
            BeginContext(3273, 20, true);
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MinderXAuth.ViewModels.UserPageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591