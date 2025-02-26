public abstract record Result{
    public record Ok(T Val) : Result;
    public record Err(E Err) : Result;
};