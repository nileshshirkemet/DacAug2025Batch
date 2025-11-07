import common.SimpleStack;

class Program {

    public static void main(String[] args) {
        SimpleStack<String> a = new SimpleStack<String>();
        a.push("Monday");
        a.push("Tuesday");
        a.push("Wednesday");
        a.push("Thursday");
        a.push("Friday");
        for(var i = a.iterator(); i.hasNext();)
            System.out.println(i.next());
        System.out.println("--------------");
        while(!a.empty())
            System.out.println(a.pop());
        System.out.println("--------------");
        SimpleStack<Double> b = new SimpleStack<>(); 
        b.push(4.31);
        b.push(7.42);
        b.push(5.13);
        b.push(3.24);
        for(double d : b)
            System.out.println(d);
    }
}
