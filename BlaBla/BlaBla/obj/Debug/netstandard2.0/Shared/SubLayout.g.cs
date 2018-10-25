#pragma checksum "G:\Sample\BLAZOR\BlaBla\BlaBla\Shared\SubLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfab75fd9b4b3a7d7f17aa52709dbd9ed80fb157"
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
    using BlaBla.Models;
    using BlaBla.Shared;
    public class SubLayout : BlazorLayoutComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "sidebar");
            builder.AddContent(2, "\n    ");
            builder.OpenComponent<BlaBla.Shared.NavMenu>(3);
            builder.AddAttribute(4, "classStyle", "navbar-collapse");
            builder.CloseComponent();
            builder.AddContent(5, "\n");
            builder.CloseElement();
            builder.AddContent(6, "\n");
            builder.OpenElement(7, "div");
            builder.AddAttribute(8, "class", "main");
            builder.AddContent(9, "\n    ");
            builder.OpenElement(10, "div");
            builder.AddAttribute(11, "class", "content px-4");
            builder.AddContent(12, "\n        ");
            builder.AddContent(13, Body);
            builder.AddContent(14, "\n    ");
            builder.CloseElement();
            builder.AddContent(15, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
