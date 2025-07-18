// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Auth
{
	/// <summary>
	/// Output parameters for the <see cref="AuthInterface.Logout" /> Function.
	/// </summary>
	public struct LogoutCallbackInfo : ICallbackInfo
	{
		/// <summary>
		/// The <see cref="Result" /> code for the operation. <see cref="Result.Success" /> indicates that the operation succeeded; other codes indicate errors.
		/// </summary>
		public Result ResultCode { get; set; }

		/// <summary>
		/// Context that was passed into <see cref="AuthInterface.Login" />
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// The Epic Account ID of the local user requesting the information
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

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
	internal struct LogoutCallbackInfoInternal : ICallbackInfoInternal, IGettable<LogoutCallbackInfo>
	{
		private Result m_ResultCode;
		private IntPtr m_ClientData;
		private IntPtr m_LocalUserId;

		public IntPtr ClientDataPointer
		{
			get
			{
				return m_ClientData;
			}
		}

		public void Get(out LogoutCallbackInfo other)
		{
			other = default;
			
			other.ResultCode = m_ResultCode;
			object ClientDataPublic;
			Helper.Get(m_ClientData, out ClientDataPublic);
			other.ClientData = ClientDataPublic;
			EpicAccountId LocalUserIdPublic;
			Helper.Get(m_LocalUserId, out LocalUserIdPublic);
			other.LocalUserId = LocalUserIdPublic;
		}
	}
}
