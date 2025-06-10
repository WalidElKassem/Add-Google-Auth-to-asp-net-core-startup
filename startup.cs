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
   var clientid = Configuration.GetValue<string>("Authentication:Google:ClientId");
   options.ClientId = clientid;
  
   var clientsecret = Configuration.GetValue<string>("Authentication:Google:ClientSecret");
   options.ClientSecret = clientsecret;
  
  });
}

