using System;

namespace Composition.ESF_1
{
    public interface IIocContainer
    {
        void RegisterPerGraph(Type[] serviceTypes, Type implementationType, Type[] interceptorTypes = null);
    }
}