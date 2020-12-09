using System.Windows.Controls;
using OfflineBoard.ViewModel;

namespace OfflineBoard.Common
{
    public partial class BoardView : UserControl
    {
        public BoardView()
        {
            InitializeComponent();
            this.DataContext = new BoardViewModel();
        }
    }
}