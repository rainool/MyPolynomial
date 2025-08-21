# MyPolynomial

## Description

**MyPolynomial** is an object-oriented C# class designed to represent and operate on polynomials. The program applies fundamental principles of object-oriented programming, including encapsulation, validation, and method abstraction. Key techniques and design concepts used in this project:

- **Encapsulation:** The internal representation of polynomial coefficients is stored in a private array, preventing external modification and ensuring data integrity.
- **Constructor Validation:** The constructor checks for null or empty arrays to guarantee only valid polynomials are instantiated.
- **Indexed Coefficient Representation:** The polynomial is defined by an array, where each index corresponds to the coefficient of a particular degree (e.g., index 0 for the constant term, index 1 for x¹, etc.).
- **Method Abstraction:** Dedicated methods perform core polynomial operations:
  - `GetDegree()`: Determines the degree of the polynomial.
  - `ToString()`: Converts the polynomial to a readable mathematical string.
  - `Evaluate(double x)`: Evaluates the polynomial for a given value of x.
  - `Add(MyPolynomial another)`: Adds two polynomials.
  - `Multiply(MyPolynomial another)`: Multiplies two polynomials.
- **Efficient Operations:** Addition and multiplication are implemented to handle polynomials of different degrees, ensuring correct results regardless of input size.
- **Exception Handling:** Robust error detection for invalid input types.

The provided `TestMyPolynomial.cs` file demonstrates usage, including construction, arithmetic operations, evaluation, and formatted output.

---

## Instructions

Follow these steps to run the program in **Microsoft Visual Studio 2022**:

1. **Clone or Download the Repository**
   - Use Git or download as ZIP:
     ```
     git clone https://github.com/rainool/MyPolynomial.git
     ```

2. **Open in Visual Studio 2022**
   - Launch Visual Studio.
   - Go to `File` > `Open` > `Project/Solution`.
   - Navigate to the folder containing `MyPolynomial.cs` and `TestMyPolynomial.cs`.
   - Open the folder as a project, or create a new C# Console Application and add both files to the project.

3. **Add Source Files to Project**
   - Ensure `MyPolynomial.cs` and `TestMyPolynomial.cs` are part of the same namespace (`polynomial`).

4. **Set Startup Object**
   - Make sure `TestMyPolynomial.cs` (which includes the `Main` method) is set as the startup file.

5. **Build and Run**
   - Press `Ctrl + F5` (or click `Start Without Debugging`) to compile and run.
   - The console will display results from polynomial operations as shown in `TestMyPolynomial.cs`.

### Requirements

- **Microsoft Visual Studio 2022**
- **.NET 6.0 or later** (for compatibility with modern C# features)

---

## License

This project is open source and available under the MIT License.

---

Feel free to extend the `MyPolynomial` class with new features or methods as needed!
