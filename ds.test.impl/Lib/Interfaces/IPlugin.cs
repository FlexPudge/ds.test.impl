namespace Lib.Interfaces
{
    public interface IPlugin
    {
        /// <summary>
        /// Название плагина
        /// </summary>
        string PluginName { get; }
        /// <summary>
        /// Версия плагина
        /// </summary>
        string Version { get; }
        /// <summary>
        /// Изображение
        /// </summary>
        object Image { get; }
        /// <summary>
        /// Описание плагина
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Метод производящий какую либо операцию
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns>результат операции</returns>
        int Run(int input1, int input2);
    }
}
