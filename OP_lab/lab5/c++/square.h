//
// Created by maxim on 25.03.2020.
//

#ifndef LAB_5_OP_TASK_2_SQUARE_H
#define LAB_5_OP_TASK_2_SQUARE_H


#include "Figure.h"

class square : public Figure {
public:
    // Для того щоб задати квадрат достатньо 2 протилежні вершини
    explicit square(Coord c1, Coord c2);
    double perimeter() override;
    double area() override ;
private:
    Coord tops[2];
};


#endif //LAB_5_OP_TASK_2_SQUARE_H
