# FibonacciApiTask

FibonacciApiTask is a .NET-based application for generating Fibonacci sequences. It includes unit tests for validating various scenarios like timeouts, memory limits, and caching behavior.

## Features

- **Generate Fibonacci Sequence:** Generate the Fibonacci sequence for a given range of indices.
- **Timeout Handling:** Respect the timeout duration when calculating the Fibonacci sequence.
- **Memory Limit:** Enforce memory limits while calculating large Fibonacci numbers.
- **Cache Support:** Use caching for already computed Fibonacci numbers.

## Setup Instructions

1. Clone this repository:
   ```bash
   git clone git@github.com:Cheburara/FibonacciApiTask.git

2. Restore dependencies:
   dotnet restore

3. Build the solution:
   dotnet build

4. Run the API:
   dotnet run --project FibonacciApiTask

5. Run the unit tests:
   dotnet test
