//
// Created by maxim on 25.03.2020.
//

#ifndef LAB_5_OP_TASK_2_FIGURE_H
#define LAB_5_OP_TASK_2_FIGURE_H

#include <map>
#include <utility>
#include <cmath>

typedef std::pair<double, double> Coord;
class Figure {
public:
    virtual double perimeter() = 0;
    virtual double area() = 0;
};

#endif //LAB_5_OP_TASK_2_FIGURE_H
