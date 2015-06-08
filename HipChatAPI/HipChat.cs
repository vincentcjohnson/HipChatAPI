using System;
using System.Net;
using HipChatAPI.Model;
using HipChatAPI.Request.Room;
using HipChatAPI.Request.User;
using HipChatAPI.Response.Room;
using HipChatAPI.Response.User;
using HipChatAPI.Utils;
using Newtonsoft.Json;
using RestSharp;

namespace HipChatAPI
{
	public class HipChatClient : IHipChat
	{
		private readonly string _baseUri;
		private readonly string _apiKey;
		private const string RoomResource = @"/v2/room";
		private const string UserResource = @"/v2/user";

		/// <summary>
		/// Hip Chat Rest Client.
		/// </summary>
		/// <param name="baseUri">Base URI</param>
		/// <param name="apiKey">Auth Token/ API Key</param>
		public HipChatClient(string baseUri = null, string apiKey = null)
		{
			//TODO:Default to resource file Base URI if null
			_baseUri = baseUri;
			//TODO: Default to resource file API key if null
			_apiKey = apiKey;
		}

		/// <summary>
		/// List non-archived rooms for this group.
		/// </summary>
		/// <returns>Response containing all HipChat rooms</returns>
		public HipChatGetAllRoomsResponse GetAllRooms()
		{
			var response = ExecuteRequestWithoutBody(RoomResource, Method.GET);
			return DeserializeResponse<HipChatGetAllRoomsResponse>(response);
		}

		/// <summary>
		/// List non-archived rooms for this group.
		/// </summary>
		/// <param name="request">GetAllRooms request</param>
		/// <returns>Response containing all HipChat rooms</returns>
		public HipChatGetAllRoomsResponse GetAllRooms(HipChatGetAllRoomsRequest request)
		{
			var response = ExecuteRequestWithBody<HipChatGetAllRoomsRequest>(request, RoomResource, Method.GET);
			return DeserializeResponse<HipChatGetAllRoomsResponse>(response);
		}

		/// <summary>
		/// Create a new HipChat Room.
		/// </summary>
		/// <param name="roomName">Name of HipChat room.</param>
		/// <returns>Information about the newly created room.</returns>
		public HipChatCreateRoomResponse CreateRoom(string roomName)
		{
			var request = new HipChatCreateRoomRequest(roomName);
			return CreateRoom(request);
		}

		/// <summary>
		/// Create a new HipChat Room.
		/// </summary>
		/// <param name="request">Name of HipChat room.</param>
		/// <returns>Information about the newly created room.</returns>
		public HipChatCreateRoomResponse CreateRoom(HipChatCreateRoomRequest request)
		{
			var response = ExecuteRequestWithBody<HipChatCreateRoomRequest>(request, RoomResource, Method.POST);
			return DeserializeResponse<HipChatCreateRoomResponse>(response);
		}

		/// <summary>
		/// Get room details.
		/// </summary>
		/// <param name="roomIdOrName">Name of room</param>
		/// <returns>Response containing room details</returns>
		public HipChatGetRoomResponse GetRoom(string roomIdOrName)
		{
			var getRoomResource = String.Format(HipChatResources.GetRoom, RoomResource, roomIdOrName);
			var response = ExecuteRequestWithoutBody(getRoomResource, Method.GET);
			return DeserializeResponse<HipChatGetRoomResponse>(response);
		}

		/// <summary>
		/// Update a room.
		/// </summary>
		/// <param name="roomIdOrName">ID or Name of Room to be updated.</param>
		/// <param name="request">Update values wrapped in request.</param>
		/// <returns>Value indicating whether the room was updated.</returns>
		public bool UpdateRoom(string roomIdOrName, HipChatUpdateRoomRequest request)
		{
			var resource = String.Format(HipChatResources.UpdateRoom, RoomResource, roomIdOrName);
			var response = ExecuteRequestWithBody<HipChatUpdateRoomRequest>(request, resource, Method.PUT);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// Delete a room.
		/// </summary>
		/// <param name="roomIdOrName">ID or Name of Room to be deleted.</param>
		/// <returns>Value indicating whether the room has been deleted.</returns>
		public bool DeleteRoom(string roomIdOrName)
		{
			string resource = String.Format(HipChatResources.DeleteRoom, RoomResource, roomIdOrName);
			var response = ExecuteRequestWithoutBody(resource, Method.DELETE);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public HipChatGetRoomMessageResponse GetRoomMessage(HipChatGetRoomMessageRequest request)
		{
			var resource = String.Format
				(HipChatResources.GetRoomMessage, RoomResource, request.NameOrId, request.MessageId);
			var response = ExecuteRequestWithBody<HipChatGetRoomMessageRequest>(request, resource, Method.GET);
			return DeserializeResponse<HipChatGetRoomMessageResponse>(response);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="messageId"></param>
		/// <param name="roomIdOrName"></param>
		/// <returns></returns>
		public HipChatGetRoomMessageResponse GetRoomMessage(string messageId, string roomIdOrName)
		{
			var request = new HipChatGetRoomMessageRequest(messageId, roomIdOrName);
			return GetRoomMessage(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public HipChatViewRoomHistoryResponse ViewRoomHistory(HipChatViewRoomHistoryRequest request)
		{
			var resource = String.Format(HipChatResources.ViewRoomHistory, RoomResource, request.NameOrId);
			var response = ExecuteRequestWithBody<HipChatViewRoomHistoryRequest>(request, resource, Method.GET);
			return DeserializeResponse<HipChatViewRoomHistoryResponse>(response);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomIdOrName"></param>
		/// <returns></returns>
		public HipChatViewRoomHistoryResponse ViewRoomHistory(string roomIdOrName)
		{
			var request = new HipChatViewRoomHistoryRequest(roomIdOrName);
			return ViewRoomHistory(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomIdOrName"></param>
		/// <returns></returns>
		public HipChatViewRecentRoomHistoryResponse ViewRecentRoomHistory(string roomIdOrName)
		{
			var request = new HipChatViewRecentRoomHistoryRequest(roomIdOrName);
			return ViewRecentRoomHistory(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public HipChatViewRecentRoomHistoryResponse ViewRecentRoomHistory(HipChatViewRecentRoomHistoryRequest request)
		{
			var resource = String.Format(HipChatResources.ViewRecentRoomHistory, RoomResource, request.NameOrId);
			var response = ExecuteRequestWithBody<HipChatViewRecentRoomHistoryRequest>(request, resource, Method.GET);
			return DeserializeResponse<HipChatViewRecentRoomHistoryResponse>(response);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userIdOrEmail"></param>
		/// <param name="roomIdOrName"></param>
		/// <returns></returns>
		public bool InviteUser(string userIdOrEmail, string roomIdOrName)
		{
			var request = new HipChatInviteUserRequest(userIdOrEmail, roomIdOrName);
			return InviteUser(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public bool InviteUser(HipChatInviteUserRequest request)
		{
			var resource = String.Format(
				HipChatResources.InviteUser, RoomResource, request.RoomIdOrName, request.UserIdOrEmail);
			var response = ExecuteRequestWithBody<HipChatInviteUserRequest>(request, resource, Method.POST);
			return response.StatusCode == HttpStatusCode.NoContent;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="userIdOrEmail"></param>
		/// <param name="roomIdOrName"></param>
		/// <returns></returns>
		public bool AddMember(string userIdOrEmail, string roomIdOrName)
		{
			var resource = String.Format(HipChatResources.AddMember, RoomResource, roomIdOrName, userIdOrEmail);
			var response = ExecuteRequestWithoutBody(resource, Method.PUT);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userIdOrEmail"></param>
		/// <param name="roomIdOrName"></param>
		/// <returns></returns>
		public bool RemoveMember(string userIdOrEmail, string roomIdOrName)
		{
			var resource = String.Format(HipChatResources.RemoveMember, RoomResource, roomIdOrName, userIdOrEmail);
			var response = ExecuteRequestWithoutBody(resource, Method.PUT);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomIdOrName"></param>
		/// <returns></returns>
		public HipChatGetAllMembersResponse GetAllMembers(string roomIdOrName)
		{
			var request = new HipChatGetAllMembersRequest(roomIdOrName);
			return GetAllMembers(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public HipChatGetAllMembersResponse GetAllMembers(HipChatGetAllMembersRequest request)
		{
			var resource = String.Format(HipChatResources.GetAllMembers, RoomResource, request.RoomIdOrName);
			var response = ExecuteRequestWithBody<HipChatGetAllMembersRequest>(request, resource, Method.GET);
			return DeserializeResponse<HipChatGetAllMembersResponse>(response);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomIdOrName"></param>
		/// <returns></returns>
		public bool SendRoomNotificationRedirect(string roomIdOrName)
		{
			var resource = String.Format(HipChatResources.SendRoomNotificationRedirect, RoomResource, roomIdOrName);
			var response = ExecuteRequestWithoutBody(resource, Method.POST);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomIdOrName"></param>
		/// <param name="messgage"></param>
		/// <returns></returns>
		public bool SendRoomNotification(string roomIdOrName, string messgage)
		{
			var request = new HipChatSendRoomNotificationRequest(roomIdOrName, messgage);
			return SendRoomNotification(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public bool SendRoomNotification(HipChatSendRoomNotificationRequest request)
		{
			var resource = String.Format(HipChatResources.SendRoomNotification, RoomResource, request.RoomIdOrName);
			var response = ExecuteRequestWithBody<HipChatSendRoomNotificationRequest>(request, resource, Method.POST);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomIdOrName"></param>
		/// <returns></returns>
		public HipChatGetAllParticipantsResponse GetAllParticipants(string roomIdOrName)
		{
			var request = new HipChatGetAllParticipantsRequest(roomIdOrName);
			return GetAllParticipants(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public HipChatGetAllParticipantsResponse GetAllParticipants(HipChatGetAllParticipantsRequest request)
		{
			var resource = String.Format(HipChatResources.GetAllParticipants, RoomResource, request.RoomIdOrName);
			var response = ExecuteRequestWithBody<HipChatGetAllParticipantsRequest>(request, resource, Method.GET);
			return DeserializeResponse<HipChatGetAllParticipantsResponse>(response);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomIdOrName"></param>
		/// <param name="parentMessageId"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		public bool ReplyToMessage(string roomIdOrName, string parentMessageId, string message)
		{
			var request = new HipChatReplyToMessageRequest(roomIdOrName, parentMessageId, message);
			return ReplyToMessage(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public bool ReplyToMessage(HipChatReplyToMessageRequest request)
		{
			var resource = String.Format(HipChatResources.ReplyToMessage, RoomResource, request.RoomIdOrName);
			var response = ExecuteRequestWithBody<HipChatReplyToMessageRequest>(request, resource, Method.POST);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomIdOrName"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		public bool ShareFileWithRoom(string roomIdOrName, string message = null)
		{
			var request = new HipChatShareFileWithRoomRequest(roomIdOrName) { Message = message };
			return ShareFileWithRoom(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public bool ShareFileWithRoom(HipChatShareFileWithRoomRequest request)
		{
			var resource = String.Format(HipChatResources.ShareFileWithRoom, RoomResource, request.RoomIdOrName);
			var response = ExecuteRequestWithBody<HipChatShareFileWithRoomRequest>(request, resource, Method.POST);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomIdOrName"></param>
		/// <param name="link"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		public bool ShareLinkWithRoom(string roomIdOrName, string link, string message = null)
		{
			var request = new HipChatShareLinkWithRoomRequest(roomIdOrName, link) { Message = message };
			return ShareLinkWithRoom(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public bool ShareLinkWithRoom(HipChatShareLinkWithRoomRequest request)
		{
			var resource = String.Format(HipChatResources.ShareLinkWithRoom, RoomResource, request.RoomIdOrName);
			var response = ExecuteRequestWithBody<HipChatShareLinkWithRoomRequest>(request, resource, Method.POST);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomIdOrName"></param>
		/// <returns></returns>
		public HipChatGetRoomStatisticsResponse GetRoomStatistics(string roomIdOrName)
		{
			ArgumentHelper.CheckNullEmptyAndCharLimit(roomIdOrName, "Room ID/Name", HipChatCharLimits.RoomIdOrName);
			var resource = String.Format(HipChatResources.GetRoomStatistics, RoomResource, roomIdOrName);
			var response = ExecuteRequestWithoutBody(resource, Method.GET);
			return DeserializeResponse<HipChatGetRoomStatisticsResponse>(response);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomIdOrName"></param>
		/// <param name="topic"></param>
		/// <returns></returns>
		public bool SetTopic(string roomIdOrName, string topic)
		{
			var request = new HipChatSetTopicRequest(roomIdOrName, topic);
			return SetTopic(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public bool SetTopic(HipChatSetTopicRequest request)
		{
			var resource = String.Format(HipChatResources.SetTopic, RoomResource, request.RoomIdOrName);
			var response = ExecuteRequestWithBody(request, resource, Method.PUT);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomIdOrName"></param>
		/// <returns></returns>
		public HipChatGetAllWebhooksResponse GetAllWebHooks(string roomIdOrName)
		{
			var request = new HipChatGetAllWebhooksRequest(roomIdOrName);
			return GetAllWebHooks(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public HipChatGetAllWebhooksResponse GetAllWebHooks(HipChatGetAllWebhooksRequest request)
		{
			var resource = String.Format(HipChatResources.GetAllWebhooks, RoomResource, request.RoomIdOrName);
			var response = ExecuteRequestWithBody<HipChatGetAllWebhooksRequest>(request, resource, Method.GET);
			return DeserializeResponse<HipChatGetAllWebhooksResponse>(response);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public HipChatCreateWebHookResponse CreateWebHook(HipChatCreateWebhookRequest request)
		{
			var resource = String.Format(HipChatResources.CreateWebhook, RoomResource, request.RoomIdOrName);
			var response = ExecuteRequestWithBody<HipChatCreateWebhookRequest>(request, resource, Method.POST);
			return DeserializeResponse<HipChatCreateWebHookResponse>(response);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomIdOrName"></param>
		/// <param name="webhookId"></param>
		/// <returns></returns>
		public HipChatGetWebHookResponse GetWebhook(string roomIdOrName, int webhookId)
		{
			var resource = String.Format(HipChatResources.GetWebhook, RoomResource, roomIdOrName, webhookId);
			var response = ExecuteRequestWithoutBody(resource, Method.GET);
			return DeserializeResponse<HipChatGetWebHookResponse>(response);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="roomIdOrName"></param>
		/// <param name="webhookId"></param>
		/// <returns></returns>
		public bool DeleteWebhook(string roomIdOrName, int webhookId)
		{
			ArgumentHelper.CheckNullEmptyAndCharLimit(roomIdOrName, "Room ID/Name", HipChatCharLimits.RoomIdOrName);
			var resource = String.Format(HipChatResources.DeleteWebhook, RoomResource, roomIdOrName, webhookId);
			var response = ExecuteRequestWithoutBody(resource, Method.DELETE);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public HipChatGetAllUsersResponse GetAllUsers()
		{
			var response = ExecuteRequestWithoutBody(UserResource, Method.GET);
			return DeserializeResponse<HipChatGetAllUsersResponse>(response);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public HipChatGetAllUsersResponse GetAllUsers(HipChatGetAllUserRequest request)
		{
			var response = ExecuteRequestWithBody<HipChatGetAllUserRequest>(request, UserResource, Method.GET);
			return DeserializeResponse<HipChatGetAllUsersResponse>(response);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="email"></param>
		/// <returns></returns>
		public HipChatCreateUserResponse CreateUser(string name, string email)
		{
			var request = new HipChatCreateUserRequest(name, email);
			return CreateUser(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public HipChatCreateUserResponse CreateUser(HipChatCreateUserRequest request)
		{
			var response = ExecuteRequestWithBody<HipChatCreateUserRequest>(request, UserResource, Method.POST);
			return DeserializeResponse<HipChatCreateUserResponse>(response);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userIdOrEmail"></param>
		/// <returns></returns>
		public HipChatViewUserResponse ViewUser(string userIdOrEmail)
		{
			var resource = String.Format(HipChatResources.ViewUser, UserResource, userIdOrEmail);
			var response = ExecuteRequestWithoutBody(resource, Method.GET);
			return DeserializeResponse<HipChatViewUserResponse>(response);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public bool UpdateUser(HipChatUpdateUserRequest request)
		{
			var resource = String.Format(HipChatResources.UpdateUser, UserResource, request.UserIdOrEmail);
			var response = ExecuteRequestWithBody<HipChatUpdateUserRequest>(request, resource, Method.PUT);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userIdOrEmail"></param>
		/// <returns></returns>
		public bool DeleteUser(string userIdOrEmail)
		{
			var resource = String.Format(HipChatResources.DeleteUser, UserResource, userIdOrEmail);
			var response = ExecuteRequestWithoutBody(resource, Method.DELETE);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userIdOrEmail"></param>
		/// <param name="messageId"></param>
		/// <param name="timeZone"></param>
		/// <returns></returns>
		public HipChatGetPrivateChatMessageResponse GetPrivateChatMessage(string userIdOrEmail, string messageId,
			HipChatTimeZone timeZone = HipChatTimeZone.Utc)
		{
			var request = new HipChatGetPrivateChatMessageRequest(userIdOrEmail, messageId) { TimeZone = timeZone };
			return GetPrivateChatMessage(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public HipChatGetPrivateChatMessageResponse GetPrivateChatMessage(HipChatGetPrivateChatMessageRequest request)
		{
			var resource = String.Format(HipChatResources.GetPrivateChatMessage, UserResource, request.UserIdOrEmail,
				request.MessageId);
			var response = ExecuteRequestWithBody<HipChatGetPrivateChatMessageRequest>(request, resource, Method.GET);
			return DeserializeResponse<HipChatGetPrivateChatMessageResponse>(response);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userIdOrEmail"></param>
		/// <returns></returns>
		public HipChatViewRecentPrivateChatHistoryResponse ViewRecentPrivateChatHistory(string userIdOrEmail)
		{
			var request = new HipChatViewRecentPrivateChatHistoryRequest(userIdOrEmail);
			return ViewRecentPrivateChatHistory(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public HipChatViewRecentPrivateChatHistoryResponse ViewRecentPrivateChatHistory(
			HipChatViewRecentPrivateChatHistoryRequest request)
		{
			var resource = String.Format
				(HipChatResources.ViewRecentPrivateChatHistory, UserResource, request.UserIdOrEmail);
			var response = ExecuteRequestWithBody<HipChatViewRecentPrivateChatHistoryRequest>(request, resource, Method.GET);
			return DeserializeResponse<HipChatViewRecentPrivateChatHistoryResponse>(response);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userIdOrEmail"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		public bool PrivateMessageUser(string userIdOrEmail, string message)
		{
			var request = new HipChatPrivateMessageUserRequest(userIdOrEmail) { Message = message };
			return PrivateMessageUser(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public bool PrivateMessageUser(HipChatPrivateMessageUserRequest request)
		{
			var resource = String.Format(HipChatResources.PrivateMessageUser, UserResource, request.UserIdOrEmail);
			var response = ExecuteRequestWithBody<HipChatPrivateMessageUserRequest>(request, resource, Method.POST);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userIdOrEmail"></param>
		/// <param name="photo"></param>
		/// <returns></returns>
		public bool UpdatePhoto(string userIdOrEmail, string photo)
		{
			var request = new HipChatUpdatePhotoRequest(userIdOrEmail, photo);
			return UpdatePhoto(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public bool UpdatePhoto(HipChatUpdatePhotoRequest request)
		{
			var resource = String.Format(HipChatResources.UpdatePhoto, UserResource, request.UserIdOrEmail);
			var response = ExecuteRequestWithBody(request, resource, Method.PUT);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userIdOrEmail"></param>
		/// <returns></returns>
		public bool DeletePhoto(string userIdOrEmail)
		{
			var resource = String.Format(HipChatResources.DeletePhoto, UserResource, Method.DELETE);
			var response = ExecuteRequestWithoutBody(resource, Method.DELETE);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userIdOrEmail"></param>
		/// <returns></returns>
		public HipChatGetAutoJoinRoomsResponse GetAutoJoinRooms(string userIdOrEmail)
		{
			var request = new HipChatGetAutoJoinRoomsRequest(userIdOrEmail);
			return GetAutoJoinRooms(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public HipChatGetAutoJoinRoomsResponse GetAutoJoinRooms(HipChatGetAutoJoinRoomsRequest request)
		{
			var resource = String.Format(HipChatResources.GetAutoJoinRooms, UserResource, request.UserIdOrEmail);
			var response = ExecuteRequestWithBody<HipChatGetAutoJoinRoomsRequest>(request, resource, Method.GET);
			return DeserializeResponse<HipChatGetAutoJoinRoomsResponse>(response);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userIdOrEmail"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		public bool ShareFileWithUser(string userIdOrEmail, string message = null)
		{
			var request = new HipChatShareFileWithUserRequest(userIdOrEmail) { Message = message };
			return ShareFileWithUser(request);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public bool ShareFileWithUser(HipChatShareFileWithUserRequest request)
		{
			var resource = String.Format(HipChatResources.ShareFileWithUser, UserResource, request.UserIdOrEmail);
			var response = ExecuteRequestWithBody<HipChatShareFileWithUserRequest>(request, resource, Method.POST);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userIdOrEmail"></param>
		/// <param name="link"></param>
		/// <param name="message"></param>
		/// <returns></returns>
		public bool ShareLinkWithUser(string userIdOrEmail, string link, string message = null)
		{
			var request = new HipChatShareLinkWithUserRequest(userIdOrEmail) { Link = link, Message = message };
			var resource = String.Format(HipChatResources.ShareLinkWithUser, UserResource, userIdOrEmail);
			var response = ExecuteRequestWithBody<HipChatShareLinkWithUserRequest>(request, resource, Method.POST);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public bool ShareLinkWithUser(HipChatShareLinkWithUserRequest request)
		{
			var resource = String.Format(HipChatResources.ShareLinkWithUser, UserResource, request.UserIdOrEmail);
			var response = ExecuteRequestWithBody<HipChatShareLinkWithUserRequest>(request, resource, Method.POST);
			return response.StatusCode == HttpStatusCode.NoContent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected virtual IRestClient CreateRestClient()
		{
			var client = new RestClient(_baseUri);
			return client;
		}

		/// <summary>
		/// Deserailize Response from API response.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="response"></param>
		/// <returns></returns>
		private static T DeserializeResponse<T>(IRestResponse response)
		{
			var result = JsonConvert.DeserializeObject<T>(response.Content);
			return result;
		}

		/// <summary>
		/// Executes non-body containing requests against endpoint.
		/// </summary>
		/// <param name="resource">Resource endpoint</param>
		/// <param name="method">HTTP Method</param>
		/// <returns>Rest Response</returns>
		private IRestResponse ExecuteRequestWithoutBody(string resource, Method method)
		{
			var client = CreateRestClient();
			var request = new RestRequest(resource, method) { RequestFormat = DataFormat.Json };
			request.AddParameter("auth_token", _apiKey);
			return client.Execute(request);
		}

		/// <summary>
		/// Executes body containing requests against endpoint
		/// </summary>
		/// <typeparam name="T">Serializable request object</typeparam>l
		/// <param name="resource">Resource endpoint</param>
		/// <param name="method">Method</param>
		/// <param name="model">Model request object</param>
		/// <returns>Response from resource</returns>
		private IRestResponse ExecuteRequestWithBody<T>(T model, string resource, Method method)
		{
			resource += "?auth_token={token}";

			var client = CreateRestClient();
			var request = new RestRequest(resource, method) { RequestFormat = DataFormat.Json };
			var json = JsonConvert.SerializeObject(model);

#if DEBUG
			request.AddHeader("User-Agent", "Fiddler");
#endif

			request.AddUrlSegment("token", _apiKey);
			request.AddParameter("application/json", json, ParameterType.RequestBody);

			return client.Execute(request);
		}
	}
}
