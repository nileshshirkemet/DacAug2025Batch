#include <iostream>
#include <vector>
#include <set>
#include <algorithm>
using namespace std;

//unary predicate defined as a function
bool IsOdd(int n)
{
    return n % 2;
}

//unary predicated defined as a functor
class IsBiggerThan
{
public:
    IsBiggerThan(int size) : limit(size) {}

    bool operator()(const string& target) const
    {
        return target.size() > limit;
    }
private:
    int limit;
};

int main(void)
{
    vector<int> a;
    a.push_back(451);
    a.push_back(712);
    a.push_back(563);
    a.push_back(204);
    a.push_back(945);
    a.push_back(326);
    a.push_back(857);
    a.push_back(378);
    cout << "Sorted integers in the vector" << endl;
    sort(a.begin(), a.end()); //requires random-access iterator that supports [] operator
    for(int i = 0; i < a.size(); ++i)
        cout << a.at(i) << endl;
    cout << "Number of odd integers = "
         << count_if(a.begin(), a.end(), IsOdd) //third argument must be a callable-object (supports () operator) with one argument
         << endl;
    set<string> b;
    b.insert("Sunday");
    b.insert("Monday");
    b.insert("Tuesday");
    b.insert("Wednesday");
    b.insert("Thursday");
    b.insert("Friday");
    b.insert("Saturday");
    cout << "---------------------------------" << endl;
    cout << "Original strings in the set" << endl;
    for(set<string>::iterator i = b.begin(); i != b.end(); ++i)
    {
        cout << *i << endl;
    }
    int m;
    cout << "Minimum Length: ";
    cin >> m;
    cout << "Number of big strings = "
         << count_if(b.begin(), b.end(), IsBiggerThan(m)) 
         << endl;
}
