using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4OOP
{
    internal class Duration
    {
        #region Proberites
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        #endregion
        #region Constructor
        public Duration()
        {

        }
        public Duration(int h,int m,int s)
        {
            Hours = h;
            Minutes = m;
            Seconds = s;
        }

        public Duration(int seconds)
        {
            Hours = seconds / (3600);
            Minutes = (seconds % (3600)) / 60;
            Seconds = seconds % 60;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Hours : {Hours} ,Minutes : {Minutes}, Seconds : {Seconds}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Duration otherDuration)
            {
                return this.Hours == otherDuration.Hours &&
                       this.Minutes == otherDuration.Minutes &&
                       this.Seconds == otherDuration.Seconds;
            }
            return false;
        }

        public static bool Equals(Duration? obj1, Duration? obj2)
        {
            if (obj1 is null || obj2 is null)
                return false;

            return obj1.Hours == obj2.Hours &&
                   obj1.Minutes == obj2.Minutes;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        public static Duration operator +(Duration left, int right)
        {
            return new Duration
            {
                Hours = left.Hours + right / (3600),
                Minutes = left.Minutes + (right % (3600)) / 60,
                Seconds = left.Seconds + right % 60
            };
        }
        public static Duration operator +(int left, Duration right) => right + left;

        public static Duration operator -(Duration left, Duration right)
        {
            return new Duration
            {
                Hours = left.Hours - right.Hours,
                Minutes = left.Minutes - right.Minutes,
                Seconds = left.Seconds - right.Seconds
            };
        }
        public static Duration operator ++(Duration duration)
        {
            return new Duration
            {
                Hours = ++duration.Hours,
                Minutes = ++duration.Minutes,
                Seconds = ++duration.Seconds,
            };
        }
        public static Duration operator --(Duration duration)
        {
            return new Duration
            {
                Hours = --duration.Hours,
                Minutes = --duration.Minutes,
                Seconds = --duration.Seconds,
            };
        }
        public static bool operator >(Duration left, Duration right)
        {
            if (left.Hours * 3600 + left.Minutes * 60 + left.Seconds > right.Hours * 360 + right.Minutes * 60 + right.Seconds)
                return true;
            return false;
        }
        public static bool operator <(Duration left, Duration right)
        {
            if (left.Hours * 3600 + left.Minutes * 60 + left.Seconds < right.Hours * 360 + right.Minutes * 60 + right.Seconds)
                return true;
            return false;
        }
        public static bool operator >=(Duration left, Duration right)
        {
            if (left.Hours * 3600 + left.Minutes * 60 + left.Seconds >= right.Hours * 360 + right.Minutes * 60 + right.Seconds)
                return true;
            return false;
        }
        public static bool operator <=(Duration left, Duration right)
        {
            if (left.Hours * 3600 + left.Minutes * 60 + left.Seconds <= right.Hours * 360 + right.Minutes * 60 + right.Seconds)
                return true;
            return false;
        }
        public static explicit operator bool(Duration? obj)
        {
            if (obj is not null) return true;
            else return false;
        }
        public static explicit operator DateTime(Duration? obj)
        {
            return new DateTime(obj.Hours, obj.Minutes, obj.Seconds);
        }


        #endregion
    }
}
