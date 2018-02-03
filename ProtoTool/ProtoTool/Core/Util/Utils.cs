using System;

namespace XUPorterJSON
{
    public class Utils
    {
        private static DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1 , 0 , 0 , 0));

        /// <summary>
        /// 获得当前时间的总毫秒数
        /// </summary>
        /// <returns></returns>
        public static double CurrentTotalMilliSeconds()
        {
            return (DateTime.Now - startTime).TotalMilliseconds;
        }

        /// <summary>
        /// 获得当前时间的总秒数
        /// </summary>
        /// <returns></returns>
        public static double CurrentTotalSeconds()
        {
            return CurrentTotalMilliSeconds() / 1000;
        }

        public static double TotalMilliSeconds(DateTime time)
        {
            return (time - startTime).TotalMilliseconds;
        }
    }
}