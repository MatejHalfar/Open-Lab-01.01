using System;

namespace Open_Lab_01._01
{
    public class Exercise
    {
        public bool IsLessThan10(string input)
        {
            int input2 = int.Parse(input); 
            if(input2 < 10)
                {
                return true;
                }
            else
            {
                return false;
            }
            
        }
    }
}
