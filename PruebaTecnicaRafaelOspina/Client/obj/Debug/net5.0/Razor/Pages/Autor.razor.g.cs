#pragma checksum "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Pages\Autor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09a8bf6f582e3e0e2c51aed231dff1ad7ef3fff4"
// <auto-generated/>
#pragma warning disable 1591
namespace PruebaTecnicaRafaelOspina.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using PruebaTecnicaRafaelOspina.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using PruebaTecnicaRafaelOspina.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Pages\Autor.razor"
using PruebaDoubleV.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/autor")]
    public partial class Autor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Autor</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Listado de Autores cargadas</p>");
#nullable restore
#line 9 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Pages\Autor.razor"
 if (forecasts == null)
{


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Cargando...</em></p>");
#nullable restore
#line 13 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Pages\Autor.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(3);
            __builder.AddAttribute(4, "class", "nav-link");
            __builder.AddAttribute(5, "href", "CrearAutor");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "<span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Nuevo Autor\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.AddMarkupContent(11, "<thead><tr><th>Nombres</th>\r\n                <th>Apellidos</th>\r\n                <th hidden>ID</th>\r\n                <th>Acciones</th></tr></thead>\r\n        ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 29 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Pages\Autor.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 32 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Pages\Autor.razor"
                         forecast.Nombres

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 33 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Pages\Autor.razor"
                         forecast.Apellidos

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddAttribute(21, "hidden");
            __builder.AddContent(22, 
#nullable restore
#line 34 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Pages\Autor.razor"
                                forecast.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(25);
            __builder.AddAttribute(26, "class", "nav-link");
            __builder.AddAttribute(27, "href", "CrearPersona");
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(29, "<span class=\"oi oi-pencil\" aria-hidden=\"true\"></span> Editar\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Pages\Autor.razor"
                                                            ()=>Borrar(forecast.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "<span class=\"oi oi-trash\" aria-hidden=\"true\"></span> Borrar\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Pages\Autor.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Pages\Autor.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Pages\Autor.razor"
       
    private IEnumerable<AutorDTO.AutorResponse> forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<IEnumerable<AutorDTO.AutorResponse>>("Autor");
    }
    protected async Task Borrar(int id)
    {
        await Http.DeleteAsync("Autor/" + Convert.ToInt32(id));
        Navigate.NavigateTo("autor", forceLoad: true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
