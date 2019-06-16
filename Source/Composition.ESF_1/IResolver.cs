using System;

namespace Composition.ESF_1
{
    public interface IResolver
    {
        object Resolver(Type type);
    }
}