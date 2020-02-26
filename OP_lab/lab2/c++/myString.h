//
// Created by maxim on 22.02.2020.
//

#ifndef LAB_2_OP_MYSTRING_H
#define LAB_2_OP_MYSTRING_H

#include <iostream>
#include <ostream>

class myString {
private:
    char *str{};
    int size;
    void initialization(char *);
public:
    myString();
    explicit myString(char *);
    myString(const myString &);
    void replace(char *);
    void replace(const myString &);
    void push_back(char *);
    void push_back(const myString &);
    void push_back(char);
    myString return_numbers();
    myString &operator =(const myString &);
    friend std::ostream &operator <<(std::ostream &, const myString &);
    friend class Text;
    int get_size() const;
    ~myString();
};


#endif //LAB_2_OP_MYSTRING_H
