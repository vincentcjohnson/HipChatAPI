using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HipChatAPI.Model
{
	public class HipChatMessage
	{
		[JsonProperty("from")]
		public HipChatUser From { get; set; }

		[JsonProperty("message_links")]
		public List<HipChatMessageLink> MessageLinks { get; set; }

		[JsonProperty("mentions")]
		public List<HipChatUser> Mentions { get; set; }

		[JsonProperty("file")]
		public HipChatFile File { get; set; }

		[JsonProperty("date")]
		public DateTime Date { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("type")]
		public HipChatMessageType Type { get; set; }
	}
}
