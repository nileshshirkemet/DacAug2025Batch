class Program {

    private static void presentRecord(Record info) {
        Class<?> c = info.getClass();
        System.out.printf("<%s>%n", c.getSimpleName());
        try{
            for(var m : c.getRecordComponents()){
                String element = m.getName();
                Object value = m.getAccessor().invoke(info);
                System.out.printf("  <%1$s>%2$s</%1$s>%n", element, value);
            }
        }catch(Exception e){}
        System.out.printf("</%s>%n", c.getSimpleName());
        System.out.println();
    }

    public static void main(String[] args) {
        Item a = Shop.popularItem();
        presentRecord(a);
        Customer b = Shop.bestCustomer();
        presentRecord(b);
    }
}
