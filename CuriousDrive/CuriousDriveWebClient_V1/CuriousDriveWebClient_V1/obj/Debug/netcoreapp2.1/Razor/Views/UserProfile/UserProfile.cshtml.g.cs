#pragma checksum "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\UserProfile\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c5710a1bb3f509929e55595d2f1199e21b58352"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserProfile_UserProfile), @"mvc.1.0.view", @"/Views/UserProfile/UserProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserProfile/UserProfile.cshtml", typeof(AspNetCore.Views_UserProfile_UserProfile))]
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
#line 1 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\UserProfile\UserProfile.cshtml"
using CuriousDriveWebClient;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c5710a1bb3f509929e55595d2f1199e21b58352", @"/Views/UserProfile/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_UserProfile_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CuriousDriveWebClient.UserProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("userProfileForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\UserProfile\UserProfile.cshtml"
  
    ViewBag.Title = @Model.displayName + " - User Profile";

#line default
#line hidden
            BeginContext(155, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\UserProfile\UserProfile.cshtml"
 using (Html.BeginForm("UserProfile", "UserProfile", FormMethod.Post, new { @class = "form-horizontal row card", role = "form" }))
{
    

#line default
#line hidden
            BeginContext(297, 23, false);
#line 11 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\UserProfile\UserProfile.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(324, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(328, 2136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e1aacbabdd1464e8bfc36cecdcf7a95", async() => {
                BeginContext(404, 390, true);
                WriteLiteral(@"

        <div class=""col-lg-12 col-12"">
            <br />
        </div>               

        <div class=""col-lg-12 col-12"">

            <div class=""col-lg-12"">
                <br />
            </div>

            <div class=""col-lg-12"">
                <span style=""font-weight:bolder;font-size:x-large"">News Feed</span>
                <hr />
            </div>

");
                EndContext();
#line 30 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\UserProfile\UserProfile.cshtml"
             foreach (NewsFeedViewModel newsFeed in Model.newsFeedsViewModel)
            {

#line default
#line hidden
                BeginContext(888, 125, true);
                WriteLiteral("                <div class=\"col-lg-12 hover_effect\">\r\n\r\n                    <div class=\"col-lg-12\">\r\n                        ");
                EndContext();
                BeginContext(1014, 70, false);
#line 35 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\UserProfile\UserProfile.cshtml"
                   Write(Html.PartialAsync("_ProfilePicture", newsFeed.profilePictureViewModel));

#line default
#line hidden
                EndContext();
                BeginContext(1173, 28, true);
                WriteLiteral("\r\n\r\n                        ");
                EndContext();
                BeginContext(1202, 124, false);
#line 37 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\UserProfile\UserProfile.cshtml"
                   Write(Html.ActionLink(newsFeed.userName, "Profile", "UserProfile",  new { id = newsFeed.userId, title = "" }, new { @class = "" }));

#line default
#line hidden
                EndContext();
                BeginContext(1326, 86, true);
                WriteLiteral("\r\n\r\n                    </div>\r\n\r\n                    <div class=\"col-lg-12 col-12\">\r\n");
                EndContext();
#line 42 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\UserProfile\UserProfile.cshtml"
                         if (newsFeed.postType == "QUES")
                        {
                            

#line default
#line hidden
                BeginContext(1527, 155, false);
#line 44 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\UserProfile\UserProfile.cshtml"
                       Write(Html.ActionLink(newsFeed.postTitle, "Question", "Question", new { id = newsFeed.postId, title = newsFeed.postTitleUrl }, new { @class = "bold-main-link" }));

#line default
#line hidden
                EndContext();
#line 44 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\UserProfile\UserProfile.cshtml"
                                                                                                                                                                                        
                        }
                        else if (newsFeed.postType == "ANNC")
                        {
                            

#line default
#line hidden
                BeginContext(1830, 237, false);
#line 48 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\UserProfile\UserProfile.cshtml"
                       Write(Html.ActionLink(newsFeed.postTitle, "Announcement", "Announcement",
                                                                         new { id = newsFeed.postId, title = newsFeed.postTitleUrl }, new { @class = "bold-main-link" }));

#line default
#line hidden
                EndContext();
#line 49 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\UserProfile\UserProfile.cshtml"
                                                                                                                                                                        
                        }

#line default
#line hidden
                BeginContext(2096, 124, true);
                WriteLiteral("                    </div>\r\n                    <div class=\"col-lg-12 col-12\">\r\n                        <span class=\"small\">");
                EndContext();
                BeginContext(2221, 24, false);
#line 53 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\UserProfile\UserProfile.cshtml"
                                       Write(newsFeed.createdDuration);

#line default
#line hidden
                EndContext();
                BeginContext(2245, 175, true);
                WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"col-lg-12 col-12\">\r\n                        <br />\r\n                    </div>\r\n\r\n                </div>\r\n");
                EndContext();
#line 60 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\UserProfile\UserProfile.cshtml"
            }

#line default
#line hidden
                BeginContext(2435, 22, true);
                WriteLiteral("        </div>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2464, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 64 "C:\Data\CuriousDrive\PrivateProjects\CuriousDrive\CuriousDriveWebClient_V1\CuriousDriveWebClient_V1\Views\UserProfile\UserProfile.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CuriousDriveWebClient.UserProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
