namespace Calculator
{
    public class Calculator
    {
        private long currentResult = 0;

        public long Add(long value)
        {
            currentResult += value;
            return currentResult;
        }

        public long Substract(long value)
        {
            currentResult -= value;
            return currentResult;
        }

        public long Multiply(long value)
        {
            currentResult *= value;
            return currentResult;
        }

        public long Divide(long value)
        {
            currentResult /= value;
            return currentResult;
        }
    }
}