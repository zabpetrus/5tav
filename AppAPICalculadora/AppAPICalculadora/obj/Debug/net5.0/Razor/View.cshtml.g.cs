#pragma checksum "D:\vstudio\BeHappy\BeHappy\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43951e92aac5791a2b36bdf3a40a63517bee20cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.View), @"mvc.1.0.view", @"/View.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43951e92aac5791a2b36bdf3a40a63517bee20cd", @"/View.cshtml")]
    public class View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BeHappy.Models.Duocalc>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\vstudio\BeHappy\BeHappy\View.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>View</h1>

<h4>Duocalc</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""View"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""fator1"" class=""control-label""></label>
                <input asp-for=""fator1"" class=""form-control"" />
                <span asp-validation-for=""fator1"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""fator2"" class=""control-label""></label>
                <input asp-for=""fator2"" class=""form-control"" />
                <span asp-validation-for=""fator2"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 37 "D:\vstudio\BeHappy\BeHappy\View.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BeHappy.Models.Duocalc> Html { get; private set; }
    }
}
#pragma warning restore 1591