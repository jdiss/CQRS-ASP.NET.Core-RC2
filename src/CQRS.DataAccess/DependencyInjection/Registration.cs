﻿using System.Linq;
using Autofac;

namespace CQRS.DataAccess.DependencyInjection
{
    public class Registration : Module
    {
        public static void Register(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<InMemoryEventStore>().As<IInMemoryEventSotre>().SingleInstance();
            containerBuilder.RegisterType<WriteContext>().AsSelf();

            var init = new WriteContext().ItemEvents.Count();
        }
    }
}