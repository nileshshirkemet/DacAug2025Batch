package common;

public class SimpleStack<V> {

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

    public void copy(SimpleStack<? super V> target) {
        for(Node n = top; n != null; n = n.below)
            target.push(n.element);
    }

}

