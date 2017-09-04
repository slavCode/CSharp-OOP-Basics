namespace DateModifier
{
    using System;
    public class DateModifier
    {
        private DateTime startDate;
        private DateTime endDate;

        public DateTime StartDate
        {
            get { return this.startDate; }
            set { this.startDate = value; }
        }

        public DateTime EndDate
        {
            get { return this.endDate; }
            set { this.endDate = value; }
        }

        public int GetNumberOfDaysBetweenDates()
        {
            return Math.Abs((this.endDate - this.startDate).Days);
        }
    }
}
