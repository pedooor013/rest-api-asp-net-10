namespace RestWithASPNET10.Services
{
    public class MathService
    {
        public decimal Sum(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public decimal Substract(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public decimal Division(decimal firstNumber, decimal secondNumber)
        {
            if(secondNumber == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return firstNumber / secondNumber;
        }
        public decimal Multiplication(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public double SquareRoot(decimal firstNumber)
        {
            if (firstNumber < 0) throw new ArgumentOutOfRangeException("Cannot calculate the square root of a negative number"); 
            return Math.Sqrt((double)firstNumber);
        }
    }
}
