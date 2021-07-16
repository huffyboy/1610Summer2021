using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operators : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // COMPARISON OPERATORS ///////////////////////////////////////////////////////////
        // == Equal To
        int x = 5;
        int y = 3;
        Debug.Log(x == y);  // returns False because 5 is not equal to 3

        // != Not Equal
        x = 5;
        y = 3;
        Debug.Log(x != y);  // returns True because 5 is not equal to 3

        // > Greater Than
        x = 5;
        y = 3;
        Debug.Log(x > y); // returns True because 5 is greater than 3

        // < Less Than
        x = 5;
        y = 3;
        Debug.Log(x < y); // returns False because 5 is not less than 3

        // >= Greater Than or Equal To
        x = 5;
        y = 3;
        Debug.Log(x >= y); // returns True because 5 is greater, or equal, to 3

        // <= Less Than or Equal To
        x = 5;
        y = 3;
        Debug.Log(x <= y); // returns False because 5 is neither less than or equal to 3

        // ARITHMETIC OPERATORS ///////////////////////////////////////////////////////////
        // + Addition
        x = 5;
        y = 3;
        Debug.Log(x + y);

        // - Subtraction
        x = 5;
        y = 3;
        Debug.Log(x - y);

        // * Multiplication
        x = 5;
        y = 3;
        Debug.Log(x * y);

        // / Division
        x = 12;
        y = 3;
        Debug.Log(x / y);

        // % Modulus
        x = 5;
        y = 2;
        Debug.Log(x % y);

        // ++ Increment
        x = 5;
        x++;
        Debug.Log(x);

        // -- Decrement
        x = 5;
        x--;
        Debug.Log(x);

        // LOGICAL OPERATORS ///////////////////////////////////////////////////////////
        int logicalX = 5;

        // && Logical And
        // returns True because 5 is greater than 3 AND 5 is less than 10
        Debug.Log(logicalX > 3 && logicalX < 10);

        // || Logical Or
        // returns True because one of the conditions are True (5 is greater than 3, but 5 is not less than 4)
        Debug.Log(logicalX > 3 || logicalX < 4);
        
        // Logical Not
        // returns False because ! (not) is used to reverse the result
        Debug.Log(!(logicalX > 3 && logicalX < 10));

        // ASSIGNMENT OPERATORS ///////////////////////////////////////////////////////////
        // = Assignment Operator
        int xAssign = 5;
        Debug.Log(xAssign);

        // += Add and Assign
        xAssign += 3;
        Debug.Log(xAssign);

        // -= Subtract and Assign
        xAssign -= 3;
        Debug.Log(xAssign);

        // *= Mulitply and Assign
        xAssign *= 3;
        Debug.Log(xAssign);

        // /= Divide and Assign
        xAssign /= 3;
        Debug.Log(xAssign);

        // %= Modulus and Assign
        xAssign %= 3;
        Debug.Log(xAssign);

        // &= Bitwise Logical AND and Assign
        xAssign &= 3;
        Debug.Log(xAssign);

        // |= Bitwise Logical OR and Assign
        xAssign |= 3;
        Debug.Log(xAssign);

        // ^= Bitwise Logical XOR and Assign
        xAssign ^= 3;
        Debug.Log(xAssign);

        // >>= Right-Shift and Assign
        xAssign >>= 3;
        Debug.Log(xAssign);

        // <<= Left-Shift and Assign
        xAssign <<= 3;
        Debug.Log(xAssign);
    }
}
