namespace practik_s4_2
{
    partial class Point
    {
        public void setXCoord(int newX)
        {
            if (newX >= 0)
                xCoord = newX;
            else
                xCoord = 0;
        }
        public void setYCoord(int newY)
        {
            if (newY >= 0)
                yCoord = newY;
            else
                yCoord = 0;
        }
        public int getXCoord() { return xCoord; }
        public int getYCoord() { return yCoord; }

    }
    partial class Point
    {
        private int xCoord;
        //Properties
        public int XCoord//(value)
        {
            get { return xCoord; }
            set
            {
                if (value >= 0)
                    xCoord = value;
                else
                    xCoord = 0;
            }
        }
        private int yCoord;
        public int YCoord//(value)
        {
            get { return yCoord; }
            set
            {
                if (value >= 0)
                    yCoord = value;
                else
                    yCoord = 0;
            }
        }
        //private string name;

        //propfull + Tab ---> fullproperty
        //private string name;

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //Auto property ---> prop + Tab
        public string Name { get; set; }
        //Full property
        private int length;
        public int Length
        {
            get { return length; }
            set
            {
                if (value >= 0)
                {
                    length = value;
                }
                else
                    length = 0;
            }
        }
        //private string color = "White";
        //public string Color
        //{ set{} get{}}
        public string Color { get; private set; } = "White";
    }
}

namespace practik_s4_2
{
    partial class Point
    {
        public void MovePoint(int newX, int newY)
        {
            XCoord = newX;
            YCoord = newY;
        }
    }
}