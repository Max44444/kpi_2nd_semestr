#include <iostream>
#include "myString.h"
#include "Text.h"

int main() {
    Text txt;
    std::cout << txt.get_quantity() << std::endl;
    txt.push_back("1234qwertytrew");
    txt.push_back("qwertytr2q3rew");
    txt.push_back("qwerasdg232bhtytrew");
    txt.push_back("qwertytr223tew");
    txt.print();
    std::cout << "==================\n";
    txt.replace(1, "qs432w3wedr");
    txt.print();
    std::cout << "=========erase=========\n";
    txt.erase(2);
    txt.print();
    std::cout << "==================\n";
    std::cout << txt.get_quantity() << std::endl;
    std::cout << txt.return_numbers() << std::endl;
    txt.clear();
    txt.print();
    std::cout << "==================\n";
    return 0;
}
