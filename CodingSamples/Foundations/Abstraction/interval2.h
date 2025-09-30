#include <cstdio>

class Interval
{
public:
    Interval(int m = 0, int s = 0)
    {
        min = m + s / 60;
        sec = s % 60;
        id = ++nid;
    }

    //copy constructor - used for initializing a new instance
    //as a copy of another instance
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

    void Print() const
    {
        printf("Interval<%d> = %hd:%02hd\n", id, min, sec);
    }

    //overloading addition operator
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
};

int Interval::nid = 0; 



