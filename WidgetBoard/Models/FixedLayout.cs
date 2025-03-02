using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetBoard.Models
{
    public class FixedLayout : BaseLayout
    {
        public int NumberOfColumns { get; set; }
        public int NumberOfRows { get; set; }
    }
}