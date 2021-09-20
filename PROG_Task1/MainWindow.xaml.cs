using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using prjClassLibTask1;

namespace PROG_Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Mod_Info info = new Mod_Info();
        Self_Study_Information sInfo = new Self_Study_Information();
        public MainWindow()
        {
            InitializeComponent();
            lstView.Visibility = Visibility.Hidden;
            lstViewSelf.Visibility = Visibility.Hidden;
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            GenericClass<double> moduleInformation = new GenericClass<double>(100);

            info.setMod_Code(txtModCode.Text);
            info.setMod_Name(txtModName.Text);
            info.setCredits(Convert.ToDouble(txtModCredits.Text));
            info.setClass_Hours(Convert.ToDouble(txtClassHours.Text));
            info.setSemester_Start(txtStartDate.Text);
            info.setSelf_Study(Convert.ToDouble(txtSelfStudyHours.Text));


            moduleInformation.Push(info.getMod_Code());
            moduleInformation.Push(info.getMod_Name());
            moduleInformation.Push(info.getCredits());
            moduleInformation.Push(info.getSelf_Study());
            moduleInformation.Push(info.getSemester_Start());
            moduleInformation.Push(info.getClass_Hours());

            MessageBox.Show("Your information has been saved", "Save", MessageBoxButton.OK, MessageBoxImage.Information);

            lstView.Visibility = Visibility.Visible;
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {

            lstView.Items.Add("Module Code: " + info.getMod_Code());
            lstView.Items.Add("Module Name: " + info.getMod_Name());
            lstView.Items.Add("Module Credits: " + info.getCredits());
            lstView.Items.Add("Module Class Hours: " + info.getClass_Hours());
            lstView.Items.Add("Module Self-study Hours: " + info.getSelf_Study());
            lstView.Items.Add("Semester Start Date: " + info.getSemester_Start());
            lstView.Items.Add("\n");
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtClassHours.Clear();
            txtModCode.Clear();
            txtModCredits.Clear();
            txtModName.Clear();
            txtStartDate.Clear();
            lstView.Items.Clear();
            txtSelfStudyHours.Clear();

            MessageBox.Show("Your information has been cleared", "Clear", MessageBoxButton.OK, MessageBoxImage.Warning);

            lstView.Visibility = Visibility.Hidden;
        }

        private void btnClearSelf_Click(object sender, RoutedEventArgs e)
        {
            txtModDate.Clear();
            txtWeeks.Clear();
            txtModNameSelf.Clear();
            txtModuleHours.Clear();
            lstViewSelf.Items.Clear();

            MessageBox.Show("Your information has been cleared", "Clear", MessageBoxButton.OK, MessageBoxImage.Warning);

            lstViewSelf.Visibility = Visibility.Hidden;
        }

        private void btnEnterSelf_Click(object sender, RoutedEventArgs e)
        {
            GenericClass<double> moduleInformation = new GenericClass<double>(100);

            info.setSemester_Weeks(Convert.ToDouble(txtWeeks.Text));
            info.setMod_Date(txtModDate.Text);
            info.setMod_NameSelf(txtModNameSelf.Text);
            info.setHoursStudied(Convert.ToDouble(txtModuleHours.Text));

            moduleInformation.Push(info.getMod_NameSelf());
            moduleInformation.Push(info.getMod_Date());
            moduleInformation.Push(info.getHoursStudied());
            moduleInformation.Push(info.getSemester_Weeks());

            MessageBox.Show("Your information has been saved", "Save", MessageBoxButton.OK, MessageBoxImage.Information);

            lstViewSelf.Visibility = Visibility.Visible;
        }

        private void btnViewSelf_Click(object sender, RoutedEventArgs e)
        {
            lstViewSelf.Items.Add("Module Date: " + info.getMod_Date());
            lstViewSelf.Items.Add("Module Name: " + info.getMod_NameSelf());
            lstViewSelf.Items.Add("Module Hours studied: " + info.getHoursStudied());
            lstViewSelf.Items.Add("Semester Weeks: " + info.getSemester_Weeks());
            lstViewSelf.Items.Add("Module Self-Study: " + sInfo.selfStudyHours());
            lstViewSelf.Items.Add("Self-study hours remaining: " + sInfo.Hours_Left());
            lstViewSelf.Items.Add("\n");
        }
    }
}