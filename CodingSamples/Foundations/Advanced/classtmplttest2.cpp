#include "interval.h"
#include <iostream>
#include <string>

using namespace std;

template<typename Key, typename Value>
class Binder
{
public:
    Binder(Key key) : first(key) {}

    void Bind(Value value)
    {
        second = value;
    }

    void Print() const
    {
        cout << "(" << first << ") => " << second << endl;
    }
private:
    Key first;
    Value second;
};

template<typename Key>
class Binder<Key, bool> //partial specialization of Binder class template for Value=bool
{
public:
    Binder(Key key) : first(key) {}

    void Bind(bool value)
    {
        second = value;
    }

    void Print() const
    {
        cout << "(" << first << ") => " << (second ? "yes" : "no") << endl;
    }
private:
    Key first;
    bool second;
};

template<>
class Binder<int, string> //full specialization of Binder class template for Key=int and Value=string
{
public:
    Binder()
    {
        //static local variable retains its value across function calls
        static int count = 0;
        first = ++count;
    }

    void Bind(const string& value)
    {
        second = value;
    }

    void Print() const
    {
        cout << "[" << first << "] => " << second << endl;
    }

private:
    int first;
    string second;
};

int main(void)
{
    Binder<string, double> a("Jack");
    a.Bind(72.5);
    a.Print();

    Binder<int, Interval> b(23);
    b.Bind(Interval(3, 65));
    b.Print();

    Binder<string, bool> c("Monday"); //using partial specialization of Binder class template
    c.Bind(true);
    c.Print();

    Binder<int, string> d; //using full specialization of Binder class template
    d.Bind("January");
    d.Print();

    Binder<int, string> e;
    e.Bind("February");
    e.Print();
}