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

void myString::replace(char *other) {
    delete [] this->str;
    initialization(other);
}

void myString::initialization(char *other) {
    size = strlen(other);
    this->str = new char[size + 1];
    for (int i = 0; i < size; ++i) {
        this->str[i] = other[i];
    }
    this->str[size] = '\0';
}

void myString::replace(const myString &other) {
    delete[] this->str;
    initialization(other.str);
}

void myString::push_back(char *other) {
    int len = size + strlen(other) + 1;
    char *tmp = new char[len];
    for (int i = 0; i < len; ++i) {
        tmp[i] = i < size ? this->str[i] : other[i - size];
    }
    size = len - 1;
    tmp[size] = '\0';
    delete[] this->str;
    this->str = tmp;
}

void myString::push_back(const myString &other) {
    push_back(other.str);
}

void myString::push_back(char ch) {
    char *tmp = new char[size + 2];
    for (int i = 0; i < size; ++i) {
        tmp[i] = str[i];
    }
    tmp[size] = ch;
    tmp[++size] = '\0';
    delete[] str;
    str = tmp;
}

myString myString::return_numbers() {
    int index = 0;
    char *tmp = new char[size];
    for (int i = 0; i < size; ++i) {
        if(isdigit(str[i])){
            tmp[index] = str[i];
            ++index;
        }
    }
    tmp[index] = '\0';
    myString strt(tmp);
    delete [] tmp;
    return strt;
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
int myString::get_size() const {
    return size;
}
