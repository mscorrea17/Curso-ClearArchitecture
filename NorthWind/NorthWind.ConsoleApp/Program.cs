using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

IUserActionWriter Writer = new FileWriter();

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Application started.");

ProductService Service = new ProductService(Writer);
Service.Add("Demo", "Azúcar refinada");

/*
 * AppLoger y los Writers: Responsabilidad unica
 * AppLogger: Abierto pero cerrado
 * AppLogger: Inversion de dependencias. los modulos
 * de alto nivel son independientes de los detalles de implementacion.
 * 
 * */