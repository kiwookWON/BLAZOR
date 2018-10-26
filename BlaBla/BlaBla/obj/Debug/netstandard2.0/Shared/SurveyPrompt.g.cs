#pragma checksum "C:\Users\johnr\Documents\BLAZOR\BlaBla\BlaBla\Shared\SurveyPrompt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d0a56bb947fc8794f08f6862111ca62ce4d4b5a"
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
    public class SurveyPrompt : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "alert alert-secondary mt-4");
            builder.AddAttribute(2, "role", "alert");
            builder.AddMarkupContent(3, "\n    <span class=\"oi oi-pencil mr-2\" aria-hidden=\"true\"></span> \n    ");
            builder.OpenElement(4, "strong");
            builder.AddContent(5, Title);
            builder.CloseElement();
            builder.AddContent(6, "\n\n    ");
            builder.AddMarkupContent(7, "<span class=\"text-nowrap\">\n        Please take our\n        <a target=\"_blank\" class=\"font-weight-bold\" href=\"https://go.microsoft.com/fwlink/?linkid=2026993\">brief survey</a>\n    </span>\n    and tell us what you think.\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 12 "C:\Users\johnr\Documents\BLAZOR\BlaBla\BlaBla\Shared\SurveyPrompt.cshtml"
            
    [Parameter]
    string Title { get; set; } // Demonstrates how a parent component can supply parameters

#line default
#line hidden
    }
}
#pragma warning restore 1591
