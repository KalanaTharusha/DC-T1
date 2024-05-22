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
using ConsoleApp1;

namespace WpfApp1
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

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            Student? student = null;

            try 
            {
                int stuId = Convert.ToInt32(StudentIdTB.Text);
                List<Student> studentList = StudentList.Students();

                foreach (Student s in studentList)
                {
                    if (s.Id == stuId)
                    {
                        student = s;
                    }
                }

                if (student != null)
                {
                    StudentNameTB.Text = student.Name;
                    UniversityTB.Text = student.University;
                }
                else
                {
                    MessageBox.Show("Couldn't find the student");
                }

            } catch 
            {
                MessageBox.Show("Invalid Student ID");
            }
        }
    }
}
