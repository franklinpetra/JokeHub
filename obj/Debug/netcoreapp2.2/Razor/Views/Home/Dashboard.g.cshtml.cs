#pragma checksum "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7356a3ec7ded480fed10d62bf650260edd13eeeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7356a3ec7ded480fed10d62bf650260edd13eeeb", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57960b033169fce63b7c4d090eb3a63bd9e374e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardWrapper>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/booknote.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:300px; margin:-230px 0px 200px 700px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("typing"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(67, 34, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(101, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7356a3ec7ded480fed10d62bf650260edd13eeeb4680", async() => {
                BeginContext(107, 123, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <title></title>\n");
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
            BeginContext(237, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(238, 6393, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7356a3ec7ded480fed10d62bf650260edd13eeeb5971", async() => {
                BeginContext(244, 454, true);
                WriteLiteral(@" 
    <div class=""container"" style=""margin:0px 0px 0px 0px"">
        <div class=""row"">
            <div class=""col-md-9"">
                <h1>Welcome to the Jokes and Memes Hub""</h1>
            </div>
            <div class=""col-md-3"">
                <a style = ""margin:0px 0px 0px 0px"" href=""/logout"">Log Out</a><br><br><br>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3"">
                <h4>Hello&nbsp;");
                EndContext();
                BeginContext(699, 22, false);
#line 24 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                          Write(Model.LoggedUser.Alias);

#line default
#line hidden
                EndContext();
                BeginContext(721, 353, true);
                WriteLiteral(@",<br>Great to have you here.  </h4><br><br>
            </div>
        </div>
        <div class=""col-md-6"">
            <a href=""/ideas/new"" class=""col-sm-12 offset-sm-10""><button class=""btn btn-success"">Have something to add to the inventory?</button></a>
        </div>
    </div>
    <div class=""row""> 
        <div class=""text-center"">
            ");
                EndContext();
                BeginContext(1074, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7356a3ec7ded480fed10d62bf650260edd13eeeb7556", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1171, 324, true);
                WriteLiteral(@" <br><br>
        </div>
    </div>
    <div class=""container"" style=""margin:-220px 0px 0px 0px"">
        <div class=""row"">
        <div class=""col"">
        <p>&nbsp;Jokes trending right now:</p><br>
        <div class=""card h-400"" style=""width: 26rem; overflow:auto; max-height:400px"">
            <div class=""card-body"">
");
                EndContext();
#line 42 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                 foreach(Idea idea in Model.AllIdeas.Where(j=>j.IsIdea==false).OrderByDescending(Ideas =>Ideas.UsersWhoLikeThisIdea.Count))
                {
                

#line default
#line hidden
                BeginContext(1670, 22, true);
                WriteLiteral("                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1692, "\"", 1731, 2);
                WriteAttributeValue("", 1699, "/onecreator/", 1699, 12, true);
#line 45 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1711, idea.Creator.UserId, 1711, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1732, 26, true);
                WriteLiteral(" class=\"card-title\" >From ");
                EndContext();
                BeginContext(1759, 18, false);
#line 45 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                                                                                   Write(idea.Creator.Alias);

#line default
#line hidden
                EndContext();
                BeginContext(1777, 60, true);
                WriteLiteral(" &nbsp;-  </a><br>\n                    <p class=\"card-text\">");
                EndContext();
                BeginContext(1838, 12, false);
#line 46 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                                    Write(idea.Content);

#line default
#line hidden
                EndContext();
                BeginContext(1850, 62, true);
                WriteLiteral(" &nbsp; <span class=\"card-subtitle mb-2 text-muted\">(Added on ");
                EndContext();
                BeginContext(1913, 44, false);
#line 46 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                                                                                                               Write(idea.CreatedAt.Date.ToString("MMM dd, yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(1957, 13, true);
                WriteLiteral(")</span></p>\n");
                EndContext();
#line 47 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                         if(idea.UserId == Model.LoggedUser.UserId)
                            {

#line default
#line hidden
                BeginContext(2068, 34, true);
                WriteLiteral("                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2102, "\"", 2133, 3);
                WriteAttributeValue("", 2109, "/ideas/", 2109, 7, true);
#line 49 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2116, idea.IdeaId, 2116, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 2128, "/edit", 2128, 5, true);
                EndWriteAttribute();
                BeginContext(2134, 53, true);
                WriteLiteral("><button class=\"btn btn-primary\">Edit</button></a> <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2187, "\"", 2220, 3);
                WriteAttributeValue("", 2194, "/ideas/", 2194, 7, true);
#line 49 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2201, idea.IdeaId, 2201, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 2213, "/delete", 2213, 7, true);
                EndWriteAttribute();
                BeginContext(2221, 52, true);
                WriteLiteral("><button class=\"btn btn-danger\">Delete</button></a>\n");
                EndContext();
#line 50 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                            }
                            else if(idea.UsersWhoLikeThisIdea.Any(r => r.UserId == Model.LoggedUser.UserId))
                            {

#line default
#line hidden
                BeginContext(2442, 34, true);
                WriteLiteral("                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2476, "\"", 2509, 3);
                WriteAttributeValue("", 2483, "/ideas/", 2483, 7, true);
#line 53 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2490, idea.IdeaId, 2490, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 2502, "/unlike", 2502, 7, true);
                EndWriteAttribute();
                BeginContext(2510, 12, true);
                WriteLiteral(">Unlike</a>\n");
                EndContext();
#line 54 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                            }
                            else
                            {

#line default
#line hidden
                BeginContext(2615, 34, true);
                WriteLiteral("                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2649, "\"", 2680, 3);
                WriteAttributeValue("", 2656, "/ideas/", 2656, 7, true);
#line 57 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2663, idea.IdeaId, 2663, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 2675, "/like", 2675, 5, true);
                EndWriteAttribute();
                BeginContext(2681, 10, true);
                WriteLiteral(">Like</a>\n");
                EndContext();
#line 58 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                            }

#line default
#line hidden
                BeginContext(2722, 22, true);
                WriteLiteral("                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2744, "\"", 2772, 2);
                WriteAttributeValue("", 2751, "/OneIdea/", 2751, 9, true);
#line 60 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2760, idea.IdeaId, 2760, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2773, 63, true);
                WriteLiteral(" class=\"card-link card-subtitle mb-2 text-muted\">&nbsp; &nbsp; ");
                EndContext();
                BeginContext(2837, 31, false);
#line 60 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                                                                                                             Write(idea.UsersWhoLikeThisIdea.Count);

#line default
#line hidden
                EndContext();
                BeginContext(2868, 63, true);
                WriteLiteral(" &nbsp; people like this joke</a>\n                    <hr><br>\n");
                EndContext();
#line 62 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                }

#line default
#line hidden
                BeginContext(2948, 247, true);
                WriteLiteral("<br>      \n            </div>\n        </div>\n    </div>\n\n    <div class=\"col\">\n        <p>&nbsp;Memes trending right now:</p><br>\n        <div class=\"card\" style=\"width: 26rem; overflow:auto; max-height:400px\">\n            <div class=\"card-body\">\n");
                EndContext();
#line 71 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                 foreach(Idea idea in Model.AllIdeas.Where(j=>j.IsIdea==true).OrderByDescending(Ideas =>Ideas.UsersWhoLikeThisIdea.Count))
                {

#line default
#line hidden
                BeginContext(3352, 22, true);
                WriteLiteral("                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3374, "\"", 3413, 2);
                WriteAttributeValue("", 3381, "/OneCreator/", 3381, 12, true);
#line 73 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 3393, idea.Creator.UserId, 3393, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3414, 26, true);
                WriteLiteral(" class=\"card-title\" >From ");
                EndContext();
                BeginContext(3441, 18, false);
#line 73 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                                                                                   Write(idea.Creator.Alias);

#line default
#line hidden
                EndContext();
                BeginContext(3459, 60, true);
                WriteLiteral(" &nbsp;-  </a><br>\n                    <p class=\"card-text\">");
                EndContext();
                BeginContext(3520, 12, false);
#line 74 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                                    Write(idea.Content);

#line default
#line hidden
                EndContext();
                BeginContext(3532, 62, true);
                WriteLiteral(" &nbsp; <span class=\"card-subtitle mb-2 text-muted\">(Added on ");
                EndContext();
                BeginContext(3595, 44, false);
#line 74 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                                                                                                               Write(idea.CreatedAt.Date.ToString("MMM dd, yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(3639, 13, true);
                WriteLiteral(")</span></p>\n");
                EndContext();
#line 75 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                         if(idea.UserId == Model.LoggedUser.UserId)
                            {

#line default
#line hidden
                BeginContext(3750, 34, true);
                WriteLiteral("                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3784, "\"", 3815, 3);
                WriteAttributeValue("", 3791, "/ideas/", 3791, 7, true);
#line 77 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 3798, idea.IdeaId, 3798, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 3810, "/edit", 3810, 5, true);
                EndWriteAttribute();
                BeginContext(3816, 36, true);
                WriteLiteral(" class=\"btn btn-primary\">Edit</a> <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3852, "\"", 3885, 3);
                WriteAttributeValue("", 3859, "/ideas/", 3859, 7, true);
#line 77 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 3866, idea.IdeaId, 3866, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 3878, "/delete", 3878, 7, true);
                EndWriteAttribute();
                BeginContext(3886, 52, true);
                WriteLiteral("><button class=\"btn btn-danger\">Delete</button></a>\n");
                EndContext();
#line 78 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                            }
                            else if(idea.UsersWhoLikeThisIdea.Any(r => r.UserId == Model.LoggedUser.UserId))
                            {

#line default
#line hidden
                BeginContext(4107, 34, true);
                WriteLiteral("                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4141, "\"", 4174, 3);
                WriteAttributeValue("", 4148, "/ideas/", 4148, 7, true);
#line 81 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 4155, idea.IdeaId, 4155, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 4167, "/unlike", 4167, 7, true);
                EndWriteAttribute();
                BeginContext(4175, 12, true);
                WriteLiteral(">Unlike</a>\n");
                EndContext();
#line 82 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                            }
                            else
                            {

#line default
#line hidden
                BeginContext(4280, 34, true);
                WriteLiteral("                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4314, "\"", 4345, 3);
                WriteAttributeValue("", 4321, "/ideas/", 4321, 7, true);
#line 85 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 4328, idea.IdeaId, 4328, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 4340, "/like", 4340, 5, true);
                EndWriteAttribute();
                BeginContext(4346, 10, true);
                WriteLiteral(">Like</a>\n");
                EndContext();
#line 86 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                            }

#line default
#line hidden
                BeginContext(4387, 22, true);
                WriteLiteral("                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4409, "\"", 4437, 2);
                WriteAttributeValue("", 4416, "/OneIdea/", 4416, 9, true);
#line 88 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 4425, idea.IdeaId, 4425, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4438, 63, true);
                WriteLiteral(" class=\"card-link card-subtitle mb-2 text-muted\">&nbsp; &nbsp; ");
                EndContext();
                BeginContext(4502, 31, false);
#line 88 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                                                                                                             Write(idea.UsersWhoLikeThisIdea.Count);

#line default
#line hidden
                EndContext();
                BeginContext(4533, 63, true);
                WriteLiteral(" &nbsp; people like this meme</a>\n                    <hr><br>\n");
                EndContext();
#line 90 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                }

#line default
#line hidden
                BeginContext(4613, 547, true);
                WriteLiteral(@"<br>      
            </div>
        </div>
    </div>

    <div class=""container""  style=""margin:50px 0px 0px 0px; ""> 
        <div class=""row"">
            <div class=""col-sm-10 offset-sm"" style=""overflow:auto; max-height:400px"">
            <table class=""table"">
                <thead>
                    <th>Idea</th>
                    <th>Creator</th>
                    <th>Date Created</th>
                    <th># of Likes</th>
                    <th>Actions</th>
                </thead>
                <tbody class=""content"" >
");
                EndContext();
#line 107 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                     foreach(Idea idea in Model.AllIdeas)
                    {

#line default
#line hidden
                BeginContext(5240, 63, true);
                WriteLiteral("                        <tr>\n                            <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5303, "\"", 5331, 2);
                WriteAttributeValue("", 5310, "/oneidea/", 5310, 9, true);
#line 110 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 5319, idea.IdeaId, 5319, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5332, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(5334, 12, false);
#line 110 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                                                           Write(idea.Content);

#line default
#line hidden
                EndContext();
                BeginContext(5346, 42, true);
                WriteLiteral("</a></td>\n                            <td>");
                EndContext();
                BeginContext(5389, 18, false);
#line 111 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                           Write(idea.Creator.Alias);

#line default
#line hidden
                EndContext();
                BeginContext(5407, 38, true);
                WriteLiteral("</td>\n                            <td>");
                EndContext();
                BeginContext(5446, 38, false);
#line 112 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                           Write(idea.CreatedAt.ToString("MMM dd yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(5484, 38, true);
                WriteLiteral("</td>\n                            <td>");
                EndContext();
                BeginContext(5523, 31, false);
#line 113 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                           Write(idea.UsersWhoLikeThisIdea.Count);

#line default
#line hidden
                EndContext();
                BeginContext(5554, 38, true);
                WriteLiteral("</td>\n                            <td>");
                EndContext();
#line 114 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                                 if(idea.UserId == Model.LoggedUser.UserId)
                                {

#line default
#line hidden
                BeginContext(5670, 38, true);
                WriteLiteral("                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5708, "\"", 5739, 3);
                WriteAttributeValue("", 5715, "/ideas/", 5715, 7, true);
#line 116 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 5722, idea.IdeaId, 5722, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 5734, "/edit", 5734, 5, true);
                EndWriteAttribute();
                BeginContext(5740, 53, true);
                WriteLiteral("><button class=\"btn btn-primary\">Edit</button></a> <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5793, "\"", 5826, 3);
                WriteAttributeValue("", 5800, "/ideas/", 5800, 7, true);
#line 116 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 5807, idea.IdeaId, 5807, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 5819, "/delete", 5819, 7, true);
                EndWriteAttribute();
                BeginContext(5827, 52, true);
                WriteLiteral("><button class=\"btn btn-danger\">Delete</button></a>\n");
                EndContext();
#line 117 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                                }
                                else if(idea.UsersWhoLikeThisIdea.Any(r => r.UserId == Model.LoggedUser.UserId))
                                {

#line default
#line hidden
                BeginContext(6060, 38, true);
                WriteLiteral("                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 6098, "\"", 6131, 3);
                WriteAttributeValue("", 6105, "/ideas/", 6105, 7, true);
#line 120 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 6112, idea.IdeaId, 6112, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 6124, "/unlike", 6124, 7, true);
                EndWriteAttribute();
                BeginContext(6132, 55, true);
                WriteLiteral("><button class=\"btn btn-secondary\">Unlike</button></a>\n");
                EndContext();
#line 121 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                                }
                                else
                                {

#line default
#line hidden
                BeginContext(6292, 38, true);
                WriteLiteral("                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 6330, "\"", 6361, 3);
                WriteAttributeValue("", 6337, "/ideas/", 6337, 7, true);
#line 124 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 6344, idea.IdeaId, 6344, 12, false);

#line default
#line hidden
                WriteAttributeValue("", 6356, "/like", 6356, 5, true);
                EndWriteAttribute();
                BeginContext(6362, 51, true);
                WriteLiteral("><button class=\"btn btn-primary\">Like</button></a>\n");
                EndContext();
#line 125 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                                }

#line default
#line hidden
                BeginContext(6447, 64, true);
                WriteLiteral("                            </td>\n                        </tr>\n");
                EndContext();
#line 128 "/Users/petrafranklin/Coding_DoJo/c_sharp/Assignments/CSharp/Views/Home/Dashboard.cshtml"
                    }

#line default
#line hidden
                BeginContext(6533, 91, true);
                WriteLiteral("                </tbody>\n            </table>\n            </div>\n        </div>\n    </div>\n");
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
            BeginContext(6631, 8, true);
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
