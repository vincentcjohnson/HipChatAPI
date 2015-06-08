using HipChatAPI.Model;
using HipChatAPI.Request.Room;
using HipChatAPI.Request.User;
using HipChatAPI.Response.Room;
using HipChatAPI.Response.User;

namespace HipChatAPI
{
	public interface IHipChat
	{
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		HipChatGetAllRoomsResponse GetAllRooms();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		HipChatGetAllRoomsResponse GetAllRooms(HipChatGetAllRoomsRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		HipChatCreateRoomResponse CreateRoom(string name);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		HipChatCreateRoomResponse CreateRoom(HipChatCreateRoomRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomNameOrId"></param>
		/// <returns></returns>
		HipChatGetRoomResponse GetRoom(string roomNameOrId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomNameOrId"></param>
		/// <param name="request"></param>
		bool UpdateRoom(string roomNameOrId, HipChatUpdateRoomRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomNameOrId"></param>
		bool DeleteRoom(string roomNameOrId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		HipChatGetRoomMessageResponse GetRoomMessage(HipChatGetRoomMessageRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="messageId"></param>
		/// <param name="roomNameOrId"></param>
		/// <returns></returns>
		HipChatGetRoomMessageResponse GetRoomMessage(string messageId, string roomNameOrId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		HipChatViewRoomHistoryResponse ViewRoomHistory(HipChatViewRoomHistoryRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomNameOrId"></param>
		/// <returns></returns>
		HipChatViewRoomHistoryResponse ViewRoomHistory(string roomNameOrId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomNameOrId"></param>
		/// <returns></returns>
		HipChatViewRecentRoomHistoryResponse ViewRecentRoomHistory(string roomNameOrId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		HipChatViewRecentRoomHistoryResponse ViewRecentRoomHistory(HipChatViewRecentRoomHistoryRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userEmailOrId"></param>
		/// <param name="roomNameOrId"></param>
		/// <returns></returns>
		bool InviteUser(string userEmailOrId, string roomNameOrId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		bool InviteUser(HipChatInviteUserRequest request);

		///<summary>
		/// 
		/// </summary>
		/// <param name="userEmailOrId"></param>
		/// <param name="roomNameOrId"></param>
		/// <returns></returns>
		bool AddMember(string userEmailOrId, string roomNameOrId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userEmailOrId"></param>
		/// <param name="roomNameOrId"></param>
		/// <returns></returns>
		bool RemoveMember(string userEmailOrId, string roomNameOrId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomNameOrId"></param>
		/// <returns></returns>
		HipChatGetAllMembersResponse GetAllMembers(string roomNameOrId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		HipChatGetAllMembersResponse GetAllMembers(HipChatGetAllMembersRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomNameOrId"></param>
		/// <returns></returns>
		bool SendRoomNotificationRedirect(string roomNameOrId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomNameOrId"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		bool SendRoomNotification(string roomNameOrId, string message);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		bool SendRoomNotification(HipChatSendRoomNotificationRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomNameOrId"></param>
		/// <returns></returns>
		HipChatGetAllParticipantsResponse GetAllParticipants(string roomNameOrId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		HipChatGetAllParticipantsResponse GetAllParticipants(HipChatGetAllParticipantsRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomNameOrId"></param>
		/// <param name="parentMessageId"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		bool ReplyToMessage(string roomNameOrId, string parentMessageId, string message);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		bool ReplyToMessage(HipChatReplyToMessageRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomNameOrId"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		bool ShareFileWithRoom(string roomNameOrId, string message = null);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		bool ShareFileWithRoom(HipChatShareFileWithRoomRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomNameOrId"></param>
		/// <param name="link"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		bool ShareLinkWithRoom(string roomNameOrId, string link, string message = null);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomNameOrId"></param>
		/// <returns></returns>
		HipChatGetRoomStatisticsResponse GetRoomStatistics(string roomNameOrId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomNameOrId"></param>
		/// <param name="topic"></param>
		/// <returns></returns>
		bool SetTopic(string roomNameOrId, string topic);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		bool SetTopic(HipChatSetTopicRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomNameOrId"></param>
		/// <returns></returns>
		HipChatGetAllWebhooksResponse GetAllWebHooks(string roomNameOrId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		HipChatGetAllWebhooksResponse GetAllWebHooks(HipChatGetAllWebhooksRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		HipChatCreateWebHookResponse CreateWebHook(HipChatCreateWebhookRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomNameOrId"></param>
		/// <param name="webhookId"></param>
		/// <returns></returns>
		HipChatGetWebHookResponse GetWebhook(string roomNameOrId, int webhookId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomNameOrId"></param>
		/// <param name="webhookId"></param>
		/// <returns></returns>
		bool DeleteWebhook(string roomNameOrId, int webhookId);

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		HipChatGetAllUsersResponse GetAllUsers();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		HipChatGetAllUsersResponse GetAllUsers(HipChatGetAllUserRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="email"></param>
		/// <returns></returns>
		HipChatCreateUserResponse CreateUser(string name, string email);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		HipChatCreateUserResponse CreateUser(HipChatCreateUserRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userEmailOrId"></param>
		/// <returns></returns>
		HipChatViewUserResponse ViewUser(string userEmailOrId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		bool UpdateUser(HipChatUpdateUserRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userEmailOrId"></param>
		/// <returns></returns>
		bool DeleteUser(string userEmailOrId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userEmailOrId"></param>
		/// <param name="messageId"></param>
		/// <param name="timeZone"></param>
		/// <returns></returns>
		HipChatGetPrivateChatMessageResponse GetPrivateChatMessage(string userEmailOrId, string messageId, HipChatTimeZone timeZone = HipChatTimeZone.Utc);

		/// <summary>
		/// 
		/// </summary>
		///<param name="request"></param>
		/// <returns></returns>
		HipChatGetPrivateChatMessageResponse GetPrivateChatMessage(HipChatGetPrivateChatMessageRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userEmailOrId"></param>
		/// <returns></returns>
		HipChatViewRecentPrivateChatHistoryResponse ViewRecentPrivateChatHistory(string userEmailOrId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		HipChatViewRecentPrivateChatHistoryResponse ViewRecentPrivateChatHistory(HipChatViewRecentPrivateChatHistoryRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userEmailOrId"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		bool PrivateMessageUser(string userEmailOrId, string message);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		bool PrivateMessageUser(HipChatPrivateMessageUserRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userEmailOrId"></param>
		/// <param name="photo"></param>
		/// <returns></returns>
		bool UpdatePhoto(string userEmailOrId, string photo);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		bool UpdatePhoto(HipChatUpdatePhotoRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userEmailOrId"></param>
		/// <returns></returns>
		bool DeletePhoto(string userEmailOrId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userEmailOrId"></param>
		/// <returns></returns>
		HipChatGetAutoJoinRoomsResponse GetAutoJoinRooms(string userEmailOrId);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		HipChatGetAutoJoinRoomsResponse GetAutoJoinRooms(HipChatGetAutoJoinRoomsRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userEmailOrId"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		bool ShareFileWithUser(string userEmailOrId, string message = null);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		bool ShareFileWithUser(HipChatShareFileWithUserRequest request);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userEmailOrId"></param>
		/// <param name="link"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		bool ShareLinkWithUser(string userEmailOrId, string link, string message = null);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		bool ShareLinkWithUser(HipChatShareLinkWithUserRequest request);
	}
}
