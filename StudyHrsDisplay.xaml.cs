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
using System.Windows.Shapes;

namespace PROG6212_POE
{
    /// <summary>
    /// Interaction logic for StudyHrsDisplay.xaml
    /// </summary>
    public partial class StudyHrsDisplay : Window
    {
        //initializer for page
        public StudyHrsDisplay()
        {
            InitializeComponent();
            //populating combo box with weeks and their numbers
            int numWeeks = Week.Weeks.Count;
            for (int i = 0; i < numWeeks; i++)
            {
                selectedWeekComboBox.Items.Add($"Week {i + 1}");
            }

            //displays week 1 as default
            selectedWeekComboBox.SelectedIndex = 0;
        }


        //update button transfer users to the update hours page to record hours studied
        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            UpdateHrs updateHrs = new UpdateHrs();
            this.Hide();
            updateHrs.Show();
            this.Close();
        }

        private void selectedWeekComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = selectedWeekComboBox.SelectedIndex;
            selfStudyGrid.ItemsSource = Week.Weeks[i].ModuleSelfStudy;
            selfStudyGrid.Items.Refresh();


        }
    }
}
