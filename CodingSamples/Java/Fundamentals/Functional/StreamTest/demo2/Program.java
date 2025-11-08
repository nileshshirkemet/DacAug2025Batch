import java.nio.file.Files;
import java.nio.file.Path;
import java.util.List;
import java.util.stream.Collectors;

class Program {

    public static void main(String[] args) throws Exception {
        
        //inner local class
        class Supplier {

            final String name;
            final String item;
            final int quantity;

            Supplier(String row){
                String[] columns = row.split(",");
                name = columns[0];
                item = columns[1];
                quantity = Integer.parseInt(columns[2]);
            }
        }

        var doc = Path.of("suppliers.csv");
        List<Supplier> suppliers = Files.readAllLines(doc).stream()
            .skip(1)
            .map(Supplier::new) //passing method reference to constructor
            .collect(Collectors.toList());
        if(args.length == 0){
            suppliers.stream()
                .sorted((a, b) -> b.quantity - a.quantity)
                .forEach(s -> System.out.printf("%-12s%-12s%8d%n", s.name, s.item, s.quantity));
        }else{
            int total = suppliers.stream()
                .filter(s -> s.item.equals(args[0]))
                .mapToInt(s -> s.quantity)
                .sum();
            System.out.printf("Total supply for %s is %d%n", args[0], total);
        }

    }
}
