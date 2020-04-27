//
// Created by maxim on 21.04.2020.
//

#ifndef LAB_6_OP_EXPRESSION_H
#define LAB_6_OP_EXPRESSION_H


#include <stdexcept>
#include <cmath>
#include <fstream>
#include <ctime>
#include <exception>

class Expression {
public:
    Expression() = default;
    explicit Expression(double a, double b, double c);
    void set_a(double _a);
    void set_b(double _b);
    void set_c(double _c);
    double get_result_of_expression();
private:
    double a, b, c;
    double expression();
};


#endif //LAB_6_OP_EXPRESSION_H
