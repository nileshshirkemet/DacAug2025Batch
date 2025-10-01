#include <cstdio>

class Interval
{
public:
    Interval(int m = 0, int s = 0)
    {
        min = m + s / 60;
        sec = s % 60;
        id = ++nid;
        printf("Interval<%d> instance initialized\n", id); //side effect
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

    //member function represents an instance method, it must
    //be called on an object using . operator and as such it
    //receives 'this' argument which points to the instance
    //refered by the object on the left of . operator
    void Print() const
    {
        printf("Interval<%d> = %hd:%02hd\n", id, min, sec);
    }

    //static member function represents a class method, it can 
    //be called directly on the class using :: operator and as
    //such it does not receive 'this' argument so it can only
    //refer to other static members
    static int Count()
    {
        return nid;
    }

    //destructor - a member function which is automatically called 
    //on an instance just before it is removed from memory or in
    //case of a stack based instance as soon as its identifer
    //goes out of scope, it is commonly defined to reverse any
    //side-effect caused by constructors
    ~Interval()
    {
        printf("Interval<%d> instance finalized\n", id); //reversing side effect
    }
private:
    short min, sec;
    int id;
    //a static member variable represents a class field whose value
    //is shared by all the instances of that class
    static int nid;
};

//allocating memory for an int type value identified by
//a static member variable nid of Interval class
int Interval::nid = 0; 



