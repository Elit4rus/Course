using Course.AppData;
using Course.View.Windows;
using System.Windows;

namespace Course
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameHelper.mainFrame = MainFrame;
            MainFrame.Navigate(new View.Pages.WelcomePage());
        }

        private void CourseBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new View.Pages.CoursePage());
        }

        private void GetOutBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            Close();
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new View.Pages.ProfilePage());
        }
    }
}
