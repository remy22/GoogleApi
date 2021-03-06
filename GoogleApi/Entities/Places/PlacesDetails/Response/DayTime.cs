﻿using System.Runtime.Serialization;

namespace GoogleApi.Entities.Places.PlacesDetails.Response
{
    [DataContract]
    public class DayTime
    {
        /// <summary>
        /// day a number from 0–6, corresponding to the days of the week, starting on Sunday. For example, 2 means Tuesday.
        /// </summary>
        [DataMember(Name = "day")]
        public int Day { get; set; }

        /// <summary>
        /// time may contain a time of day in 24-hour hhmm format (values are in the range 0000–2359). The time will be reported in the Place’s timezone
        /// </summary>
        [DataMember(Name = "time")]
        public string Time { get; set; }
    }
}