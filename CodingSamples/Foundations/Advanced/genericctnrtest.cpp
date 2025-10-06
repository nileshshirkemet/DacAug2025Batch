#include <iostream>
#include <vector>
#include <set>

using namespace std;

int main(void)
{
    //std::vector<T> is sequential container (implemented as an array-list)
    vector<int> a;
    a.push_back(451);
    a.push_back(712);
    a.push_back(563);
    a.push_back(204);
    a.push_back(945);
    a.push_back(326);
    a.push_back(857);
    a.push_back(378);
    cout << "Original integers in the vector" << endl;
    for(int i = 0; i < a.size(); ++i)
        cout << a.at(i) << endl;
    //std::set<T> is associative container (implemented as a binary-tree)
    //it can only be used for type T that supports == and < operators
    set<string> b;
    b.insert("Sunday");
    b.insert("Monday");
    b.insert("Tuesday");
    b.insert("Wednesday");
    b.insert("Thursday");
    b.insert("Friday");
    b.insert("Saturday");
    b.insert("Sunday");
    cout << "---------------------------------" << endl;
    cout << "Original strings in the set" << endl;
    //a container exposes a standard iterator which supports !=,
    //++ and * operators through its begin() and end() members
    for(set<string>::iterator i = b.begin(); i != b.end(); ++i)
    {
        cout << *i << endl;
    }
}
