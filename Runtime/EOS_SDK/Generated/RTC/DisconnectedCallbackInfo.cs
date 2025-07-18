// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTC
{
	/// <summary>
	/// This struct is passed in with a call to <see cref="RTCInterface.AddNotifyDisconnected" /> registered event.
	/// </summary>
	public struct DisconnectedCallbackInfo : ICallbackInfo
	{
		/// <summary>
		/// This returns:
		/// <see cref="Result.Success" /> The room was left cleanly.
		/// <see cref="Result.NoConnection" />: There was a network issue connecting to the server (retryable).
		/// <see cref="Result.UserKicked" />: The user has been kicked by the server (retryable).
		/// <see cref="Result.ServiceFailure" />: A known error occurred during interaction with the server (retryable).
		/// <see cref="Result.UnexpectedError" /> Unexpected error (retryable).
		/// </summary>
		public Result ResultCode { get; set; }

		/// <summary>
		/// Client-specified data passed into <see cref="RTCInterface.AddNotifyDisconnected" />.
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// The Product User ID of the user who initiated this request.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The room associated with this event.
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
	internal struct DisconnectedCallbackInfoInternal : ICallbackInfoInternal, IGettable<DisconnectedCallbackInfo>
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

		public void Get(out DisconnectedCallbackInfo other)
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
