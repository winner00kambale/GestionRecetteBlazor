#pragma checksum "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20d2f73d031def0d61ff423a84ebf79a5c0599e6"
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
#line 1 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
using Recettes_Soft.Data.classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
using Recettes_Soft.Data.interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/esditdepenses/{id_dep:int}")]
    public partial class EditDepenses : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content-wrapper mt-3");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        <div class=\"col-md-3\"></div>\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-6");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<h3>Modifier Depenses</h3>\r\n");
#nullable restore
#line 14 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
             if (depens == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.AddMarkupContent(11, "<p>loading data in table...</p>\r\n");
#nullable restore
#line 17 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                ");
            __builder.OpenElement(13, "form");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "text");
            __builder.AddAttribute(20, "name", "motif");
            __builder.AddAttribute(21, "id", "motif");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "placeholder", "saisir le motif");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                                                                                                             depens.motif

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => depens.motif = __value, depens.motif));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group");
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "number");
            __builder.AddAttribute(33, "name", "montant");
            __builder.AddAttribute(34, "id", "montant");
            __builder.AddAttribute(35, "class", "form-control");
            __builder.AddAttribute(36, "placeholder", "saisir le montant");
            __builder.AddAttribute(37, "min", "0");
            __builder.AddAttribute(38, "oninput", "this.value=Math.abs(this.value)");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                                                                                                                                                                       depens.montant

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => depens.montant = __value, depens.montant, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-group");
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "select");
            __builder.AddAttribute(47, "name", "categorie");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                                                             depens.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => depens.id = __value, depens.id));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(51, "\r\n                            ");
            __builder.OpenElement(52, "option");
            __builder.AddAttribute(53, "value", true);
            __builder.AddContent(54, "... selectionner la categorie");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 30 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                             if (catedep == null)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "                                ");
            __builder.OpenElement(57, "option");
            __builder.AddAttribute(58, "value", true);
            __builder.AddContent(59, "data is loading ...");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 33 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                 foreach (var d in catedep)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(61, "                                    ");
            __builder.OpenElement(62, "option");
            __builder.AddAttribute(63, "value", 
#nullable restore
#line 38 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                                    d.id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(64, 
#nullable restore
#line 38 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                                           d.designation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 39 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "form-group");
            __builder.AddMarkupContent(71, "\r\n                        ");
            __builder.OpenElement(72, "select");
            __builder.AddAttribute(73, "name", "beneficiaire");
            __builder.AddAttribute(74, "class", "form-control");
            __builder.AddAttribute(75, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                                                                depens.beneficiaire

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => depens.beneficiaire = __value, depens.beneficiaire));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(77, "\r\n                            ");
            __builder.OpenElement(78, "option");
            __builder.AddAttribute(79, "value", true);
            __builder.AddContent(80, "... selectionner le beneficiaire");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 46 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                             if (beneciaire == null)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "                                ");
            __builder.OpenElement(83, "option");
            __builder.AddAttribute(84, "value", true);
            __builder.AddContent(85, "data is loading ...");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
#nullable restore
#line 49 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                 foreach (var b in beneciaire)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "                                    ");
            __builder.OpenElement(88, "option");
            __builder.AddAttribute(89, "value", 
#nullable restore
#line 54 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                                    b.code

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(90, 
#nullable restore
#line 54 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                                             b.nom

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(91, "  ");
            __builder.AddContent(92, 
#nullable restore
#line 54 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                                                     b.postnom

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n");
#nullable restore
#line 55 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(94, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                    ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "form-group");
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.OpenElement(100, "input");
            __builder.AddAttribute(101, "type", "text");
            __builder.AddAttribute(102, "name", "autorisation");
            __builder.AddAttribute(103, "id", "autorisation");
            __builder.AddAttribute(104, "class", "form-control");
            __builder.AddAttribute(105, "placeholder", "saisir l\'autorisation");
            __builder.AddAttribute(106, "required", true);
            __builder.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                                                                                                                                 depens.autorisation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => depens.autorisation = __value, depens.autorisation));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                    ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "form-group");
            __builder.AddMarkupContent(113, "\r\n                        ");
            __builder.OpenElement(114, "input");
            __builder.AddAttribute(115, "type", "text");
            __builder.AddAttribute(116, "name", "libelle");
            __builder.AddAttribute(117, "id", "libelle");
            __builder.AddAttribute(118, "class", "form-control");
            __builder.AddAttribute(119, "placeholder", "saisir le libelle");
            __builder.AddAttribute(120, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 64 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                                                                                                                   depens.libelle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(121, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => depens.libelle = __value, depens.libelle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                    ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "form-group");
            __builder.AddMarkupContent(126, "\r\n                        ");
            __builder.OpenElement(127, "input");
            __builder.AddAttribute(128, "type", "text");
            __builder.AddAttribute(129, "name", "user");
            __builder.AddAttribute(130, "id", "user");
            __builder.AddAttribute(131, "class", "form-control");
            __builder.AddAttribute(132, "placeholder", "saisir l\'utilisateur");
            __builder.AddAttribute(133, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                                                                                                                depens.users

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(134, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => depens.users = __value, depens.users));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                    ");
            __builder.OpenElement(137, "div");
            __builder.AddAttribute(138, "class", "modal-footer justify-content-between");
            __builder.AddMarkupContent(139, "\r\n                        ");
            __builder.OpenElement(140, "input");
            __builder.AddAttribute(141, "type", "submit");
            __builder.AddAttribute(142, "class", "btn btn-primary mb-2");
            __builder.AddAttribute(143, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                                                                     UpdateDepense

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(144, "value", "Modifier");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                        ");
            __builder.OpenElement(146, "input");
            __builder.AddAttribute(147, "type", "button");
            __builder.AddAttribute(148, "class", "btn btn-outline-danger");
            __builder.AddAttribute(149, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
                                                                                       fermer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(150, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n");
#nullable restore
#line 74 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(154, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n        <div class=\"col-md-3\"></div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, ">\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditDepenses.razor"
       
    IEnumerable<Categoriedepense> catedep;
    IEnumerable<Beneficiaire> beneciaire;
    [Parameter]
    public int id_dep { get; set; }
    Depenses depens = new Depenses();
    //on innitialise(overide) on recupere les differentes values;
    protected override async Task OnInitializedAsync()
    {
        depens = await depenseservice.SingleDepense(id_dep);
        catedep = await catdepenseservice.Getcategdepense();
        beneciaire = await beneficiaireservice.GetBeneficiaire();

    }
    protected async Task UpdateDepense()
    {
        await depenseservice.EditDepense(id_dep, depens);
        NavigationManager.NavigateTo("/depense");
    }
    void fermer()
    {
        NavigationManager.NavigateTo("/depense");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBeneficiaire beneficiaireservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategDepense catdepenseservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDepense_services depenseservice { get; set; }
    }
}
#pragma warning restore 1591
