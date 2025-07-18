// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTC
{
	/// <summary>
	/// This struct is passed in with a call to <see cref="OnLeaveRoomCallback" />.
	/// </summary>
	public struct LeaveRoomCallbackInfo : ICallbackInfo
	{
		/// <summary>
		/// This returns:
		/// <see cref="Result.Success" /> if the channel was successfully left.
		/// <see cref="Result.AccessDenied" /> if the room name belongs to the Lobby voice system.
		/// <see cref="Result.UnexpectedError" /> otherwise.
		/// </summary>
		public Result ResultCode { get; set; }

		/// <summary>
		/// Client-specified data passed into <see cref="LeaveRoomOptions" />.
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// The Product User ID of the user who initiated this request.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The room the user was trying to leave.
		/// </summary>
		public Utf8String RoomName { get; set; }

		public object GetClientData()
		{
			return ClientData;
		}

		public Result? GetResultCode()
		{
			return ResultCode;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct LeaveRoomCallbackInfoInternal : ICallbackInfoInternal, IGettable<LeaveRoomCallbackInfo>
	{
		private Result m_ResultCode;
		private IntPtr m_ClientData;
		private IntPtr m_LocalUserId;
		private IntPtr m_RoomName;

		public IntPtr ClientDataPointer
		{
			get
			{
				return m_ClientData;
			}
		}

		public void Get(out LeaveRoomCallbackInfo other)
		{
			other = default;
			
			other.ResultCode = m_ResultCode;
			object ClientDataPublic;
			Helper.Get(m_ClientData, out ClientDataPublic);
			other.ClientData = ClientDataPublic;
			ProductUserId LocalUserIdPublic;
			Helper.Get(m_LocalUserId, out LocalUserIdPublic);
			other.LocalUserId = LocalUserIdPublic;
			Utf8String RoomNamePublic;
			Helper.Get(m_RoomName, out RoomNamePublic);
			other.RoomName = RoomNamePublic;
		}
	}
}
