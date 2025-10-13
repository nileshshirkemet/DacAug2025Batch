namespace Common;

//contravariant interface
public interface IStackWriter<in T>
{
    void Push(T item);
}