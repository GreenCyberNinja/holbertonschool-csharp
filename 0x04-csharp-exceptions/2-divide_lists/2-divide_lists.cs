  
using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> anslst = new List<int>() {};
        for (int i = 0; i < listLength; i++)
        {
            int ans = 0;
            try
            {
                ans = list1[i] / list2[i];
                anslst.Add(ans);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                anslst.Add(ans);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
            finally
            {}
        }
        return anslst;
    }
}