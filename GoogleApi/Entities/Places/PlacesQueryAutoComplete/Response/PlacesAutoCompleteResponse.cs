﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using GoogleApi.Entities.Common.Interfaces;
using GoogleApi.Entities.Maps.Common;

namespace GoogleApi.Entities.Places.PlacesQueryAutoComplete.Response
{
    [DataContract]
    public class PlacesQueryAutoCompleteResponse : MapsBaseResponse, IResponseFor
	{
		/// <summary>
        /// Contains an array of predictions, with information about the prediction.
		/// </summary>
		[DataMember(Name = "predictions")]
		public IEnumerable<Prediction> Predictions { get; set; }
	}
}
