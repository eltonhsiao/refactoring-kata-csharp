using System.Collections.Generic;

namespace RefactoringKata
{
    public class ProdColor
    {
        public static string getColorName(int num)
        {
            Dictionary<int, string> colorMap = new Dictionary<int, string>()
            {
                {1, "blue"},
                {2, "red"},
                {3, "yellow"},
            };

            string color;
            return colorMap.TryGetValue(num, out color) ? color : "no color";
        }
    }
}
