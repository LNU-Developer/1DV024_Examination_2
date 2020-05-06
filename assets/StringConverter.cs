using System;

namespace Examination_2
{
    public static class StringConverter
    {  
        public static int TypeSelection (string source) 
        {
            try 
            {
                int input = Convert.ToInt32(source);
                if (input == 0 || input == 1) 
                {
                    return input;
                }
                else 
                {
                    throw new ArgumentOutOfRangeException($"Incorrect input syntax, must be either 0 or 1");
                }
            }
            catch (FormatException)
            {
                throw new FormatException($"Incorrect input syntax, must be either 0 or 1");
            }
        }
        public static int FormsSelection (string source) 
        {
            try 
            {
                int input = Convert.ToInt32(source);
                if (input <= 0) 
                {
                    throw new ArgumentOutOfRangeException($"Selection must be above 0");
                }
                return input;
            }
            catch (FormatException)
            {
                throw new FormatException($"Incorrect input syntax, must be either 0 or 1");
            }
        }
         public static double[] RangeSelection (string min, string max) 
        {
            try 
            {
                double minimum = Convert.ToDouble(min);
                double maximum = Convert.ToDouble(max);
                if (minimum < 0 || maximum < 0) 
                {
                    throw new ArgumentOutOfRangeException($"Selection must be above 0");
                } 
                else if(minimum > maximum)
                {
                    throw new ArgumentOutOfRangeException($"The minimum value cannot be larger than the maximum value");
                }
                return new double[]{minimum, maximum};
            }
            catch (FormatException)
            {
                throw new FormatException($"Incorrect input syntax, must be either 0 or 1");
            }
        }
   

    }
}