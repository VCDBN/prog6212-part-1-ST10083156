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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace PROG6212_POE
{
    /// <summary>
    /// Interaction logic for UpdateHrs.xaml
    /// </summary>
    public partial class UpdateHrs : Window
    {
        //initializer for page
        //calls "PopulateWeekComboBox" and "PopulateModuleComboBox" methods to populate the corresponding methods on runtime
        public UpdateHrs()
        {
            InitializeComponent();
            PopulateWeekComboBox();
            PopulateModuleComboBox();
        }

        //populates week combobox by using the number of "Week" objects in the "Weeks" list
        private void PopulateWeekComboBox()
        {
            weekComboBox.Items.Clear();
            int numWeeks = Week.Weeks.Count;
            for(int i = 0;i < numWeeks; i++) 
            {
                weekComboBox.Items.Add($"Week {i + 1}");

            }
        }

        //populates the module combobox by using the number of "Module" objects in the "Modules list
        private void PopulateModuleComboBox()
        {
            moduleComboBox.Items.Clear();
            int numModules = Module.Modules.Count;
            for (int i = 0; i < numModules; i++)
            {
                moduleComboBox.Items.Add(Module.Modules[i].Name);
            }          
        }

        private void updateHrsBtn_Click(object sender, RoutedEventArgs e)
        {
            //trying to assign all user input to corresponding variables
            int hrsStudied=0;
            try { hrsStudied = Convert.ToInt32(hrsTxt.Text); }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            string moduleName = moduleComboBox.Text;
            int weekIndex = weekComboBox.SelectedIndex;
            
            //calculating the number of self study hours remaining in the selected week
            int selfStudyHrs = Week.Weeks[weekIndex].ModuleSelfStudy.Where(x => x.Key == moduleName).Select(x => x.Value).First() ;
            int hrsRemaining = selfStudyHrs - hrsStudied;
            if (hrsRemaining < 0) 
            {
                MessageBox.Show("You have entered more hours than you have left this week", "No hours left", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                hrsRemaining= 0;
                return;
            }

            //updating the self study hours in the IDictionary
            Week.Weeks[weekIndex].ModuleSelfStudy[moduleName] = hrsRemaining;

            //returning the user to the display for self study hours
            StudyHrsDisplay studyHrsDisplay = new StudyHrsDisplay();
            this.Hide();
            studyHrsDisplay.Show();
            this.Close();
        }
    }
}
