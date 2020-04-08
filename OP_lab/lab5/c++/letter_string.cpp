//
// Created by maxim on 24.03.2020.
//

#include "letter_string.h"

void letter_string::row_offset() {
    if(this->size == 0) return;
    char tmp = this->str[size-1];
    for (int i = this->size - 1; i > 0; --i) {
        str[i] = str[i-1];
    }
    str[0] = tmp;
}

char *letter_string::get_string() {
    auto* tmp = new char[this->size];
    for (int i = 0; i < this->size; ++i) {
        tmp[i] = this->str[i];
    }
    return tmp;
}
