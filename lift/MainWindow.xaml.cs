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
using System.Windows.Threading;

namespace lift
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        double StartY = 524;
        DispatcherTimer timer = new DispatcherTimer();
        LiftDrive ld;
        public MainWindow()
        {
            InitializeComponent();
            ld = new LiftDrive(StartY);
            timer.Interval = TimeSpan.FromSeconds(0.05);
            
        }

        

        private void UserControl1_Change_floor(string floor)
        {
            double length = ld.toDrive(Canvas.GetTop(Lift), Int32.Parse(floor));
            double step = length / 50;
            for (int i = 0; i < 50; i++)
            {
                Canvas.SetTop(Lift, Canvas.GetTop(Lift) - step);
            }
        }
    }
}
