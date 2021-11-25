using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Helper
    {
        public static EventsEntities s_modelEventsContainer;

        public static EventsEntities GetContext()
        {
            if (s_modelEventsContainer == null)
            {
                s_modelEventsContainer = new EventsEntities();
            }
            return s_modelEventsContainer;
        }
    }
}
