using System.Linq.Expressions;

namespace Common;

//a generic class with type parameter E
public class SimpleStack<E> : IStackReader<E>, IStackWriter<E>
{
    //nested class
    class Node
    {
        internal E element;
        internal Node below;
    }

    private Node top;

    public int Length { get; private set; }

    public void Push(E item)
    {
        top = new Node { element = item, below = top }; //instance initializer
        Length += 1;
    }

    public E Pop()
    {
        E item = top.element;
        top = top.below;
        Length -= 1;
        return item;
    }
}