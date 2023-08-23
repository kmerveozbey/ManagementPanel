using ManagementPanelProject.BLL.Process;
using ManagementPanelProject.DAL.ContextInfo;
using ManagementPanelProject.Entity.Models;
using ManagementPanelProject.Entity.ViewModels;
using Microsoft.EntityFrameworkCore;
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
    public partial class AdminView : Window
    {
        public static string userName;
        MyContext context = new MyContext();
        public AdminView()
        {
            InitializeComponent();
            txtAdm.Text = StringLibrary.Welcome + " - " + userName;
            getAllUsers();
            getStringData();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (userName != null)
            {
                Methods activityLogUpdateMethod = new Methods();
                var getUserName = context.Users.Where(x => x.UserName == userName).FirstOrDefault();
                activityLogUpdateMethod.activityLogUpdate(getUserName.UserName);
            }
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

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AddUserView addUser = new AddUserView();
                addUser.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void modify_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserViewModel getuserName = (UserViewModel)listGrid.SelectedItem;
                if (getuserName != null)
                {
                    ModifyUserView.getUserName = getuserName.UserName;
                    ModifyUserView modifyUser = new ModifyUserView();
                    modifyUser.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                getAllUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserViewModel getuserName = (UserViewModel)listGrid.SelectedItem;
                if (getuserName != null && userName != getuserName.UserName)
                {
                    MessageBoxResult result = MessageBox.Show(getuserName.UserName + StringLibrary.DeleteRequestMessage, StringLibrary.DeleteUserApproval, MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        var user = context.Users.Where(x => x.UserName == getuserName.UserName).FirstOrDefault();
                        if (user != null)
                        {
                            context.Users.Remove(user);
                            context.SaveChanges();
                            getAllUsers();
                        }
                    }
                }
                else if (getuserName == null)
                {
                    MessageBox.Show(StringLibrary.UserSelectError);
                }
                else if(userName == getuserName.UserName)
                {
                    MessageBox.Show(StringLibrary.NotDeleteOwnAccount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btNewAcc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AddUserView addUser = new AddUserView();
                addUser.ShowDialog();
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
        private void getStringData()
        {
            try
            {
                addClick.Header = StringLibrary.NewRecord;
                modifyClick.Header = StringLibrary.Modify;
                deleteClick.Header = StringLibrary.Delete;
                refreshClick.Header = StringLibrary.Refresh;
                btNewAcc.Content = StringLibrary.NewRecord;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion Methods End

       
    }

}
