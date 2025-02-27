
using System;

Result<int> TryParse(string number){
  if(int.TryParse(number, out int result))
    return Result.Ok(result);
  return Result.Fail(new Exception("Could not parse number"));
}

var parsingResult = TryParse("test");

if(parsingResult.IsOk){
  Console.WriteLine(parsingResult.Val);
} else {
  Console.WriteLine($"Parsing failed: {parsingResult.Ex.Message}!");
}

