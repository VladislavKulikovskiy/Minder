#pragma checksum "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\Home\addLike.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d51b9115e6de816374d72892b4ac89401d531a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_addLike), @"mvc.1.0.view", @"/Views/Home/addLike.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/addLike.cshtml", typeof(AspNetCore.Views_Home_addLike))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d51b9115e6de816374d72892b4ac89401d531a2", @"/Views/Home/addLike.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1981613dfb43f41e20a580550cacec64841520ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_addLike : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MinderXAuth.ViewModels.MindModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\Home\addLike.cshtml"
  
    string nameBlock = "numOfLike" + Model.MindId.ToString();
    string formblock = "formblock" + Model.MindId.ToString();

#line default
#line hidden
            BeginContext(176, 6, true);
            WriteLiteral("\r\n<div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 182, "\"", 197, 1);
#line 8 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\Home\addLike.cshtml"
WriteAttributeValue("", 187, nameBlock, 187, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(198, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 9 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\Home\addLike.cshtml"
     if (Model.liked)
    {

#line default
#line hidden
            BeginContext(231, 44, true);
            WriteLiteral("        <input type=\"submit\" value=\"dislike\"");
            EndContext();
            BeginWriteAttribute("form", " form=\"", 275, "\"", 292, 1);
#line 11 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\Home\addLike.cshtml"
WriteAttributeValue("", 282, formblock, 282, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(293, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 12 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\Home\addLike.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(320, 41, true);
            WriteLiteral("        <input type=\"submit\" value=\"like\"");
            EndContext();
            BeginWriteAttribute("form", " form=\"", 361, "\"", 378, 1);
#line 15 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\Home\addLike.cshtml"
WriteAttributeValue("", 368, formblock, 368, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(379, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 16 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\Home\addLike.cshtml"
    }

#line default
#line hidden
            BeginContext(389, 42, true);
            WriteLiteral("\r\n\r\n    <input type=\"hidden\" name=\"MindId\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 431, "", 451, 1);
#line 19 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\Home\addLike.cshtml"
WriteAttributeValue("", 438, Model.MindId, 438, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("form", " form=\"", 451, "\"", 468, 1);
#line 19 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\Home\addLike.cshtml"
WriteAttributeValue("", 458, formblock, 458, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(469, 11, true);
            WriteLiteral(">\r\n    <h2>");
            EndContext();
            BeginContext(481, 16, false);
#line 20 "E:\ПВИ Курсач\MinderXAuth v3\MinderXAuth\Views\Home\addLike.cshtml"
   Write(Model.NumOfLikes);

#line default
#line hidden
            EndContext();
            BeginContext(497, 17, true);
            WriteLiteral("</h2>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MinderXAuth.ViewModels.MindModel> Html { get; private set; }
    }
}
#pragma warning restore 1591