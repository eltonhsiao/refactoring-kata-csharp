using System.Collections.Generic;

namespace RefactoringKata
{
    public class ProdSize
    {
        public static string getSizeName(int num)
        {
            Dictionary<int, string> sizeMap = new Dictionary<int, string>()
            {
                {1, "XS"},
                {2, "S"},
                {3, "M"},
                {4, "L"},
                {5, "XL"},
                {6, "XXL"}
            };

            string size;
            return sizeMap.TryGetValue(num, out size) ? size : "Invalid Size";
        }
    }
}
