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
#line 1 "C:\Users\darkz\Source\Repos\rafaelospinacastro\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\darkz\Source\Repos\rafaelospinacastro\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\darkz\Source\Repos\rafaelospinacastro\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\darkz\Source\Repos\rafaelospinacastro\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\darkz\Source\Repos\rafaelospinacastro\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\darkz\Source\Repos\rafaelospinacastro\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\darkz\Source\Repos\rafaelospinacastro\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\darkz\Source\Repos\rafaelospinacastro\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\darkz\Source\Repos\rafaelospinacastro\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using PruebaTecnicaRafaelOspina.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\darkz\Source\Repos\rafaelospinacastro\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using PruebaTecnicaRafaelOspina.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\darkz\Source\Repos\rafaelospinacastro\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Pages\CrearPersona.razor"
using PruebaDoubleV.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CrearPersona")]
    public partial class CrearPersona : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\darkz\Source\Repos\rafaelospinacastro\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Pages\CrearPersona.razor"
      

    [Inject] HttpClient Http { get; set; }
    public PersonaDTO.CrearPersona persona = new PersonaDTO.CrearPersona();
    public string mensaje = "";
    private async Task Grabar()
    {
        mensaje = "Se guardo el registro con exito";
        var devol = await Http.PostAsJsonAsync("Personas", persona);
        if(devol.IsSuccessStatusCode)
        {
            mensaje = "Se guardo el registro con exito";
        }
        else
        {
            mensaje = "Hubo un problema al guardar";
        }
    }

    protected async override void OnParametersSet()
    {

    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
