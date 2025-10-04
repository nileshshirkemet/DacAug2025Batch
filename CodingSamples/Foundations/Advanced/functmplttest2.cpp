#include <iostream>

using namespace std;

template<typename Any>
Any Select(Any first, Any second)
{
    if(first > second)
        return first;
    return second;
}

template<> //explicit specialization of Select function template for Any=string
string Select(string first, string second)
{
    if(first.size() > second.size())
        return first;
    return second;
}

int main(void)
{
    double d1 = 4.56, d2 = 6.54;
    cout << "Selected double value = "
         << Select(d1, d2) //Select<double>(d1, d2) - type deduction from arguments
         << endl;
    string s1 = "Saturday", s2 = "Sunday";

    cout << "Selected string value = "
         << Select(s1, s2)  //specialized Select will be called
         << endl;
}