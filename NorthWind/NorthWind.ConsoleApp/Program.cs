HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

Builder.Services.AddNorthWindServices();

using IHost AppHost = Builder.Build();

IAppLogger Logger = AppHost.Services.GetRequiredService<IAppLogger>();
Logger.WriteLog("Application started.");

IProductService Service = AppHost.Services.GetRequiredService<IProductService>();
Service.Add("Demo", "Azúcar refinada");

/*
 * AppLogger y los Writers: Responsabilidad única
 * AppLogger: Abierto pero cerrado
 * AppLogger: Inversión de dependencias. Los módulos
 * de alto nivel son independientes de los detalles de implementación.
 */