using System.Collections.Generic;
using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Response.Room
{
	public class HipChatGetAllWebhooksResponse
	{
		/// <summary>
		/// Messages
		/// </summary>
		[JsonProperty("items")]
		public List<HipChatWebhook> Webhooks { get; set; }

		/// <summary>
		/// The start index for this set of results
		/// </summary>
		[JsonProperty("startIndex")]
		public int StartIndex { get; set; }

		/// <summary>
		/// The maximum number of results returned.
		/// 
		/// Valid length range: 1 - 1000.
		/// </summary>
		[JsonProperty("maxResults")]
		public int MaxResults { get; set; }

		/// <summary>
		/// Links
		/// </summary>
		[JsonProperty("links")]
		public HipChatLink Links { get; set; }
	}
}
