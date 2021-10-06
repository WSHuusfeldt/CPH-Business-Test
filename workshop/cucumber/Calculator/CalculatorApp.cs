using System;

namespace Calculator
{
    public class CalculatorApp
    {
        public int firstNumber {get; private set;}
        public int secondNumber { get; private set; }
        public int result { get; private set; }

        public void SetFirstNumber(int firstNumber) {
            this.firstNumber = firstNumber;
        }

        public void SetSecondNumber(int secondNumber)
        {
            this.secondNumber = secondNumber;
        }

        public void AddNumbers()
        {
            this.result = this.firstNumber + this.secondNumber;
        }
    }
}
