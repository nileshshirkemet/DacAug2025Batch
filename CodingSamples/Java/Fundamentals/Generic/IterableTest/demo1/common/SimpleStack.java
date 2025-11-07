package common;

import java.util.Iterator;

public class SimpleStack<V>  implements Iterable<V> {

    //inner member class
    class Node {

        V element;
        Node below;

        Node(V item){
            element = item;
            below = top;
        }
    }

    private Node top;

    public void push(V item) {
        top = new Node(item);
    }

    public V pop() {
        V item = top.element;
        top = top.below;
        return item;
    }

    public boolean empty() {
        return top == null;
    }

    public Iterator<V> iterator() {
        //instantiating an inner local anonymous class 
        //that implements Iterator<V>
        return new Iterator<V>(){

            private Node current = top;

            public boolean hasNext() {
                return current != null;
            }

            public V next() {
                V result = current.element;
                current = current.below;
                return result;
            }
        };
    }

}

