using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetBoard
{
    public class Scheduler
    {
        public void ScheduleAction(TimeSpan timeSpan, Action action)
        {
            Task.Run(async () =>
            {
                await Task.Delay(timeSpan);
                action.Invoke();
            });
        }
    }
}
