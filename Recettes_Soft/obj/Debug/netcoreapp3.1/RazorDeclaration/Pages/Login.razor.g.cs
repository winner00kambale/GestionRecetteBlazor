#pragma checksum "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38e612a53438b3530d856b9e011184bd8cd7c4ef"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Recettes_Soft.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\_Imports.razor"
using Recettes_Soft;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\_Imports.razor"
using Recettes_Soft.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\Login.razor"
 
    private Data.classes.Login model = new Data.classes.Login();
    private bool loading;
    private async void OnValidSubmit()
    {
        // reset alerts on submit
        //AlertService.Clear();

        //loading = true;
        //try
        //{
        //    await AccountService.Login(model);
        //    var returnUrl = NavigationManager.QueryString("returnUrl") ?? "";
        //    NavigationManager.NavigateTo(returnUrl);
        //}
        //catch (Exception ex)
        //{
        //    AlertService.Error(ex.Message);
        //    loading = false;
        //    StateHasChanged();
        //}
    }

    //void login()
    //{

    //    NavigationManager.NavigateTo("");
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
