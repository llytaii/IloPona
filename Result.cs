
public abstract record Result<T, E>
{
    public sealed record Ok(T Val) : Result<T, E>;
    public sealed record Err(E Err) : Result<T, E>;
}
