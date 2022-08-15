using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Layered.BLL.Abstract;
using Layered.BLL.Concrete;
using Layered.Core.Utilities.Interceptors;
using Layered.DAL.Abstract;
using Layered.DAL.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.BLL.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EFProductRepository>().As<IProductRepository>().SingleInstance();
            builder.RegisterType<ProductService>().As<IProductService>().SingleInstance();
            builder.RegisterType<EFOrderRepository>().As<IOrderRepository>().SingleInstance();
            builder.RegisterType<OrderService>().As<IOrderService>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).Where(a => a.Name.EndsWith("Service")).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
