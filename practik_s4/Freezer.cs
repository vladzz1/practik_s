namespace practik_s4
{
    partial class Freezer
    {
        private int temperature;
        public int Temperature
        {
            get { return temperature; }
            set
            {
                if (temperature <= -5 && temperature >= -20)
                {
                    temperature = value;
                }
                else
                {
                    temperature = -5;
                }
            }
        }
        private double height;
        public double Height
        {
            get { return height; }
            set
            {
                if (height >= 1)
                {
                    height = value;
                }
                else
                {
                    height = 1;
                }
            }
        }
        private double width;
        public double Width
        {
            get { return width; }
            set
            {
                if (width >= 1)
                {
                    width = value;
                }
                else
                {
                    width = 1;
                }
            }
        }
        public string? Name { get; set; }
        public string? Color { get; set; }
        static int count;
        static string? regime;
    }
}