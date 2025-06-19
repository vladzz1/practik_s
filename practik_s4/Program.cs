using System.Drawing;
using System.Xml.Linq;

namespace practik_s4
{
    partial class Freezer
    {
        static Freezer()
        {
            count = 0;
            regime = "суха заморозка";
        }
        public Freezer()
        {
            Temperature = -5;
            Height = 1;
            Width = 1;
            Name = "no data";
            Color = "no data";
            count++;
        }
        public Freezer(string? name, string? color) : this()
        {
            Name = name;
            Color = color;
        }
        public Freezer(int temperature, double height, double width, string? name, string? color) : this(name, color)
        {
            Temperature = temperature;
            Height = height;
            Width = width;
            Name = name;
            Color = color;
        }
        public override string ToString()
        {
            return $"temperature: {Temperature}\nheight: {Height}\nwidth: {Width}\nname: {Name}\ncolor: {Color}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
