using Azure.Identity;
using ManagementPanelProject.BLL.Process;
using ManagementPanelProject.DAL.ContextInfo;
using ManagementPanelProject.Entity.Models;
using ManagementPanelProject.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace ManagementPanelProject.WPF
{
    class Methods
    {

        MyContext context = new MyContext();
        public void activityLogCreate(string userName, Boolean isLoginStatus, Boolean isActive)
        {
            try
            {
                LoginActivityModel activityLogs = new LoginActivityModel()
                {
                    LoginActivityID = Guid.NewGuid(),
                    UserName = userName,
                    LogInDate = DateTime.Now,
                    LoginStatus = isLoginStatus,
                    LoginIsActive = isActive
                };
                activityLogs.User = context.Users.Where(x => x.UserName == userName).FirstOrDefault();
                if (isLoginStatus == false)
                    activityLogs.LogoutDate = DateTime.Now;

                context.LoginActivityList.Add(activityLogs);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void activityLogUpdate(string userName)
        {
            try
            {
                var loginActivityList = context.LoginActivityList.Where(x => x.UserName == userName && x.LoginIsActive == true).FirstOrDefault();
                if (loginActivityList != null)
                {
                    loginActivityList.LoginIsActive = false;
                    loginActivityList.LogoutDate = DateTime.Now;

                    context.LoginActivityList.Update(loginActivityList);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void addRole(string roleName, string roleDesc)
        {
            try
            {
                var role = context.Roles.Where(x => x.RoleName == roleName).FirstOrDefault();
                if (role == null)
                {
                    RoleModel newRole = new RoleModel()
                    {
                        RoleName = roleName,
                        RoleDesc = roleDesc,

                    };
                    var result = context.Roles.Add(newRole);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addUser(UserModel user, string userRoleName)
        {
            try
            {
                var md5Password = ProcessForPassword.MD5Hash(user.Password);
                var getUser = context.Users.Where(x => x.UserName == user.UserName.ToString()).FirstOrDefault();
                if (getUser == null)
                {
                    UserModel newUser = new UserModel()
                    {
                        UserName = user.UserName,
                        Name = user.Name,
                        Surname = user.Surname,
                        Email = user.Email,
                        Birthday = Convert.ToDateTime(user.Birthday),
                        Phone = user.Phone,
                        Password = md5Password,
                        School = user.School,
                        ExperienceYear = user.ExperienceYear,
                    };
                    var userResult = context.Users.Add(newUser);
                    context.SaveChanges();


                    var userRole = context.UserRole.Where(x => x.UserRoleUserName == user.UserName).FirstOrDefault();
                    if (userRole == null)
                    {

                        UserRoleModel newUserRole = new UserRoleModel()
                        {
                            UserRoleUserName = user.UserName,
                            UserRoleRoleName = userRoleName,
                        };
                        newUserRole.User = context.Users.Where(x => x.UserName == user.UserName).FirstOrDefault();
                        newUserRole.Role = context.Roles.Where(x => x.RoleName == userRoleName).FirstOrDefault();
                        var userRoleResult = context.UserRole.Add(newUserRole);
                        context.SaveChanges();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void addInitData()
        {
            try
            {
                #region Role Add Start
                addRole("administrator", "admin user");
                addRole("standarduser", "standard user");               
                #endregion Role Add Start End

                #region User Add Start
                UserModel newUser = new UserModel()
                {
                    UserName = "admin",
                    Name = "admin",
                    Surname = "admin",
                    Email = "admin@admin",
                    Birthday = Convert.ToDateTime("05/05/1955"),
                    Phone = "05332152321",
                    Password = "admin",
                    School = "",
                };
                addUser(newUser, "administrator");
                #endregion User Add End
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public List<UserViewModel> getUsers()
        {
            var userModels = context.Users.ToList();
            List<UserViewModel> users = new List<UserViewModel>();

            //yeni view ile ekrana belirli değerler yazılsın.
            foreach (var user in userModels)
            {
                UserViewModel userList = new UserViewModel()
                {
                    UserName = user.UserName,
                    Name = user.Name,
                    Surname = user.Surname,
                    Email = user.Email,
                    Birthday = Convert.ToDateTime(user.Birthday).ToShortDateString(),
                    Phone = user.Phone,
                    School = user.School,
                };
                userList.Age = CalculateAge(Convert.ToDateTime(user.Birthday));
                users.Add(userList);

            }
            return users;
        }
        public int CalculateAge(DateTime dateOfBirth)
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
        public bool regexControl(string text, string type)
        {
            try
            {
                bool isStatus = false;
                if (type.ToLower() == "email")
                {
                    Regex regexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                    isStatus = regexEmail.IsMatch(text);
                }
                else if (type.ToLower() == "number")
                {
                    Regex regexPhone = new Regex("^[a-zA-Z]*$");
                    isStatus = !regexPhone.IsMatch(text);
                }
                else if (type.ToLower() == "string")
                {
                    Regex regexString = new Regex("^[a-zA-Z]*$");
                    isStatus = regexString.IsMatch(text);
                }
                return isStatus;
            }
            catch (Exception ex)
            {
                return false;
            }
           
    }

        public bool validateForm(string text, string fieldName)
        {
            var result = false;
            try
            {
                if (String.IsNullOrEmpty(text))
                {
                    MessageBox.Show(fieldName + " " + StringLibrary.StringEmpty);
                    return false;
                }
                result = true;
            }
            catch (Exception ex)
            {
            }
            return result;
        }
    }
}
