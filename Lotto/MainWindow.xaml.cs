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

            //textBox1.Clear();
            //textBox2.Clear();

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

        
        private void Button_Clickeuro(object sender, RoutedEventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();

            Random rnd = new Random();
            List<int> euroList = new List<int>();


            for (int i = 0; i < 5; i++)
            {
                int eurozahlen = rnd.Next(1, 51);

                if (!euroList.Contains(eurozahlen))
                {
                    euroList.Add(eurozahlen);
                }
                else
                {
                    i--;
                }
            }

            euroList.Sort();

            foreach (int eurozahlen in euroList)
            {
                string c = eurozahlen.ToString();
                textBox3.Text += c + " ";
            }

            List<int> eurosuperzahlList = new List<int>();

            for (int i = 0; i < 2; i++)
            {
                int eurosuperzahl = rnd.Next(1, 11);
                if (!eurosuperzahlList.Contains(eurosuperzahl))
                {
                    eurosuperzahlList.Add(eurosuperzahl);
                }
                else
                {
                    i--;
                }
            }
            eurosuperzahlList.Sort();

            foreach (int eurosuperzahl in eurosuperzahlList)
            {
                string c = eurosuperzahl.ToString();
                textBox4.Text += c + " ";
            }
            
        }
        private void Button_Click_aufraumen(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}