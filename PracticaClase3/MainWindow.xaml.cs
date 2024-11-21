using App.Controller;
using App.Model;
using Microsoft.Win32;
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

namespace PracticaClase3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            if(txtNombre.Text.Equals("") || txtTipoEnergia.Text.Equals("") 
                || txtColor.Text.Equals("") || txtMarca.Text.Equals(""))
            {
                MessageBox.Show("Hay un campo vacio corrija", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                Data.Text = "Error";
                return;
            }


            Carro vehiculo = new Carro(txtNombre.Text,
                txtTipoEnergia.Text, "", txtColor.Text,txtMarca.Text);
            Data.Text = vehiculo.ToString();
            ISave salvar = Mediator.Instance.ObtenerNuevoSave();
            salvar.Path = GetPath();
            salvar.Save(vehiculo.ToString());   
        }
        private string GetPath()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Download"; //Default Name
            dialog.DefaultExt = ".txt";
            dialog.Filter = "Text documents (.txt)|*.txt";

            bool? result = dialog.ShowDialog();
            if (result == true)
            {
               return dialog.FileName;
            }
            return "";
        }
    }
}