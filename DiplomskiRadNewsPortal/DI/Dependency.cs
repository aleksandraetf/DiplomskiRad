using NewsPortal.BusinessLogic.News;
using NewsPortal.BusinessLogic.User;
using NewsPortal.Repository.NewsRepository;
using NewsPortal.Repository.UnitOfWork;
using NewsPortal.Repository.UsersRepository;

namespace DiplomskiRadNewsPortal.DI
{
    public static class DiContainer
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            //Instanca na nivou aplikacije
            //services.AddSingleton<INTERFACE, SERVICE>();
            //services.AddSingleton<ITenantSource, FileTenantSource>();
            // services.AddSingleton<ITenantSource, SQLTenantSource>();

            //Instanca na nivou request-a
            //services.AddScoped<INTERFACE, SERVICE>();

            services.AddScoped<INewsRepository, NewsRepository>();

            services.AddScoped<INewsUnitOfWork, NewsUnitOfWork>();

            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IUserUnitOfWork, UserUnitOfWork>();


            services.AddScoped<INewsService, NewsService>();

            services.AddScoped<IUserService, UserService>();
            //Instanca na nivou klase
            //services.AddTransient<INTERFACE, SERVICE>();
            //   services.AddTransient<UserResolverService>();
            return services;
        }
    }
}
