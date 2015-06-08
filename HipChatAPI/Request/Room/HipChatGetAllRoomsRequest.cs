using System;
using Newtonsoft.Json;

namespace HipChatAPI.Request.Room
{
	public class HipChatGetAllRoomsRequest
	{
		private int? _maxResults;

		/// <summary>
		/// The start index for the result set
		/// 
		/// Defaults to 0.
		/// </summary>
		[JsonProperty("start-index", NullValueHandling = NullValueHandling.Ignore)]
		public int? StartIndex { get; set; }

		/// <summary>
		/// The maximum number of results.
		/// Valid length range: 0 - 1000.
		/// 
		/// Defaults to 100.
		/// </summary>
		[JsonProperty("max-results", NullValueHandling = NullValueHandling.Ignore)]
		public int? MaxResults
		{
			get { return _maxResults; }
			set
			{
				if (value >= 1 || value <= 1000)
				{
					_maxResults = value;
					return;
				}
				throw new ArgumentOutOfRangeException("MaxResults range is 1 - 1000");
			}
		}

		/// <summary>
		/// Filter out private rooms (boolean)
		/// 
		/// Defaults to 'true'.
		/// </summary>
		[JsonProperty("include-private", NullValueHandling = NullValueHandling.Ignore)]
		public bool IncludePrivate { get; set; }

		/// <summary>
		/// Filter rooms (boolean)
		/// 
		/// Defaults to 'false'.
		/// </summary>
		[JsonProperty("include-archived", NullValueHandling = NullValueHandling.Ignore)]
		public bool IncludeArchived { get; set; }
	}
}
