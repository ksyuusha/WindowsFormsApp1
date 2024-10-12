using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = Convert.ToDouble(textBox1.Text);
                Circle circle = new Circle(radius);
                Площадь.Text = "Площадь: " + circle.GetArea();
                Периметр.Text = "Периметр: " + circle.GetPerimeter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double width = Convert.ToDouble(textBox2.Text);
                double height = Convert.ToDouble(textBox3.Text);
                Rectangle rectangle = new Rectangle(width, height);
                Площадь.Text = "Площадь: " + rectangle.GetArea();
                Периметр.Text = "Периметр: " + rectangle.GetPerimeter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double side1 = Convert.ToDouble(textBox4.Text);
                double side2 = Convert.ToDouble(textBox5.Text);
                double side3 = Convert.ToDouble(textBox6.Text);
                Triangle triangle = new Triangle(side1, side2, side3);
                Площадь.Text = "Площадь: " + triangle.GetArea();
                Периметр.Text = "Периметр: " + triangle.GetPerimeter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }

    public class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }

    public class Triangle
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double GetPerimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public double GetArea()
        {
            double s = GetPerimeter() / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }
    }
}
