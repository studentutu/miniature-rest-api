using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Weather
{
    public interface IInstaller
    {
        void Install(IConfiguration config, IServiceCollection services);
    }
}