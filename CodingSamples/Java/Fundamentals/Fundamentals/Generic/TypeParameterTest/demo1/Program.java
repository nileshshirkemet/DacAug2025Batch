class Program {

    private static String select(int choice, String first, String second) {
        if((choice % 2) == 1)
            return first;
        return second;
    }

    private static double select(int choice, double first, double second) {
        if((choice % 2) == 1)
            return first;
        return second;
    }

    public static void main(String[] args) {
        if(args.length > 0){
            int s = Integer.parseInt(args[0]);
            String ss = select(s, "Monday", "Tuesday");
            System.out.printf("Selected String = %s%n", ss);
            double sd = select(s, 9.75, 8.25);
            System.out.printf("Selected double = %s%n", sd);
            //select(s, 7.5, "Wednesday");
        }
    }
}
