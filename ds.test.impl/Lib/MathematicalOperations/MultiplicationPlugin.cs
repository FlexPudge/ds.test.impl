namespace Lib.MathematicalOperations
{
    internal class MultiplicationPlugin : PluginBase
    {
        public override string PluginName => "Multiplication";

        public override string Version => "1.0";

        public override object Image => throw new NotImplementedException();

        public override string Description => "Производит операцию умножения чисел";

        public override int Run(int input1, int input2)
        {
            return input1 * input2;
        }
    }
}
