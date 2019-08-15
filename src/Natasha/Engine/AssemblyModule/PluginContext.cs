using System;
using System.Collections.Generic;
using System.Runtime.Loader;
using System.Text;

namespace Natasha.AssemblyModule
{
    public class PluginContext : AssemblyLoadContext
    {
        private AssemblyDependencyResolver _resolver;
        public PluginContext() : base()
        {

        }
    }
}
