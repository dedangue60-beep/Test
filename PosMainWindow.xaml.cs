using System;
using System.Windows;
using System.Windows.Threading;

namespace POSPro.Views
{
    public partial class PosMainWindow : Window
    {
        private readonly DispatcherTimer _clockTimer;

        public PosMainWindow()
        {
            InitializeComponent();
            
            _clockTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            _clockTimer.Tick += (s, e) => TxtClock.Text = DateTime.Now.ToString("HH:mm");
            _clockTimer.Start();
            TxtClock.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
