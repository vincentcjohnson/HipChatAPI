using Newtonsoft.Json;

namespace HipChatAPI.Request.User
{
	public class HipChatGetAllUserRequest
	{
		/// <summary>
		/// The start index for the result set
		/// 
		/// Defaults to 0.
		/// </summary>
		[JsonProperty("start_index")]
		public int StartIndex { get; set; }

		/// <summary>
		/// The maximum number of results.
		/// 
		/// Valid length range: 0 - 1000.
		/// 
		/// Defaults to 100.
		/// </summary>
		[JsonProperty("max-results")]
		public int MaxResults { get; set; }

		/// <summary>
		/// Include active guest users in response. Otherwise, no guest users will be included.
		/// 
		/// Defaults to false.
		/// </summary>
		[JsonProperty("include-guests")]
		public bool IncludeGuests { get; set; }

		/// <summary>
		/// Include deleted users in response
		/// 
		/// Defaults to false.
		/// </summary>
		[JsonProperty("include-deleted")]
		public bool IncludeDeleted { get; set; }
	}
}
