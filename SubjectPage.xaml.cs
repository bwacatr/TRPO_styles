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
    /// Логика взаимодействия для SubjectPage.xaml
    /// </summary>
    public partial class SubjectPage : Page
    {

        public ObservableCollection<Themes> Themes { get; set; } = new();

        public Subject? SelectedTheme { get; set; }
        public SubjectPage()
        {
            InitializeComponent();

            Themes.Add  (new Themes("Тема",4));

            DataContext = this;
        }

        private void ThemeListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new GradePage());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void ChangeThemeBtn_Click(object sender, RoutedEventArgs e)
        {
            UIThemeHelper.Toggle();
        }
    }
}
