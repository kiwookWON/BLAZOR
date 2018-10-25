using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlaBla
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //여기에서 종속성 주입을 사용할 수 있습니다.
        
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
