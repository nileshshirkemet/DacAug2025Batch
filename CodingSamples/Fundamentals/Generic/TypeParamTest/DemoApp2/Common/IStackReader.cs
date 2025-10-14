namespace Common;

//covariant interface
public interface IStackReader<out T>
{
    public int Length { get; }

    public T Pop();
}