//
// Created by maxim on 21.04.2020.
//

#include "Expression.h"

Expression::Expression(double a, double b, double c) : a(a), b(b), c(c) {
}

void Expression::set_a(double _a) {
    this->a = _a;
}

void Expression::set_b(double _b) {
    this->b = _b;
}

void Expression::set_c(double _c) {
    this->c = _c;
}

double Expression::get_result_of_expression() {
    try {
        expression();
    }
    catch (const std::exception& err){
        time_t t = time(nullptr);
        tm* time_info = localtime(&t);

        std::ofstream fout;
        fout.open("log.txt", std::ostream::app);

        fout << asctime(time_info) << "Error\t::\t" << err.what()
             << " {a, b, c} = {" << a << ", " << b << ", " << c << "}\n\n";
        
        fout.close();
        return NAN;
    }
    return expression();
}

double Expression::expression() {
    if(a*b <= 2)
        throw std::underflow_error("Underflow error\t::\tThe logarithm value is less than zero");
    if(c == 0)
        throw std::runtime_error("Runtime error\t::\tDivide by zero");
    if(b / c == 42)
        throw std::runtime_error("Runtime error\t::\tDivide by zero");
    return std::log(a * b + 2) * c / (41 - b / c + 1);
}
