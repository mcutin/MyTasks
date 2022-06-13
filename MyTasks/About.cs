using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTasks
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}, build {1}", AssemblyVersion, AssemblyBuild);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            //this.textBoxDescription.Text = AssemblyDescription;
            this.textBoxDescription.Text = $"A (very) simple to do list manager software.{Environment.NewLine}{Environment.NewLine}" +
                $"Clipboard icon art by Icojam (https://iconarchive.com/artist/icojam.html).{Environment.NewLine}{Environment.NewLine}" +
                $"Clipboard icon downloaded from:{Environment.NewLine}" +
                $"https://iconarchive.com/show/onebit-4-icons-by-icojam/clipboard-icon.html.{Environment.NewLine}{Environment.NewLine}" +
                $"Clipboard icon is used under Creative Commons Public Domain License{Environment.NewLine}" +
                "(https://creativecommons.org/publicdomain/zero/1.0/).";
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                string majorMinor = Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() +
                    "." + Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString();
                return majorMinor;
                //return Assembly.GetExecutingAssembly().GetName().Version.ToString();
                
            }
        }

        public string AssemblyBuild
        {
            get
            {
                string build = Assembly.GetExecutingAssembly().GetName().Version.Build.ToString() +
                    "." + Assembly.GetExecutingAssembly().GetName().Version.Revision.ToString();
                return build;
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void lblGitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/mcutin");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not visit github.com/mcutin. Check your internet connection.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
