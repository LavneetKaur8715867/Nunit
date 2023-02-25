using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Student Name : Lavneet Kaur , Student id: 8715867
namespace Nunit 
{
    public static class Triangle
    {
       

            public static void Main(String[] args)
        { }
            public static string ValidTriangle(int firstAngle, int secondAngle, int
            thirdAngle)
            {
                string result;
                if ((firstAngle + secondAngle + thirdAngle) == 180)
                {
                    result = "The triangle is valid triangle."; 
                // Changed the result to "The triangle is valid triangle" from "The triangle is valid".
                }
                else
                {
                    result = "The triangle is NOT valid.";
                }
                return result;
            }
        }
    }
