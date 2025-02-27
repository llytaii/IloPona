
using System;

Result<int, Exception> TryParse(string number)
{
    if (int.TryParse(number, out int result))
        return Result.Ok(result);
    return Result.Fail(new Exception("Parsing failed!"));
}

var parsingResult = TryParse("-1");

if (parsingResult.IsOk)
{
    Console.WriteLine(parsingResult.Value);
}
else
{
    Console.WriteLine(parsingResult.Error);
}

