#pragma checksum "C:\Users\AnthonyB\source\End_Project\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cc10e450bc7f43ccfc816d1691ed48151168272"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "C:\Users\AnthonyB\source\End_Project\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AnthonyB\source\End_Project\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\Areas\Identity\Pages\_ViewImports.cshtml"
using Purchase_Sale_Project.Blazor.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AnthonyB\source\End_Project\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\Areas\Identity\Pages\_ViewImports.cshtml"
using Purchase_Sale_Project.Blazor.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AnthonyB\source\End_Project\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\Areas\Identity\Pages\_ViewImports.cshtml"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\AnthonyB\source\End_Project\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Purchase_Sale_Project.Blazor.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cc10e450bc7f43ccfc816d1691ed48151168272", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d9ab52af236f00187ae185f50274b39882b0c2c", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68d53ae3f7594a47f9becd6643b95a9c56de70d8", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\AnthonyB\source\End_Project\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Confirmación del registro";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\AnthonyB\source\End_Project\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 8 "C:\Users\AnthonyB\source\End_Project\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    <a id=\"confirm-link\"");
            BeginWriteAttribute("href", " href=\"", 216, "\"", 250, 1);
#nullable restore
#line 12 "C:\Users\AnthonyB\source\End_Project\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
WriteAttributeValue("", 223, Model.EmailConfirmationUrl, 223, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Click aqui debe confirmar su cuenta</a>\r\n</p>\r\n");
#nullable restore
#line 14 "C:\Users\AnthonyB\source\End_Project\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n        Please check your email to confirm your account.\r\n</p>\r\n");
#nullable restore
#line 20 "C:\Users\AnthonyB\source\End_Project\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
