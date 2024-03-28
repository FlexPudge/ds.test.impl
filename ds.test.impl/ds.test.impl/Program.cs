//конфигурируем необходимый нам список плагинов
using Lib;
using Lib.Interfaces;

PluginsServices pluginsConfig = new();
pluginsConfig.PluginsСonfigurator();
//получаем имена плагинов
var listPluginName = pluginsConfig.Plugins.GetPluginNames;
//выбираем плагин
var pluginName = listPluginName[0];
//получаем плагин
IPlugin plugin = pluginsConfig.Plugins.GetPlugin(pluginName);
//выводим результат выполнения операции
Console.WriteLine($" результат операции = {plugin.Run(10, 5)}, " +
    $"название плагина {plugin.PluginName}, описание плагина {plugin.Description}");
Console.ReadLine();