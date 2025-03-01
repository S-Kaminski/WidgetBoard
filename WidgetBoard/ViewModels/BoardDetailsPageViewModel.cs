using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WidgetBoard.ViewModels.BaseViewModel;

namespace WidgetBoard.ViewModels
{
    public class BoardDetailsPageViewModel : BaseViewModel
    {
        private string boardName;

        public string BoardName
        {
            get => boardName;
            set => SetProperty(ref boardName, value);
        }
    }
}