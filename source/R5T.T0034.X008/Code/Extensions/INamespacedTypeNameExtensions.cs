﻿using System;

using R5T.T0034;
using R5T.T0034.X008;


namespace System
{
    public static class INamespacedTypeNameExtensions
    {
        public static string IServiceCollection(this INamespacedTypeName namespacedTypeName)
        {
            var output = namespacedTypeName.From(
                Instances.TypeName.IServiceCollection(),
                Instances.NamespaceName.Microsoft().Extensions().DependencyInjection().Value());

            return output;
        }
    }
}
