package app.models;

public record ItemInfo(double cost, int stock) {
    
    public static ItemInfo parse(String text) {
        String[] segments = text.split("&");
        double p = Double.parseDouble(segments[0].substring(5));
        int n = Integer.parseInt(segments[1].substring(6));
        return new ItemInfo(p, n);
    }
}
