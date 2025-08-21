using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polynomial
{
    internal class MyPolynomial
    {
        private double[] _coeffs;

        public MyPolynomial(double[] coeffs)
        {
            //Null or empty array validation
            if (coeffs == null || coeffs.Length == 0)
            {
                throw new ArgumentException("Coefficients cannot be null or empty");
            }
            _coeffs = new double[coeffs.Length];

            //array population
            for (int i = 0; i < coeffs.Length; i++)
            {
                _coeffs[i] = coeffs[i];
            }
        }

        public int GetDegree()
        {
            //Finds the degree by -1 from the amount of elements.
            //(ie. quadratic expression has 2 indeterminate and 1 constant, ax^2 + bx + c, hence the degree is 2)
            for (int i = _coeffs.Length - 1; i >= 0; i--)
            {
                if (_coeffs[i] != 0)
                {
                    return i;
                }
            }
            return 0;
        }

        public override string ToString()
        {
            var sb = new StringBuilder(); 
            int degree = GetDegree();
            bool firstTerm = true;

            for (int i = degree; i >= 0; i--) //starts from the variable with highest degree
            {
                double coef = _coeffs[i]; //coef = highest degree variables coefficient
                if (coef == 0) //if the coefficient is 0 ( 0x^n), then it skips to next lowest degree
                {
                    continue;
                }

                if (firstTerm)
                {
                    if (coef < 0) // checking for negative cooefficients
                    {
                        sb.Append("-");
                    }
                }
                else
                {
                    sb.Append(coef < 0 ? " - " : " + "); //appending negative or positive signs for each coefficient
                }
                
                //absolute coefficient. Multiplies negative coefficients with -1 to get
                //an absolute coefficient
                double absCoef = coef < 0 ? -coef : coef; 


                //Checks for the degree, x^0 = 1
                //If absolute = 1, then no variables with exponentials need to be attached
                if (absCoef != 1 || i == 0)
                {
                    sb.Append(absCoef);
                }

                //if absolute coefficient does have a degree, it attaches x, and then checks for the degree (i)
                //and attaches to coefficient with plaintext format (x^n)
                if (i > 0) 
                {
                    sb.Append("x");
                    
                    if (i > 1)
                    {
                        sb.Append("^" + i);
                    }
                }

                firstTerm = false;

            }
            //If polynomial has any length >= 1 (constant only or nth degree)
            //it will return the built string, else it will return a 0 (no constant or exponential variables
            return sb.Length > 0 ? sb.ToString() : "0"; 
        }

        public double Evaluate(double x)
        {
            //local exponentiation method to fit UML constraints
            double Power(double baseValue, int exponent)
            {
                double result = 1; //if degree = 0, x^0 = 1
                for(int i = 0; i < exponent; i++)
                {
                    result *= baseValue;
                }
                return result;
            }

            //substituting each x with the ith iteration (x = b, where b is some arbitrary value)
            double result = 0;
            for (int i = 0; i < _coeffs.Length; i++)
            {
                result += _coeffs[i] * Power(x, i);
            }
            return result;
        }

        public MyPolynomial Add(MyPolynomial another)
        {
            //checking which polynomial is longer. The longer polynomial will be the max length
            //after the sum of both polynomials
            int maxLen = _coeffs.Length > another._coeffs.Length ? _coeffs.Length : another._coeffs.Length;
            double[] result = new double[maxLen];

      
            for (int i = 0; i < maxLen; i++)
            {
                //if the iteration is higher than the maxLen (which dictates the highest degree in the addition system)
                //then it adds zero
                double a = i < _coeffs.Length ? _coeffs[i] : 0; 
                double b = i < another._coeffs.Length ? another._coeffs[i] : 0;
                result[i] = a + b;
            }
            return new MyPolynomial(result);
        }

        public MyPolynomial Multiply(MyPolynomial another)
        {
            int resultLen = _coeffs.Length + another._coeffs.Length - 1;
            double[] result = new double[resultLen];

            //takes each element in both polynomials, and multiplies by each other to get the product
            //of both polynomials
            for (int i = 0; i < _coeffs.Length; i++)
            {
                for (int j = 0; j < another._coeffs.Length; j++)
                {
                    result[i + j] += _coeffs[i] * another._coeffs[j];
                }
            }
            return new MyPolynomial(result);
        }

    }
}
