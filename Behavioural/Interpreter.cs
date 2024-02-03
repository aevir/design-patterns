namespace DesignPatterns.Behavioural
{
    /*
     * IExpression: This will be a basic interface for all expressions.        
     * NumberExpression: Class used to interpret numbers.        
     * AddExpression: Class used to interpret addition of two numbers.        
     * Context: Not always necessary, but for complex scenarios, this class holds global information.    
     */

    #region Interfaces
    public interface IExpression
    {
        int Interpret();
    }
    #endregion

    #region Implementation
    public class NumberExpression : IExpression
    {
        private int number;

        public NumberExpression(int number)
        {
            this.number = number;
        }

        public int Interpret()
        {
            return number;
        }
    }

    public class AddExpression : IExpression
    {
        private IExpression firstExpression;
        private IExpression secondExpression;

        public AddExpression(IExpression first, IExpression second)
        {
            firstExpression = first;
            secondExpression = second;
        }

        public int Interpret()
        {
            return firstExpression.Interpret() + secondExpression.Interpret();
        }
    }

    // ExpressionInterpreter class has a method Evaluate which takes a string expression, parses it, and uses the Interpreter pattern to calculate the result.
    public class ExpressionInterpreter
    {
        public int Evaluate(string expression)
        {
            // For simplicity, we assume the expression is always "a + b"
            var parts = expression.Split(' ');
            IExpression firstNumber = new NumberExpression(int.Parse(parts[0]));
            IExpression secondNumber = new NumberExpression(int.Parse(parts[2]));
            IExpression addition = new AddExpression(firstNumber, secondNumber);

            return addition.Interpret();
        }
    }
    #endregion
}
