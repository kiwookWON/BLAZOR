#pragma checksum "C:\Users\johnr\Documents\BLAZOR\BlaBla\BlaBla\Pages\Counter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "191c49bbe0327ae49a43740e6660b2e8f56f78fc"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    using BlaBla.Infrastructure;
    using BlaBla.Repositories;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 9 "C:\Users\johnr\Documents\BLAZOR\BlaBla\BlaBla\Pages\Counter.cshtml"
            

    [Parameter]
    private int IncrementAmount { get; set; } = 1;

    int currentCount = 0;

    void IncrementCount()
    {
        currentCount+= IncrementAmount;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
