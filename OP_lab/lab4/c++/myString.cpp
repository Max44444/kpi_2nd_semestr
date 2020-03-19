//
// Created by maxim on 22.02.2020.
//

#include <cstring>
#include "myString.h"

myString::myString() : size{0} {
    str = new char[0];
}

myString::myString(char *str) {
    initialization(str);
}

myString::myString(const myString & other) {
    initialization(other.str);
}

myString::~myString() {
    delete [] str;
}

std::ostream &operator<<(std::ostream &out, const myString &str) {
    out << str.str;
    return out;
}

void myString::initialization(char *other) {
    size = strlen(other);
    this->str = new char[size + 1];
    for (int i = 0; i < size; ++i) {
        this->str[i] = other[i];
    }
    this->str[size] = '\0';
}

myString &myString::operator=(const myString &other) {
    this->size = other.get_size();
    if(this->str != nullptr)
        delete[] this->str;
    this->str = new char[size + 1];
    for (int i = 0; i < size + 1; ++i) {
        this->str[i] = other.str[i];
    }
    return *this;
}
std::size_t myString::get_size() const {
    return size;
}

myString myString::operator*(int n) const{
    if(size == 0) return myString(str);
    std::size_t len{size * n};
    char *tmp = new char[len];
    for (int i = 0; i < len; ++i) {
        tmp[i] = str[i % size];
    }
    return myString(tmp);
}

myString myString::operator+(const myString &other) const {
    std::size_t len = this->size + other.size;
    char *tmp = new char[len];
    for (int i = 0; i < this->size; ++i) {
        tmp[i] = this->str[i];
    }
    for (int i = this->size; i < len; ++i) {
        tmp[i] = other.str[i - this->size];
    }
    return myString(tmp);
}
