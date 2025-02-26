
using System;

Result<int, string> result = new Result<int, string>.Ok(1);

string msg = result switch {
    Result<int, string>.Ok ok => ok.Val.ToString(),
    Result<int, string>.Err err => err.Err.ToString(),
};

Console.WriteLine(msg);
