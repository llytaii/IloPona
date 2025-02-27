public static class Result
{
  public static Result<V, object> Ok<V>(V value) where V : notnull
      => new Result<V, object>.Ok(value);

  public static Result<object, E> Fail<E>(E error) where E : notnull
      => new Result<object, E>.Fail(error);
}

public abstract record Result<V, E>
    where V : notnull
    where E : notnull
{
  public bool IsOk => this is Ok;
  public V Value => ((Ok)this).Val;
  public E Error => ((Fail)this).Err;

  public record Ok(V Val) : Result<V, E>;
  public record Fail(E Err) : Result<V, E>;

  public static implicit operator Result<V, E>(Result<V, object> other)
      => new Ok(other.Value);

  public static implicit operator Result<V, E>(Result<object, E> other)
      => new Fail(other.Error);
}

