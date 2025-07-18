// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Friends
{
	/// <summary>
	/// Structure containing information about a friend status update.
	/// </summary>
	public struct OnFriendsUpdateInfo : ICallbackInfo
	{
		/// <summary>
		/// Client-specified data passed into <see cref="FriendsInterface.AddNotifyFriendsUpdate" />
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// The Epic Account ID of the local user who is receiving the update
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The Epic Account ID of the user whose status is being updated.
		/// </summary>
		public EpicAccountId TargetUserId { get; set; }

		/// <summary>
		/// The previous status of the user.
		/// </summary>
		public FriendsStatus PreviousStatus { get; set; }

		/// <summary>
		/// The current status of the user.
		/// </summary>
		public FriendsStatus CurrentStatus { get; set; }

		public object GetClientData()
		{
			return ClientData;
		}

		public Result? GetResultCode()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct OnFriendsUpdateInfoInternal : ICallbackInfoInternal, IGettable<OnFriendsUpdateInfo>
	{
		private IntPtr m_ClientData;
		private IntPtr m_LocalUserId;
		private IntPtr m_TargetUserId;
		private FriendsStatus m_PreviousStatus;
		private FriendsStatus m_CurrentStatus;

		public IntPtr ClientDataPointer
		{
			get
			{
				return m_ClientData;
			}
		}

		public void Get(out OnFriendsUpdateInfo other)
		{
			other = default;
			
			object ClientDataPublic;
			Helper.Get(m_ClientData, out ClientDataPublic);
			other.ClientData = ClientDataPublic;
			EpicAccountId LocalUserIdPublic;
			Helper.Get(m_LocalUserId, out LocalUserIdPublic);
			other.LocalUserId = LocalUserIdPublic;
			EpicAccountId TargetUserIdPublic;
			Helper.Get(m_TargetUserId, out TargetUserIdPublic);
			other.TargetUserId = TargetUserIdPublic;
			other.PreviousStatus = m_PreviousStatus;
			other.CurrentStatus = m_CurrentStatus;
		}
	}
}
