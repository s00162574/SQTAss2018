using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQTesting.Models
{
    public class Calculator
    {
        public float CalcPremium(int age, string gender)
        {
            float premium;

            if (gender == "female")//a
                if ((age >= 18) && (age <= 30))//b
                    premium = 5.0f;//c
                else
                    if (age >= 31)//d
                        premium = 2.50f;//e
                    else
                        premium = 0.0f;//f
            else 
                if (gender == "male")//g
                    if ((age >= 18) && (age <= 35))//h
                        premium = 6.0f;//i
                    else
                        if (age >= 36)//j
                            premium = 5.0f;//k
                        else
                    premium = 0.0f;//l
            else
               premium = 0.0f;//m

            if (age >= 50)//n
                premium = premium * 0.15f;//o
            return premium;//p
        }

    }
}