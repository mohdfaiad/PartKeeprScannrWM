using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PartkeeprScannr
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void Save()
        {
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\PartkeeprScannr", "username", userUsername.Text, RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\PartkeeprScannr", "password", userPassword.Text, RegistryValueKind.ExpandString);
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\PartkeeprScannr", "server", serverURL.Text, RegistryValueKind.ExpandString);

        }


        private void menuSave_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
            
        }

        private void Config_Load(object sender, EventArgs e)
        {
            updateBtnShortcutText();
            userUsername.Text = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\PartkeeprScannr", "username", "admin");
            userPassword.Text = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\PartkeeprScannr", "password", "admin");
            serverURL.Text = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\PartkeeprScannr", "server", "https://demo.partkeepr.org");

        }

        private void Config_Closing(object sender, CancelEventArgs e)
        {
            Save();
        }

        private void btnShortcut_Click(object sender, EventArgs e)
        {
            string appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            string pfadVerknüpfungsdatei = Environment.GetFolderPath(Environment.SpecialFolder.Programs) + "\\" + appName + ".lnk";
            string exePfad = "\"" + System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase + "\"";

            if (System.IO.File.Exists(pfadVerknüpfungsdatei))
            {
                System.IO.File.Delete(pfadVerknüpfungsdatei);
                
            }
            else
            {
                System.IO.StreamWriter swLnkDatei = System.IO.File.CreateText(pfadVerknüpfungsdatei);
                swLnkDatei.WriteLine(exePfad.Length.ToString() + "#" + exePfad);
                swLnkDatei.Close();
            }

            updateBtnShortcutText();      
            
            
        }

        private void updateBtnShortcutText()
        {
            string appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            string pfadVerknüpfungsdatei = Environment.GetFolderPath(Environment.SpecialFolder.Programs) + "\\" + appName + ".lnk";

            if (System.IO.File.Exists(pfadVerknüpfungsdatei))
            {
                btnShortcut.Text = "Remove Shortcut";

            }
            else
            {
                btnShortcut.Text = "Add Shortcut";
            }

        }


    }
}