using Course.AppData;
using Course.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Course.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для CoursePage.xaml
    /// </summary>
    public partial class CoursePage : Page
    {
        List<CourseTable> courses = App.context.CourseTable.ToList();
        List<Category> categories = App.context.Category.ToList();
        public CoursePage()
        {
            InitializeComponent();
            LoadingData();
            categories.Insert(0, new Category() { Title = "Все категории" });
            CategoryCmb.ItemsSource = categories;
        }
        public void LoadingData()
        {

            // Первый курс
            NameTbl.Text = App.context.CourseTable.Where(c => c.ID == 1).Select(c => c.Title).FirstOrDefault();
            DescTbl.Text = App.context.CourseTable.Where(c => c.ID == 1).Select(c => c.Description).FirstOrDefault();
            CategoryTbl.Text = App.context.CourseTable.Where(c => c.ID == 1).Select(c => c.Category.Title).FirstOrDefault();
            FullNameTbl.Text = App.context.CourseTable.Where(c => c.ID == 1).Select(c => c.Teacher.Surname + " " + c.Teacher.Name + " " + c.Teacher.Patronymic).FirstOrDefault();
            FormatTbl.Text = App.context.CourseTable.Where(c => c.ID == 1).Select(c => c.Format.Title).FirstOrDefault();
            PriceTbl.Text = App.context.CourseTable.Where(c => c.ID == 1).Select(c => c.Price + " руб.").FirstOrDefault().ToString();
            DurationTbl.Text = App.context.CourseTable.Where(c => c.ID == 1).Select(c => c.Duration + " часов").FirstOrDefault().ToString();

            // Второй курс
            Name2Tbl.Text = App.context.CourseTable.Where(c => c.ID == 2).Select(c => c.Title).FirstOrDefault();
            Desc2Tbl.Text = App.context.CourseTable.Where(c => c.ID == 2).Select(c => c.Description).FirstOrDefault();
            Category2Tbl.Text = App.context.CourseTable.Where(c => c.ID == 2).Select(c => c.Category.Title).FirstOrDefault();
            FullName2Tbl.Text = App.context.CourseTable.Where(c => c.ID == 2).Select(c => c.Teacher.Surname + " " + c.Teacher.Name + " " + c.Teacher.Patronymic).FirstOrDefault();
            Format2Tbl.Text = App.context.CourseTable.Where(c => c.ID == 2).Select(c => c.Format.Title).FirstOrDefault();
            Price2Tbl.Text = App.context.CourseTable.Where(c => c.ID == 2).Select(c => c.Price + " руб.").FirstOrDefault().ToString();
            Duration2Tbl.Text = App.context.CourseTable.Where(c => c.ID == 2).Select(c => c.Duration + " часов").FirstOrDefault().ToString();

            // Третий курс
            Name3Tbl.Text = App.context.CourseTable.Where(c => c.ID == 3).Select(c => c.Title).FirstOrDefault();
            Desc3Tbl.Text = App.context.CourseTable.Where(c => c.ID == 3).Select(c => c.Description).FirstOrDefault();
            Category3Tbl.Text = App.context.CourseTable.Where(c => c.ID == 3).Select(c => c.Category.Title).FirstOrDefault();
            FullName3Tbl.Text = App.context.CourseTable.Where(c => c.ID == 3).Select(c => c.Teacher.Surname + " " + c.Teacher.Name + " " + c.Teacher.Patronymic).FirstOrDefault();
            Format3Tbl.Text = App.context.CourseTable.Where(c => c.ID == 3).Select(c => c.Format.Title).FirstOrDefault();
            Price3Tbl.Text = App.context.CourseTable.Where(c => c.ID == 3).Select(c => c.Price + " руб.").FirstOrDefault().ToString();
            Duration3Tbl.Text = App.context.CourseTable.Where(c => c.ID == 3).Select(c => c.Duration + " часов").FirstOrDefault().ToString();

            // Четвертый курс
            Name4Tbl.Text = App.context.CourseTable.Where(c => c.ID == 4).Select(c => c.Title).FirstOrDefault();
            Desc4Tbl.Text = App.context.CourseTable.Where(c => c.ID == 4).Select(c => c.Description).FirstOrDefault();
            Category4Tbl.Text = App.context.CourseTable.Where(c => c.ID == 4).Select(c => c.Category.Title).FirstOrDefault();
            FullName4Tbl.Text = App.context.CourseTable.Where(c => c.ID == 4).Select(c => c.Teacher.Surname + " " + c.Teacher.Name + " " + c.Teacher.Patronymic).FirstOrDefault();
            Format4Tbl.Text = App.context.CourseTable.Where(c => c.ID == 4).Select(c => c.Format.Title).FirstOrDefault();
            Price4Tbl.Text = App.context.CourseTable.Where(c => c.ID == 4).Select(c => c.Price + " руб.").FirstOrDefault().ToString();
            Duration4Tbl.Text = App.context.CourseTable.Where(c => c.ID == 4).Select(c => c.Duration + " часов").FirstOrDefault().ToString();

            // Пятый курс
            Name5Tbl.Text = App.context.CourseTable.Where(c => c.ID == 5).Select(c => c.Title).FirstOrDefault();
            Desc5Tbl.Text = App.context.CourseTable.Where(c => c.ID == 5).Select(c => c.Description).FirstOrDefault();
            Category5Tbl.Text = App.context.CourseTable.Where(c => c.ID == 5).Select(c => c.Category.Title).FirstOrDefault();
            FullName5Tbl.Text = App.context.CourseTable.Where(c => c.ID == 5).Select(c => c.Teacher.Surname + " " + c.Teacher.Name + " " + c.Teacher.Patronymic).FirstOrDefault();
            Format5Tbl.Text = App.context.CourseTable.Where(c => c.ID == 5).Select(c => c.Format.Title).FirstOrDefault();
            Price5Tbl.Text = App.context.CourseTable.Where(c => c.ID == 5).Select(c => c.Price + " руб.").FirstOrDefault().ToString();
            Duration5Tbl.Text = App.context.CourseTable.Where(c => c.ID == 5).Select(c => c.Duration + " часов").FirstOrDefault().ToString();

            // Шестой курс
            Name6Tbl.Text = App.context.CourseTable.Where(c => c.ID == 6).Select(c => c.Title).FirstOrDefault();
            Desc6Tbl.Text = App.context.CourseTable.Where(c => c.ID == 6).Select(c => c.Description).FirstOrDefault();
            Category6Tbl.Text = App.context.CourseTable.Where(c => c.ID == 6).Select(c => c.Category.Title).FirstOrDefault();
            FullName6Tbl.Text = App.context.CourseTable.Where(c => c.ID == 6).Select(c => c.Teacher.Surname + " " + c.Teacher.Name + " " + c.Teacher.Patronymic).FirstOrDefault();
            Format6Tbl.Text = App.context.CourseTable.Where(c => c.ID == 6).Select(c => c.Format.Title).FirstOrDefault();
            Price6Tbl.Text = App.context.CourseTable.Where(c => c.ID == 6).Select(c => c.Price + " руб.").FirstOrDefault().ToString();
            Duration6Tbl.Text = App.context.CourseTable.Where(c => c.ID == 6).Select(c => c.Duration + " часов").FirstOrDefault().ToString();

            // Седьмой курс
            Name7Tbl.Text = App.context.CourseTable.Where(c => c.ID == 7).Select(c => c.Title).FirstOrDefault();
            Desc7Tbl.Text = App.context.CourseTable.Where(c => c.ID == 7).Select(c => c.Description).FirstOrDefault();
            Category7Tbl.Text = App.context.CourseTable.Where(c => c.ID == 7).Select(c => c.Category.Title).FirstOrDefault();
            FullName7Tbl.Text = App.context.CourseTable.Where(c => c.ID == 7).Select(c => c.Teacher.Surname + " " + c.Teacher.Name + " " + c.Teacher.Patronymic).FirstOrDefault();
            Format7Tbl.Text = App.context.CourseTable.Where(c => c.ID == 7).Select(c => c.Format.Title).FirstOrDefault();
            Price7Tbl.Text = App.context.CourseTable.Where(c => c.ID == 7).Select(c => c.Price + " руб.").FirstOrDefault().ToString();
            Duration7Tbl.Text = App.context.CourseTable.Where(c => c.ID == 7).Select(c => c.Duration + " часов").FirstOrDefault().ToString();

            // Восьмой курс
            Name8Tbl.Text = App.context.CourseTable.Where(c => c.ID == 8).Select(c => c.Title).FirstOrDefault();
            Desc8Tbl.Text = App.context.CourseTable.Where(c => c.ID == 8).Select(c => c.Description).FirstOrDefault();
            Category8Tbl.Text = App.context.CourseTable.Where(c => c.ID == 8).Select(c => c.Category.Title).FirstOrDefault();
            FullName8Tbl.Text = App.context.CourseTable.Where(c => c.ID == 8).Select(c => c.Teacher.Surname + " " + c.Teacher.Name + " " + c.Teacher.Patronymic).FirstOrDefault();
            Format8Tbl.Text = App.context.CourseTable.Where(c => c.ID == 8).Select(c => c.Format.Title).FirstOrDefault();
            Price8Tbl.Text = App.context.CourseTable.Where(c => c.ID == 8).Select(c => c.Price + " руб.").FirstOrDefault().ToString();
            Duration8Tbl.Text = App.context.CourseTable.Where(c => c.ID == 8).Select(c => c.Duration + " часов").FirstOrDefault().ToString();

            // Девятый курс
            Name9Tbl.Text = App.context.CourseTable.Where(c => c.ID == 9).Select(c => c.Title).FirstOrDefault();
            Desc9Tbl.Text = App.context.CourseTable.Where(c => c.ID == 9).Select(c => c.Description).FirstOrDefault();
            Category9Tbl.Text = App.context.CourseTable.Where(c => c.ID == 9).Select(c => c.Category.Title).FirstOrDefault();
            FullName9Tbl.Text = App.context.CourseTable.Where(c => c.ID == 9).Select(c => c.Teacher.Surname + " " + c.Teacher.Name + " " + c.Teacher.Patronymic).FirstOrDefault();
            Format9Tbl.Text = App.context.CourseTable.Where(c => c.ID == 9).Select(c => c.Format.Title).FirstOrDefault();
            Price9Tbl.Text = App.context.CourseTable.Where(c => c.ID == 9).Select(c => c.Price + " руб.").FirstOrDefault().ToString();
            Duration9Tbl.Text = App.context.CourseTable.Where(c => c.ID == 9).Select(c => c.Duration + " часов").FirstOrDefault().ToString();

            // Десятый курс
            // Десятый курс
            Name10Tbl.Text = App.context.CourseTable.Where(c => c.ID == 10).Select(c => c.Title).FirstOrDefault();
            Desc10Tbl.Text = App.context.CourseTable.Where(c => c.ID == 10).Select(c => c.Description).FirstOrDefault();
            Category10Tbl.Text = App.context.CourseTable.Where(c => c.ID == 10).Select(c => c.Category.Title).FirstOrDefault();
            FullName10Tbl.Text = App.context.CourseTable.Where(c => c.ID == 10).Select(c => c.Teacher.Surname + " " + c.Teacher.Name + " " + c.Teacher.Patronymic).FirstOrDefault();
            Format10Tbl.Text = App.context.CourseTable.Where(c => c.ID == 10).Select(c => c.Format.Title).FirstOrDefault();
            Price10Tbl.Text = App.context.CourseTable.Where(c => c.ID == 10).Select(c => c.Price + " руб.").FirstOrDefault().ToString();
            Duration10Tbl.Text = App.context.CourseTable.Where(c => c.ID == 10).Select(c => c.Duration + " часов").FirstOrDefault().ToString();
        }
        public void LoadingDataForCmb()
        {
            firstCourse.Visibility = Visibility.Visible;
            secondCourse.Visibility = Visibility.Visible;
            thirdCourse.Visibility = Visibility.Visible;
            fourCourse.Visibility = Visibility.Visible;
            fiveCourse.Visibility = Visibility.Visible;
            sixCourse.Visibility = Visibility.Visible;
            sevenCourse.Visibility = Visibility.Visible;
            eightCourse.Visibility = Visibility.Visible;
            nineCourse.Visibility = Visibility.Visible;
            tenCourse.Visibility = Visibility.Visible;
        }

        private void Add1Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            CheckCourse(App.currentUser.ID, App.context.CourseTable.Where(c => c.ID == 1).Select(c => c.ID).FirstOrDefault());
        }

        private void Add2Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void Add3Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void Add4Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void Add5Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void Add6Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void Add7Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void Add8Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void Add9Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void Add10Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void CheckCourse(int userID, int courseID)
        {
            if (userID == courseID)
            {
                MessageBox.Show("Это курс уже добавлен в профиль!");
            }
        }

        private void CategoryCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Category selectedCategory = CategoryCmb.SelectedItem as Category;
            if (CategoryCmb.SelectedIndex == 0)
            {
                LoadingDataForCmb();
            }
            else
            {
                switch (CategoryCmb.SelectedIndex)
                {
                    case 1:
                        firstCourse.Visibility = Visibility.Visible;
                        secondCourse.Visibility = Visibility.Collapsed;
                        thirdCourse.Visibility = Visibility.Visible;
                        fourCourse.Visibility = Visibility.Collapsed;
                        fiveCourse.Visibility = Visibility.Visible;
                        sixCourse.Visibility = Visibility.Collapsed;
                        sevenCourse.Visibility = Visibility.Collapsed;
                        eightCourse.Visibility = Visibility.Collapsed;
                        nineCourse.Visibility = Visibility.Visible;
                        tenCourse.Visibility = Visibility.Collapsed;
                        break;
                    case 2:
                        firstCourse.Visibility = Visibility.Collapsed;
                        secondCourse.Visibility = Visibility.Collapsed;
                        thirdCourse.Visibility = Visibility.Collapsed;
                        fourCourse.Visibility = Visibility.Collapsed;
                        fiveCourse.Visibility = Visibility.Collapsed;
                        sixCourse.Visibility = Visibility.Collapsed;
                        sevenCourse.Visibility = Visibility.Visible;
                        eightCourse.Visibility = Visibility.Visible;
                        nineCourse.Visibility = Visibility.Collapsed;
                        tenCourse.Visibility = Visibility.Collapsed;
                        break;
                    case 3:
                        firstCourse.Visibility = Visibility.Collapsed;
                        secondCourse.Visibility = Visibility.Visible;
                        thirdCourse.Visibility = Visibility.Collapsed;
                        fourCourse.Visibility = Visibility.Collapsed;
                        fiveCourse.Visibility = Visibility.Collapsed;
                        sixCourse.Visibility = Visibility.Collapsed;
                        sevenCourse.Visibility = Visibility.Collapsed;
                        eightCourse.Visibility = Visibility.Collapsed;
                        nineCourse.Visibility = Visibility.Collapsed;
                        tenCourse.Visibility = Visibility.Visible;
                        break;
                    case 4:
                        firstCourse.Visibility = Visibility.Collapsed;
                        secondCourse.Visibility = Visibility.Collapsed;
                        thirdCourse.Visibility = Visibility.Collapsed;
                        fourCourse.Visibility = Visibility.Visible;
                        fiveCourse.Visibility = Visibility.Collapsed;
                        sixCourse.Visibility = Visibility.Visible;
                        sevenCourse.Visibility = Visibility.Collapsed;
                        eightCourse.Visibility = Visibility.Collapsed;
                        nineCourse.Visibility = Visibility.Collapsed;
                        tenCourse.Visibility = Visibility.Collapsed;
                        break;
                }
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameHelper.mainFrame.Navigate(new View.Pages.WelcomePage());
        }
    }
}
