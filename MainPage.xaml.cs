using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace TRPO_styles
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public ObservableCollection<Student> Students { get; set; } = new();
        public ObservableCollection<Subject> Subjects { get; set; } = new();

        public Subject? SelectedSubject { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Students.Add(new Student());
            Subjects.Add(new Subject());

            DataContext = this;
        }

        

        private void SubjectListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new SubjectPage());
        }

        private void ChangeThemeBtn_Click(object sender, RoutedEventArgs e)
        {
            UIThemeHelper.Toggle();
        }
    }
}
