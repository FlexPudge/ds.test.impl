using Lib.MathematicalOperations;

namespace Lib
{
    public class PluginsServices
    {
        public Plugins Plugins { get; set; }
        public PluginsServices()
        {
            Plugins = Plugins.getInstance();
        }
        /// <summary>
        /// Конфигурирует все необходимые плагины
        /// </summary>
        public void PluginsСonfigurator()
        {
            Plugins.AddPlugin(new AdditionPlugin());
            Plugins.AddPlugin(new DivisionPlugin());
            Plugins.AddPlugin(new MultiplicationPlugin());
            Plugins.AddPlugin(new SubtractionPlugin());
        }
    }
}
