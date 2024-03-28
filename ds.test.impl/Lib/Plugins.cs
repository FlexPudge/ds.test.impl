using Lib.Interfaces;

namespace Lib
{
    public class Plugins : IPluginFactory
    {
        /// <summary>
        /// список плагинов
        /// </summary>
        private static List<IPlugin> plugins = new List<IPlugin>();
        private static Plugins instance;
        public int PluginsCount { get => plugins.Count; }
        public string[] GetPluginNames
        {
            get
            {
                string[] result = new string[plugins.Count];
                for (int i = 0; i < plugins.Count; i++)
                {
                    result[i] = plugins[i].PluginName;
                }
                return result;
            }
        }
        private Plugins() { }
        public static Plugins getInstance()
        {
            if (instance == null)
                instance = new Plugins();
            return instance;
        }
        public void AddPlugin(IPlugin plugin) => plugins.Add(plugin);
        public IPlugin GetPlugin(string pluginName)
        {
            return plugins.Find(plugin => plugin.PluginName == pluginName) ?? throw new NotImplementedException();
        }
    }
}
