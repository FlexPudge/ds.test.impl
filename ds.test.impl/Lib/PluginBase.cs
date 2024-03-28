using Lib.Interfaces;

namespace Lib
{
    internal abstract class PluginBase : IPlugin
    {
        public abstract string PluginName { get; }

        public abstract string Version { get; }

        public abstract object Image { get; }

        public abstract string Description { get; }

        public abstract int Run(int input1, int input2);
    }
}
