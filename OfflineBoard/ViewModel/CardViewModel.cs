using OfflineBoard.Common;

namespace OfflineBoard.ViewModel
{
    public class CardViewModel : ViewModelBase
    {
        private string _title;

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public CardViewModel()
        {
            Title = "Test";
        }
    }
}