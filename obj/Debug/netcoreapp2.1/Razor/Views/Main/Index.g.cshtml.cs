#pragma checksum "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_projects\DojoSurveyWithModel\Views\Main\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b89eb31adb4f35ed5924fbc0a6978184e5413bfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Index), @"mvc.1.0.view", @"/Views/Main/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Index.cshtml", typeof(AspNetCore.Views_Main_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b89eb31adb4f35ed5924fbc0a6978184e5413bfb", @"/Views/Main/Index.cshtml")]
    public class Views_Main_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2504, true);
            WriteLiteral(@"<div class=""row justify-content-center"">
    <div class=""col-lg-8 border border-dark rounded justify-content-center m-4"">
        <form class=""m-3"" action=""/survey"" method=""post"">
            <div class=""form-row"">
                <div class=""col-lg-6 ml-5"">
                    <label for=""name""><h5>Your Name:</h5></label>
                </div>
                <div class=""col-4 justify-content-end"">
                    <input type=""text"" class=""form-control"" id=""name"" name=""name"">
                </div>
            </div>
            <div class=""form-row"">
                <div class=""col-lg-6 ml-5"">
                    <label for=""location""><h5>Dojo Location:</h5></label>
                </div>
                <div class=""col-4"">
                    <select class=""custom-select"" id=""location"" name=""location"">
                        <option selected>San Jose</option>
                        <option value=""McClean"">McLean</option>
                        <option value=""Dallas"">Dallas</optio");
            WriteLiteral(@"n>
                        <option value=""Seattle"">Seattle</option>
                    </select>
                </div>
            </div>
            <div class=""form-row"">
                <div class=""col-lg-6 ml-5"">
                    <label for=""language""><h5>Favorite Language:</h5></label>
                </div>
                <div class=""col-4"">
                    <select class=""custom-select"" id=""langauge"" name=""language"">
                        <option selected>Python</option>
                        <option value=""C#"">C#</option>
                        <option value=""MEAN"">MEAN</option>
                        <option value=""SWIFT"">Swift</option>
                    </select>
                </div>
            </div>
            <div class=""form-row"">
                <div class=""col-lg-10 ml-5"">
                    <label for=""comment""><h5>Comment (Optional):</h5></label>
                </div>
            </div>
            <div class=""form-row"">
                <div cla");
            WriteLiteral(@"ss=""col-lg-10 ml-5 align-self-start"">
                    <textarea class=""w-100"" id=""comment"" name=""comment"" rows=""3""></textarea>
                </div>
            </div>
            <div class=""form-row justify-content-end"">
                <div class=""col-lg-3"">
                    <button type=""submit"" class=""btn btn-primary text-right pl-4 pr-4"">Submit</button>
                </div>
            </div>
        </form>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591