using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Mikolo.CoreNet.Base.Engine.Resolver
{
    public class MvcDependencyResolver : IDependencyResolver
    {

        private readonly IDependencyResolver _fallbackResolver;

        private readonly IDependencyResolver _newResolver;

        public MvcDependencyResolver(IDependencyResolver newResolver, IDependencyResolver fallbackResolver)
        {
            _newResolver = newResolver;
            _fallbackResolver = fallbackResolver;
        }

        public object GetService(Type serviceType)
        {
            var result = _newResolver.GetService(serviceType);

            return result ?? _fallbackResolver.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            var result = _newResolver.GetServices(serviceType);

            return result.Any() ? result : _fallbackResolver.GetServices(serviceType);
        }
    }
}
