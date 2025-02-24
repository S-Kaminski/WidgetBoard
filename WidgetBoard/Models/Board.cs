using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetBoard.Models
{
    public class Board
    {
        public required string Name { get; init; }
        public required BaseLayout Layout { get; init; }
    }
}
