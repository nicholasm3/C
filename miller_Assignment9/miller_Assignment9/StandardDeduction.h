#pragma once

#ifndef MILLER_ASSIGNMENT9_STANDARDDEDUCTION_H
#define MILLER_ASSIGNMENT9_STANDARDDEDUCTION_H

#include "Deduction.h"
#include "FilingStatus.h"


// Derived class representing a standard deduction
class StandardDeduction : public Deduction {
private:
    static const double single_filer;
    static const double head_of_household;
    static const double filing_jointly;
    FilingStatus filingStatus;

public:
    StandardDeduction(FilingStatus filingStatus);
    static const double getSingleFiler();
    static const double getHeadOfHousehold();
    static const double getFilingJointly();
    double calcDeduction() override;
    std::string getDeductionType() override;
    FilingStatus getFilingStatus() const;

};


#endif //MILLER_ASSIGNMENT9_STANDARDDEDUCTION_H