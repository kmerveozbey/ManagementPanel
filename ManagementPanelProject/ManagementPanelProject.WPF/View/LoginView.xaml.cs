using ManagementPanelProject.BLL;
using ManagementPanelProject.BLL.Implementations;
using ManagementPanelProject.BLL.Process;
using ManagementPanelProject.DAL;
using ManagementPanelProject.DAL.ContextInfo;
using ManagementPanelProject.DAL.Implementations;
using ManagementPanelProject.Entity.Models;
using ManagementPanelProject.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {

        //private readonly IUserService _userService;
        //private readonly ILoginActivityService _activityListService;
        //private readonly IUserRoleService _userRoleService;
        //private readonly IRoleService _roleService;

        MyContext context = new MyContext();

        public LoginView()
        {
            InitializeComponent();
            Methods addInitDataMethod = new Methods();
            addInitDataMethod.addInitData(); //The admin user and  two roles added
            getStringData();
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
                if (!String.IsNullOrEmpty(txtUser.Text))
                {
                    Methods activityLogUpdateMethod = new Methods();
                    var userName = context.Users.Where(x => x.UserName == txtUser.Text).FirstOrDefault();
                    if (userName != null)
                        activityLogUpdateMethod.activityLogUpdate(userName.UserName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Methods validateMethod = new Methods();
                Boolean userNameControl = validateMethod.validateForm(txtUser.Text, lblUsername.Text);
                if (userNameControl)
                {
                    LoginViewModel login = new LoginViewModel()
                    {
                        UserName = txtUser.Text,
                    };
                    var md5Password = ProcessForPassword.MD5Hash(txtPass.Password.ToString());
                    var user = context.Users.Where(x => x.UserName == txtUser.Text).FirstOrDefault();

                    if (user != null && user.Password == md5Password)
                    {
                        var userName = context.Users.Where(x => x.UserName == txtUser.Text && x.Password == md5Password).FirstOrDefault();
                        if (userName != null)
                        {
                            var isLoginStatus = context.LoginActivityList.Where(x => x.UserName == userName.UserName && x.LoginIsActive == true).FirstOrDefault();
                            if (isLoginStatus == null)
                            {
                                Methods activityLogCreateMethod = new Methods();
                                activityLogCreateMethod.activityLogCreate(userName.UserName.ToString(), true, true);

                                var roleName = context.UserRole.Where(x => (x.UserRoleUserName == userName.UserName)).FirstOrDefault();
                                if (roleName != null)
                                {
                                    if (roleName.UserRoleRoleName.ToLower().Trim() == StringLibrary.Admin)
                                    {

                                        AdminView.userName = userName.UserName;
                                        AdminView admView = new AdminView();
                                        admView.ShowDialog();
                                        this.Hide();
                                    }
                                    else if (roleName.UserRoleRoleName.ToLower().Trim() == StringLibrary.StandardUser)
                                    {
                                        StandardView.userName = userName.UserName;
                                        StandardView stdView = new StandardView();
                                        stdView.ShowDialog();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show(StringLibrary.RoleNotFound);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show(StringLibrary.UserAlreadyLogin);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(StringLibrary.UserError);
                        Methods activityLogCreateMethod = new Methods();
                        activityLogCreateMethod.activityLogCreate(txtUser.Text.ToString(), false, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                MessageBox.Show(StringLibrary.LogOutMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #region Methods Start       
        private void getStringData()
        {
            try
            {
                lblUsername.Text = StringLibrary.Username;
                lblPassword.Text = StringLibrary.Password;
                btnLogin.Content = StringLibrary.Login;
                Login.Name = StringLibrary.Login;
                Login.Text = StringLibrary.Login;
                ManagementPanel.Text = StringLibrary.ManagementPanel.ToUpper();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        #endregion Methods End

    }
}
