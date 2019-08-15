using System;
using System.Collections.Generic;
using System.Runtime.Loader;
using System.Text;

namespace Core31
{
    public class PluginContext : AssemblyLoadContext
    {
        private AssemblyDependencyResolver _resolver;
        public PluginContext() : base()
        {

        }
    }
}
