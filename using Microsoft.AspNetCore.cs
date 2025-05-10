using Microsoft.AspNetCore.Mvc;

namespace FunMathAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MathFunController : ControllerBase
    {
        [HttpGet("factorial")]
        public IActionResult Factorial(int number)
        {
            if (number < 0)
            {
                return BadRequest("Number must be non-negative.");
            }

            try
            {
                long result = CalculateFactorial(number);
                return Ok(new { number, result });
            }
            catch (OverflowException)
            {
                return BadRequest("The number is too large to calculate the factorial.");
            }
        }

        [HttpGet("fibonacci")]
        public IActionResult Fibonacci(int count)
        {
            if (count < 0)
            {
                return BadRequest("Count must be non-negative.");
            }

            var result = GenerateFibonacci(count);
            return Ok(new { count, result });
        }

        private long CalculateFactorial(int number)
        {
            if (number == 0 || number == 1) return 1;
            return checked(number * CalculateFactorial(number - 1));
        }

        private List<long> GenerateFibonacci(int count)
        {
            var sequence = new List<long> { 0, 1 };
            for (int i = 2; i < count; i++)
            {
                sequence.Add(sequence[i - 1] + sequence[i - 2]);
            }
            return sequence.Take(count).ToList();
        }
    }
}
