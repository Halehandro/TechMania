#pragma checksum "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd2a4e5afdb54ca9ce540dac1b8f393cbfdfee1d"
// <auto-generated/>
#pragma warning disable 1591
namespace TechMania_Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\_Imports.razor"
using TechMania_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\_Imports.razor"
using TechMania_Client.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\_Imports.razor"
using TechMania_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\_Imports.razor"
using TechMania_Client.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\_Imports.razor"
using TechMania_Client.Service.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\_Imports.razor"
using Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\_Imports.razor"
using TechMania_Client.Model.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<TechMania_Client.Shared.NavMenu>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n\r\n");
            __builder.OpenElement(2, "main");
            __builder.AddAttribute(3, "id", "main");
            __builder.AddAttribute(4, "b-8hmt6hzawr");
            __builder.AddContent(5, 
#nullable restore
#line 9 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Client\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenComponent<TechMania_Client.Shared.Footer>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.AddMarkupContent(9, "<a href=\"#\" class=\"back-to-top d-flex align-items-center justify-content-center\" b-8hmt6hzawr><i class=\"bi bi-arrow-up-short\" b-8hmt6hzawr></i></a>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591