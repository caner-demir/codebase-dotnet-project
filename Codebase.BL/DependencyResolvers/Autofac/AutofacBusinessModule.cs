using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Codebase.BL.Abstract;
using Codebase.BL.Concrete;
using Codebase.Core.Utilities.Interceptors;
using Codebase.DAL.Abstract;
using Codebase.DAL.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase.BL.DependencyResolvers.Autofac
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

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
