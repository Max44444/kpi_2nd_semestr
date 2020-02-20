#include "header.h"

void sum(int a, int b, int &res){
    int n1 = a, n2 = b;
    while(n2 != 0){
        n1 = -~n1;
        n2 = ~-n2;
    }
    res = n1;
}
bool RelationshipOperator(int a, int b){
    return (a^b) == 0;
}
