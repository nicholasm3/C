#pragma once
#ifndef MILLER_MIDTERM_FRESHPRODUCE_H
#define MILLER_MIDTERM_FRESHPRODUCE_H

#include "Item.h"

// The FreshProduce class inherits from Item.
// It is specialized to represent items whose price
// is calculated by weight
class FreshProduce : public Item {
private:
    int pounds = 0;
public:
    FreshProduce(string name, double price, int pounds);
    double calcFullPrice();
    int getPounds();
    void setPounds(int);
    int amount();
};


#endif //MILLER_MIDTERM_FRESHPRODUCE_H