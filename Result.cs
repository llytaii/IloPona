
public abstract record Result<T>
{
    private Result() { } // Prevent external inheritance

    public sealed record Success(T Value) : Result<T>;
    public sealed record Failure(string Error) : Result<T>;

    public TResult Match<TResult>(
        Func<T, TResult> success,
        Func<string, TResult> failure) => this switch
    {
        Success s => success(s.Value),
        Failure f => failure(f.Error),
        _ => throw new ArgumentException("Invalid Result state")
    };
}
