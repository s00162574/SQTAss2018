﻿using System;
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
                    premium = 5.0f;
                else//c
                    if (age >= 31)//d
                        premium = 2.50f;
                    else//e
                        premium = 0.0f;
            else //f
                if (gender == "male")//g
                    if ((age >= 18) && (age <= 35))//h
                        premium = 6.0f;
                    else//i
                        if (age >= 36)//j
                            premium = 5.0f;
                        else//k
                    premium = 0.0f;
            else//l
                premium = 0.0f;

            if (age >= 50)//m
                premium = premium * 0.15f;
            return premium;//n
        }

    }
}