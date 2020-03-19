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
    std::size_t size;
    void initialization(char *);
public:
    myString();
    explicit myString(char *);
    myString(const myString &);
    myString &operator =(const myString &);
    friend std::ostream &operator <<(std::ostream &, const myString &);

    myString operator*(int n) const;
    myString operator+(const myString &) const;

    std::size_t get_size() const;
    ~myString();
};


#endif //LAB_2_OP_MYSTRING_H
