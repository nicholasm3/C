using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using static System.Console;

namespace Miller_FarmerGrainChicken
{
    enum Direction { NORTH, SOUTH };

    class Farmer
    {
        private List<string> northBank = new List<string>();        //ArrayList that stores the values for north
        private List<string> southBank = new List<string>();        //ArrayList that stores the values for south 
        private Direction farmer;                                   //Direction enum thats holds farmer location

        
        public List<string> NorthBank
        {
            get { return northBank; }
            set { northBank = value; }
        }

        
        public List<string> SouthBank
        {
            get { return southBank; }
            set { northBank = value; }
        }

        
        public Direction TheFarmer
        {
            get { return farmer; }
            set { farmer = value; }
        }

        
        public Farmer()
        {
            northBank.Add("FOX");
            northBank.Add("CHICKEN");
            northBank.Add("GRAIN");

            farmer = Direction.NORTH;
        }

        //Method to determine if the animal will eat
        
        public int AnimalAteFood()
        {
            int tempInt = 0;

            if (farmer == Direction.NORTH && southBank.Count > 1)
            {
                for (int i = 0; i < southBank.Count; i++)
                {
                    if (southBank[i] == "FOX")
                    {
                        tempInt += 1;
                    }
                    if (southBank[i] == "CHICKEN")
                    {
                        tempInt += 3;
                    }
                    if (southBank[i] == "GRAIN")
                    {
                        tempInt += 5;
                    }
                }
            }
            else if (farmer == Direction.SOUTH && northBank.Count > 1)
            {
                for (int i = 0; i < northBank.Count; i++)
                {
                    if (northBank[i] == "FOX")
                    {
                        tempInt += 1;
                    }
                    if (northBank[i] == "CHICKEN")
                    {
                        tempInt += 3;
                    }
                    if (northBank[i] == "GRAIN")
                    {
                        tempInt += 5;
                    }
                }
            }

            if (DetermineWin())
            {
                return 1;
            }
            else if (tempInt == 4 || tempInt == 8)
            {
                return tempInt;
            }
            else if (farmer == Direction.SOUTH && northBank.Count == 3 && tempInt == 9)
            {
                return 4;
            }
            else
            {
                return 0;
            }

        }

        //Method to determine who wins the game
        
        public bool DetermineWin()
        {
            int tempInt = 0;

            for (int i = 0; i < southBank.Count; i++)
            {
                if (southBank[i] == "FOX")
                {
                    tempInt += 1;
                }
                if (southBank[i] == "CHICKEN")
                {
                    tempInt += 3;
                }
                if (southBank[i] == "GRAIN")
                {
                    tempInt += 5;
                }
            }

            if (tempInt == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method that accepts a string and then determines where to move
        public int Move(string value)
        {
            int tempInt;

            if (value == "")
            {
                if (farmer == Direction.NORTH)
                {
                    farmer = Direction.SOUTH;
                }
                else if (farmer == Direction.SOUTH)
                {
                    farmer = Direction.NORTH;
                }
            }
            else if (farmer == Direction.NORTH)
            {
                northBank.Remove(value.ToUpper());
                southBank.Add(value.ToUpper());

                farmer = Direction.SOUTH;
            }
            else if (farmer == Direction.SOUTH)
            {
                southBank.Remove(value.ToUpper());
                northBank.Add(value.ToUpper());

                farmer = Direction.NORTH;
            }

            tempInt = AnimalAteFood();
            if (tempInt > 0)
            {
                northBank.Clear();
                southBank.Clear();

                farmer = Direction.NORTH;

                northBank.Add("FOX");
                northBank.Add("CHICKEN");
                northBank.Add("GRAIN");
            }
            return tempInt;


        }
    }
}