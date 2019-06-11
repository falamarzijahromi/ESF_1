using System;

namespace Composition.ESF_1
{
    public interface IServiceInterceptor
    {
        void Intercept(IInterceptionContext interceptionContext);
    }
}