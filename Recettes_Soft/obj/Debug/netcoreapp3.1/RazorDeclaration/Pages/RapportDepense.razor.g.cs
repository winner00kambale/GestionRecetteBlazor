#pragma checksum "E:\Mes documents\L1\C#\Recettes_Soft\Recettes_Soft\Pages\RapportDepense.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0308b4296cfbcd3cde6f40b11aab4b2de02b3114"
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
#line 1 "E:\Mes documents\L1\C#\Recettes_Soft\Recettes_Soft\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Mes documents\L1\C#\Recettes_Soft\Recettes_Soft\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Mes documents\L1\C#\Recettes_Soft\Recettes_Soft\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Mes documents\L1\C#\Recettes_Soft\Recettes_Soft\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Mes documents\L1\C#\Recettes_Soft\Recettes_Soft\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Mes documents\L1\C#\Recettes_Soft\Recettes_Soft\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Mes documents\L1\C#\Recettes_Soft\Recettes_Soft\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Mes documents\L1\C#\Recettes_Soft\Recettes_Soft\_Imports.razor"
using Recettes_Soft;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Mes documents\L1\C#\Recettes_Soft\Recettes_Soft\_Imports.razor"
using Recettes_Soft.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Mes documents\L1\C#\Recettes_Soft\Recettes_Soft\Pages\RapportDepense.razor"
using Recettes_Soft.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Mes documents\L1\C#\Recettes_Soft\Recettes_Soft\Pages\RapportDepense.razor"
using Recettes_Soft.Data.classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Mes documents\L1\C#\Recettes_Soft\Recettes_Soft\Pages\RapportDepense.razor"
using Recettes_Soft.Data.interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Rappot_depense")]
    public partial class RapportDepense : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "E:\Mes documents\L1\C#\Recettes_Soft\Recettes_Soft\Pages\RapportDepense.razor"
       
    IEnumerable<Depenses> depenses;
    protected override async Task OnInitializedAsync()
    {
        depenses = await DepenseService.GetRapportDepenses();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDepense_services DepenseService { get; set; }
    }
}
#pragma warning restore 1591
