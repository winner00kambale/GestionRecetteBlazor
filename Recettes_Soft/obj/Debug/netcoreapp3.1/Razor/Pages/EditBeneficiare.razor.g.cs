#pragma checksum "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bd13f60be290cb833c114a68b6ae759b8b827cc"
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
#line 1 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
using Recettes_Soft.Data.classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
using Recettes_Soft.Data.interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editbeneficiaire/{code:int}")]
    public partial class EditBeneficiare : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content-wrapper mt-3");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, "\r\n            <div class=\"col-md-3\"></div>\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-md-6");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "container");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.AddMarkupContent(15, "<h3 class=\"mt-2\">Modifier Le Beneficiaire</h3>\r\n");
#nullable restore
#line 15 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
                     if (benef == null)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                        ");
            __builder.AddMarkupContent(17, "<p>loading data in table...</p>\r\n");
#nullable restore
#line 18 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                        ");
            __builder.OpenElement(19, "form");
            __builder.AddMarkupContent(20, "\r\n                            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.AddMarkupContent(23, "\r\n                                ");
            __builder.AddMarkupContent(24, "<label class=\"control-label\">nom</label>\r\n                                ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "name", "nom");
            __builder.AddAttribute(28, "id", "nom");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "placeholder", "saisir le nom");
            __builder.AddAttribute(31, "required", true);
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
                                                                                                                                benef.nom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => benef.nom = __value, benef.nom));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                ");
            __builder.AddMarkupContent(35, "<label class=\"control-label\">postnom</label>\r\n                                ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "text");
            __builder.AddAttribute(38, "name", "postnom");
            __builder.AddAttribute(39, "id", "postnom");
            __builder.AddAttribute(40, "class", "form-control");
            __builder.AddAttribute(41, "placeholder", "saisir le postnom");
            __builder.AddAttribute(42, "required", true);
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
                                                                                                                                            benef.postnom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => benef.postnom = __value, benef.postnom));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                                ");
            __builder.AddMarkupContent(46, "<label class=\"control-label\">genre</label>\r\n                                ");
            __builder.OpenElement(47, "select");
            __builder.AddAttribute(48, "name", "sexe");
            __builder.AddAttribute(49, "id", "sexe");
            __builder.AddAttribute(50, "class", "form-control");
            __builder.AddAttribute(51, "required", true);
            __builder.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
                                                                                           benef.sexe

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => benef.sexe = __value, benef.sexe));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(54, "\r\n                                    ");
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", true);
            __builder.AddContent(57, "... selectionner le sexe");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                    ");
            __builder.OpenElement(59, "option");
            __builder.AddAttribute(60, "value", "M");
            __builder.AddContent(61, "M");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                                    ");
            __builder.OpenElement(63, "option");
            __builder.AddAttribute(64, "value", "F");
            __builder.AddContent(65, "F");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                                ");
            __builder.AddMarkupContent(68, "<label class=\"control-label\">residence</label>\r\n                                ");
            __builder.OpenElement(69, "input");
            __builder.AddAttribute(70, "type", "text");
            __builder.AddAttribute(71, "name", "residence");
            __builder.AddAttribute(72, "id", "residence");
            __builder.AddAttribute(73, "class", "form-control");
            __builder.AddAttribute(74, "placeholder", "saisir la residence");
            __builder.AddAttribute(75, "required", true);
            __builder.AddAttribute(76, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
                                                                                                                                                  benef.residence

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => benef.residence = __value, benef.residence));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                                ");
            __builder.AddMarkupContent(79, "<label class=\"control-label\">telephone</label>\r\n                                ");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "type", "tel");
            __builder.AddAttribute(82, "name", "telephone");
            __builder.AddAttribute(83, "id", "telephone");
            __builder.AddAttribute(84, "class", "form-control");
            __builder.AddAttribute(85, "placeholder", "saisir le numero telephone");
            __builder.AddAttribute(86, "required", true);
            __builder.AddAttribute(87, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
                                                                                                                                                        benef.tel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => benef.tel = __value, benef.tel));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                                ");
            __builder.AddMarkupContent(90, "<label>Fonction</label>\r\n                                ");
            __builder.OpenElement(91, "select");
            __builder.AddAttribute(92, "name", "sexe");
            __builder.AddAttribute(93, "id", "sexe");
            __builder.AddAttribute(94, "class", "form-control");
            __builder.AddAttribute(95, "required", true);
            __builder.AddAttribute(96, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
                                                                                           benef.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => benef.id = __value, benef.id));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(98, "\r\n                                    ");
            __builder.OpenElement(99, "option");
            __builder.AddAttribute(100, "value", true);
            __builder.AddContent(101, "... selectionner la fonction");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n");
#nullable restore
#line 40 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
                                     if (fonc == null)
                                    {

                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
                                         foreach (var f in fonc)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(103, "                                            ");
            __builder.OpenElement(104, "option");
            __builder.AddAttribute(105, "value", 
#nullable restore
#line 48 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
                                                            f.id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(106, 
#nullable restore
#line 48 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
                                                                   f.design

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
#nullable restore
#line 49 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
                                         
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(108, "                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                            ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "modal-footer justify-content-between");
            __builder.AddMarkupContent(113, "\r\n                                ");
            __builder.OpenElement(114, "input");
            __builder.AddAttribute(115, "type", "submit");
            __builder.AddAttribute(116, "class", "btn btn-primary mb-2");
            __builder.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
                                                                                             UpdateBenefic

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "value", "Modifier");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                                ");
            __builder.OpenElement(120, "input");
            __builder.AddAttribute(121, "type", "button");
            __builder.AddAttribute(122, "class", "btn btn-outline-danger");
            __builder.AddAttribute(123, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
                                                                                               fermer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(124, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n\r\n                            <br>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n");
#nullable restore
#line 60 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(128, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n            <div class=\"col-md-3\"></div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Pages\EditBeneficiare.razor"
       
    IEnumerable<Fonctions> fonc;
    [Parameter]
    public int code { get; set; }
    Beneficiaire benef = new Beneficiaire();
    //on innitialise(overide) on recupere les differentes values;
    protected override async Task OnInitializedAsync()
    {
        benef = await Ibeneficiaireservice.SingleBeneficiaire(code);
        fonc = await fonctionservice.Getfonction();

    }
    protected async Task UpdateBenefic()
    {
        await Ibeneficiaireservice.EditBeneficiaire(code, benef);
        NavigationManager.NavigateTo("/beneficiare");
    }
    void fermer()
    {
        NavigationManager.NavigateTo("/beneficiare");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFonction fonctionservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBeneficiaire Ibeneficiaireservice { get; set; }
    }
}
#pragma warning restore 1591
