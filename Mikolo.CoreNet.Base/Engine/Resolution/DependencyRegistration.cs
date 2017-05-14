using System;

namespace Mikolo.CoreNet.Base.Engine.Resolution
{
    public class DependencyRegistration
    {
        public DependencyRegistration(Type[] interfaces, Type implementation)
        {
            this.Interfaces = interfaces;
            this.Implementation = implementation;
        }
        
        public Type[] Interfaces { get; set; }
        
        public Type Implementation { get; set; }
    }
}
