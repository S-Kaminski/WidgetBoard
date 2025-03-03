using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidgetBoard.Models;

namespace WidgetBoard.ViewModels
{
    public class FixedBoardPageViewModel : BaseViewModel, IQueryAttributable
    {
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            var board = query["Board"] as Board;
        }
    }
}