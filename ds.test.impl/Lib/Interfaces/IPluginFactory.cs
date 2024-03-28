namespace Lib.Interfaces
{
    interface IPluginFactory
    {
        /// <summary>
        /// Количество доступных плагинов
        /// </summary>
        int PluginsCount { get; }
        /// <summary>
        /// Получение списка плагинов
        /// </summary>
        string[] GetPluginNames { get; }
        /// <summary>
        /// Получение плагина по названию
        /// </summary>
        /// <param name="pluginName"></param>
        /// <returns></returns>
        IPlugin GetPlugin(string pluginName);
    }
}
