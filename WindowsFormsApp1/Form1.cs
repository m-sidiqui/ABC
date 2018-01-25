using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        IWebDriver driver;
        public Form1()
        {
            InitializeComponent();
        }

        private void ChromeStart_Click(object sender, EventArgs e)
        {
            driver = new ChromeDriver();
        }

        private void Navigate_Click(object sender, EventArgs e)
        {
            driver.Url = txtValue.Text;
           
        }

        private void Back_Click(object sender, EventArgs e)
        {
            driver.Navigate().Back();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            driver.Navigate().Forward();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            driver.Navigate().Refresh();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            driver.Close();
            driver.Quit();
        }

        private void Click_Click(object sender, EventArgs e)
        {
            IWebElement element = driver.FindElement(By.Name("q"));

            element.Clear();

            element.SendKeys(txtValue.Text);

            element.Submit();
        }
    }
}
