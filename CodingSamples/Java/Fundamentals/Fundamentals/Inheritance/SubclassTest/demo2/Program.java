class Program {

    private static void print(String name, Object val) {
        System.out.printf("%s = %s%n", name, val.toString());
    }

    private static boolean checkIdentity(Object x, Object y) {
        return x == y;
    }

    private static boolean checkEquality(Object x, Object y) {
        return x.hashCode() == y.hashCode() && x.equals(y);
    }

    public static void main(String[] args) {
        Interval a = new Interval(4, 15);
        Interval b = new Interval(6, 5);
        Interval c = new Interval(3, 75);
        Interval d = b;
        print("Interval a", a);
        print("Interval b", b);
        print("Interval c", c);
        print("Interval d", d);
        System.out.println("--------------------------------");
        System.out.printf("a is identical to b: %b%n", checkIdentity(a, b));
        System.out.printf("a is identical to c: %b%n", checkIdentity(a, c));
        System.out.printf("d is identical to b: %b%n", checkIdentity(d, b));
        System.out.println("--------------------------------");
        System.out.printf("a is equal to b: %b%n", checkEquality(a, b));
        System.out.printf("a is equal to c: %b%n", checkEquality(a, c));
        System.out.printf("d is equal to b: %b%n", checkEquality(d, b));
    }
}
