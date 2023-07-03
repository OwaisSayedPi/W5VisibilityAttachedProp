using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace W5VisibilityAttachedProp
{
    public class MainWindowViewModel : BaseViewModel
    {
        public bool ToggleVisibility { get; set; } = false;
        public ICommand ToggleCommand { get; set; }
        public MainWindowViewModel()
        {
            ToggleCommand = new RelayCommand(ChangeVisibility);
        }
        private void ChangeVisibility()
        {
            ToggleVisibility = !ToggleVisibility;
            OnPropertyChanged(nameof(ToggleVisibility));
        }
    }
}
