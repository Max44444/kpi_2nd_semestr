#include <iostream>
#include <string>

using namespace std;

int lower_case_count(const string& str) {
    size_t counter(0);
    for (auto i : str) {
        if (i >= 'a' && i <= 'z')
            ++counter;
    }
    return counter;
}

void foo(int (*f)(const string&)){
    string str = "iehrj i3i99*U )( (80u9* *U_u49";
    cout << f(str) << endl;
}

int main()
{
    foo(lower_case_count);
    return 0;
}
