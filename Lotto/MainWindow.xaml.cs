using System;
using System.Collections.Generic;
using System.Windows;

namespace Lotto
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();

            Random rnd = new Random();
            List<int> myList = new List<int>();


            for (int i = 0; i < 6; i++)
            {
                int lottozahlen = rnd.Next(1, 50);

                if (!myList.Contains(lottozahlen))
                {
                    myList.Add(lottozahlen);
                }
                else
                {
                    i--;
                }
            }

            myList.Sort();

            foreach (int lottozahlen in myList)
            {
                string c = lottozahlen.ToString();
                textBox1.Text += c + " ";
            }

            int superzahl = rnd.Next(1, 10);
            textBox2.Text = superzahl.ToString();

        }

        private void DataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}