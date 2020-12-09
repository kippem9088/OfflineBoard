using System.Windows.Controls;
using OfflineBoard.ViewModel;

namespace OfflineBoard.View
{
    public partial class ListView : UserControl
    {
        public ListView()
        {
            InitializeComponent();
            this.DataContext = new ListViewModel();
        }
    }
}