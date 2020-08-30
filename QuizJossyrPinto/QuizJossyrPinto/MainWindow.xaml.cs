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

namespace QuizJossyrPinto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text.ToLower() == "mrkeroro" && txtPassword.Password == "1234")
            {
                pnlAccess.Visibility = Visibility.Visible;
                lblUsername.Content = txtUsername.Text;
                pnlForm.Visibility = Visibility.Hidden;
            }
            else
            {
                MessageBox.Show("Wrong Password or Username");
            }
        }


        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            pnlAccess.Visibility = Visibility.Hidden;
            pnlForm.Visibility = Visibility.Visible;
            txtUsername.Text = "";
            txtPassword.Password = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lstFrutas.Items.Add(txtFrutas.Text);
            txtFrutas.Text = string.Empty;
        }
    }
}
