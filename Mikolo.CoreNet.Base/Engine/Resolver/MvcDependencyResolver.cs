using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Mikolo.CoreNet.Base.Engine.Resolver
{
    public class MvcDependencyResolver : IDependencyResolver
    {

        IDependencyResolver _fallbackResolver;
        
        IDependencyResolver _newResolver;

        public MvcDependencyResolver(IDependencyResolver newResolver, IDependencyResolver fallbackResolver)
        {
            _newResolver = newResolver;
            _fallbackResolver = fallbackResolver;
        }

        public object GetService(Type serviceType)
        {
            object result = null;

            result = _newResolver.GetService(serviceType);
            if (result != null)
            {
                return result;
            }

            return _fallbackResolver.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            IEnumerable<object> result = Enumerable.Empty<object>();

            result = _newResolver.GetServices(serviceType);
            if (result.Any())
            {
                return result;
            }

            return _fallbackResolver.GetServices(serviceType);
        }
    }
}
