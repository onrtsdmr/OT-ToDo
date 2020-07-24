using Microsoft.Extensions.DependencyInjection;
using OTProje.ToDo.Business.Concrete;
using OTProje.ToDo.Business.Interfaces;
using OTProje.ToDo.DataAccess.Concrete.EFCore.Repositories;
using OTProje.ToDo.DataAccess.Interfaces;

namespace OTProje.ToDo.Business.Containers.MicrosoftIoC
{
    public static class CustomExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<,>));

            services.AddScoped<IToDoService, ToDoManager>();
            services.AddScoped<IUserService, UserManager>();

            services.AddScoped<IToDoDal, EfToDoRepository>();
            services.AddScoped<IUserDal, EfUserRepository>();
        }
    }
}