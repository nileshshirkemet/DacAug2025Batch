#include <iostream>

class Interval
{
public:
    Interval(int m = 0, int s = 0)
    {
        min = m + s / 60;
        sec = s % 60;
        id = ++nid;
    }

    Interval(const Interval& other)
    {
        min = other.min;
        sec = other.sec;
        id = ++nid;
    }

    long Time() const
    {
       return 60 * min + sec; 
    }

    void Adjust(long t)
    {
        min = t / 60;
        sec = t % 60;
    }

    Interval operator+(const Interval& rhs) const
    {
        return Interval(min + rhs.min, sec + rhs.sec);
    }

    static int Count()
    {
        return nid;
    }

private:
    short min, sec;
    int id;
    static int nid;

    //A function declared with friend key-word in a class is a non-member 
    //function of that class but it has access to the private members
    //of that class (because it is defined by the class author)
    friend std::ostream& operator<<(std::ostream& out, const Interval& val);
};

int Interval::nid = 0; 

std::ostream& operator<<(std::ostream& out, const Interval& val)
{
    if(val.sec < 10)
        out << val.min << ":0" << val.sec;
    else
        out << val.min << ":" << val.sec;
    return out;
}

