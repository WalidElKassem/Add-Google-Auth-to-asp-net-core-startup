using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Linq;
using Xunit;

public class GoogleOptionsTests
{
    [Fact]
    public void ConfigureServices_BindsGoogleOptionsFromConfiguration()
    {
        // Arrange
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        var services = new ServiceCollection();
        var startup = new Startup(configuration);

        // Act
        startup.ConfigureServices(services);
        var provider = services.BuildServiceProvider();

        var configureOptions = provider.GetServices<IConfigureOptions<GoogleOptions>>();
        var options = new GoogleOptions();
        foreach (var configure in configureOptions)
        {
            configure.Configure(options);
        }

        // Assert
        Assert.Equal(configuration["Authentication:Google:ClientId"], options.ClientId);
        Assert.Equal(configuration["Authentication:Google:ClientSecret"], options.ClientSecret);
    }
}
