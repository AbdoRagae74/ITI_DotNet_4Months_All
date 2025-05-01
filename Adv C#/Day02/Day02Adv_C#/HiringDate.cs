using System;

public class Class1
{
    class HiringDate : IComparable
    {
        int day, month, year;
        public int Day { get { return day; } set { day = value; } }
        public int Month { get { return month; } set { month = value; } }
        public int Year { get { return year; } set { year = value; } }
        public HiringDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int CompareTo(object? obj)
        {
            if (obj is HiringDate h)

            {
                int ans = year.CompareTo(h.year);

                if (ans != 0) return ans;

                ans = month.CompareTo(h.month);

                if (ans != 0) return ans;

                return day.CompareTo(h.day);

            }
            return -1;
        }

        public override string ToString()
        {
            return $"{day} / {month} / {year}";
        }

    }
}
