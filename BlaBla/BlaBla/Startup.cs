using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlaBla
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //���⿡�� ���Ӽ� ������ ����� �� �ֽ��ϴ�.
        
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
