#include <iostream>
#include "Expression.h"
#include <array>

using namespace std;

int main() {
    srand(time(nullptr));
    array<Expression, 100> arr{};
    for(auto& el : arr){
        el.set_a(rand() % 199 - 99);
        el.set_b(rand() % 199 - 99);
        el.set_c(rand() % 199 - 99);
    }
    arr.back().set_b(42);
    arr.back().set_c(1);
    for(auto& el : arr){
        cout << el.get_result_of_expression() << endl;
    }
    return 0;
}
