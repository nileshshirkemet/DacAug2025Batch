import java.util.Date;

import common.SimpleStack;

class Program {

    //private static void printStack(SimpleStack<? extends Object> store)
    private static void printStack(SimpleStack<?> store) {
        while(!store.empty())
            System.out.println(store.pop());
    }

    public static void main(String[] args) {
        SimpleStack<String> a = new SimpleStack<String>();
        a.push("Monday");
        a.push("Tuesday");
        a.push("Wednesday");
        a.push("Thursday");
        a.push("Friday");
        printStack(a);
        System.out.println("--------------");
        SimpleStack<Interval> b = new SimpleStack<>(); 
        b.push(new Interval(4, 31));
        b.push(new Interval(7, 42));
        b.push(new Interval(5, 13));
        b.push(new Interval(3, 24));
        SimpleStack<Object> c = new SimpleStack<>();
        c.push(2.15);
        c.push(new Date());
        b.copy(c);
        printStack(b);
        System.out.println("--------------");
        printStack(c);
    }
}
