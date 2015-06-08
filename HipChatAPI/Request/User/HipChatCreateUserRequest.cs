using Newtonsoft.Json;

namespace HipChatAPI.Request.User
{
	public class HipChatCreateUserRequest
	{
		/// <summary>
		/// User's full name
		/// 
		/// Valid length range: 1 - 50.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// User's title
		/// </summary>
		[JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
		public string Title { get; set; }

		/// <summary>
		/// User's @mention name
		/// </summary>
		[JsonProperty("mention_name", NullValueHandling = NullValueHandling.Ignore)]
		public string MentionName { get; set; }

		/// <summary>
		/// Whether or not this user is an admin 
		/// 
		/// Defaults to false.
		/// </summary>
		[JsonProperty("is_group_admin", NullValueHandling = NullValueHandling.Ignore)]
		public bool IsGroupAdmin { get; set; }

		/// <summary>
		/// User's timezone. Must be a supported timezone
		/// 
		/// Defaults to 'UTC'.
		/// </summary>
		[JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
		public string TimeZone { get; set; }

		/// <summary>
		/// User's password. If not provided, a randomly generated password will be returned.
		/// </summary>
		[JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
		public string Password { get; set; }

		/// <summary>
		/// User's email.
		/// </summary>
		[JsonProperty("email")]
		public string Email { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="email"></param>
		public HipChatCreateUserRequest(string name, string email)
		{
			Name = name;
			Email = email;
		}
	}
}
