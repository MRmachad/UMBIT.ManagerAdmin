using System.Reflection;
using UMBIT.ManagerAdmin.InterfaceWeb.Controllers.Base;
using UMBIT.ManagerAdmin.InterfaceWeb.Recursos.CustomAtributte;

namespace UMBIT.ManagerAdmin.InterfaceWeb.Extensores
{
    public class AppServicesHelper
    {
        public static List<AppServices> GetServiceList()
        {
            var serviceList = new List<AppServices>()
            {
            };
            var assemblies = Assembly.GetEntryAssembly()?.GetTypes().Where(m => m.BaseType == typeof(ServiceController));
            foreach (var app in assemblies)
            {
                var appService = new AppServices()
                {
                    NameApp = app.Name,
                    Controller = app.Name,
                    Services =  new List<KeyValuePair<string, string>>()
                }; 
                foreach(var methode in app.GetMethods().Where(m => m.GetCustomAttribute(typeof(ServiceAttribute)) != null))
                {
                    var atribute = methode.GetCustomAttribute(typeof(ServiceAttribute)) as ServiceAttribute;
                    appService.Services.Add(new KeyValuePair<string, string>(methode.Name, atribute.Nome));
                }

                serviceList.Add(appService);
            }

            return serviceList;
        }
    }
    public class AppServices
    {
        public string NameApp { get; set; }
        public string Controller { get; set; }
        public List<KeyValuePair<string, string>> Services { get; set; }
    }
}
