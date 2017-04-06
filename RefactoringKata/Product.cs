namespace RefactoringKata
{
    public class Product
    {
        public static int SIZE_NOT_APPLICABLE = -1;

        public string Code { get; set; }
        public int Color { get; set; }
        public int Size { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; }

        public Product(string code, int color, int size, double price, string currency)
        {
            Code = code;
            Color = color;
            Size = size;
            Price = price;
            Currency = currency;
        }

        public string FormatString()
        {
            string outputString = string.Empty;
            if (Size != SIZE_NOT_APPLICABLE)
                outputString = string.Format("\"size\": \"{0}\", ", getSizeFor(Size));
            return string.Format("{{\"code\": \"{0}\", \"color\": \"{1}\", {2}\"price\": {3}, \"currency\": \"{4}\"}}", Code, getColorFor(Color), outputString, Price, Currency);
        }

        private string getSizeFor(int num)
        {
            return ProdSize.getSizeName(num);
        }

        private string getColorFor(int num)
        {
            return ProdColor.getColorName(num);
        }
    }
}
