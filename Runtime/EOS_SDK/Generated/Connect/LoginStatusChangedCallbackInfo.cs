// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Connect
{
	/// <summary>
	/// Output parameters for the <see cref="OnLoginStatusChangedCallback" /> function.
	/// </summary>
	public struct LoginStatusChangedCallbackInfo : ICallbackInfo
	{
		/// <summary>
		/// Context that was passed into <see cref="ConnectInterface.AddNotifyLoginStatusChanged" />.
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// The Product User ID of the local player whose status has changed.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The status prior to the change.
		/// </summary>
		public LoginStatus PreviousStatus { get; set; }

		/// <summary>
		/// The status at the time of the notification.
		/// </summary>
		public LoginStatus CurrentStatus { get; set; }

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
	internal struct LoginStatusChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LoginStatusChangedCallbackInfo>
	{
		private IntPtr m_ClientData;
		private IntPtr m_LocalUserId;
		private LoginStatus m_PreviousStatus;
		private LoginStatus m_CurrentStatus;

		public IntPtr ClientDataPointer
		{
			get
			{
				return m_ClientData;
			}
		}

		public void Get(out LoginStatusChangedCallbackInfo other)
		{
			other = default;
			
			object ClientDataPublic;
			Helper.Get(m_ClientData, out ClientDataPublic);
			other.ClientData = ClientDataPublic;
			ProductUserId LocalUserIdPublic;
			Helper.Get(m_LocalUserId, out LocalUserIdPublic);
			other.LocalUserId = LocalUserIdPublic;
			other.PreviousStatus = m_PreviousStatus;
			other.CurrentStatus = m_CurrentStatus;
		}
	}
}
