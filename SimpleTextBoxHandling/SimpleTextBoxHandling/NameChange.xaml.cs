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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleTextBoxHandling
{
    /// <summary>
    /// Interaction logic for NameChange.xaml
    /// </summary>
    public partial class NameChange : Page
    {
        public NameChange()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text != "")
            {
                MessageBox.Show("Welcome ," + txtName.Text);
            }
            else
            {
                MessageBox.Show("you haven't type the Name");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
        }
    }
}
