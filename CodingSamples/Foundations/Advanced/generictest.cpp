#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main(void)
{
    //std::vector<T> is sequential container implemented as an array-list
    vector<int> a;
    a.push_back(451);
    a.push_back(712);
    a.push_back(563);
    a.push_back(204);
    a.push_back(945);
    a.push_back(326);
    a.push_back(857);
    cout << "Original integers in the vector" << endl;
    a.push_back(378);
    for(int i = 0; i < a.size(); ++i)
        cout << a.at(i) << endl;
    //a container exposes standard iterator through begin() and end() methods
    sort(a.begin(), a.end()); //generic algorithm to sort items in container using iterator
    cout << "---------------------------" << endl;
    cout << "Sorted integers in the vector" << endl;
    //a standard iterator overloads !=, ++ and * operators
    for(auto i = a.begin(); i != a.end(); ++i)
        cout << *i << endl;
}