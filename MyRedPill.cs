using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using knockknock.readify.net;

namespace KnockKnockReadify
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [DataContract]
    public class MyRedPill : IRedPill
    {
        public long FibonacciNumber(long n)
        {
            long a = 0;
            long b = 1;
            long temp = 0;

            if (n == 0)
            {
                return 0;
            }
            else if (n < 0)
            {
                if (n < -92)
                {
                    throw new Exception("Number is too small!");
                }
                for (long i = 0; i>n; i--)
                {
                    temp = a;
                    a = b;
                    b = temp - b;
                }

            } else
            {
                if (n > 92)
                {
                    throw new Exception("Number is too large!");
                }
                for (long i = 0; i < n; i++)
                {
                    temp = a;
                    a = b;
                    b = temp + b;
                }

            }
            return a;
        }

        public string ReverseWords(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public Guid WhatIsYourToken()
        {
            return new Guid("87e89e2c-d368-4887-b2be-6ca91ec97fca");
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if (a >= b+c || b >= a+c || c >= a+b) //Cannot make a triangle
            {
                return TriangleType.Error;
            } else if (a < 1 || b < 1 || c < 1) //Invalid number input
            {
                return TriangleType.Error;
            } else if (a == b && b == c) //Equilateral
            {
                return TriangleType.Equilateral;
            } else if (a == b || b == c || a == c) //Isoceles
            {
                return TriangleType.Isosceles;
            } else //Scalene
            {
                return TriangleType.Scalene;
            }

        }
    }
}
