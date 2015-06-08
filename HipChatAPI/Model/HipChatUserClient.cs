using Newtonsoft.Json;

namespace HipChatAPI.Model
{
	public class HipChatUserClient
	{
		/// <summary>
		/// The version of the client they are using to connect to HipChat.
		/// 
		/// May be null.

		/// </summary>
		[JsonProperty("version")]
		public string Version { get; set; }

		/// <summary>
		///  The client they are using to connect to HipChat.
		/// 
		/// May be null.
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }
	}
}
