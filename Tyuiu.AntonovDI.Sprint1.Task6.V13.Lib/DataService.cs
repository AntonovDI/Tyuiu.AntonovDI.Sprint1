using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AntonovDI.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool CheckWordsAlphabet(string value)
        {
            value = value.Replace(" ", "").ToLower();

            for (int i = 1; i < value.Length; i++)
            {
                if (value[i] < value[i - 1])
                {
                    return false; 
                }
            }

            return true;
        }
    }
}
        
    
