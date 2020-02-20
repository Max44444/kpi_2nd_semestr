#include "header.h"
#include <iostream>

using namespace std;

int main() {
  int a, b;
  cin >> a >> b;
  cout << RelationshipOperator(a, b) << endl;
  int res;
  sum(a, b, res);
  cout << res << endl;
  return 0;
}
