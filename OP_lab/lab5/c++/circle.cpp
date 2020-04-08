//
// Created by maxim on 25.03.2020.
//

#include "circle.h"
#include <iostream>

circle::circle(Coord c, double r) : center{std::move(c)}, radius{r}
{}

double circle::perimeter() {
    return PI * 2.0 * radius;
}

double circle::area() {
    return PI * pow(radius, 2);
}
