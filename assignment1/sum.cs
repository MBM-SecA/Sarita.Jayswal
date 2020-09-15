//Given two numbers, write C# method that returns true if sum of both numbers is greater than 500. Otherwise returns false.

 public class BothSum
{
     internal bool sum(int num1, int num2)
    {
        int sum = num1 + num2;
        if (sum > 500)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}