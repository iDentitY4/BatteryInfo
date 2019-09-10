using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryInfo
{
    static class TimeUtil
    {
        public static string ToHumanTimeString(this TimeSpan timeSpan)
        {
            Func<Tuple<int, string>, string> tupleFormatter = t => $"{t.Item1}{t.Item2}{(t.Item1 == 1 ? string.Empty : "")}";
            var components = new List<Tuple<int, string>>
            {
                Tuple.Create((int) timeSpan.Days, "d"),
                Tuple.Create(timeSpan.Hours, "h"),
                Tuple.Create(timeSpan.Minutes, "m"),
                Tuple.Create(timeSpan.Seconds, "s"),
            };

            components.RemoveAll(i => i.Item1 == 0);

            string extra = "";

            if (components.Count > 1)
            {
                var finalComponent = components[components.Count - 1];
                components.RemoveAt(components.Count - 1);
                extra = $" {tupleFormatter(finalComponent)}";
            } else if(components.Count == 0)
            {
                return "Now";
            }

            return $"{string.Join(" ", components.Select(tupleFormatter))}{extra}";
        }
    }
}
