using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetBoard.ViewModels
{
    public interface IWidgetViewModel
    {
        int Position { get; set; }
        string Type { get; set; }
    }
}
