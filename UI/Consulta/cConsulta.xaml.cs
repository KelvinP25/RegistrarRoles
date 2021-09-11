using RegistrarRolesWpf.ENTIDADES;
using RegistrarrRolesWpf.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RegistrarRolesWpf.UI.Consulta
{
    /// <summary>
    /// Interaction logic for cConsulta.xaml
    /// </summary>
    public partial class cConsulta : Window
    {
        public cConsulta()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click_1(object sender, RoutedEventArgs e)
        {
            var listado = new List<Roles>();


            switch (FiltroComboBox.SelectedIndex)
            {
                case 0: //RolId
                    listado = RolesBLL.GetRoles();
                    break;
            }

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }
    }
}
