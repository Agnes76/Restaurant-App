#pragma checksum "C:\Users\hp\Documents\Projecct\RestaurantApp\Restaurant\Restaurant.API\Views\OrderDetails\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c91f4db7c018a57dacd6e2f18db24e18703806b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderDetails_Create), @"mvc.1.0.view", @"/Views/OrderDetails/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c91f4db7c018a57dacd6e2f18db24e18703806b", @"/Views/OrderDetails/Create.cshtml")]
    public class Views_OrderDetails_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurant.API.Models.OrderDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hp\Documents\Projecct\RestaurantApp\Restaurant\Restaurant.API\Views\OrderDetails\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>OrderDetail</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""OrderMasterId"" class=""control-label""></label>
                <select asp-for=""OrderMasterId"" class =""form-control"" asp-items=""ViewBag.OrderMasterId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""FoodItemid"" class=""control-label""></label>
                <select asp-for=""FoodItemid"" class =""form-control"" asp-items=""ViewBag.FoodItemid""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""FoodItemPrice"" class=""control-label""></label>
                <input asp-for=""FoodItemPrice"" class=""form-control"" />
                <span asp-validation-for=""FoodItemPrice"" class=""text-danger""></span>
            </div>
            <div cla");
            WriteLiteral(@"ss=""form-group"">
                <label asp-for=""Quantity"" class=""control-label""></label>
                <input asp-for=""Quantity"" class=""form-control"" />
                <span asp-validation-for=""Quantity"" class=""text-danger""></span>
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
#line 45 "C:\Users\hp\Documents\Projecct\RestaurantApp\Restaurant\Restaurant.API\Views\OrderDetails\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Restaurant.API.Models.OrderDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
