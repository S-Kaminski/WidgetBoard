﻿using System;
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
        private bool isFixed = true;
        private int numberOfColumns = 3;
        private int numberOfRows = 2;

        public string BoardName
        {
            get => boardName;
            set => SetProperty(ref boardName, value);
        }

        public bool IsFixed
        {
            get => isFixed;
            set => SetProperty(ref isFixed, value);
        }

        public int NumberOfColumns
        {
            get => numberOfColumns;
            set => SetProperty(ref numberOfColumns, value);
        }

        public int NumberOfRows
        {
            get => numberOfRows;
            set => SetProperty(ref numberOfRows, value);
        }
    }
}