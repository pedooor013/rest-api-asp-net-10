using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using RestWithASPNET10.Utils;

namespace RestWithASPNET10.Controller
{   
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult SumGet(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var sum = NumberHelper.ConvertToDecimal(firstNumber) + NumberHelper.ConvertToDecimal(secondNumber);
                return Ok(sum);
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("substract/{firstNumber}/{secondNumber}")]
        public IActionResult Substract(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var substr = NumberHelper.ConvertToDecimal(firstNumber) - NumberHelper.ConvertToDecimal(secondNumber);
                return Ok(substr);
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult DivisionGet(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var division = NumberHelper.ConvertToDecimal(firstNumber) / NumberHelper.ConvertToDecimal(secondNumber);
                return Ok(division);
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult MultiplicationGet(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var multiplication = NumberHelper.ConvertToDecimal(firstNumber) * NumberHelper.ConvertToDecimal(secondNumber);
                return Ok(multiplication);
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("average/{firstNumber}/{secondNumber}")]
        public IActionResult AverageGet(string firstNumber, string secondNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) && NumberHelper.IsNumeric(secondNumber))
            {
                var average = (NumberHelper.ConvertToDecimal(firstNumber) + NumberHelper.ConvertToDecimal(secondNumber)) / 2;
                return Ok(average);
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("squareRoot/{firstNumber}")]
        public IActionResult SquareRootGet(string firstNumber)
        {
            if (NumberHelper.IsNumeric(firstNumber) )
            {
                var num = NumberHelper.ConvertToDecimal(firstNumber);
                var squareRoot = Math.Sqrt((double)num);
                return  Ok(squareRoot);
            }

            return BadRequest("Invalid Input");
        }
    }
}