using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;

namespace ADmanager
{
   

    public partial class Form1 : Form
    {
        public string CreateUserAccount(string ldapPath, User U)
        {
            string oGUID = string.Empty; 
            try
            {

                string connectionPrefix = "LDAP:" + ldapPath; // LDAP://OU=Users,DC=company,DC=com
                DirectoryEntry dirEntry = new DirectoryEntry(connectionPrefix);
                DirectoryEntry newUser = dirEntry.Children.Add("CN=" + U.givenName+" "+U.sn, "user");
                newUser.Properties["samAccountName"].Value = U.userName;
                newUser.Properties["displayName"].Value = U.givenName + " " + U.sn;
                newUser.Properties["givenName"].Value = U.givenName;
                newUser.Properties["department"].Value = U.department;
                newUser.Properties["company"].Value = U.company;
                newUser.Properties["title"].Value = U.title;
                newUser.Properties["sn"].Value = U.sn;
                newUser.Properties["mobile"].Value = U.mobile;
                newUser.Properties["telephoneNumber"].Value = U.telephone;

                newUser.Properties["employeeNumber"].Value = U.DateOfBirth;
                newUser.Properties["extensionAttribute1"].Value = U.DepOne;
                newUser.Properties["extensionAttribute2"].Value = U.SubDep;
                newUser.Properties["extensionAttribute3"].Value = U.ShortName;
                newUser.Properties["userPrincipalName"].Value = U.userPrincipalName;
                newUser.CommitChanges();
                oGUID = newUser.Guid.ToString();

                newUser.Invoke("SetPassword", new object[] { U.Password });

                int val = (int)newUser.Properties["userAccountControl"].Value;
                newUser.Properties["userAccountControl"].Value = val & ~0x2;
                //ADS_UF_NORMAL_ACCOUNT;

                newUser.CommitChanges();
                dirEntry.Close();
                newUser.Close();
            }
            catch (System.DirectoryServices.DirectoryServicesCOMException E)
            {
                //DoSomethingwith --> E.Message.ToString();
                MessageBox.Show(E.Message.ToString());
            }
            return oGUID;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonDo_Click(object sender, EventArgs e)
        {
            User User = new User();
            User.company = "113tv";
            User.department = "IT";
            User.givenName = "John";
            User.Password = "P@ssw0rd";
            User.mobile = "+38 044 444 44 44";
            User.sn = "Stainback";
            User.telephone = "+38 099 993 33 33";
            User.title = "Engeneer";
            User.userName = "j.stainback";
            User.DateOfBirth = "22.03.1984";
            User.DepOne = "IT charts";
            User.SubDep = "SubIT";
            User.ShortName = "Some short name";
            User.userPrincipalName = User.userName + "@113tv.com";

            ConsoleBox.AppendText("New user created "+CreateUserAccount("//cn=Users,dc=113tv,dc=com",User));
        }
    }

    public class User
    {
        public string userName { get; set; }
        public string givenName { get; set; }
        public string sn { get; set; }
        public string department { get; set; }
        public string title { get; set; }
        public string company { get; set; }
        public string mobile { get; set; }
        public string telephone { get; set; }
        public string Password { get; set; }
        public string DateOfBirth { get; set; }
        public string DepOne { get; set; }
        public string SubDep { get; set; }
        public string ShortName { get; set; }
        public string userPrincipalName { get; set; }

        public User()
        {
            userName = String.Empty;
            givenName = String.Empty;
            sn = String.Empty;
            department = String.Empty;
            title = String.Empty;
            company = String.Empty;
            mobile = String.Empty;
            telephone = String.Empty;
            Password = String.Empty;
            DateOfBirth = String.Empty;
            DepOne = String.Empty;
            SubDep = String.Empty;
            ShortName = String.Empty;
            userPrincipalName = String.Empty;
        }
    }
}
