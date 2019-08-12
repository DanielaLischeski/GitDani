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
using WPFAppEntity.Data;

namespace WPFAppEntity.Views
{
    /// <summary>
    /// Interaction logic for ucGridView.xaml
    /// </summary>
    public partial class ucGridView : UserControl
    {
        public ucGridView()
        {
            InitializeComponent();
        }

        public BibliotecaDBContext context = new BibliotecaDBContext();

        private void DtGridView_Loaded(object sender, RoutedEventArgs e)
        {
            dtGridView.ItemsSource = context.Usuarios.ToList<Usuario>();
        }

        private void DtGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        
        }

        private void DtGridView_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            var objectToEdit = ((DataGrid)sender).SelectedValue as Usuario;


            //var objectToRemove = ((DataGrid)sender).SelectedValue as Usuario; //para remover um usuário
            // context.Usuarios.Remove(objectToRemove);
        }

        private void BntSalvar_Click(object sender, RoutedEventArgs e)
        {            
            context.SaveChanges(); //salva as alterações no banco

            MessageBox.Show("Itens salvos com sucesso");
        }
    }
}
