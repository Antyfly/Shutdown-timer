using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Shutdown_timer.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        

        private void TimeHalf_Click(object sender, RoutedEventArgs e)
        {
            int time = 30;
            MyTime(time);
        }
        private void TimeHour_Click(object sender, RoutedEventArgs e)
        {
            int time = 60;
            MyTime(time);
        }
        private void TimeHourHalf_Click(object sender, RoutedEventArgs e)
        {
            int time = 90;
            MyTime(time);
        }

        private void TimeTwoHour_Click(object sender, RoutedEventArgs e)
        {
            int time = 120;
            MyTime(time);
        }
        public void MyTime(int time)
        {
            InitializeComponent();
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(Timer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, time, 0);
            dispatcherTimer.Start();
            MessageBox.Show("Таймер запущен");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
            
        }
    }
}
