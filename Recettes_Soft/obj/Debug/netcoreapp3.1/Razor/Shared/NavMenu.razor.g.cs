#pragma checksum "E:\Mes documents\L1\C#\github\GestionRecetteBlazor\Recettes_Soft\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de8c347c52f3477bb0e9c31ffcbb809fb4c8e863"
// <auto-generated/>
#pragma warning disable 1591
namespace Recettes_Soft.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<aside class=\"main-sidebar sidebar-dark-primary elevation-4\">\r\n    \r\n    <a href=\"/\" class=\"brand-link\">\r\n        <img src=\"dist/img/AdminLTELogo.png\" alt=\"AdminLTE Logo\" class=\"brand-image img-circle elevation-3\" style=\"opacity: .8\">\r\n        <span class=\"brand-text font-weight-light\">Soft Church</span>\r\n    </a>\r\n\r\n    \r\n    <div class=\"sidebar\">\r\n        \r\n        <div class=\"user-panel mt-3 pb-3 mb-3 d-flex\">\r\n            <div class=\"image\">\r\n                <img src=\"dist/img/logo.jpg\" class=\"img-circle elevation-0\" alt=\"User Image\">\r\n            </div>\r\n            <div class=\"info\">\r\n                <a href=\"/\" class=\"d-block\">ECC CBCA</a>\r\n            </div>\r\n        </div>\r\n        <nav class=\"mt-2\">\r\n            <ul class=\"nav nav-pills nav-sidebar flex-column\" data-widget=\"treeview\" role=\"menu\" data-accordion=\"false\">\r\n                <li class=\"nav-item menu-open\">\r\n                    <a href=\"/\" class=\"nav-link active\">\r\n                        <i class=\"nav-icon fas fa-tachometer-alt\"></i>\r\n                        <p>\r\n                            Dashboard\r\n                            <i class=\"right fas fa-angle-left\"></i>\r\n                        </p>\r\n                    </a>\r\n                    <ul class=\"nav nav-treeview\">\r\n                       <li class=\"nav-item\">\r\n                            <a href=\"/\" class=\"nav-link active\">\r\n                                <i class=\"far fa-circle nav-icon\"></i>\r\n                                <p>Dashboard</p>\r\n                            </a>\r\n                        </li>\r\n                    </ul>\r\n                </li>\r\n                <li class=\"nav-item\">\r\n                    <a href=\"#\" class=\"nav-link\">\r\n                        <i class=\"nav-icon fas fa-tree\"></i>\r\n                        <p>\r\n                            Menus\r\n                            <i class=\"fas fa-angle-left right\"></i>\r\n                        </p>\r\n                    </a>\r\n                    <ul class=\"nav nav-treeview\">\r\n                        <li class=\"nav-item\">\r\n                            <a href=\"recette\" class=\"nav-link\">\r\n                                <i class=\"far fa-circle nav-icon\"></i>\r\n                                <p>Recettes</p>\r\n                            </a>\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            <a href=\"beneficiare\" class=\"nav-link\">\r\n                                <i class=\"far fa-circle nav-icon\"></i>\r\n                                <p>Beneficiaires</p>\r\n                            </a>\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            <a href=\"depense\" class=\"nav-link\">\r\n                                <i class=\"far fa-circle nav-icon\"></i>\r\n                                <p>Depenses</p>\r\n                            </a>\r\n                        </li>\r\n                    </ul>\r\n                </li>\r\n                </ul>\r\n        </nav>\r\n        \r\n    </div>\r\n    \r\n</aside>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
