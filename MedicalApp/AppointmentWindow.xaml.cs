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
using System.Windows.Shapes;



namespace MedicalApp
{
    public partial class AppointmentWindow : Window
    {
        public AppointmentWindow()
        {
            InitializeComponent();
        }

        private void ReserveAppointment_Click(object sender, RoutedEventArgs e)
        {
            // Reservation logic here
        }

        private void CancelAppointment_Click(object sender, RoutedEventArgs e)
        {
            // Cancellation logic here
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            var homeWindow = new HomeWindow();
            homeWindow.Show();
            this.Close();
        }
    }
}
