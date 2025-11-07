import java.util.*;

class Program {

    public static void main(String[] args) {
        if(args.length == 0){
            //Collection<Interval> store = new ArrayList<>();
            //Collection<Interval> store = new LinkedList<>();
            //Collection<Interval> store = new HashSet<>();
            Collection<Interval> store = new TreeSet<>();
            store.add(new Interval(4, 31));
            store.add(new Interval(7, 42));
            store.add(new Interval(6, 13));
            store.add(new Interval(3, 24));
            store.add(new Interval(5, 25));
            store.add(new Interval(2, 84));
            for(var entry : store)
                System.out.println(entry);
        }else{
            //Map<String, Interval> store = new HashMap<>();
            Map<String, Interval> store = new TreeMap<>();
            store.put("monday", new Interval(4, 31));
            store.put("tuesday", new Interval(7, 42));
            store.put("wednesday", new Interval(6, 13));
            store.put("thursday", new Interval(3, 24));
            store.put("friday", new Interval(5, 25));
            store.put("thursday", new Interval(2, 24));
            Interval val = store.get(args[0]);
            if(val != null)
                System.out.printf("Interval = %s%n", val);
            else{
                for(var entry : store.entrySet()){
                    System.out.printf("%-12s%8s%n", entry.getKey(), entry.getValue());
                }
            }
        }
    }
}