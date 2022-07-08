#pragma once

#ifndef MILLER_ASSIGNMENT9_FILINGSTATUS_H
#define MILLER_ASSIGNMENT9_FILINGSTATUS_H

// Specifies the filer's tax filing status
enum class FilingStatus {
    Single,
    Jointly,
    HeadOfHousehold
};

// Array of strings for each filing status enum
static const char* status_str[] = { "Single", "Jointly", "Head of household" };

#endif //MILLER_ASSIGNMENT9_FILINGSTATUS_H