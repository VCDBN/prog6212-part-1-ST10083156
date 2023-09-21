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
    /// Interaction logic for SemesterWindow.xaml
    /// </summary>
    public partial class SemesterWindow : Window
    {
        //Varibales used to hold details about semester
        public DateTime startDate { get; set; }
        public DateTime currentDate { get; set; }
public TimeSpan semesterLength { get; set; }
        Week week = new Week();

//initializer for page
        public SemesterWindow()
        {
            InitializeComponent();
        }

        //Confirm button click, when used, completes calculation for self study hours and adds it to the IDictionary in the Week class
        //Afterwards, transfers users to the display for the self study hours per week
        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            int selfStudyHrs;
            IDictionary<String,int> moduleSelfStudy = new Dictionary<String,int>();
            foreach (Module module in Module.Modules)
            {
                int.TryParse(numWeeksTxt.Text, out int numWeeks);
                selfStudyHrs = ((module.Credits * 10) / numWeeks) - module.ClassHrs;
                moduleSelfStudy.Add(module.Name, selfStudyHrs);

            }

            if (int.TryParse(numWeeksTxt.Text,out int numWeeks1))
            {
                for (int i = 0; i < numWeeks1; i++)
                {
                    Week week1 = new Week(moduleSelfStudy);
                    Week.Weeks.Add(week1);
                }
            }
            else { MessageBox.Show("Please enter a valid number of weeks for the semester", "Input error!", MessageBoxButton.OK, MessageBoxImage.Exclamation); return; }
        StudyHrsDisplay studyHrsDisplay = new StudyHrsDisplay();
            this.Hide();
            studyHrsDisplay.Show();
            this.Close();
        } 
    }
}
