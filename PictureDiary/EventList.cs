using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureDiary
{
    class EventList
    {
        public int ID { get; set; }
        public string EventName { get; set; }
        public string Date { get; set; }
        public string LastUpdated { get; set; }
        public Bitmap Picture { get; set; }

    }
}
