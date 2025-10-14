namespace Common;

//a generic class with type parameter E
public class SimpleStack<E> : IStackReader<E>, IStackWriter<E>
{
    //nested class
    class Node
    {
        internal E element;
        internal Node below;

        internal Node Skip(int count)
        {
            Node n = this;
            for(int i = 0; i < count; ++i)
                n = n.below;
            return n;
        }
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

    public Iterator GetEnumerator()
    {
        return new Iterator(this);
    }

    public struct Iterator(SimpleStack<E> source)
    {
        private Node next = source.top;

        public E Current { get; private set; }

        public bool MoveNext()
        {
            if(next != null)
            {
                Current = next.element;
                next = next.below;
                return true;
            }
            return false;
        }
    }

    //indexer - is a parameterized property for getting/setting 
    //a value in this instance at index specified by the parameter
    public E this[int index]
    {
        get{ return top.Skip(index).element; }
        set{ top.Skip(index).element = value; }
    }
}