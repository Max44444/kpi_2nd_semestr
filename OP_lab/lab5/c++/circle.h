//
// Created by maxim on 25.03.2020.
//

#ifndef LAB_5_OP_TASK_2_CIRCLE_H
#define LAB_5_OP_TASK_2_CIRCLE_H


#include "Figure.h"
#define PI 3.14159265359

class circle : public Figure {
public:
    circle(Coord c, double r);
    double perimeter() override;
    double area() override;
private:
    Coord center;
    double radius;
};


#endif //LAB_5_OP_TASK_2_CIRCLE_H
