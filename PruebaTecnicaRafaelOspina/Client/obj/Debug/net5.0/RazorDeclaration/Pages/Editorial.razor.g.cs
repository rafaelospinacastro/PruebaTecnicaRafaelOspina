// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Pages\Editorial.razor"
using PruebaDoubleV.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editorial")]
    public partial class Editorial : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\darkz\source\repos\Mainsoft\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Pages\Editorial.razor"
       
    private IEnumerable<EditorialDTO.EditorialResponse> forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<IEnumerable<EditorialDTO.EditorialResponse>>("Editorial");
    }
    protected async Task Borrar(int id)
    {
        await Http.DeleteAsync("Editorial/" + Convert.ToInt32(id));
        Navigate.NavigateTo("editorial", forceLoad: true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
