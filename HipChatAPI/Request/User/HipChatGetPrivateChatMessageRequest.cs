using HipChatAPI.Model;
using HipChatAPI.Utils;
using Newtonsoft.Json;

namespace HipChatAPI.Request.User
{
	public class HipChatGetPrivateChatMessageRequest
	{
		/// <summary>
		/// Request for GetPrivateHipChatMessage resource
		/// </summary>
		/// <param name="userIdOrEmail"></param>
		/// <param name="messageId"></param>
		public HipChatGetPrivateChatMessageRequest(string userIdOrEmail, string messageId)
		{
			ArgumentHelper.CheckNullEmptyAndCharLimit(userIdOrEmail, "User ID/Email", HipChatCharLimits.UserIdOrEmail);
			ArgumentHelper.CheckNullEmptyAndCharLimit(messageId, "Message ID", HipChatCharLimits.MessageId);
			UserIdOrEmail = userIdOrEmail;
			MessageId = messageId;
		}
		/// <summary>
		///  The id or name of the room
		/// 
		/// Valid length range: 1 - 100.
		/// </summary>
		[JsonProperty("id_or_email")]
		public string UserIdOrEmail { get; private set; }

		/// <summary>
		/// The id of the message to retrieve
		/// 
		/// Valid length range: 1 - 100.
		/// </summary>
		[JsonProperty("message_id")]
		public string MessageId { get; private set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
		public HipChatTimeZone TimeZone { get; set; }
	}
}
