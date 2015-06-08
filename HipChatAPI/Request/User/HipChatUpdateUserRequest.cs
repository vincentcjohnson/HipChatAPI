using HipChatAPI.Model;
using HipChatAPI.Utils;
using Newtonsoft.Json;

namespace HipChatAPI.Request.User
{
	public class HipChatUpdateUserRequest
	{
		/// <summary>
		/// The id, email address, or mention name (beginning with an '@') of the user to update.
		/// </summary>
		[JsonProperty("id_or_email")]
		public string UserIdOrEmail { get; private set; }

		/// <summary>
		/// User's title
		/// </summary>
		[JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
		public string Title { get; set; }

		/// <summary>
		/// User's full name 
		/// 
		/// Valid length range: 1 - 50.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; private set; }

		/// <summary>
		/// User's @mention name
		/// </summary>
		[JsonProperty("mention_name")]
		public string MentionName { get; private set; }

		/// <summary>
		/// Presence information for the user
		/// 
		/// May be null.
		/// </summary>
		[JsonProperty("presence")]
		public HipChatUserPresence Presence { get; set; }

		/// <summary>
		/// Whether or not this user is an admin.
		/// 
		/// Defaults to false.
		/// </summary>
		[JsonProperty("is_group_admin")]
		public bool IsGroupAdmin { get; set; }

		/// <summary>
		/// User's timezone. Must be a supported timezone
		/// 
		/// Defaults to 'UTC'.
		/// </summary>
		[JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
		public HipChatTimeZone? TimeZone { get; set; }

		/// <summary>
		/// User's password. If not provided, the existing password is kept
		/// </summary>
		[JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
		public string Password { get; set; }

		/// <summary>
		/// User's email
		/// </summary>
		[JsonProperty("email")]
		public string Email { get; set; }

		/// <summary>
		/// Request for UpdateUser Resource
		/// </summary>
		/// <param name="email">ID or Email of User</param>
		/// <param name="updatedName">Name of User</param>
		/// <param name="updatedMentionName">Mention Name of user</param>
		public HipChatUpdateUserRequest(string email, string updatedName, string updatedMentionName)
		{
			ArgumentHelper.CheckNullEmptyAndCharLimit(updatedName, "Name", 50);
			UserIdOrEmail = email;
			Name = updatedName;
			MentionName = updatedMentionName;
			Presence = new HipChatUserPresence();
			Email = email;
		}
	}
}
