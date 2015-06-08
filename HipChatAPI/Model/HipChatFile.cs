using Newtonsoft.Json;

namespace HipChatAPI.Model
{
	public class HipChatFile
	{
		[JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }

		[JsonProperty("thumb_url", NullValueHandling = NullValueHandling.Ignore)]
		public string ThumbUrl { get; set; }

		[JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }

		[JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
		public int Size { get; set; }
	}
}
