#pragma checksum "G:\Sample\BLAZOR\BlaBla\BlaBla\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8cc84f02532706cf68423090f04640c70e8fba2"
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

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\n\nWelcome to your new app.\n\n");
            builder.OpenComponent<BlaBla.Shared.SurveyPrompt>(1);
            builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            builder.CloseComponent();
            builder.AddContent(3, "\n\n");
            builder.OpenElement(4, "p");
            builder.AddContent(5, "\n    ");
            builder.OpenComponent<BlaBla.Pages.Counter>(6);
            builder.AddAttribute(7, "IncrementAmount", Microsoft.AspNetCore.Blazor.Components.RuntimeHelpers.TypeCheck<System.Int32>(10));
            builder.CloseComponent();
            builder.AddContent(8, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
