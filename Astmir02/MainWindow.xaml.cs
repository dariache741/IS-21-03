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

namespace Astmir02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_login.Text))
            {
                MessageBox.Show("Логин пустой");
                return;
            }

            if (string.IsNullOrEmpty(tb_password.Password))
            {
                MessageBox.Show("Пароль пустой");
                return;
            }

            if (cb_eula_agree.IsChecked.Value)
            {
                MessageBox.Show("Вы не согласились с условием нашей программы");
                return;
            }


            if (tb_login.Text=="admin" && tb_password.Password== "123")
            {
                MessageBox.Show("Успешная авторизация");
                return;

            }
            else 
            {
                MessageBox.Show("ЫЫЫ шакалы");


            }


            //if (cb_eula_agree.IsChecked.Value)
            //{
                //MessageBox.Show("Ура вы согласились на наши условия!");
               // cb_eula_agree.IsEnabled = false;
                //this.Close();
            //}
           // else
            //{
            //    MessageBox.Show("Соглашайтесь!");
            //}


        }
    }
}
