#pragma once
#ifndef MILLER_MIDTERM_MENUERROR_H
#define MILLER_MIDTERM_MENUERROR_H


// Custom exception class to be thrown when menu selection is out of range
class MenuError : public std::exception {
private:
    // Store message as string to avoid memory leaks
    std::string errMessage;
public:
    // Default constructor
    explicit MenuError() {}
    // Constructor takes error message as parameter
    explicit MenuError(const std::string& errMessage) : errMessage(errMessage) {}
    // overridden function can be called through reference to exception superclass
    const char* what() const noexcept override {
        return errMessage.c_str();
    }
};


#endif //MILLER_MIDTERM_MENUERROR_H