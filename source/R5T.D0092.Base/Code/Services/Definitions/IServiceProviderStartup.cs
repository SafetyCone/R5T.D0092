using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.T0064;


namespace R5T.D0092
{
    /// <summary>
    /// Startup service for a service provider.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IServiceProviderStartup : IServiceDefinition
    {
        Task ConfigureConfiguration(IConfigurationBuilder configurationBuilder);
        Task ConfigureServices(IServiceCollection services);
    }
}