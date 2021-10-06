using TechTalk.SpecFlow;
using Xunit;

namespace Calculator.Tests.StepDefinitions
{
    [Binding]
    public class AddTwoNumbersSteps
    {
        private readonly CalculatorApp _calculatorApp;

        public AddTwoNumbersSteps()
        {
            _calculatorApp = new CalculatorApp();
        }

        [Given(@"the number (.*) as firstNumber")]
        public void GiventhenumberasfirstNumber(int firstNumber)
        {
            _calculatorApp.SetFirstNumber(firstNumber);
        }

        [Given(@"the number (.*) as second number")]
        public void Giventhenumberassecondnumber(int secondNumber)
        {
            _calculatorApp.SetSecondNumber(secondNumber);
        }

        [When(@"i press add")]
        public void Whenipressadd()
        {
            _calculatorApp.AddNumbers();
        }

        [Then(@"the result should show (.*)")]
        public void ThenTheResultShouldShow(int result)
        {
            Assert.Equal(result, _calculatorApp.result);
        }

    }
}