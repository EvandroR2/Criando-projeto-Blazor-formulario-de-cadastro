#pragma checksum "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\Shared\MainLayout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bb99a10c2bd0e7afcb9e21da23d7e2905c82444ca8e6b9e20456a4554257bb20"
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
    public partial class MainLayout : LayoutComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-n6ogsgkirn");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-n6ogsgkirn");
            __builder.OpenComponent<global::BlazorAppCrudSln_5.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-n6ogsgkirn");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-n6ogsgkirn><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-n6ogsgkirn>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-n6ogsgkirn");
            __builder.AddContent(15, 
#nullable restore
#line 14 "C:\Users\Srb-Evandro-Dev\Documents\GitHub\Criando-projeto-Blazor-formulario-de-cadastro\BlazorAppCrudSln_5\Shared\MainLayout.razor"
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
    }
}
#pragma warning restore 1591
