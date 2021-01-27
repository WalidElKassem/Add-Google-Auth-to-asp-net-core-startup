public IConfiguration Configuration { get; }

 public Startup(IConfiguration configuration)
{           
       Configuration = configuration;
}

public void ConfigureServices(IServiceCollection services)
{
  //GOOGLE
 services.AddAuthentication().AddGoogle(options =>
 {
   var clientid = Configuration.GetSection("Authentication").GetSection("Google").GetValue(typeof(string), "ClientId");
   options.ClientId = clientid.ToString();
  
   var clientsecret = Configuration.GetSection("Authentication").GetSection("Google").GetValue(typeof(string), "ClientSecret");
   options.ClientSecret = clientsecret.ToString();
  
  });
}

