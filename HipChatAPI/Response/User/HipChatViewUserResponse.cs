using HipChatAPI.Model;
using Newtonsoft.Json;

namespace HipChatAPI.Response.User
{
	public class HipChatViewUserResponse
	{
		/// <summary>
		///  XMPP/Jabber ID of the user.
		/// </summary>
		[JsonProperty("xmpp_jid")]
		public string XmppJid { get; set; }

		/// <summary>
		/// Whether the user has been deleted or not.
		/// </summary>
		[JsonProperty("is_deleted")]
		public bool IsDeleted { get; set; }

		/// <summary>
		/// User's full name
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The date in ISO-8601 when the user was last active
		/// 
		/// May be null.
		/// </summary>
		[JsonProperty("last_active")]
		public string LastActive { get; set; }

		/// <summary>
		/// User's title
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// The date in ISO-8601 when the user was created
		/// </summary>
		[JsonProperty("created")]
		public string Created { get; set; }

		/// <summary>
		/// User's ID
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// User's @mention name 
		/// </summary>
		[JsonProperty("mention_name")]
		public string MentionName { get; set; }

		/// <summary>
		/// Whether or not this user is an admin of the group.
		/// Defaults to false.
		/// </summary>
		[JsonProperty("is_group_admin")]
		public bool IsGroupAdmin { get; set; }

		/// <summary>
		/// The desired user timezone
		/// </summary>
		[JsonProperty("timezone")]
		public string TimeZone { get; set; }

		/// <summary>
		/// Whether or not this user is a guest or registered user.
		/// 
		/// Defaults to false.
		/// </summary>
		[JsonProperty("is_guest")]
		public bool IsGuest { get; set; }

		/// <summary>
		/// User's email
		/// May be null. 
		/// </summary>
		[JsonProperty("email")]
		public string Email { get; set; }

		/// <summary>
		/// URL to user's photo. 125px on the longest side.
		/// 
		/// May be null.
		/// </summary>
		[JsonProperty("photo_url")]
		public string PhotoUrl { get; set; }

		/// <summary>
		/// User's presence
		/// </summary>
		[JsonProperty("presence")]
		public HipChatUserPresence Presence { get; set; }
	}
}
