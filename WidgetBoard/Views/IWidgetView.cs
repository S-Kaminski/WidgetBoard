using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidgetBoard.ViewModels;

namespace WidgetBoard.Views
{
    public interface IWidgetView
    {
        int Position
        {
            get => WidgetViewModel.Position;
            set => WidgetViewModel.Position = value;
        }

        IWidgetViewModel WidgetViewModel { get; set; }
    }
}