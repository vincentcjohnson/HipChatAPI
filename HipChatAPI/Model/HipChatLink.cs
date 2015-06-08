using Newtonsoft.Json;

namespace HipChatAPI.Model
{
	public class HipChatLink
	{
		/// <summary>
		/// The unique identifier for the created entity
		/// </summary>
		[JsonProperty("self")]
		public string Self { get; set; }

		/// <summary>
		/// The URL to retrieve the previous set of results.
		/// </summary>
		[JsonProperty("prev", NullValueHandling = NullValueHandling.Ignore)]
		public string Prev { get; set; }

		/// <summary>
		/// The URL to retrieve the next page of results.
		/// </summary>
		[JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
		public string Next { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("webhooks", NullValueHandling = NullValueHandling.Ignore)]
		public string Webhooks { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("members", NullValueHandling = NullValueHandling.Ignore)]
		public string Members { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("participants", NullValueHandling = NullValueHandling.Ignore)]
		public string Participants { get; set; }
	}
}
