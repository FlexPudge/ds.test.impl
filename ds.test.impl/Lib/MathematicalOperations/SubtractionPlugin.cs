namespace Lib.MathematicalOperations
{
    internal class SubtractionPlugin : PluginBase
    {
        public override string PluginName => "Subtraction";

        public override string Version => "1.0";

        public override object Image => throw new NotImplementedException();

        public override string Description => "Производит операцию вычитания чисел";

        public override int Run(int input1, int input2)
        {
            return input1 - input2;
        }
    }
}
