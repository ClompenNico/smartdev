using System;

namespace NMCT.Resto.Core.Model
{
    public class Review
    {
        public string UserName { get; set; }
        public double Score { get; set; }
        public string Comment { get; set; }

        public long TimeStampOfVisit { get; set; }

        /// <summary>
        /// zet timestamp van het bezoek om naar echte datum & tijd, en vice versa
        /// </summary>
        public DateTime DateOfVisit
        {
            get { return UnixTimestampToDateTime(TimeStampOfVisit); }
            set { TimeStampOfVisit = DateTimeToUnixTimestamp(value); }
        }

        private DateTime UnixTimestampToDateTime(long unixTime)
        {
            DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            long unixTimeStampInTicks = (long)(unixTime * TimeSpan.TicksPerSecond);
            return new DateTime(unixStart.Ticks + unixTimeStampInTicks, System.DateTimeKind.Utc);
        }

        private long DateTimeToUnixTimestamp(DateTime dateTime)
        {
            DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            long unixTimeStampInTicks = (dateTime.ToUniversalTime() - unixStart).Ticks;
            return unixTimeStampInTicks / TimeSpan.TicksPerSecond;
        }
    }
}
