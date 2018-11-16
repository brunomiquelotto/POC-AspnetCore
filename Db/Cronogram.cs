using System;

namespace Db
{
    public class Cronogram
    {
        public int CronogramId { get; set; }
        public string Text { get; set; }
        public DateTime Scheduled { get; set; }
        public DateTime ExecutionDate { get; set; }
    }
}