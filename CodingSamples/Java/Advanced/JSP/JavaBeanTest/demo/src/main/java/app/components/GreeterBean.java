package app.components;

public class GreeterBean {
    
    private String person;

    private String period;

    private int greetCount;

    public final String getPerson() {
        return person;
    }

    public final void setPerson(String person) {
        this.person = person;
    }

    public final String getPeriod() {
        return period;
    }

    public final void setPeriod(String period) {
        this.period = period;
    }

    public final int getGreetCount() {
        return greetCount;
    }

    public synchronized String getMessage() {
        if(person == null)
            return "Hello Visitor";
        ++greetCount;
        return String.format("Good %s %s", period, person);
    }



}
