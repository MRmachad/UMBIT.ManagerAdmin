namespace UMBIT.ManagerAdmin.InterfaceWeb.Configurate
{
    public static class AppConfigurate
    {
        public static IServiceCollection AddAppConfigurate(this IServiceCollection services)
        {
            services.AddControllersWithViews();
           
            return services;
        }

        public static IApplicationBuilder UseAppConfigurate(this IApplicationBuilder app, IWebHostEnvironment env)
        {
           
            if (!env.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=RegistroUsuario}/{action=Login}/{id?}");
            });

            return app;
        }
    }
}
