#include <iostream>
#include <string>

using namespace std;

//Function Template - provides a general pattern for a function with
//one or more type-parameters from which actual functions can be 
//obtained at compile type by replacement of these type parameters
template<typename T>
T Select(int choice, T first, T second) //Select function template with T as type-parameter
{
    if(choice % 2)
        return first;
    return second;
}

int main(void)
{
    int n;
    cout << "Selector: ";
    cin >> n;

    double d1 = 4.56, d2 = 6.54;
    cout << "Selected double value = "
         << Select<double>(n, d1, d2) //templated Select function with T=double
         << endl;

    string s1 = "Monday", s2 = "Wednesday";
    cout << "Selected string value = "
         << Select<string>(n, s1, s2)
         << endl;
    //Select<double>(n, d1, s1);
}