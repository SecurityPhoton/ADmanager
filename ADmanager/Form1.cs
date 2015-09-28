using System;
using System.Collections.Generic;
using System.Collections;
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
        public static bool ObjExists(string objectPath) // Check existense of an object
        {
            bool found = false;
            try
            {

                if (DirectoryEntry.Exists(objectPath))
                {
                    found = true;
                }
            }
            catch (Exception ex_ObjExists)
            {
                MessageBox.Show(ex_ObjExists.Message.ToString());
            }

            return found;
        }

        public string CreateUserAccount(string ldapPath, User U)
        {
            string oGUID = string.Empty;
            try
            {

                string connectionPrefix = "LDAP:" + ldapPath; // LDAP://cn=Users,DC=company,DC=com
                DirectoryEntry dirEntry = new DirectoryEntry(connectionPrefix);
                DirectoryEntry newUser = dirEntry.Children.Add("CN=" + U.givenName + " " + U.sn, "user");
                newUser.Properties["samAccountName"].Value = U.userName;
                newUser.Properties["displayName"].Value = U.sn + " " + U.givenName + " " + U.SecondName;
                if (!String.IsNullOrEmpty(U.givenName))
                {
                    newUser.Properties["givenName"].Value = U.givenName;
                }

                if (!String.IsNullOrEmpty(U.department))
                {
                    newUser.Properties["department"].Value = U.department;
                }

                if (!String.IsNullOrEmpty(U.company))
                {
                    newUser.Properties["company"].Value = U.company;
                }
                if (!String.IsNullOrEmpty(U.title))
                {
                    newUser.Properties["title"].Value = U.title;
                }
                
                newUser.Properties["sn"].Value = U.sn;


                if (!("+38            " == U.mobile))
                {
                    newUser.Properties["mobile"].Value = U.mobile;
                }
                if (!("+38            " == U.telephone))
                {
                    newUser.Properties["telephoneNumber"].Value = U.telephone;
                }
                
                if (!(U.DateOfBirth == "") || !(U.DateOfBirth == " . ."))
                {
                    newUser.Properties["employeeNumber"].Value = U.DateOfBirth;
                }
                if (!String.IsNullOrEmpty(U.DepOne))
                {
                    newUser.Properties["extensionAttribute1"].Value = U.DepOne; 
                }
                if (!String.IsNullOrEmpty(U.SubDep))
                {
                    newUser.Properties["extensionAttribute2"].Value = U.SubDep;
                }
                if (!String.IsNullOrEmpty(U.ShortName))
                {
                    newUser.Properties["extensionAttribute3"].Value = U.ShortName;
                }
                
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

        public ArrayList EnumerateOU(string OuDn)
        {
            ArrayList alObjects = new ArrayList();
            try
            {
                DirectoryEntry directoryObject = new DirectoryEntry("LDAP://" + OuDn);
                
                foreach (DirectoryEntry child in directoryObject.Children)
                {
                    string childPath = child.Path.ToString();
                    alObjects.Add(childPath.Remove(0, 7));
                    ConsoleBox.AppendText(child.Name+"\n");
                    //remove the LDAP prefix from the path

                    child.Close();
                    child.Dispose();
                }
                directoryObject.Close();
                directoryObject.Dispose();
            }
            catch (DirectoryServicesCOMException e)
            {
                ConsoleBox.AppendText("An Error Occurred: " + e.Message.ToString());
            }
            return alObjects;
        }

        public ArrayList GetAllGroupNames(string ouPath)
        {
            DirectorySearcher deSearch = new DirectorySearcher();
            //deSearch.SearchRoot = GetRootDirectoryEntry(ipAddress, ouPath);
            deSearch.Filter = "(&(objectClass=group))";
            SearchResultCollection results = deSearch.FindAll();
            if (results.Count > 0)
            {
                ArrayList groupNames = new ArrayList();

                foreach (SearchResult group in results)
                {
                    var entry = new DirectoryEntry(group.Path);
                    string shortName = entry.Name.Substring(3, entry.Name.Length - 3);
                    groupNames.Add(shortName);
                    ConsoleBox.AppendText(entry.Name + "\n");
                }

                return groupNames;
            }
            else
            {
                return new ArrayList();
            }
        }

        public void AddToGroup(string userDn, string groupDn)
        {
            try
            {
                DirectoryEntry dirEntry = new DirectoryEntry("LDAP://" + groupDn);
                dirEntry.Properties["member"].Add(userDn);
                dirEntry.CommitChanges();
                dirEntry.Close();
            }
            catch (System.DirectoryServices.DirectoryServicesCOMException E)
            {
                ConsoleBox.AppendText("An Error Occurred: " + E.Message.ToString());
            }
        }

        public string makeUserDN(string name)
        {
            string DN = String.Empty;
            DN = "cn=" + name + "," + OUBox.Text;
            return DN;
        }

        public string makeGroupDN(string name)
        {
            string DN = String.Empty;
            DN = "cn=" + name + ","+ GroupOUBox.Text;
            return DN;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonDo_Click(object sender, EventArgs e)
        {
            //User User = new User();
            //User.company = "113tv";
            //User.department = "IT";
            //User.givenName = "John";
            //User.Password = "P@ssw0rd";
            //User.mobile = "+38 044 444 44 44";
            //User.sn = "Stainback";
            //User.telephone = "+38 099 993 33 33";
            //User.title = "Engeneer";
            //User.userName = "j.stainback";
            //User.DateOfBirth = "22.03.1984";
            //User.DepOne = "IT charts";
            //User.SubDep = "SubIT";
            //User.ShortName = "Some short name";
            //User.userPrincipalName = User.userName + "@113tv.com";

            User User = new User();

            if ((PasswordBox.Text != PasswordConfirmBox.Text) || String.IsNullOrEmpty(PasswordConfirmBox.Text))
            {
                PasswordConfirmBox.Text = String.Empty;
                MessageBox.Show("Password is empty or fields do not match!");
                return;
            }

            if (string.IsNullOrEmpty(LoginBox.Text))
            {
                 MessageBox.Show("Login field cannot be empty!");
                return;
            }

            if (string.IsNullOrEmpty(SurnameBox.Text))
            {
                MessageBox.Show("Surname field cannot be empty!");
                return;
            }

            User.company = Domain.Text;
            User.department = DepartmentBox.Text;
            User.givenName = NameBox.Text;
            User.Password = PasswordBox.Text;
            User.mobile = MobileBox.Text;
            User.sn = SurnameBox.Text;
            User.telephone = WorkPhoneBox.Text;
            User.title = TitleBox.Text;
            User.userName = LoginBox.Text;
            User.DateOfBirth = DateTextBox1.Text;
            User.DepOne = Dep2Box.Text;
            User.SubDep = SubDepBox.Text;
            User.ShortName = ShortBox.Text;
            User.userPrincipalName = User.userName + "@" + Domain.Text;

            ConsoleBox.AppendText("New user created " + CreateUserAccount("//" + OUBox.Text, User));
            //AddToGroup("cn="+User.userName+""+User.sn+",dc=113tv,dc=com", GroupBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DomainBox.Text= System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAllGroupNames(OUBox.Text);
            // EnumerateOU(OUBox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddToGroup(makeUserDN(NameBox.Text + " " + SurnameBox.Text), makeGroupDN(GroupBox.Text));
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
        public string SecondName { get; set; }

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
            SecondName = String.Empty;
        }
    }
}
