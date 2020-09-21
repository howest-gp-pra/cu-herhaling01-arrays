using System;
using System.Collections.Generic;
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

namespace Pra.HerhalingArrays.WPF
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
        private void BtnArray1_Click(object sender, RoutedEventArgs e)
        {
            // we maken een array aan waarin we maximaal 10 integers kunnen bewaren.

            int[] getallen;
            getallen = new int[10];

            // we vullen deze array met 10 getallen
            // denk eraan, er zijn wel 10 elementen, 
            // maar de eerste heeft als adres/index 0, de tweede 1 ... de laatste 9

            for (int r = 0; r <= 9; r++)
            {
                getallen[r] = r;
            }

            // we beelden alle waarden uit onze array of in de listbox lstDisplay
            // we maken de listbox wel eerst leeg

            lstDisplay.Items.Clear();

            for (int r = 0; r <= 9; r++)
            {
                lstDisplay.Items.Add(getallen[r]);
            }
        }

        private void BtnArray2_Click(object sender, RoutedEventArgs e)
        {
            // zelfde als BtnArray1, maar deze keer wordt de array gevuld met random getallen

            int[] getallen = new int[10];
            Random rnd = new Random();
            for (int r = 0; r <= 9; r++)
            {
                getallen[r] = rnd.Next(1, 1000); // random getal van 1 tot en met 999
            }
            lstDisplay.Items.Clear();
            for (int r = 0; r <= 9; r++)
            {
                lstDisplay.Items.Add(getallen[r]);
            }
        }

        private void BtnArray3_Click(object sender, RoutedEventArgs e)
        {
            // zelfde als BtnArray2 maar deze keer laten we ook het lot bepalen hoeveel elementen 
            // er in onze array zullen worden aangemaakt

            Random rnd = new Random();
            int aantalElementen = rnd.Next(1, 51);
            int[] getallen = new int[aantalElementen];
            for (int r = 0; r < aantalElementen; r++)
            {
                getallen[r] = rnd.Next(1, 1000); // random getal van 1 tot en met 999
            }
            lstDisplay.Items.Clear();
            for (int r = 0; r < aantalElementen; r++)
            {
                lstDisplay.Items.Add(getallen[r]);
            }
        }

        private void BtnArray4_Click(object sender, RoutedEventArgs e)
        {
            // zelfde als BtnArray3 maar deze keer gaan we onze array
            // (automatisch) laten sorteren.

            Random rnd = new Random();
            int aantalElementen = rnd.Next(1, 51);
            int[] getallen = new int[aantalElementen];
            for (int r = 0; r < aantalElementen; r++)
            {
                getallen[r] = rnd.Next(1, 1000); // random getal van 1 tot en met 999
            }

            // ++++++++++++++++++
            Array.Sort(getallen);
            // ++++++++++++++++++

            lstDisplay.Items.Clear();
            for (int r = 0; r < aantalElementen; r++)
            {
                lstDisplay.Items.Add(getallen[r]);
            }
        }

        private void BtnArray5_Click(object sender, RoutedEventArgs e)
        {
            // zelfde als BtnArray5 maar deze keer gaan we onze array
            // (automatisch) aflopend laten sorteren.

            Random rnd = new Random();
            int aantalElementen = rnd.Next(1, 51);
            int[] getallen = new int[aantalElementen];
            for (int r = 0; r < aantalElementen; r++)
            {
                getallen[r] = rnd.Next(1, 1000); // random getal van 1 tot en met 999
            }

            // ++++++++++++++++++
            Array.Sort(getallen);
            Array.Reverse(getallen);
            // ++++++++++++++++++

            lstDisplay.Items.Clear();
            for (int r = 0; r < aantalElementen; r++)
            {
                lstDisplay.Items.Add(getallen[r]);
            }
        }

        private void BtnArray6_Click(object sender, RoutedEventArgs e)
        {
            // je kan een array bij aanmaak ook onmiddellijk voorzien van waarden
            int[] getallen = { 1, 2, 3, 4, 5, 6, 99, 102 };

            // met de LENGTH eigenschap kan je de grootte achterhalen
            int aantalElementen = getallen.Length;

            lstDisplay.Items.Clear();
            for (int r = 0; r < aantalElementen; r++)
            {
                lstDisplay.Items.Add(getallen[r]);
            }
        }

        private void BtnArray7_Click(object sender, RoutedEventArgs e)
        {
            // een 2-dimensionele array aanmaken
            // beschouw onderstaande als tabel van 3 rijen en 2 kolommen
            string[,] namen = new string[3, 2];
            namen[0, 0] = "Piet";
            namen[0, 1] = "Pieraat";
            namen[1, 0] = "Guy";
            namen[1, 1] = "Taar";
            namen[2, 0] = "Bert";
            namen[2, 1] = "Bibber";


            lstDisplay.Items.Clear();
            for (int r = 0; r < 3; r++)
            {
                lstDisplay.Items.Add(namen[r, 0] + " " + namen[r, 1]);
            }
        }

        private void BtnArray8_Click(object sender, RoutedEventArgs e)
        {
            string[,] namen = { { "Piet", "Pieraat" }, { "Guy", "Taar" }, { "Bert", "Bibber" } };

            // onderstaand is NIET correct : dit levert nu immers 6 op !
            // int aantalRijen = namen.Length;

            // je dient het aantal rijen nu op te vragen met GetUpperBound methode
            // 0 staat hier voor de 1° dimensie, dus het aantal rijen
            // 1 zou hier staan voor de 2° dimensie, dus het aantal kolommen (we gebruiken dit hier niet)
            int aantalRijen = namen.GetUpperBound(0);
            // opgepast : deze methode geeft het hoogste indexnummer van een dimensie
            // in dit voorbeeld levert dit 2 op, omdat de laatste rij - de derde rij - index 2 heeft

            lstDisplay.Items.Clear();
            for (int r = 0; r <= aantalRijen; r++)
            {
                lstDisplay.Items.Add(namen[r, 0] + " " + namen[r, 1]);
            }
        }
    }
}
