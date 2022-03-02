#pragma checksum "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/Pages/ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da099cabd2bffbd6f1004d8c29ec8a0733f2b48f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorUi.Pages
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
#line 14 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/_Imports.razor"
using Core.Dtos.CategoryDto;

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/productlist")]
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ProductList</h3>");
#nullable restore
#line 8 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/Pages/ProductList.razor"
 if (productList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 11 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/Pages/ProductList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "type", "submit");
            __builder.AddAttribute(4, "class", "btn btn-success");
            __builder.AddAttribute(5, "value", "Urunlere git");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/Pages/ProductList.razor"
                                                                                  (()=> CreateProduct())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Urun Olustur");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n    ");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.AddMarkupContent(11, "<thead><tr><th>Name</th>\n                <th>Price</th>\n                <th>Sold Status</th>\n                <th></th></tr></thead>\n        ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 25 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/Pages/ProductList.razor"
             foreach (var product in productList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
#nullable restore
#line 28 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/Pages/ProductList.razor"
__builder.AddContent(15, product.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 29 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/Pages/ProductList.razor"
__builder.AddContent(18, product.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                    ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 30 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/Pages/ProductList.razor"
__builder.AddContent(21, product.IsSold);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                    ");
            __builder.OpenElement(23, "td");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btn btn-primary");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/Pages/ProductList.razor"
                                                                  (()=>ShowProduct(product.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Detay Gor");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/Pages/ProductList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/Pages/ProductList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "/Users/gozdecengiz/Downloads/WardrobeProject-main/BlazorUi/Pages/ProductList.razor"
       
    public List<ProductDto> productList;

    protected override async Task OnInitializedAsync()
    {
        var client = ClientFactory.CreateClient();
        var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44320/api/product/getall");
        var token = await Storage.GetAsync<string>("token");

        request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Value);

        var response = await client.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            productList = System.Text.Json.JsonSerializer.Deserialize<List<ProductDto>>(json);           
        }

    }

    void ShowProduct(int id)
    {
        navigation.NavigateTo($"product/{id}");
    }

    void CreateProduct()
    {
        navigation.NavigateTo("createProduct");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage Storage { get; set; }
    }
}
#pragma warning restore 1591
