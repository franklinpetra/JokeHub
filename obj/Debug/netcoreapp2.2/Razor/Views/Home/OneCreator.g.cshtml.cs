#pragma checksum "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/OneCreator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab77c9000e46dca846c8bdbbf23854df9b6ccc6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneCreator), @"mvc.1.0.view", @"/Views/Home/OneCreator.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/OneCreator.cshtml", typeof(AspNetCore.Views_Home_OneCreator))]
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
#line 1 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/_ViewImports.cshtml"
using CSharp;

#line default
#line hidden
#line 2 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/_ViewImports.cshtml"
using CSharp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab77c9000e46dca846c8bdbbf23854df9b6ccc6e", @"/Views/Home/OneCreator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57960b033169fce63b7c4d090eb3a63bd9e374e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneCreator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardWrapper>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 34, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(58, 359, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab77c9000e46dca846c8bdbbf23854df9b6ccc6e3349", async() => {
                BeginContext(64, 346, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>OneUser</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous"">
");
                EndContext();
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
            EndContext();
            BeginContext(417, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(418, 1657, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab77c9000e46dca846c8bdbbf23854df9b6ccc6e4867", async() => {
                BeginContext(424, 55, true);
                WriteLiteral("\n    <div class=\"container\">\n        <div Class=\"row\">\n");
                EndContext();
                BeginContext(650, 76, true);
                WriteLiteral("        </div>\n        <div Class=\"row\">\n            <div class=\"col-sm-8\">\n");
                EndContext();
#line 20 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/OneCreator.cshtml"
                 foreach(User user in Model.AllUsers)
                {

#line default
#line hidden
                BeginContext(798, 37, true);
                WriteLiteral("                    <h5>Name: &nbsp; ");
                EndContext();
                BeginContext(836, 9, false);
#line 22 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/OneCreator.cshtml"
                                Write(user.Name);

#line default
#line hidden
                EndContext();
                BeginContext(845, 45, true);
                WriteLiteral(" </h5>\n                    <h5>Alias: &nbsp; ");
                EndContext();
                BeginContext(891, 10, false);
#line 23 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/OneCreator.cshtml"
                                 Write(user.Alias);

#line default
#line hidden
                EndContext();
                BeginContext(901, 45, true);
                WriteLiteral(" </h5>\n                    <h5>Email: &nbsp; ");
                EndContext();
                BeginContext(947, 10, false);
#line 24 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/OneCreator.cshtml"
                                 Write(user.Email);

#line default
#line hidden
                EndContext();
                BeginContext(957, 61, true);
                WriteLiteral(" </h5>\n                    <h5>Total Number of Posts: &nbsp; ");
                EndContext();
                BeginContext(1019, 24, false);
#line 25 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/OneCreator.cshtml"
                                                 Write(user.CreatedByUser.Count);

#line default
#line hidden
                EndContext();
                BeginContext(1043, 6, true);
                WriteLiteral("</h5>\n");
                EndContext();
#line 26 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/OneCreator.cshtml"
                         foreach(Idea idea in Model.AllIdeas)
                        {

#line default
#line hidden
                BeginContext(1137, 61, true);
                WriteLiteral("                            <h5>Total Number of Fans: &nbsp; ");
                EndContext();
                BeginContext(1199, 31, false);
#line 28 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/OneCreator.cshtml"
                                                        Write(idea.UsersWhoLikeThisIdea.Count);

#line default
#line hidden
                EndContext();
                BeginContext(1230, 6, true);
                WriteLiteral("</h5>\n");
                EndContext();
#line 29 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/OneCreator.cshtml"
                        }

#line default
#line hidden
#line 29 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/OneCreator.cshtml"
                         
                    
                }

#line default
#line hidden
                BeginContext(1301, 150, true);
                WriteLiteral("            </div>\n        </div>\n        <hr>\n            <div class=\"row\">\n                <div class=\"col-sm-8\" style=\"margin: 100px 0px 0px 0px\">\n");
                EndContext();
#line 37 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/OneCreator.cshtml"
                     foreach(Like liker in Model.IdeaForm.UsersWhoLikeThisIdea)
                    {

#line default
#line hidden
                BeginContext(1553, 28, true);
                WriteLiteral("                        <li>");
                EndContext();
                BeginContext(1582, 17, false);
#line 39 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/OneCreator.cshtml"
                       Write(liker.Liker.Alias);

#line default
#line hidden
                EndContext();
                BeginContext(1599, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(1603, 16, false);
#line 39 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/OneCreator.cshtml"
                                            Write(liker.Liker.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1619, 6, true);
                WriteLiteral("</li>\n");
                EndContext();
                BeginContext(1626, 33, true);
                WriteLiteral("                        <br><br>\n");
                EndContext();
#line 42 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/OneCreator.cshtml"
                    }

#line default
#line hidden
                BeginContext(1681, 76, true);
                WriteLiteral("                    <h4>Likes received by</h4>\n                        <ul>\n");
                EndContext();
#line 45 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/OneCreator.cshtml"
                             foreach(Like liker in Model.IdeaForm.UsersWhoLikeThisIdea)
                            {

#line default
#line hidden
                BeginContext(1875, 36, true);
                WriteLiteral("                                <li>");
                EndContext();
                BeginContext(1912, 17, false);
#line 47 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/OneCreator.cshtml"
                               Write(liker.Liker.Alias);

#line default
#line hidden
                EndContext();
                BeginContext(1929, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(1933, 16, false);
#line 47 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/OneCreator.cshtml"
                                                    Write(liker.Liker.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1949, 6, true);
                WriteLiteral("</li>\n");
                EndContext();
#line 48 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/OneCreator.cshtml"
                            }

#line default
#line hidden
                BeginContext(1985, 83, true);
                WriteLiteral("                        </ul>\n                </div>\n            </div>\n    </div>\n");
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
            BeginContext(2075, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardWrapper> Html { get; private set; }
    }
}
#pragma warning restore 1591
