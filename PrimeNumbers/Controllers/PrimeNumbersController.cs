using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PrimeNumbers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrimeNumbersController : ControllerBase
    {
        private readonly ILogger<PrimeNumbersController> _logger;

        public PrimeNumbersController(ILogger<PrimeNumbersController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get string of numbers with prime numbers removed.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        [HttpGet]
        public string Get(string numbers)
        {
            NumbersController numbersController = new NumbersController();

            string removedNumbers = numbersController.RemovePrimeNumbers(numbers);

            return removedNumbers;
        }
    }
}
