#pragma checksum "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "147bb7bba3edd9c6fbdd5fb4741d2711a5a692e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_SingleRoom), @"mvc.1.0.view", @"/Views/Room/SingleRoom.cshtml")]
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
#line 1 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\_ViewImports.cshtml"
using HotelService.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\_ViewImports.cshtml"
using HotelService.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\_ViewImports.cshtml"
using HotelService.Web.ViewModels.Rooms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\_ViewImports.cshtml"
using HotelService.Web.ViewModels.Home;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147bb7bba3edd9c6fbdd5fb4741d2711a5a692e9", @"/Views/Room/SingleRoom.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8518155818b3f0aa4751c69edf4895f958edabca", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_SingleRoom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SingleRoomViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AlertPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-success text-white mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddGuest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-dark text-white mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
  
    this.ViewData["Title"] = @Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
 if (this.TempData.ContainsKey("Message"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "147bb7bba3edd9c6fbdd5fb4741d2711a5a692e95888", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
  
    var userId = this.User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-info text-monospace mt-3 ml-5\">");
#nullable restore
#line 15 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
                                          Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<hr />

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-6"">
            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-interval=""false"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">
");
#nullable restore
#line 23 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
                     for (var i = 1; i <= this.Model.Images.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 25 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" ");
#nullable restore
#line 25 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
                                                                                    Write(i == 1 ? "class='active'" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("></li>\r\n");
#nullable restore
#line 26 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ol>\r\n                <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 29 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
                       var counter = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
                     foreach (var image in Model.Images)
                    {
                        var id = image.Id;
                        var extension = image.Extension;

                        var imageUrl = "/images/rooms/" + id + "." + extension;


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 1264, "\"", 1321, 2);
            WriteAttributeValue("", 1272, "carousel-", 1272, 9, true);
#nullable restore
#line 37 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
WriteAttributeValue("", 1281, counter == 1 ? "item active" : "item", 1281, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1357, "\"", 1372, 1);
#nullable restore
#line 38 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
WriteAttributeValue("", 1363, imageUrl, 1363, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\" alt=\"...\" style=\"height: 500px;\">\r\n                        </div>\r\n");
#nullable restore
#line 40 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"

                        counter++;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
        </div>

        <div class=""col-md-6"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <h1>");
#nullable restore
#line 58 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <span class=\"category\">Location: ");
#nullable restore
#line 64 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
                                                Write(Model.LocationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <p class=\"category\">Type: ");
#nullable restore
#line 70 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
                                         Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <span class=\"timestamp\">");
#nullable restore
#line 76 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n\r\n            <hr />\r\n\r\n");
#nullable restore
#line 82 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
             if (Model.SettleAsString != "01.01.0001 00:00")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-md-12\">\r\n                        <p class=\"description\">Settle: ");
#nullable restore
#line 86 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
                                                  Write(Model.SettleAsString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-md-12\">\r\n                        <p class=\"description\">Leave: ");
#nullable restore
#line 92 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
                                                 Write(Model.LeavingAsString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 95 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 97 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
              
                var status = string.Empty;
                var activeOrNo = string.Empty;
                if (this.Model.IsFree == true)
                {
                    status = "Free";
                    activeOrNo = "text-success";
                }
                else
                {
                    status = "Taken";
                    activeOrNo = "text-danger";
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <p class=\"description\">Status: <span");
            BeginWriteAttribute("class", " class=\"", 4046, "\"", 4065, 1);
#nullable restore
#line 114 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
WriteAttributeValue("", 4054, activeOrNo, 4054, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 114 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
                                                                        Write(status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                </div>\r\n            </div>\r\n\r\n            <ul class=\"list-group\">\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Price - </span>$");
#nullable restore
#line 119 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
                                                                                      Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n\r\n            <hr />\r\n\r\n");
#nullable restore
#line 124 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
              
                if (Model.UserId == userId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "147bb7bba3edd9c6fbdd5fb4741d2711a5a692e918030", async() => {
                WriteLiteral("Add Guest");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-roomId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 128 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
                                                                                                         WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-roomId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "147bb7bba3edd9c6fbdd5fb4741d2711a5a692e920394", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-roomId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 129 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
                                                                                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-roomId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roomId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 131 "C:\Users\Goshicha\Desktop\gitFolder\Hotel-service\Web\HotelService.Web\Views\Room\SingleRoom.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SingleRoomViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
