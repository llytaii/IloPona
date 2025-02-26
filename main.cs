
using System;

Result result = new Result.Ok(1);

string msg = result switch {
    Result.Ok ok => ok.Val.ToString(),
    Result.Err err => err.Err.ToString(),
};

Console.WriteLine(msg);
