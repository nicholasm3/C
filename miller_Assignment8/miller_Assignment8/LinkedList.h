#pragma once


#ifndef MILLER_ASSIGNMENT8_LINKEDLIST_H
#define MILLER_ASSIGNMENT8_LINKEDLIST_H

#include "PersonNode.h"
#include <string>
using namespace std;

// This linked list represents a contact directory and includes
// operations to add and remove links
class LinkedList {
private:
    PersonNode* headPtr;
    PersonNode* tailPtr;
    PersonNode* findInsertSpot(string lName);
public:
    LinkedList();
    void addLink(PersonNode* person);
    PersonNode* getHeadPtr();
    PersonNode* getTailPtr();
    bool removePerson(string lName);
};


#endif //MILLER_ASSIGNMENT8_LINKEDLIST_H