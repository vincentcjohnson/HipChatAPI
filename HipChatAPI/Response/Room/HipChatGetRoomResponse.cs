using System;
using System.Collections.Generic;
using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Response.Room
{
	public class HipChatGetRoomResponse
	{
		/// <summary>
		/// XMPP/Jabber ID of the room.
		/// </summary>
		[JsonProperty("xmpp_jid")]
		public string XmppJid { get; set; }

		/// <summary>
		/// URLs to retrieve room information
		/// </summary>
		[JsonProperty("links")]
		public HipChatLink Links { get; set; }

		/// <summary>
		/// Statistics for this room.
		/// </summary>
		[JsonProperty("statistics")]
		public HipChatStatistic Statistics { get; set; }

		/// <summary>
		/// NameOrId of the room.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Time the room was created in UTC.
		/// </summary>
		[JsonProperty("created")]
		public DateTime Created { get; set; }

		/// <summary>
		/// Whether or not this room is archived.
		/// </summary>
		[JsonProperty("is_archived")]
		public bool IsArchived { get; set; }

		/// <summary>
		/// Privacy setting. Valid values: public, private.
		/// </summary>
		[JsonProperty("privacy")]
		public HipChatRoomPrivacy Privacy { get; set; }

		/// <summary>
		/// Whether or not guests can access this room.
		/// </summary>
		[JsonProperty("is_guest_accessible")]
		public bool IsGuestAccessible { get; set; }

		/// <summary>
		/// Current topic.
		/// </summary>
		[JsonProperty("topic")]
		public string Topic { get; set; }

		/// <summary>
		/// List of current room participants, limited to 50 users. (Deprecated: Use the participants link.) 
		/// </summary>
		[JsonProperty("participants")]
		public List<HipChatUser> Participants { get; set; }

		/// <summary>
		/// The room owner.
		/// </summary>
		[JsonProperty("owner")]
		public HipChatUser Owner { get; set; }

		/// <summary>
		/// ID of the room.
		/// </summary>
		[JsonProperty("id")]
		public int Id { get; set; }

		/// <summary>
		/// URL for guest access, if enabled. May be null.
		/// </summary>
		[JsonProperty("guest_access_url")]
		public string GuestAccessUrl { get; set; }
	}
}
