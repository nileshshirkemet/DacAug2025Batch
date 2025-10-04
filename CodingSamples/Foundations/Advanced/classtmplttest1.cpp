#include <iostream>
#include <string>

using namespace std;

//Class Template - provides a general pattern for a class with one
//or more type-parameters from which actual classes can be obtained
//at compile-time by replacement of these type parameters
template<typename T> 
class Selector
{
public:
    Selector(T a, T b) : first(a), second(b) {}

    T Select(int choice) const
    {
        if(choice % 2)
            return first;
        return second;
    }
private:
    T first, second;
};

int main(void)
{
    int n;
    cout << "Selector: ";
    cin >> n;

    double d1 = 4.56, d2 = 6.54;
    Selector<double> sd(d1, d2); //Instantiating Selector class template with T=double
    cout << "Selected double value = "
         << sd.Select(n)
         << endl;

    string s1 = "Monday", s2 = "Sunday";
    Selector<string> ss(s1, s2);
    cout << "Selected string value = "
         << ss.Select(n)
         << endl;
}
