using FibonacciApiTask.Models;

namespace FibonacciApiTask.Services;

public interface IFibonacciService
{
    Task<FibonacciResponse> GenerateFibonacciAsync(
        FibonacciRequest request,
        CancellationToken cancellationToken);
}