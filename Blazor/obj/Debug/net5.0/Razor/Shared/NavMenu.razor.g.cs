#pragma checksum "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0ea9f7702a9549480861eab34341d9356987c31"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/_Imports.razor"
using Core.Dtos.CategoryDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/_Imports.razor"
using Core.Dtos.ProductDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-32xpj7b96w");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-32xpj7b96w>Blazor</a>\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/Shared/NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-32xpj7b96w");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-32xpj7b96w></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/Shared/NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/Shared/NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-32xpj7b96w");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-32xpj7b96w");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-32xpj7b96w");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/Shared/NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-32xpj7b96w></span> Home\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddAttribute(29, "b-32xpj7b96w");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "counter");
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-32xpj7b96w></span> Counter\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n        ");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "nav-item px-3");
            __builder.AddAttribute(38, "b-32xpj7b96w");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
            __builder.AddAttribute(40, "class", "nav-link");
            __builder.AddAttribute(41, "href", "fetchdata");
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-32xpj7b96w></span> Fetch data\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n\n");
            __builder.AddMarkupContent(45, @"<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" b-32xpj7b96w><ol class=""carousel-indicators"" b-32xpj7b96w><li data-target=""#myCarousel"" data-slide-to=""0"" class=""active"" b-32xpj7b96w></li>
        <li data-target=""#myCarousel"" data-slide-to=""1"" b-32xpj7b96w></li>
        <li data-target=""#myCarousel"" data-slide-to=""2"" b-32xpj7b96w></li></ol>

    
    <div class=""carousel-inner"" b-32xpj7b96w><div class=""item active"" b-32xpj7b96w><img src=""la.jpg"" alt=""Los Angeles"" style=""width:100%;"" b-32xpj7b96w></div>

        <div class=""item"" b-32xpj7b96w><img src=""chicago.jpg"" alt=""Chicago"" style=""width:100%;"" b-32xpj7b96w></div>

        <div class=""item"" b-32xpj7b96w><img src=""ny.jpg"" alt=""New york"" style=""width:100%;"" b-32xpj7b96w></div></div>

    
    <a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"" b-32xpj7b96w><span class=""glyphicon glyphicon-chevron-left"" b-32xpj7b96w></span>
        <span class=""sr-only"" b-32xpj7b96w>Previous</span></a>
    <a class=""right carousel-control"" href=""#myCarousel"" data-slide=""next"" b-32xpj7b96w><span class=""glyphicon glyphicon-chevron-right"" b-32xpj7b96w></span>
        <span class=""sr-only"" b-32xpj7b96w>Next</span></a></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/Shared/NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
