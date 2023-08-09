using UMBIT.ManagerAdmin.Dominio.Servicos.Identidade;
using UMBIT.ManagerAdmin.Dominio.Servicos.Identidade.Facade.Indentity;

namespace UMBIT.ManagerAdmin.InterfaceWeb.Configurate
{
    public static class InjectionDependencyConfigurate
    {
        public static IServiceCollection AddInjectionDependency(this IServiceCollection services)
        {
            services.AddScoped<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IServicoDeIdentidade, ServicoDeIdentity>();

            return services;
        }
    }
}
