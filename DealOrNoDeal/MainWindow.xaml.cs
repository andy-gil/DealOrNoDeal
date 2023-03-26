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

namespace DealOrNoDeal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        setGame Game;
        private static Random random = new Random();
        int round = 1;
        public MainWindow()
        {
            InitializeComponent();
            Game = new setGame();
            LoadBriefCases();
            LoadLabels();
        }

        /// <summary>
        /// make the labels have the values they relate too
        /// </summary>
        private void LoadLabels()
        {
            lbl1.Tag = Game._briefcases[0];
            lbl2.Tag = Game._briefcases[1];
            lbl3.Tag = Game._briefcases[2];
            lbl4.Tag = Game._briefcases[3];
            lbl5.Tag = Game._briefcases[4];
            lbl6.Tag = Game._briefcases[5];
            lbl7.Tag = Game._briefcases[6];
            lbl8.Tag = Game._briefcases[7];
            lbl9.Tag = Game._briefcases[8];
            lbl10.Tag = Game._briefcases[9];
            lbl11.Tag = Game._briefcases[10];
            lbl12.Tag = Game._briefcases[11];
            lbl13.Tag = Game._briefcases[12];
            lbl14.Tag = Game._briefcases[13];
            lbl15.Tag = Game._briefcases[14];
            lbl16.Tag = Game._briefcases[15];
            lbl17.Tag = Game._briefcases[16];
            lbl18.Tag = Game._briefcases[17];
            lbl19.Tag = Game._briefcases[18];
            lbl20.Tag = Game._briefcases[19];
            lbl21.Tag = Game._briefcases[20];
            lbl22.Tag = Game._briefcases[21];
            lbl23.Tag = Game._briefcases[22];
            lbl24.Tag = Game._briefcases[23];
            lbl25.Tag = Game._briefcases[24];
            lbl26.Tag = Game._briefcases[25];

        }

        /// <summary>
        /// Randomize the breifcases
        /// Connect it to the case buttons
        /// </summary>
        private void LoadBriefCases()
        {
            Game._remainingBriefcases = Game._briefcases.ToList();
            Game._remainingBriefcases = Game._briefcases.OrderBy(x => Guid.NewGuid()).ToList();
            Case1.Tag = Game._remainingBriefcases[0];
            Case2.Tag = Game._remainingBriefcases[1];
            Case3.Tag = Game._remainingBriefcases[2];
            Case4.Tag = Game._remainingBriefcases[3];
            Case5.Tag = Game._remainingBriefcases[4];
            Case6.Tag = Game._remainingBriefcases[5];
            Case7.Tag = Game._remainingBriefcases[6];
            Case8.Tag = Game._remainingBriefcases[7];
            Case9.Tag = Game._remainingBriefcases[8];
            Case10.Tag = Game._remainingBriefcases[9];
            Case11.Tag = Game._remainingBriefcases[10];
            Case12.Tag = Game._remainingBriefcases[11];
            Case13.Tag = Game._remainingBriefcases[12];
            Case14.Tag = Game._remainingBriefcases[13];
            Case15.Tag = Game._remainingBriefcases[14];
            Case16.Tag = Game._remainingBriefcases[15];
            Case17.Tag = Game._remainingBriefcases[16];
            Case18.Tag = Game._remainingBriefcases[17];
            Case19.Tag = Game._remainingBriefcases[18];
            Case20.Tag = Game._remainingBriefcases[19];
            Case21.Tag = Game._remainingBriefcases[20];
            Case22.Tag = Game._remainingBriefcases[21];
            Case23.Tag = Game._remainingBriefcases[22];
            Case24.Tag = Game._remainingBriefcases[23];
            Case25.Tag = Game._remainingBriefcases[24];
            Case26.Tag = Game._remainingBriefcases[25];
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            Button btn = (Button)sender;
            string i = btn.Tag.ToString();
            Int32.TryParse(i, out int val);
            int value = val;
            RemoveCase(val);
        }

        private void RemoveCase(int val)
        {
            HighlightLabel(val);
            for (int i = 1; i <= 26; i++)
            {
                Button caseButton = (Button)FindName("Case" + i);
                if ((int)caseButton.Tag == val)
                {
                    Game._remainingBriefcases.Remove(val);
                    //int newCaseValue = Game._remainingBriefcases[0];
                    //Game._remainingBriefcases.RemoveAt(0);
                    //caseButton.Tag = newCaseValue;
                    caseButton.Content = "X";
                    break;
                }
            }
        }

        private void HighlightLabel(int val)
        {
            for (int i = 1; i <= 26; i++)
            {
                Label label = (Label)FindName("lbl" + i);
                string content = label.Content.ToString();
                if (content.Contains("$" + val))
                {
                    label.Foreground = Brushes.White; // Change the color to gray
                    label.Background = Brushes.Black;
                    break;
                }
            }
        }
    }
}
