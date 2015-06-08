using System.Collections.Generic;
using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Response.Room
{
	public class HipChatGetAllParticipantsResponse
	{
		/// <summary>
		/// Mention Name, ID, Link and Name of user
		/// </summary>
		[JsonProperty("items")]
		public List<HipChatItem> Items { get; set; }

		/// <summary>
		///  The start index for this set of results.
		/// </summary>
		[JsonProperty("startIndex")]
		public int StartIndex { get; set; }

		/// <summary>
		/// The maximum number of results returned.
		/// Valid length range: 1 - 1000.
		/// </summary>
		[JsonProperty("maxResults")]
		public int MaxResults { get; set; }

		/// <summary>
		/// URL or resource
		/// </summary>
		[JsonProperty("links")]
		public HipChatLink Links { get; set; }
	}
}
