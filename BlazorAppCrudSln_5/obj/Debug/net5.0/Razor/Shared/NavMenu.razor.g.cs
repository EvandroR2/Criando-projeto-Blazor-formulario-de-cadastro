#pragma checksum "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\Shared\NavMenu.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "12acc887713a6b624e2d42522c2355abfa1aa0e434a9b43c6014691daf170225"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppCrudSln_5.Shared
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\_Imports.razor"
using BlazorAppCrudSln_5

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\_Imports.razor"
using BlazorAppCrudSln_5.Shared

#line default
#line hidden
#nullable disable
    ;
    #nullable restore
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-0rbjjgbmwv");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-0rbjjgbmwv>EvandroEdgariano</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-0rbjjgbmwv");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-0rbjjgbmwv></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-0rbjjgbmwv");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-0rbjjgbmwv");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-0rbjjgbmwv");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", (object)("nav-link"));
            __builder.AddAttribute(22, "href", (object)(""));
            __builder.AddAttribute(23, "Match", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(24, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-0rbjjgbmwv></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddAttribute(29, "b-0rbjjgbmwv");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(30);
            __builder.AddAttribute(31, "class", (object)("nav-link"));
            __builder.AddAttribute(32, "href", (object)("counter"));
            __builder.AddAttribute(33, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-0rbjjgbmwv></span> Counter\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "nav-item px-3");
            __builder.AddAttribute(38, "b-0rbjjgbmwv");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(39);
            __builder.AddAttribute(40, "class", (object)("nav-link"));
            __builder.AddAttribute(41, "href", (object)("#Amigos"));
            __builder.AddAttribute(42, "onclick", (object)(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\Shared\NavMenu.razor"
                                                               ToggleSubMenu

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(43, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(44, "span");
                __builder2.AddAttribute(45, "class", "oi" + " oi-" + (
#nullable restore
#line 22 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\Shared\NavMenu.razor"
                                    Sign

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "aria-hidden", "true");
                __builder2.AddAttribute(47, "b-0rbjjgbmwv");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, " Amigos\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\Shared\NavMenu.razor"
         if (Visible)
        {

#line default
#line hidden
#nullable disable

            __builder.OpenElement(49, "li");
            __builder.AddAttribute(50, "class", "expand mx-3 p-2");
            __builder.AddAttribute(51, "b-0rbjjgbmwv");
            __builder.OpenElement(52, "ul");
            __builder.AddAttribute(53, "b-0rbjjgbmwv");
            __builder.OpenElement(54, "li");
            __builder.AddAttribute(55, "class", "expand-nav-item px-3");
            __builder.AddAttribute(56, "b-0rbjjgbmwv");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(57);
            __builder.AddAttribute(58, "class", (object)("nav-link"));
            __builder.AddAttribute(59, "href", (object)("Consultar"));
            __builder.AddAttribute(60, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(61, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-0rbjjgbmwv></span> Consultar\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "li");
            __builder.AddAttribute(64, "class", "expand-nav-item px-3");
            __builder.AddAttribute(65, "b-0rbjjgbmwv");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(66);
            __builder.AddAttribute(67, "class", (object)("nav-link"));
            __builder.AddAttribute(68, "href", (object)("Incluir"));
            __builder.AddAttribute(69, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(70, "<span class=\"oi oi-expand-up\" aria-hidden=\"true\" b-0rbjjgbmwv></span> Incluir\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.OpenElement(72, "li");
            __builder.AddAttribute(73, "class", "expand-nav-item px-3");
            __builder.AddAttribute(74, "b-0rbjjgbmwv");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(75);
            __builder.AddAttribute(76, "class", (object)("nav-link"));
            __builder.AddAttribute(77, "href", (object)("Alterar"));
            __builder.AddAttribute(78, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(79, "<span class=\"oi oi-ellipses\" aria-hidden=\"true\" b-0rbjjgbmwv></span> Alterar\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.OpenElement(81, "li");
            __builder.AddAttribute(82, "class", "expand-nav-item px-3");
            __builder.AddAttribute(83, "b-0rbjjgbmwv");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(84);
            __builder.AddAttribute(85, "class", (object)("nav-link"));
            __builder.AddAttribute(86, "href", (object)("Deletar"));
            __builder.AddAttribute(87, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(88, "<span class=\"oi oi-trash\" aria-hidden=\"true\" b-0rbjjgbmwv></span> Deletar\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable

            __builder.OpenElement(89, "li");
            __builder.AddAttribute(90, "class", "nav-item px-3");
            __builder.AddAttribute(91, "b-0rbjjgbmwv");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(92);
            __builder.AddAttribute(93, "class", (object)("nav-link"));
            __builder.AddAttribute(94, "href", (object)("fetchdata"));
            __builder.AddAttribute(95, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(96, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-0rbjjgbmwv></span> Fetch data\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n        ");
            __builder.OpenElement(98, "li");
            __builder.AddAttribute(99, "class", "nav-item px-3");
            __builder.AddAttribute(100, "b-0rbjjgbmwv");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(101);
            __builder.AddAttribute(102, "class", (object)("nav-link"));
            __builder.AddAttribute(103, "href", (object)("vbseis"));
            __builder.AddAttribute(104, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(105, "<span class=\"oi oi-book\" aria-hidden=\"true\" b-0rbjjgbmwv></span> Doc Vb6\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\Shared\NavMenu.razor"
       
    private bool Visible = false;

    private bool collapseNavMenu = true;

    private string Sign = "plus";



    private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
    private void ToggleSubMenu()
    {
        Visible = !Visible;
        Sign = Visible ? "minus" : "plus";
    }

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591
