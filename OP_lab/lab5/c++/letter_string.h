//
// Created by maxim on 24.03.2020.
//

#ifndef LAB_5_OP_LETTER_STRING_H
#define LAB_5_OP_LETTER_STRING_H


#include "myString.h"

class letter_string : public myString {
public:
    letter_string() = default;
    explicit letter_string(char *str) : myString(str){};
    letter_string(const letter_string &str) : myString(str){}

    void row_offset();
    char* get_string();

    ~letter_string() = default;
};


#endif //LAB_5_OP_LETTER_STRING_H
