//class with primary constructoi
class Interval(int min, int sec)
{
    public int Minutes { get; set; } = min + sec / 60;

    public int Seconds { get; set; } = sec % 60;

    public int Time()
    {
        return 60 * Minutes + Seconds;
    }

    //overriding ToString() method of System.Object (implicit base)
    //to return string representation of state of the instance
    //referred by this object
    public override string ToString()
    {
        if(Seconds < 10)
            return Minutes + ":0" + Seconds;
        return Minutes + ":" + Seconds;   
    }

    public override int GetHashCode()
    {
        return Minutes + Seconds;
    }

    public override bool Equals(object other)
    {
        if(other is Interval)
        {
            Interval that = (Interval)other; //explicit down-casting
            return Minutes == that.Minutes && Seconds == that.Seconds;
        }
        return false;
    }

    //overloading + operator
    public static Interval operator+(Interval lhs, Interval rhs)
    {
        return new Interval(lhs.Minutes + rhs.Minutes, lhs.Seconds + rhs.Seconds);
    }

}