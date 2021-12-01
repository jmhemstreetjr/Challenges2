// LeapYear.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

bool leapYear(int year);

int main()
{
    int year = 0;

    std::cout << "Enter a year any year: ";
    std::cin >> year;



    if (leapYear(year))
    {
        std::cout << year <<" is a leap year." << std::endl;

    }
    else
    {
        std::cout << "Nope. Not a leap year." << std::endl;
    }

    return 0;
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//leapYear() -> figures out if a particular yeaar is a leap year or not
//Paraaam: int year -> the yeaar we need to check
//Returns: bool -> true if the year in question is a leap year; false if it is not
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//These are the rules for a leap year:
//1)on every year that is evenly divisible by 4
//2)except every year that is evenly divisible by 100
//  2.1)unless the year is also evenly divisible by 400
bool leapYear(int year)
{
    //If the year is evenly divisible by 4, this MIGHT be a leap year. If not return false
    if ((year % 4) == 0)
    {
        
        //If the year is evenly divisible by 100, the year is MIGHT NOT a leap year
        if ((year % 100) == 0)
        {
            //Unless the year is evenly divisible by 400
            if ((year % 400) == 0)
            {
                return true;
            }

            return false;
        }

        //If the year is not evenly divisible by 100, the year is definitly a leap year
        return true;
    }
    else
    {
        return false;
    }
}

