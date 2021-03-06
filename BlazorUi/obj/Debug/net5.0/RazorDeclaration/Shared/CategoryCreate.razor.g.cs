// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorUi.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using BlazorUi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using BlazorUi.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using Core.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using Core.Dtos.UserDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using Core.Dtos.ColorDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using Core.Dtos.OfferDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using Core.Dtos.BrandDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using Core.Dtos.UsageStatus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using Core.Dtos.ProductDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using BlazorUi.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/Shared/CategoryCreate.razor"
using Core.Dtos.CategoryDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/Shared/CategoryCreate.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    public partial class CategoryCreate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/Shared/CategoryCreate.razor"
       
    public PostCategoryDto category = new();

    public void Submit()
    {
        var client = ClientFactory.CreateClient();

        var result = client.PostAsJsonAsync($"https://localhost:5001/api/category", category);
        if (result.IsFaulted)
        {
            navigation.NavigateTo($"home");
        }
        else
        {
            navigation.NavigateTo($"categoryList");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
#pragma warning restore 1591
