#pragma checksum "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e1a3aead452ea3b834ebf5f7a0d42cabefaef6d"
// <auto-generated/>
#pragma warning disable 1591
namespace TechMania_Server.Pages.SmartPhoneOrder
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using TechMania_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using TechMania_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using TechMania_Server.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using TechMania_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
using Common;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/smartphone-order/details/{Id:int}")]
    public partial class SmartPhoneOrderManagement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "mt-4 px-md-1 mx-md-1");
#nullable restore
#line 10 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
     if (IsLoading)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<div class=\"spinner\"></div>");
#nullable restore
#line 13 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row p-2 my-3 bg-dark");
            __builder.AddAttribute(5, "style", "border-radius:20px; ");
            __builder.AddMarkupContent(6, "<div class=\"col-6 pt-2 pl-4 text-info\"><h2>Order Details : </h2></div>\r\n            ");
            __builder.AddMarkupContent(7, "<div class=\"col-6 pt-2 col-md-3 offset-md-3\"><a href=\"/smartphone-order\" class=\"btn btn-info form-control\">Back to Orders</a></div>\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-12 col-lg-8 p-4");
            __builder.AddMarkupContent(10, "<div class=\"row px-2 text-success border-bottom\"><div class=\"col-8 py-1\"><p style=\"font-size:x-large;margin:0px;\">Selected SmartPhone</p></div></div>\r\n\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-7");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "id");
            __builder.AddAttribute(17, "class", "carousel slide mb-4 m-md-3 m-0 pt-3 pt-md-0");
            __builder.AddAttribute(18, "data-ride", "carousel");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "id", "carouselExampleIndicators");
            __builder.AddAttribute(21, "class", "carousel slide");
            __builder.AddAttribute(22, "data-ride", "carousel");
            __builder.OpenElement(23, "ol");
            __builder.AddAttribute(24, "class", "carousel-indicators");
#nullable restore
#line 34 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                       int imageIndex = 0;
                                        int innerImageIndex = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                     foreach (var image in SmartPhoneOrdering.SmartPhoneDTO.SmartPhoneImages)
                                    {
                                        if (imageIndex == 0)
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "data-target", "#carouselExampleIndicators");
            __builder.AddAttribute(27, "data-slide-to", 
#nullable restore
#line 40 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                                                                                         imageIndex

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "class", "active");
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
 }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "li");
            __builder.AddAttribute(30, "data-target", "#carouselExampleIndicators");
            __builder.AddAttribute(31, "data-slide-to", 
#nullable restore
#line 44 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                                                                                         imageIndex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
}
                                        imageIndex++;
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                                ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "carousel-inner");
#nullable restore
#line 50 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                     foreach (var image in SmartPhoneOrdering.SmartPhoneDTO.SmartPhoneImages)
                                    {
                                        var domain = config["ServerUrl"];
                                        var imageUrl = domain + image.PhoneImageUrl;

                                        if (innerImageIndex == 0)
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "carousel-item active");
            __builder.OpenElement(37, "img");
            __builder.AddAttribute(38, "class", "d-block w-100");
            __builder.AddAttribute(39, "style", "border-radius:20px;");
            __builder.AddAttribute(40, "src", 
#nullable restore
#line 58 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                                                                                             imageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(41, "alt", "First slide");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                                   }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "carousel-item");
            __builder.OpenElement(44, "img");
            __builder.AddAttribute(45, "class", "d-block w-100");
            __builder.AddAttribute(46, "style", "border-radius:20px;");
            __builder.AddAttribute(47, "src", 
#nullable restore
#line 63 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                                                                                             imageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(48, "alt", "First slide");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                                  }

                                        innerImageIndex++;
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                                ");
            __builder.AddMarkupContent(50, @"<a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev""><span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                                    <span class=""sr-only"">Previous</span></a>
                                ");
            __builder.AddMarkupContent(51, "<a class=\"carousel-control-next\" href=\"#carouselExampleIndicators\" role=\"button\" data-slide=\"next\"><span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\r\n                                    <span class=\"sr-only\">Next</span></a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "col-5");
            __builder.OpenElement(55, "span");
            __builder.AddAttribute(56, "class", "float-right pt-4 text-white-50");
            __builder.OpenElement(57, "span");
            __builder.AddAttribute(58, "class", "float-right");
            __builder.AddContent(59, "SmartPhone manufacturer: ");
            __builder.AddContent(60, 
#nullable restore
#line 82 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                                                                SmartPhoneOrdering.SmartPhoneDTO.Manufacturer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "<br>\r\n                            ");
            __builder.OpenElement(62, "span");
            __builder.AddAttribute(63, "class", "float-right pt-1");
            __builder.AddContent(64, "SmartPhone details : ");
            __builder.AddContent(65, 
#nullable restore
#line 83 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                                                                 SmartPhoneOrdering.SmartPhoneDTO.Details

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "<br>\r\n                            ");
            __builder.OpenElement(67, "h4");
            __builder.AddAttribute(68, "class", "text-warning font-weight-bold pt-5 float-right");
            __builder.AddMarkupContent(69, "\r\n                                USD\r\n                                ");
            __builder.OpenElement(70, "span");
            __builder.AddAttribute(71, "style", "border-bottom:1px solid #ff6a00");
            __builder.AddContent(72, 
#nullable restore
#line 87 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                     SmartPhoneOrdering.TotalCost.ToString("#,#.00#;(#,#.00#)")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "row p-2");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "col-12");
            __builder.OpenElement(78, "p");
            __builder.AddAttribute(79, "class", "card-title text-warning");
            __builder.AddAttribute(80, "style", "font-size:xx-large");
            __builder.AddContent(81, 
#nullable restore
#line 96 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                                                                       SmartPhoneOrdering.SmartPhoneDTO.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                        ");
            __builder.OpenElement(83, "p");
            __builder.AddAttribute(84, "class", "card-text");
            __builder.AddAttribute(85, "style", "font-size:large");
            __builder.AddContent(86, 
#nullable restore
#line 98 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                              (MarkupString)@SmartPhoneOrdering.SmartPhoneDTO.Details

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "row p-2");
#nullable restore
#line 104 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                     if (SmartPhoneOrdering.Status == SD.Status_Ordered || SmartPhoneOrdering.Status == SD.Status_Pending)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "col-3");
            __builder.OpenElement(92, "button");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 107 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                              CancelOrder

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "class", "btn btn-danger form-control");
            __builder.AddContent(95, "Cancel Order");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 109 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n\r\n            ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "col-12 col-lg-4 p-4 2 mt-4 mt-md-0");
            __builder.AddMarkupContent(99, "<div class=\"row px-2 text-success border-bottom\"><div class=\"col-7 py-1\"><p style=\"font-size:x-large;margin:0px;\">Enter Details</p></div></div>\r\n                ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "form-group pt-2");
            __builder.AddMarkupContent(102, "<label class=\"text-warning\">Order Status</label>\r\n                    ");
            __builder.OpenElement(103, "input");
            __builder.AddAttribute(104, "type", "text");
            __builder.AddAttribute(105, "disabled");
            __builder.AddAttribute(106, "class", "form-control");
            __builder.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 118 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                        SmartPhoneOrdering.Status

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SmartPhoneOrdering.Status = __value, SmartPhoneOrdering.Status));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                ");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "form-group pt-2");
            __builder.AddMarkupContent(112, "<label class=\"text-warning\">Name</label>\r\n                    ");
            __builder.OpenElement(113, "input");
            __builder.AddAttribute(114, "type", "text");
            __builder.AddAttribute(115, "disabled");
            __builder.AddAttribute(116, "class", "form-control");
            __builder.AddAttribute(117, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 122 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                        SmartPhoneOrdering.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SmartPhoneOrdering.Name = __value, SmartPhoneOrdering.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "form-group pt-2");
            __builder.AddMarkupContent(122, "<label class=\"text-warning\">Phone</label>\r\n                    ");
            __builder.OpenElement(123, "input");
            __builder.AddAttribute(124, "type", "text");
            __builder.AddAttribute(125, "disabled");
            __builder.AddAttribute(126, "class", "form-control");
            __builder.AddAttribute(127, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 126 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                        SmartPhoneOrdering.Phone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(128, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SmartPhoneOrdering.Phone = __value, SmartPhoneOrdering.Phone));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "form-group");
            __builder.AddMarkupContent(132, "<label class=\"text-warning\">Email</label>\r\n                    ");
            __builder.OpenElement(133, "input");
            __builder.AddAttribute(134, "type", "email");
            __builder.AddAttribute(135, "disabled");
            __builder.AddAttribute(136, "class", "form-control");
            __builder.AddAttribute(137, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 130 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                        SmartPhoneOrdering.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(138, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SmartPhoneOrdering.Email = __value, SmartPhoneOrdering.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 133 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                 if (SmartPhoneOrdering.Status == SD.Status_OrderConfirmed)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "class", "form-group");
            __builder.AddMarkupContent(141, "<label class=\"text-warning\">Order date</label>\r\n                        ");
            __builder.OpenElement(142, "input");
            __builder.AddAttribute(143, "type", "text");
            __builder.AddAttribute(144, "disabled");
            __builder.AddAttribute(145, "value", 
#nullable restore
#line 137 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                                            SmartPhoneOrdering.CheckInDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(146, "class", "form-control");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 139 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "form-group");
#nullable restore
#line 143 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                     if (SmartPhoneOrdering.Status == SD.Status_Pending)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(149, "button");
            __builder.AddAttribute(150, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 145 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                          ConfirmOrder

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(151, "class", "btn btn-success");
            __builder.AddContent(152, "Confirm Order");
            __builder.CloseElement();
#nullable restore
#line 146 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                     if (SmartPhoneOrdering.Status == SD.Status_Ordered)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(153, "button");
            __builder.AddAttribute(154, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 150 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                                          ConfirmOrderSent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(155, "class", "btn btn-success");
            __builder.AddContent(156, "Ship order");
            __builder.CloseElement();
#nullable restore
#line 151 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 153 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                     if (SmartPhoneOrdering.Status == SD.Status_Order_Completed)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(157, "<button disabled class=\"btn btn-primary\">Order is completed</button>");
#nullable restore
#line 156 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                     if (SmartPhoneOrdering.Status == SD.Status_NoShow || SmartPhoneOrdering.Status == SD.Status_Cancelled)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(158, "<button disabled class=\"btn btn-primary\">Order is canceled</button>");
#nullable restore
#line 161 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 167 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 175 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhoneOrder\SmartPhoneOrderManagement.razor"
       
    [Parameter]
    public int Id { get; set; }

    private SmartPhoneOrderDetailDTO SmartPhoneOrdering { get; set; } = new SmartPhoneOrderDetailDTO() { SmartPhoneDTO = new SmartPhoneDTO() };
    private bool IsLoading { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        IsLoading = true;
        if (Id != 0)
        {
            SmartPhoneOrdering = await smartPhoneDetailsRepository.GetSmartphoneOrderDetail(Id);
        }
        else
        {
            //error
        }
        IsLoading = false;

    }

    private async Task ConfirmOrder()
    {
        await smartPhoneDetailsRepository.UpdateOrderStatus(SmartPhoneOrdering.Id, SD.Status_Ordered);
        SmartPhoneOrdering = await smartPhoneDetailsRepository.GetSmartphoneOrderDetail(Id);
        await jsRuntime.ToastrSuccess("Order is succesfully ordered");
    }

    private async Task ConfirmOrderSent()
    {
        await smartPhoneDetailsRepository.UpdateOrderStatus(SmartPhoneOrdering.Id, SD.Status_Order_Completed);
        SmartPhoneOrdering = await smartPhoneDetailsRepository.GetSmartphoneOrderDetail(Id);
        await jsRuntime.ToastrSuccess("Order is succesfully sent");
    }

    private async Task CancelOrder()
    {
        await smartPhoneDetailsRepository.UpdateOrderStatus(SmartPhoneOrdering.Id, SD.Status_Cancelled);
        SmartPhoneOrdering = await smartPhoneDetailsRepository.GetSmartphoneOrderDetail(Id);
        await jsRuntime.ToastrSuccess("Order has been canceled");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISmartPhoneOrderDetailRepository smartPhoneDetailsRepository { get; set; }
    }
}
#pragma warning restore 1591