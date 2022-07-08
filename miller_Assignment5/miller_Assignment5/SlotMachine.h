#ifndef SLOTMACHINE_H
#define SLOTMACHINE_H
#include "Reel.h"


class SlotMachine {
private:
    static const int NUM_REELS = 3;
    Reel reels[NUM_REELS];

public:
    bool play();

};

#endif //SLOTMACHINE_H#pragma once
