using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.InversionOfControl.Microsoft
{
    public static class MicrosoftDependencies
    {
        public static void AddCustomDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(ITestDal), typeof(TestDal));
            services.AddScoped(typeof(IUserDal), typeof(UserDal));
            services.AddScoped(typeof(ICategoryDal), typeof(CategoryDal));
            services.AddScoped(typeof(IProductDal), typeof(ProductDal));
            services.AddScoped(typeof(IProductImageDal), typeof(ProductImageDal));
            services.AddScoped(typeof(IColorDal), typeof(ColorDal));
        }
    }
}
