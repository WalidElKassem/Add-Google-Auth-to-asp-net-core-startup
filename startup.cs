private readonly IConfigurationRoot _configurationRoot;

 public Startup(IWebHostEnvironment webHostEnvironment)
{           
    _configurationRoot = new ConfigurationBuilder().SetBasePath(webHostEnvironment.ContentRootPath).AddJsonFile("appsettings.json").Build();
}

public void ConfigureServices(IServiceCollection services)
{
  //GOOGLE
 services.AddAuthentication().AddGoogle(options =>
 {
   var clientid = _configurationRoot.GetSection("Authentication").GetSection("Google").GetValue(typeof(string), "ClientId");
   options.ClientId = clientid.ToString();
  
   var clientsecret = _configurationRoot.GetSection("Authentication").GetSection("Google").GetValue(typeof(string), "ClientSecret");
   options.ClientSecret = clientsecret.ToString();
  
  });
}

