//
// Created by maxim on 25.03.2020.
//

#include "square.h"

square::square(Coord c1, Coord c2) : tops{c1, c2}{
}

double square::perimeter() {
    return 4.0 * sqrt(this->area());
}

double square::area() {
    return (pow(tops[0].first - tops[1].first, 2) +
            pow(tops[0].second - tops[1].second, 2)) / 2.0;
}
