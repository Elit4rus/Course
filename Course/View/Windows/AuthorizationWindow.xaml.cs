using System.Linq;
using System.Windows;

namespace Course.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void EntryBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Validation() == true)
            {
                Authentication();
            }
        }
        public bool Validation()
        {
            if (string.IsNullOrEmpty(EmailTb.Text) && string.IsNullOrEmpty(PasswordPb.Password))
            {
                MessageBox.Show("Поля для ввода не должны быть пустым. Введите логин и пароль!", "Ошибка", MessageBoxButton.OK);
                return false;
            }
            else if (string.IsNullOrEmpty(EmailTb.Text))
            {
                MessageBox.Show("Поля для ввода не должны быть пустым. Введите логин!", "Ошибка", MessageBoxButton.OK);
                return false;
            }
            else if (string.IsNullOrEmpty(PasswordPb.Password))
            {
                MessageBox.Show("Поля для ввода не должны быть пустым. Введите пароль!", "Ошибка", MessageBoxButton.OK);
                return false;
            }
            return true;
        }
        public void Authentication()
        {
            App.currentUser = App.context.User.FirstOrDefault(user => user.Email == EmailTb.Text && user.Password == PasswordPb.Password);

            if (App.currentUser == null)
            {
                MessageBox.Show($"Вы ввели неверный логин или пароль. Пожалуйста проверьте ещё раз введенные данные!", "Ошибка", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Вы успешно авторизовались!");
                Authorization();
                Close();
            }
        }
        public void Authorization()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
