using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SpecFlowCalculatorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly Calculator _calculator;

        public CalculatorController(IConfiguration config)
        {
            _config = config;
            _calculator = new Calculator();
        }

        [HttpGet("/Calculator/Add")]
        public Calculator Add(int firstNumber, int secondNumber)
        {
            var releaseLabel = _config["ReleaseLabel"];
            _calculator.Add(firstNumber, secondNumber);

            return _calculator;
        }

        [HttpGet("/Calculator/Subtract")]
        public Calculator Subtract(int firstNumber, int secondNumber)
        {
            _calculator.Subtract(firstNumber, secondNumber);

            return _calculator;
        }

        [HttpGet("/Calculator/Multiply")]
        public Calculator Multiply(int firstNumber, int secondNumber)
        {
            _calculator.Multiply(firstNumber, secondNumber);

            return _calculator;
        }

        [HttpGet("/Calculator/Divide")]
        public Calculator Divide(int firstNumber, int secondNumber)
        {
            _calculator.Divide(firstNumber, secondNumber);

            return _calculator;
        }
    }
}