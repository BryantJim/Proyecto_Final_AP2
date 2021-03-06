// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Purchase_Sale_Project.Blazor.Pages.Registros
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Brian\Source\Repos\Proyecto_Final_AP2\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Brian\Source\Repos\Proyecto_Final_AP2\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Brian\Source\Repos\Proyecto_Final_AP2\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Brian\Source\Repos\Proyecto_Final_AP2\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Brian\Source\Repos\Proyecto_Final_AP2\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Brian\Source\Repos\Proyecto_Final_AP2\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Brian\Source\Repos\Proyecto_Final_AP2\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Brian\Source\Repos\Proyecto_Final_AP2\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Brian\Source\Repos\Proyecto_Final_AP2\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\_Imports.razor"
using Purchase_Sale_Project.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Brian\Source\Repos\Proyecto_Final_AP2\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\_Imports.razor"
using Purchase_Sale_Project.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Brian\Source\Repos\Proyecto_Final_AP2\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Brian\Source\Repos\Proyecto_Final_AP2\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Brian\Source\Repos\Proyecto_Final_AP2\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Brian\Source\Repos\Proyecto_Final_AP2\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\Pages\Registros\R_Clientes.razor"
using BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/clientes")]
    public partial class R_Clientes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Users\Brian\Source\Repos\Proyecto_Final_AP2\Purchase_Sale_Project\Purchase_Sale_Project\Purchase_Sale_Project.Blazor\Pages\Registros\R_Clientes.razor"
 
    [Inject]
    public ClientesBLL clienteBLL { get; set; }

    Clientes cliente = new Clientes();
    string Id;

    protected override void OnInitialized()
    {
        Nuevo();
        Id = Authentication.GetAuthenticationStateAsync().Result.User.getUserId();
    }

    public void Nuevo()
    {
        cliente = new Clientes();
        cliente.FechaNacimiento = DateTime.Now;
    }

    public async Task Guardar()
    {
        bool guardado;

        cliente.UsuarioId = Convert.ToInt32(Id);
        guardado = await clienteBLL.Guardar(cliente);

        if (guardado)
        {
            Nuevo();
            Toast.ShowSuccess("Guardado correctamente");
        }
        else
            Toast.ShowError("No fue posible guardar");
    }

    public async Task Buscar()
    {
        var Cliente = await clienteBLL.Buscar(cliente.ClienteId);

        if (Cliente != null)
            cliente = Cliente;
        else
        {
            Toast.ShowError("El cliente no existe");
            Nuevo();
        }
    }

    public async Task Eliminar()
    {
        bool Eliminar;

        Eliminar = await clienteBLL.Eliminar(cliente.ClienteId);

        if (Eliminar)
        {
            Nuevo();
            Toast.ShowSuccess("Eliminado correctamente");
        }
        else
            Toast.ShowError("No fue posible eliminar");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService Toast { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider Authentication { get; set; }
    }
}
#pragma warning restore 1591
