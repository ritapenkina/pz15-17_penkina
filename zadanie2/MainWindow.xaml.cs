using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pz2_penkina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }
    }
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Class1 A1 { get; set; } = new Class1("A1", 1);
        public Class1 A2 { get; set; } = new Class1("A2", 2);
        public Class1 A3 { get; set; } = new Class1("A3", 3);
        public Class2 B1 { get; set; } = new Class2("B1", "Белый");
        public Class2 B2 { get; set; } = new Class2("B2", "Синий");
        public Class2 B3 { get; set; } = new Class2("B3", "Красный");
        public Class3 C1 { get; set; } = new Class3(1, 2);
        public Class3 C2 { get; set; } = new Class3(3, 4);
        public Class3 C3 { get; set; } = new Class3(5, 6);
    }
    public class Class1
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public Class1(string name, int number)
        {
            Name = name;
            Number = number;
        }
        public void UpdateNumber(int newNumber)
        {
            Number = newNumber;
        }
        public string GetInfo()
        {
            return $"Класс1: {Name} ({Number})";
        }
    }
    public class Class2
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public Class2(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public string GetInfo()
        {
            return $"Класс2: {Name}, Цвет: ({Color})";
        }
        public void ChangeColor(string newColor)
        {
            Color = newColor;
        }
    }
    public class Class3
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Class3(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void UpdateXY(int newX, int newY)
        {
            X = newX;
            Y = newY;
        }
        public string GetInfo()
        {
            return $"Класс3: ({X}, {Y})";
        }
    }
    }
