using ManagementPanelProject.BLL.Process;
using ManagementPanelProject.DAL.ContextInfo;
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
    /// Interaction logic for AddUserView.xaml
    /// </summary>
    public partial class AddUserView : Window
    {
        MyContext context = new MyContext();

        public AddUserView()
        {
            InitializeComponent();
            getUserRoles();
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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (!validateControl()) return;

                var md5Password = ProcessForPassword.MD5Hash(txtPass.Password.ToString());
                var user = context.Users.Where(x => x.UserName == txtUser.Text && x.Password == md5Password).FirstOrDefault();
                var role = context.Roles.Where(x => x.RoleName == cmbRole.SelectedItem.ToString()).FirstOrDefault();
                if (user == null && role != null)
                {
                    UserModel newUser = new UserModel()
                    {
                        UserName = txtUser.Text,
                        Name = txtName.Text,
                        Surname = txtSurname.Text,
                        Email = txtEmail.Text,
                        Birthday = Convert.ToDateTime(dtBirthDay.Text),
                        Phone = txtPhone.Text.ToString(),
                        Password = txtPass.Password.ToString(),
                        School = txtSchool.Text,
                    };
                    Methods userAdd = new Methods();
                    userAdd.addUser(newUser, role.RoleName);
                    MessageBox.Show(StringLibrary.Success);
                }
                else if (user != null)
                {
                    MessageBox.Show(StringLibrary.AlreadyExist);

                }
                else if (role == null)
                {
                    MessageBox.Show(StringLibrary.RoleNotFound);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Methods Start
        private void getUserRoles()
        {
            try
            {
                var roles = context.Roles.ToList();
                foreach (var role in roles)
                {
                    cmbRole.Items.Add(role.RoleName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getStringData()
        {
            try
            {
                lblUsername.Text = StringLibrary.Username;
                lblPassword.Text = StringLibrary.Password;
                lblEmail.Text = StringLibrary.Email;
                lblBirthday.Text = StringLibrary.Birthday;
                lblPhone.Text = StringLibrary.Phone;
                lblRole.Text = StringLibrary.Role;
                lblName.Text = StringLibrary.Name;
                lblSchool.Text = StringLibrary.School;
                lblSurname.Text = StringLibrary.Surname;
                btnSave.Content = StringLibrary.Save;
                txtAdd.Text = StringLibrary.NewRecord.ToUpper();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool validateControl()
        {
            try
            {
                Methods validateMethod = new Methods();
                bool status = true;
                bool regexControl;
                Boolean passControl = validateMethod.validateForm(txtPass.Password, lblPassword.Text);
                if (passControl == false) return false;

                Boolean userNameControl = validateMethod.validateForm(txtUser.Text, lblUsername.Text);
                if (userNameControl == false) return false;
                

                Boolean nameControl = validateMethod.validateForm(txtName.Text, lblName.Text);
                if (nameControl == false) return false;
                else
                {
                    regexControl = validateMethod.regexControl(txtName.Text, "string");
                    if (regexControl == false)
                    {
                        MessageBox.Show(lblName.Text + " " + StringLibrary.OnlyStringValue);
                        return false;
                    }
                }

                Boolean surnameControl = validateMethod.validateForm(txtSurname.Text, lblSurname.Text);
                if (surnameControl == false) return false;
                else
                {
                    regexControl = validateMethod.regexControl(txtSurname.Text, "string");
                    if (regexControl == false)
                    {
                        MessageBox.Show(lblSurname.Text + " " + StringLibrary.OnlyStringValue);
                        return false;
                    }
                }
                Boolean rolNameControl = validateMethod.validateForm(cmbRole.SelectedItem.ToString(), lblRole.Text);
                if (rolNameControl == false) return false;

                Boolean birthDayControl = validateMethod.validateForm(dtBirthDay.Text, dtBirthDay.Name);
                if (birthDayControl == false) return false;


                Boolean emailcontrol = validateMethod.validateForm(txtEmail.Text, lblEmail.Text);
                if (emailcontrol != false)
                {
                    bool emailRegexControl = validateMethod.regexControl(txtEmail.Text, "email");
                    if (emailRegexControl == false)
                    {
                        MessageBox.Show(StringLibrary.EmailFormatError);
                        return false;
                    }
                }

                if (!string.IsNullOrEmpty(txtPhone.Text))
                {
                    bool phoneRegexControl = validateMethod.regexControl(txtPhone.Text, "number");
                    if (phoneRegexControl == false)
                    {
                        MessageBox.Show(StringLibrary.PhoneFormatError);
                        return false;
                    }
                }

                return status;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion Methods End
    }
}
