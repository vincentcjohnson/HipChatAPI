using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Response.User
{
	public class HipChatCreateUserResponse
	{
		/// <summary>
		/// The unique identifier for the created entity
		/// </summary>
		[JsonProperty("id")]
		public int Id { get; set; }

		/// <summary>
		/// Links object.
		/// </summary>
		[JsonProperty("links")]
		public HipChatLink Links { get; set; }
	}
}
