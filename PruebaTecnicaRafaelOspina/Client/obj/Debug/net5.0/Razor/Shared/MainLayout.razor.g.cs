#pragma checksum "C:\Users\darkz\source\repos\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e68e007cd4d631edf41be6b05b022a13382388ee"
// <auto-generated/>
#pragma warning disable 1591
namespace PruebaTecnicaRafaelOspina.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\darkz\source\repos\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\darkz\source\repos\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\darkz\source\repos\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\darkz\source\repos\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\darkz\source\repos\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\darkz\source\repos\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\darkz\source\repos\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\darkz\source\repos\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\darkz\source\repos\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using PruebaTecnicaRafaelOspina.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\darkz\source\repos\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\_Imports.razor"
using PruebaTecnicaRafaelOspina.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-52q51h31x4");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-52q51h31x4");
            __builder.OpenComponent<PruebaTecnicaRafaelOspina.Client.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-52q51h31x4");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-52q51h31x4");
#nullable restore
#line 12 "C:\Users\darkz\source\repos\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Shared\MainLayout.razor"
             if (loginState.IsLoggedIn.Equals(false))
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "<p b-52q51h31x4></p>");
#nullable restore
#line 15 "C:\Users\darkz\source\repos\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Shared\MainLayout.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "p");
            __builder.AddAttribute(16, "class", "ml-md-auto");
            __builder.AddAttribute(17, "b-52q51h31x4");
            __builder.AddContent(18, "Bienvenido ");
            __builder.AddContent(19, 
#nullable restore
#line 18 "C:\Users\darkz\source\repos\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Shared\MainLayout.razor"
                                                  loginState.username

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, "!");
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\darkz\source\repos\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Shared\MainLayout.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "content px-4");
            __builder.AddAttribute(24, "b-52q51h31x4");
            __builder.AddContent(25, 
#nullable restore
#line 23 "C:\Users\darkz\source\repos\PruebaTecnicaRafaelOspina\PruebaTecnicaRafaelOspina\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Class.AppUser loginState { get; set; }
    }
}
#pragma warning restore 1591
