#pragma checksum "C:\Users\DELL\Documents\GitHub\TodoApp\TodoApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3e8ed8c037ddaab8eff44815b24d050c6b2d225"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TodoApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace TodoApp.Pages
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
#line 1 "C:\Users\DELL\Documents\GitHub\TodoApp\TodoApp\Pages\_ViewImports.cshtml"
using TodoApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3e8ed8c037ddaab8eff44815b24d050c6b2d225", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f0c28a7de30b78359da2dc7dcb28459e72867c0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\DELL\Documents\GitHub\TodoApp\TodoApp\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n</div>\r\n");
            WriteLiteral("<div><h2>Tasks on going:</h2></div>\r\n<section>\r\n");
#nullable restore
#line 23 "C:\Users\DELL\Documents\GitHub\TodoApp\TodoApp\Pages\Index.cshtml"
     foreach (var todo in Model.TodoList)
    {
        if (todo.IsDone==false)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"todoList\">\r\n\r\n        <h2>");
#nullable restore
#line 30 "C:\Users\DELL\Documents\GitHub\TodoApp\TodoApp\Pages\Index.cshtml"
       Write(todo.TodoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <p>");
#nullable restore
#line 31 "C:\Users\DELL\Documents\GitHub\TodoApp\TodoApp\Pages\Index.cshtml"
      Write(todo.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 32 "C:\Users\DELL\Documents\GitHub\TodoApp\TodoApp\Pages\Index.cshtml"
      Write(todo.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>-</p>\r\n        <p>");
#nullable restore
#line 34 "C:\Users\DELL\Documents\GitHub\TodoApp\TodoApp\Pages\Index.cshtml"
      Write(todo.FinshDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <br />\r\n\r\n    </section>\r\n");
#nullable restore
#line 38 "C:\Users\DELL\Documents\GitHub\TodoApp\TodoApp\Pages\Index.cshtml"
        }

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
