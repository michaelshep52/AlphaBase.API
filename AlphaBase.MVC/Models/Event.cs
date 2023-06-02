using System;
namespace AlphaBase.MVC.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }

        public Event()
        {

        }
    }
}

