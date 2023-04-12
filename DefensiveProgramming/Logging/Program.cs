using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Config;
using NLog.Extensions.Logging;
using System;
using System.IO;
using System.Linq;

namespace Logging
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var serviceProvider = BuildDI())
      {
        using (var scope = serviceProvider.CreateScope())
        {
          var provider = scope.ServiceProvider; 
          IDataLoader dataLoader = provider.GetRequiredService<IDataLoader>();
          dataLoader = provider.GetRequiredService<IDataLoader>();
        }
        Console.WriteLine("----");
        using (var scope = serviceProvider.CreateScope())
        {
          var provider = scope.ServiceProvider;
          IDataLoader dataLoader = provider.GetRequiredService<IDataLoader>();
        }
      }
      
     
    }

    private static ServiceProvider BuildDI()
    {
      var configuration = new ConfigurationBuilder()                                                            
                              .AddJsonFile("appsettings.json")
                              .Build();

      IServiceCollection services = new ServiceCollection();
      var provider = services.AddLogging(configure => {
                                  configure.AddConfiguration(configuration.GetSection("Logging"));
                                  configure.AddConsole();
                                  configure.AddNLog(new NLogProviderOptions { RemoveLoggerFactoryFilter = false });
                              })
                             .AddTransient<IDataLoader, DataLoader>()
                             .AddScoped<A>()
                             .AddTransient<B>()
                             .BuildServiceProvider();
      return provider;
    }
  }
}
