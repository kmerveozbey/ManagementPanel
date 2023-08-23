using ManagementPanelProject.DAL.ContextInfo;
using ManagementPanelProject.Entity.ViewModels;
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
using System.Windows.Shapes;

namespace ManagementPanelProject.WPF.View
{
    /// <summary>
    /// Interaction logic for StandardView.xaml
    /// </summary>
    public partial class StandardView : Window
    {
        public static string userName;
        MyContext context = new MyContext();

        public StandardView()
        {
            InitializeComponent();
            UserPanel.Text = StringLibrary.Welcome + " - " + userName;
            getAllUsers();
        }
        
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                    DragMove();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WindowState = WindowState.Minimized;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Application.Current.Shutdown();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btUserAcc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (userName != null)
                {
                    ModifyUserView.getUserName = userName;
                    ModifyUserView modifyUser = new ModifyUserView();
                    modifyUser.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Methods Start
        private void getAllUsers()
        {
            try
            {
                listGrid.ItemsSource = null;
                Methods getUsers = new Methods();
                listGrid.ItemsSource = getUsers.getUsers();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static int CalculateAge(DateTime dateOfBirth)
        {
            try
            {
                int age = 0;
                age = DateTime.Now.Year - dateOfBirth.Year;
                if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                    age = age - 1;

                return age;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        #endregion Methods End

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (userName != null)
            {
                Methods activityLogUpdateMethod = new Methods();
                var getUserName = context.Users.Where(x => x.UserName == userName).FirstOrDefault();
                activityLogUpdateMethod.activityLogUpdate(getUserName.UserName);
            }
        }
    }
}
