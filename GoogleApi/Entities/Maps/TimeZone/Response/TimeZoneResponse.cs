﻿using System.Runtime.Serialization;
using GoogleApi.Entities.Common.Interfaces;
using GoogleApi.Entities.Maps.Common;

namespace GoogleApi.Entities.Maps.TimeZone.Response
{
    [DataContract]
    public class TimeZoneResponse : MapsBaseResponse, IResponseFor
    {        
        /// <summary>
        /// DstOffset: the offset for daylight-savings time in seconds. This will be zero if the time zone is not in Daylight Savings Time during the specified timestamp.
        /// </summary>
        [DataMember(Name = "dstOffset")]
        public double OffSet { get; set; }

        /// <summary>
        /// RawOffset: the offset from UTC (in seconds) for the given location. This does not take into effect daylight savings.
        /// </summary>
        [DataMember(Name = "rawOffset")]
        public double RawOffSet { get; set; }
        
        /// <summary>
        /// TimeZoneId: a string containing the ID of the time zone, such as "America/Los_Angeles" or "Australia/Sydney".
        /// </summary>
        [DataMember(Name = "timeZoneId")]
        public string TimeZoneId { get; set; }
        
        /// <summary>
        /// TimeZoneName: a string containing the long form name of the time zone. This field will be localized if the language parameter is set. eg. "Pacific Daylight Time" or "Australian.
        /// </summary>
        [DataMember(Name = "timeZoneName")]
        public string TimeZoneName { get; set; }
    }
}
 
 

