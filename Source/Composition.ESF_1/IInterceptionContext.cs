using System;

namespace Composition.ESF_1
{
    public interface IInterceptionContext
    {
        Type TargetType { get; }
        string MethodName { get; }
        void Proceed();
    }
}