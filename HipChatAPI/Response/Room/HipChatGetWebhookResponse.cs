using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Response.Room
{
	public class HipChatGetWebHookResponse
	{
		[JsonProperty("room")]
		public HipChatRoom Room { get; set; }

		[JsonProperty("links")]
		public HipChatLink Links { get; set; }

		[JsonProperty("creator")]
		public HipChatUser Creator { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("pattern")]
		public string Pattern { get; set; }

		[JsonProperty("created")]
		public string Created { get; set; }

		[JsonProperty("event")]
		public HipChatRoomEvent Event { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
