using Course.Model;
using System.Windows;

namespace Course
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static CoursesEntities context = new CoursesEntities();
        public static User currentUser;
    }
}
