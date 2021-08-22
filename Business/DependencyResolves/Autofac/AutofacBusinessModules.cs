﻿using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;

using System.Text;

namespace Business.DependencyResolves.Autofac
{
   public class AutofacBusinessModules : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ICarService>().As<CarManager>().SingleInstance();
            builder.RegisterType<ICarDal>().As<EfCarDal>().SingleInstance();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions

                {


                    Selector = new AspectInterceptorSelector()





                }).SingleInstance();


        }

        

    }
}
