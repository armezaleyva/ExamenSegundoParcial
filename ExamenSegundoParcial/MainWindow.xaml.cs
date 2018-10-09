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

namespace ExamenSegundoParcial {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, RoutedEventArgs e) {
            if (controlInfoPersonal.Visibility == Visibility.Visible) {
                if (controlInfoPersonal.txtNombre.Text == "" ||
                    controlInfoPersonal.txtApellidoPaterno.Text == "" ||
                    controlInfoPersonal.txtApellidoMaterno.Text == "" ||
                    controlInfoPersonal.txtEdad.Text == "") {
                    txtAlertaLlenarCampos.Visibility = Visibility.Visible;
                }
                else {
                    txtAlertaLlenarCampos.Visibility = Visibility.Collapsed;
                    controlInfoPersonal.Visibility = Visibility.Collapsed;
                    controlContacto.Visibility = Visibility.Visible;
                }
            }

            else if (controlContacto.Visibility == Visibility.Visible) {
                if (controlContacto.txtCorreo.Text == "" ||
                    controlContacto.txtTelefono.Text == "" ||
                    controlContacto.txtCelular.Text == "") {
                    txtAlertaLlenarCampos.Visibility = Visibility.Visible;
                }
                else {
                    txtAlertaLlenarCampos.Visibility = Visibility.Collapsed;
                    controlContacto.Visibility = Visibility.Collapsed;
                    controlInfoPago.Visibility = Visibility.Visible;
                }
            }

            else if (controlInfoPago.Visibility == Visibility.Visible) {
                var digitosTarjeta = controlInfoPago.txtNumeroTarjeta.Text.ToString();
                if (digitosTarjeta.Length != 16) {
                    txtAlertaDigitosTarjeta.Visibility = Visibility.Visible;
                }
                else {
                    txtAlertaDigitosTarjeta.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
