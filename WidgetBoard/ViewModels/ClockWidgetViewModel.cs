using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WidgetBoard.ViewModels
{
    public class ClockWidgetViewModel : BaseViewModel, IWidgetViewModel //must be partial
    {
        private DateTime time;

        public DateTime Time
        {
            get => time;
            set => SetProperty(ref time, value);
        }

        private readonly Scheduler scheduler = new();
        public int Position { get; set; }
        public string Type => "Clock";

        public ClockWidgetViewModel()
        {
            SetTime(DateTime.Now);
        }

        public void SetTime(DateTime dateTime)
        {
            Time = dateTime;

            scheduler.ScheduleAction(TimeSpan.FromSeconds(1), () => SetTime(DateTime.Now));
        }
    }
}