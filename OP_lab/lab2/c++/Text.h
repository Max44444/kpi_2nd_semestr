//
// Created by maxim on 24.02.2020.
//

#ifndef LAB_2_OP_TEXT_H
#define LAB_2_OP_TEXT_H

#include "myString.h"

class Text {
private:
    myString *text;
    int capasity, quantity;
    void resize(int);
public:
    Text();
    void print();
    int get_quantity();
    void push_back(char *);
    void push_back(const myString &);
    void erase(int);
    void replace(int, char *);
    void replace(int, const myString &);
    void clear();
    myString &at(int index);
    myString return_numbers();
    ~Text();
};


#endif //LAB_2_OP_TEXT_H
