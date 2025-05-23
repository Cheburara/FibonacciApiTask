using FibonacciApiTask.Models;
using FibonacciApiTask.Services;
using Microsoft.AspNetCore.Mvc;

namespace FibonacciApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FibonacciController : ControllerBase
    {
        // Service that handles Fibonacci logic
        private readonly IFibonacciService _fibonacciService;
        
        //Constructor injection of the service 
        public FibonacciController(IFibonacciService fibonacciService)
        {
            _fibonacciService = fibonacciService;
        }

        
        [HttpPost]
        public async Task<ActionResult<FibonacciResponse>> GetSubsequence(
            [FromBody] FibonacciRequest request,
            CancellationToken cancellationToken)
        {
            try
            {   
                // Enforce timeoutMs from request
                var timeoutCts = new CancellationTokenSource(TimeSpan.FromMilliseconds(request.TimeoutMs));
                var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(timeoutCts.Token, cancellationToken);

                // Introduction service layer
                var response = await _fibonacciService.GenerateFibonacciAsync(request, linkedCts.Token);

                return Ok(response);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Internal server error", detail = ex.Message });
            }
        }
    }
}