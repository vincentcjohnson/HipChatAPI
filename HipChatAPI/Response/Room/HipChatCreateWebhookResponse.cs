using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Response.Room
{
	/// <summary>
	/// Response object for CreateWebhook resource
	/// </summary>
	public class HipChatCreateWebHookResponse
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("links")]
		public HipChatLink Links { get; set; }
	}
}
