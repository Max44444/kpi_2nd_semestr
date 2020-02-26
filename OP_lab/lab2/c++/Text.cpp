//
// Created by maxim on 24.02.2020.
//

#include "Text.h"

Text::Text() : quantity{0}, capasity{2} {
    text = new myString[capasity];
    for (int i = 0; i < capasity; ++i)
        text[i] = myString();
}

void Text::print() {
    for (int i = 0; i < quantity; ++i) {
        std::cout << text[i] << std::endl;
    }
}

int Text::get_quantity() {
    return quantity;
}

Text::~Text() {
    delete[] text;
}

void Text::resize(int value) {
    capasity = value + 2;
    auto *tmp = new myString[capasity];
    for (int i = 0; i < capasity; ++i) {
        tmp[i] = i < quantity ? myString(text[i]) : myString();
    }
    if(this->text != nullptr) {
        delete[] text;
    }
    text = tmp;
}

void Text::push_back(char *arr) {
    if(quantity == capasity)
        resize(quantity + 1);
    text[quantity] = myString(arr);
    ++quantity;
}

void Text::push_back(const myString &str) {
    push_back(str.str);
}

void Text::erase(int index) {
    for (int i = index; i < quantity; ++i) {
        text[i] = text[i + 1];
    }
    --quantity;
}

void Text::replace(int index, char *str) {
    text[index].replace(str);
}

void Text::replace(int index, const myString &str) {
    text[index].replace(str);
}

void Text::clear() {
    for (int i = 0; i < quantity; ++i) {
        text[i] = myString();
    }
    quantity = 0;
}

myString Text::return_numbers() {
    myString str;
    for (int i = 0; i < quantity; ++i) {
        str.push_back(text[i].return_numbers());
    }
    return str;
}

myString &Text::at(int index) {
    if(index < 0 || index >= quantity){
        throw "invalid index";
    }
    return text[index];
}
