using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Response.Room
{
	public class HipChatGetRoomMessageResponse
	{
		[JsonProperty("message")]
		public HipChatMessage Message { get; set; }
	}
}
