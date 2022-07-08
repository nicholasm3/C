#pragma once
#ifndef MILLER_ASSIGNMENT9_DEDUCTION_H
#define MILLER_ASSIGNMENT9_DEDUCTION_H

#include <string>

// Abstract superclass for standard and itemized deduction classes
class Deduction {
public:
    // virtual function with default implementation
    virtual std::string getDeductionType();
    // Pure virtual function that must be overridden
    // returns the calculated deduction amount
    virtual double calcDeduction() = 0;
    virtual ~Deduction();
};


#endif //MILLER_ASSIGNMENT9_DEDUCTION_H