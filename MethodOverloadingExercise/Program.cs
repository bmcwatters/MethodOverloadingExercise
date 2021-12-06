

Console.WriteLine(Add(5, 0, true));

/*
    static int Add(int num1, int num2) //Method adding two numbers
    {
        return num1 + num2;
    }


     static decimal Add(decimal num1, decimal num2) //Method Overload adding two decimal num
    {
        return num1 + num2;
    }
*/

    static string Add(int num1, int num2, bool isTrue)//Method Overload Add returning string
    {
        var sum = num1 + num2;

        if (isTrue == true && sum > 1)
        {

            return $"{sum} dollars";
        }
        else if (isTrue == true && sum == 1)
        {
            return $"{sum} dollar";
        }
        else if (isTrue == true && sum < 1)
        {
            return $"{sum} dollars";
        }
        else
        {
            return sum.ToString();
        }

    }





