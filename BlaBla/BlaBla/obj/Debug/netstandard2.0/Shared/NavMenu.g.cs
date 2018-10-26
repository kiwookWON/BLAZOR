#pragma checksum "C:\Users\johnr\Documents\BLAZOR\BlaBla\BlaBla\Shared\NavMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff880038ba863057613f80a7aa2d233ae81b9ac5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlaBla.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using BlaBla;
    using BlaBla.Shared;
    public class NavMenu : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            builder.AddContent(2, "\n    ");
            builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href=\"\">BlaBla</a>\n    ");
            builder.OpenElement(4, "button");
            builder.AddAttribute(5, "class", "navbar-toggler");
            builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(ToggleNavMenu));
            builder.AddMarkupContent(7, "\n        <span class=\"navbar-toggler-icon\"></span>\n    ");
            builder.CloseElement();
            builder.AddContent(8, "\n");
            builder.CloseElement();
            builder.AddContent(9, "\n\n");
            builder.OpenElement(10, "div");
            builder.AddAttribute(11, "class", collapseNavMenu ? "collapse" : null);
            builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(ToggleNavMenu));
            builder.AddContent(13, "\n    ");
            builder.OpenElement(14, "ul");
            builder.AddAttribute(15, "class", "nav flex-column");
            builder.AddContent(16, "\n        ");
            builder.OpenElement(17, "li");
            builder.AddAttribute(18, "class", "nav-item px-3");
            builder.AddContent(19, "\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(20);
            builder.AddAttribute(21, "class", "nav-link");
            builder.AddAttribute(22, "href", "");
            builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Blazor.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Blazor.Routing.NavLinkMatch>(NavLinkMatch.All));
            builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(25, "\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(26, "\n        ");
            builder.CloseElement();
            builder.AddContent(27, "\n        ");
            builder.OpenElement(28, "li");
            builder.AddAttribute(29, "class", "nav-item px-3");
            builder.AddContent(30, "\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(31);
            builder.AddAttribute(32, "class", "nav-link");
            builder.AddAttribute(33, "href", "counter");
            builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(35, "\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Counter\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(36, "\n        ");
            builder.CloseElement();
            builder.AddContent(37, "\n        ");
            builder.OpenElement(38, "li");
            builder.AddAttribute(39, "class", "nav-item px-3");
            builder.AddContent(40, "\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(41);
            builder.AddAttribute(42, "class", "nav-link");
            builder.AddAttribute(43, "href", "fetchdata");
            builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(45, "\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Fetch data\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(46, "\n        ");
            builder.CloseElement();
            builder.AddContent(47, "\n        ");
            builder.OpenElement(48, "li");
            builder.AddAttribute(49, "class", "nav-item px-3");
            builder.AddContent(50, "\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(51);
            builder.AddAttribute(52, "class", "nav-link");
            builder.AddAttribute(53, "href", "Parameter");
            builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(55, "\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Parameter Empty\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(56, "\n        ");
            builder.CloseElement();
            builder.AddContent(57, "\n        ");
            builder.OpenElement(58, "li");
            builder.AddAttribute(59, "class", "nav-item px-3");
            builder.AddContent(60, "\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(61);
            builder.AddAttribute(62, "class", "nav-link");
            builder.AddAttribute(63, "href", "Parameter/Good");
            builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(65, "\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Parameter\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(66, "\n        ");
            builder.CloseElement();
            builder.AddContent(67, "\n    ");
            builder.CloseElement();
            builder.AddContent(68, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 38 "C:\Users\johnr\Documents\BLAZOR\BlaBla\BlaBla\Shared\NavMenu.cshtml"
            
    bool collapseNavMenu = true;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
