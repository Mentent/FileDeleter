using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //打开文件
            var path = "";
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == true)
            {
                path = dialog.FileName;
            }
            else
            {
                MessageBox.Show("未选择文件");
            }
            //获取文件路径与名称与后缀
            this.txtbox1.Text = path;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (File.Exists(this.txtbox1.Text))
            {
                File.Delete(this.txtbox1.Text);
                MessageBox.Show("OK.");
            }
            else
            {
                MessageBox.Show("无此文件");
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
                MessageBox.Show("尚未实现.");
        }
    }
}
