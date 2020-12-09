using System.Windows.Controls;
using OfflineBoard.ViewModel;

namespace OfflineBoard.View
{
    public partial class CardView : UserControl
    {
        public CardView()
        {
            InitializeComponent();
            this.DataContext = new CardViewModel();
        }
    }
}