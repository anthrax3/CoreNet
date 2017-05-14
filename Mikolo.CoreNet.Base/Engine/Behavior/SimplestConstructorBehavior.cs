using SimpleInjector.Advanced;
using System;
using System.Linq;
using System.Reflection;

namespace Mikolo.CoreNet.Base.Engine.Behavior
{
    public class SimplestConstructorBehavior : IConstructorResolutionBehavior
    {
        public ConstructorInfo GetConstructor(Type implementationType)
        {
            return (
                from ctor in implementationType.GetConstructors()
                orderby ctor.GetParameters().Length ascending
                select ctor)
                .FirstOrDefault();
        }
    }
}
