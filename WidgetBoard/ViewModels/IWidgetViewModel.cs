﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetBoard.ViewModels
{
    public interface IWidgetViewModel
    {
        public int Position { get; set; }
        public string Type { get; }
    }
}