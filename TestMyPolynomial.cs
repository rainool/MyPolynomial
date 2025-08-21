namespace polynomial
{
    internal class TestMyPolynomial
    {
        static void Main(string[] args)
        {

            //Predefine each polynomial by using an array indexed to the polynomial variable length, including constant variables
            //eg. For a quadratic x^2 + x + 1, create an array with size 3
            
            double[] arr = new double[3];
            arr[0] = 1; //constant
            arr[1] = 2; // x
            arr[2] = -3; // i = n-th degree

            double[] arr1 = new double[4];
            arr1[0] = 1; //constant
            arr1[1] = 2; // x
            arr1[2] = 3; // i = n-th degree
            arr1[3] = -4;
            

            try
            {
                MyPolynomial poly1 = new MyPolynomial(arr); 
                MyPolynomial poly2 = new MyPolynomial(arr1); 

                //To operate on the polynomials, take the object name (poly1, poly2), and add the method onto the end (poly1.Add()) and put it into the try-catch block, as there is built in error handling.

            }
            catch (ArgumentException exception)
            {
                Console.WriteLine("The following error detected: " 
                    + exception.GetType().ToString() + " with message \"" + exception.Message + "\"");
            }

            Console.WriteLine("Polynomial 1 Nth-Degree: " + poly1.GetDegree() + "\n");
            //Expected result: 2

            Console.WriteLine("Polynomial 1: " + poly1.ToString() + "\n");
            //Expected result: -3x^2 + 2x + 1

            Console.WriteLine("Polynomial 2: " + poly2.ToString() + "\n");
            //Expected result: -4x^3 + 3x^2 + 2x + 1

            Console.WriteLine("Evaluate Polynomial1(2): " + poly1.Evaluate(2) + "\n");
            //Expected result: f(2) = -7

            Console.WriteLine("Add: (-3x^2 + 2x + 1) + (-4x^3 + 3x^2 + 2x + 1): " + poly1.Add(poly2) + "\n");
            //Expected result: -4x ^ 3 + 4x + 2

            Console.WriteLine("Multiply: (-3x^2 + 2x + 1) * (-4x^3 + 3x^2 + 2x + 1): " + poly1.Multiply(poly2) + "\n");
            //Expected result: 12x^5 - 17x^4 - 4x^3 + 4x^2 + 4x + 1

        }
    }
}


