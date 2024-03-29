﻿using System;
using System.Linq;
using System.Reflection;

namespace Composition.ESF_1
{
    public static class IocContainerExtensions
    {
        public static void RegisterAllServicesPerGraph(
            this IIocContainer container,
            Assembly assembly,
            Type[] interceptorTypes = null)
        {
            var implementationTypes = assembly.ExportedTypes.Where(type => type.IsClass);

            foreach (var implementationType in implementationTypes)
            {
                container.RegisterPerGraph(new[] { implementationType }, implementationType, interceptorTypes);

                var serviceTypes = implementationType.GetInterfaces();

                if (serviceTypes.Any())
                {
                    container.RegisterPerGraph(serviceTypes, implementationType, interceptorTypes);
                }
            }
        }

        public static void RegisterAllServicesFactoryTransient(
            this IIocContainer container,
            Func<IResolver, Type, object> genericFactoryDelegate,
            Type[] serviceTypes,
            Type[] interceptorTypes = null)
        {
            foreach (var serviceType in serviceTypes)
            {
                container.RegisterFactoryTransient(
                    new[] { serviceType }, 
                    r => genericFactoryDelegate(r, serviceType), 
                    interceptorTypes);
            }
        }
    }
}
