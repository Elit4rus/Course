using Course.AppData;
using Course.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace Course.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        List<UserCourse> userCourses = App.context.UserCourse.ToList();
        List<Status> statuses = App.context.Status.ToList();
        public ProfilePage()
        {
            InitializeComponent();
            FullNameTbl.Text = App.currentUser.Surname + " " + App.currentUser.Name + " " + App.currentUser.Patronymic;
            UserCourseLv.ItemsSource = userCourses.Where(uc => uc.UserID == App.currentUser.ID);
            StatusCmb.ItemsSource = statuses;
        }

        private void BackBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            FrameHelper.mainFrame.Navigate(new View.Pages.WelcomePage());
        }

        private void SaveBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
