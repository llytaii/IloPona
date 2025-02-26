
using System;

Result<int> Divide(int a, int b) => b == 0 
    ? new Result<int>.Failure("Cannot divide by zero") 
    : new Result<int>.Success(a / b);

var result = Divide(10, 2);
var output = result.Match(
    success: value => $"Result: {value}",
    failure: error => $"Error: {error}"
);
Console.WriteLine(output);
