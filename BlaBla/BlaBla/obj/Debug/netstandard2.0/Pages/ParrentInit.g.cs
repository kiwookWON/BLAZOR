#pragma checksum "G:\Sample\BLAZOR\BlaBla\BlaBla\Pages\ParrentInit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1013607f0211dac1f7366fbf6a820b9624e3d4e9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlaBla.Pages
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
    using BlaBla.Models;
    using BlaBla.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/parentInit")]
    public class ParrentInit : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Page with Parameters</h1>\n\n");
            builder.OpenElement(1, "button");
            builder.AddAttribute(2, "type", "button");
            builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(SwitchName));
            builder.AddContent(4, "Switch Name");
            builder.CloseElement();
            builder.AddContent(5, "\n\n");
            builder.OpenComponent<BlaBla.Pages.Initialization>(6);
            builder.AddAttribute(7, "Name", Microsoft.AspNetCore.Blazor.Components.RuntimeHelpers.TypeCheck<System.String>(Name));
            builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 9 "G:\Sample\BLAZOR\BlaBla\BlaBla\Pages\ParrentInit.cshtml"
            
    private string Name { get; set; } = "Blazor";
    private void SwitchName() => Name = Name == "Blazor" ? "John" : "Blazor";

#line default
#line hidden
    }
}
#pragma warning restore 1591
