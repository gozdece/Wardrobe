#pragma checksum "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55117be6ac6441c02153e480093c17390447ab89"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "py-5");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container px-4 px-lg-5 mt-5");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row gx-4 gx-lg-5 row-cols-2 row-cols-md-3 row-cols-xl-4 justify-content-center");
#nullable restore
#line 10 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/Pages/Index.razor"
                 foreach (var item in productList)
                {
                

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col mb-5");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card h-100");
            __builder.AddMarkupContent(10, "<div class=\"badge bg-dark text-white position-absolute\" style=\"top: 0.5rem; right: 0.5rem\">Sale</div>\n                        \n                        ");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "href", "/product/" + (
#nullable restore
#line 19 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/Pages/Index.razor"
                                           item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "<img class=\"card-img-top\" src=\"https://dummyimage.com/450x300/dee2e6/6c757d.jpg\" alt=\"...\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                            \n                            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-body p-4");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "text-center");
            __builder.OpenElement(19, "h5");
            __builder.AddAttribute(20, "class", "fw-bolder");
#nullable restore
#line 26 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/Pages/Index.razor"
__builder.AddContent(21, item.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                                    \n                                    ");
            __builder.AddMarkupContent(23, @"<div class=""d-flex justify-content-center small text-warning mb-2""><div class=""bi-star-fill""></div>
                                        <div class=""bi-star-fill""></div>
                                        <div class=""bi-star-fill""></div>
                                        <div class=""bi-star-fill""></div>
                                        <div class=""bi-star-fill""></div></div>
                                    
                                    ");
            __builder.OpenElement(24, "span");
            __builder.AddAttribute(25, "class", "text-muted text-decoration-line-through");
            __builder.AddContent(26, "$");
#nullable restore
#line 36 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/Pages/Index.razor"
__builder.AddContent(27, item.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                            \n                            ");
            __builder.AddMarkupContent(29, @"<div class=""card-footer p-4 pt-0 border-top-0 bg-transparent""><div class=""text-center""><a class=""btn btn-outline-dark mt-auto"" href=""#"">Teklif Ver</a></div>
                                <div class=""text-center""><a class=""btn btn-outline-dark mt-auto"" href=""#"">Satin Al</a></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/Pages/Index.razor"
               
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "/Users/gozdecengiz/Downloads/WardrobeProject-main/Blazor/Pages/Index.razor"
       
    public List<ProductDto> productList = new List<ProductDto>();

    protected override async Task OnInitializedAsync()
    {

        var url = "https://localhost:5001/api/Product/GetAll";

        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.GetAsync(url);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                productList = System.Text.Json.JsonSerializer.Deserialize<List<ProductDto>>(responseString,
                new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
        }


    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591