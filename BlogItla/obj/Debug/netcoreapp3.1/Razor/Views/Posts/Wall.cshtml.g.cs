#pragma checksum "C:\Users\heili\OneDrive\C# II\BlogItla\BlogItla\Views\Posts\Wall.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83c4aa7eeb847abac3579f34caa1ad2b7c88e56b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Wall), @"mvc.1.0.view", @"/Views/Posts/Wall.cshtml")]
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
#line 1 "C:\Users\heili\OneDrive\C# II\BlogItla\BlogItla\Views\_ViewImports.cshtml"
using BlogItla;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\heili\OneDrive\C# II\BlogItla\BlogItla\Views\_ViewImports.cshtml"
using BlogItla.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83c4aa7eeb847abac3579f34caa1ad2b7c88e56b", @"/Views/Posts/Wall.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae8eda17cc6c509842294f761af4545adfe4fb05", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Wall : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BlogItla.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\heili\OneDrive\C# II\BlogItla\BlogItla\Views\Posts\Wall.cshtml"
  
    ViewData["Title"] = "Wall";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-8 col-md-10 mx-auto\">\r\n");
#nullable restore
#line 9 "C:\Users\heili\OneDrive\C# II\BlogItla\BlogItla\Views\Posts\Wall.cshtml"
                 foreach (var post in Model)
                {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"post-preview\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 351, "\"", 358, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h2 class=\"post-title\">\r\n                                ");
#nullable restore
#line 15 "C:\Users\heili\OneDrive\C# II\BlogItla\BlogItla\Views\Posts\Wall.cshtml"
                           Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h2>\r\n                            <h3 class=\"post-subtitle\">\r\n                                ");
#nullable restore
#line 18 "C:\Users\heili\OneDrive\C# II\BlogItla\BlogItla\Views\Posts\Wall.cshtml"
                           Write(post.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h3>\r\n                        </a>\r\n                        <p class=\"post-meta\">\r\n                            Posted by ");
#nullable restore
#line 22 "C:\Users\heili\OneDrive\C# II\BlogItla\BlogItla\Views\Posts\Wall.cshtml"
                                 Write(post.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <a href=\"#\">Start Bootstrap</a>\r\n                            on ");
#nullable restore
#line 24 "C:\Users\heili\OneDrive\C# II\BlogItla\BlogItla\Views\Posts\Wall.cshtml"
                          Write(post.PostDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n");
#nullable restore
#line 27 "C:\Users\heili\OneDrive\C# II\BlogItla\BlogItla\Views\Posts\Wall.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <hr>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BlogItla.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
