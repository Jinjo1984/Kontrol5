using System;
using System.Collections.Generic;
using System.IO;
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
using контрольная_2;

namespace Kontrol5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Utilites utilites = new Utilites();
            utilites.WriteFileRandomStr("C:\\Users\\Georgiy\\Documents\\Лаба\\Kontrol5\\Kontrol5\\file\\Исходный файл.txt",10000);
            string array;
            using(StreamReader readFile =  new StreamReader("C:\\Users\\Georgiy\\Documents\\Лаба\\Kontrol5\\Kontrol5\\file\\Исходный файл.txt"))
            {
                array = readFile.ReadToEnd();
            }
            string str = "";
            string number = utilites.SortMassInt(array, ref str);
            string[] numberMass = new string[number.Length];
            for(int i = 0; i < numberMass.Length; i++)
            {
                numberMass[i] = Convert.ToString(number[i]);
            }
            int[] IntStr = new int[numberMass.Length];
            for (int i = 0; i < numberMass.Length; i++)
            {
                IntStr[i] = Convert.ToInt32(numberMass[i]);
            }
            int[] BubbleInt = utilites.BubbleSort(IntStr);
            string ConvertBubbleInt  = "";
            for(int i = 0; i < BubbleInt.Length; i++)
            {
                ConvertBubbleInt += Convert.ToString(BubbleInt[i]);
            }
            using(StreamWriter WrireFile = new StreamWriter("C:\\Users\\Georgiy\\Documents\\Лаба\\Kontrol5\\Kontrol5\\file\\Строки.txt"))
            {
                WrireFile.Write(str);
            }
            using (StreamWriter WrireFile = new StreamWriter("C:\\Users\\Georgiy\\Documents\\Лаба\\Kontrol5\\Kontrol5\\file\\Числа без сортировки.txt"))
            {
                WrireFile.Write(number);
            }
            using (StreamWriter WrireFile = new StreamWriter("C:\\Users\\Georgiy\\Documents\\Лаба\\Kontrol5\\Kontrol5\\file\\Bubble sort.txt"))
            {
                WrireFile.Write(ConvertBubbleInt);
            }
        }
    }
}
