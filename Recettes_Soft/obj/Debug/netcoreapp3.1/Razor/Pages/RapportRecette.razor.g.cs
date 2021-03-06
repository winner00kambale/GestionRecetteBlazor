#pragma checksum "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\RapportRecette.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b418bc43ffb1981d9cd374789d500453e2e31edf"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 1 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\RapportRecette.razor"
using Recettes_Soft.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\RapportRecette.razor"
using Recettes_Soft.Data.classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\RapportRecette.razor"
using Recettes_Soft.Data.interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Rappot_recette")]
    public partial class RapportRecette : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"image\">\r\n    <img src=\"dist/img/logo.jpg\" style=\"width:70px;height:70px;\" class=\"img-circle elevation-0\" alt=\"User Image\">\r\n    <a>ECC CBCA</a>\r\n</div>\r\n");
            __builder.AddMarkupContent(1, "<h2 style=\"text-align:center\">Rapport Journalier du Recette</h2>\r\n  \r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-12");
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 16 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\RapportRecette.razor"
         if (recettes == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "            ");
            __builder.AddMarkupContent(9, "<p>loading data in table...</p>\r\n");
#nullable restore
#line 19 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\RapportRecette.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "id", "example2");
            __builder.AddAttribute(13, "class", "table table-bordered table-striped mt-2 table-hover");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.AddMarkupContent(15, @"<thead>
                    <tr>
                        <th>id</th>
                        <th>Motif</th>
                        <th>Montant</th>
                        <th>Categorie</th>
                        <th>Users</th>
                        <th>Dates</th>
                    </tr>
                </thead>
                ");
            __builder.OpenElement(16, "tbody");
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 34 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\RapportRecette.razor"
                     foreach (var r in recettes)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                        ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "\r\n                            ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 37 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\RapportRecette.razor"
                                 r.id_rec

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                            ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 38 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\RapportRecette.razor"
                                 r.motif

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 39 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\RapportRecette.razor"
                                 r.montant

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 40 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\RapportRecette.razor"
                                 r.design

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                            ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 41 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\RapportRecette.razor"
                                 r.users

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                            ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 42 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\RapportRecette.razor"
                                 r.dates

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            \r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 45 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\RapportRecette.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.AddMarkupContent(42, "<tfoot>\r\n\r\n                </tfoot>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 51 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\RapportRecette.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\RapportRecette.razor"
       
    IEnumerable<Recettes> recettes;
    protected override async Task OnInitializedAsync()
    {
        recettes = await recetteservice.GetRapportRecettes();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecettes_services recetteservice { get; set; }
    }
}
#pragma warning restore 1591
