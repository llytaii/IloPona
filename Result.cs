using System;

public abstract record Result
{
    public static Result<V> Ok<V>(V val) => new ResultOk<V>(val);
    public static Result<object> Fail(Exception ex) => new ResultError<object>(ex);
}

public abstract record Result<V>
{
    public bool IsOk => this is ResultOk<V>;

    public V Val => this switch {
        ResultOk<V> r => r.val,
        _ => throw new InvalidOperationException($"No VALUE on {this.GetType()}")
    };

    public Exception Ex => this switch {
        ResultError<V> r => r.ex,
        _ => throw new InvalidOperationException($"No ERROR on {this.GetType()}")
    };

}

internal record ResultOk<V>(V val) : Result<V>;
internal record ResultError<V>(Exception ex) : Result<V>;

    
