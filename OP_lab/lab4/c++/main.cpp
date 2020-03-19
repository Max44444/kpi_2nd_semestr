#include <iostream>
#include "myString.h"

using namespace std;

int main() {
    myString str1("iuoenbhnoe");
    myString str2("iu ergtbh wetw");
    myString str3("iewrg engwjrti ");
    cout << "str1 : " << str1 << endl;
    cout << "str2 : " << str2 << endl;
    cout << "str3 : " << str3 << endl;
    cout << "==================" << endl;
    str3 = str3 * 2;
    cout << "str3 * 2 : " << str3 << endl;
    str1 = str2 + str3;
    cout << "str2 + str3 : " << str1 << endl;
    return 0;
}
