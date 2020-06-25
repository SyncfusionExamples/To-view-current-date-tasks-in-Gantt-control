using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.Windows.Controls.Gantt;
using System.Windows.Controls.Primitives;
using Syncfusion.Windows.Controls.Gantt.Chart;
using Syncfusion.Windows.Controls.Gantt.Schedule;

namespace EssentialGantt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Gantt.Loaded += new RoutedEventHandler(Gantt_Loaded);
        }

        void Gantt_Loaded(object sender, RoutedEventArgs e)
        {
            this.Gantt.ScrollGanttChartTo(DateTime.Now);
        }
    }
}
