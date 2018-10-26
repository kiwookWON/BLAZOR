using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlaBla.Class
{
    public static class ExampleJsInterop
    {
        public static Task<string> Prompt(string message)
        {
            return JSRuntime.Current.InvokeAsync<string>("exampleJsFunction.showPrompt", message);
        }
    }
}
