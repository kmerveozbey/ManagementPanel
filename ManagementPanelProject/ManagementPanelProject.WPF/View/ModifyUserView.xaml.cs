using ManagementPanelProject.BLL.Process;
using ManagementPanelProject.DAL.ContextInfo;
using ManagementPanelProject.Entity.Models;
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
    /// Interaction logic for ModifyUserView.xaml
    /// </summary>
    /// 
    public partial class ModifyUserView : Window
    {

        public static string getUserName;
        MyContext context = new MyContext();
        public ModifyUserView()
        {
            InitializeComponent();
            getSelectedUSer();
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

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!validateControl()) return;

                var user = context.Users.Where(x => x.UserName == getUserName.ToString()).FirstOrDefault();
                if (user != null)
                {
                    user.Name = txtName.Text;
                    user.Surname = txtSurname.Text;
                    user.Email = txtEmail.Text;
                    user.Birthday = Convert.ToDateTime(dtBirthDay.Text);
                    user.Phone = txtPhone.Text;
                    user.School = txtSchool.Text;
                    if(!String.IsNullOrEmpty(txtPass.Password) || txtPass.Password.ToString() != "" )
                    {
                        var md5Password = ProcessForPassword.MD5Hash(txtPass.Password);
                        user.Password = md5Password;
                    }
                    var result = context.Users.Update(user);
                    context.SaveChanges();
                    MessageBox.Show(StringLibrary.Success);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Methods Start
        private void getSelectedUSer()
        {
            try
            {
                var user = context.Users.Where(x => x.UserName == getUserName.ToString()).FirstOrDefault();
                if (user != null)
                {
                    txtUser.Text = user.UserName;
                    txtName.Text = user.Name;
                    txtSurname.Text = user.Surname;
                    txtEmail.Text = user.Email;
                    txtPhone.Text = user.Phone;
                    txtSchool.Text = user.School;
                    dtBirthDay.Text = user.Birthday.ToString();
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
                lblName.Text = StringLibrary.Name;
                lblSchool.Text = StringLibrary.School;
                lblSurname.Text = StringLibrary.Surname;
                btnUpdate.Content = StringLibrary.Update;
                txtModify.Text = StringLibrary.Modify;
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
