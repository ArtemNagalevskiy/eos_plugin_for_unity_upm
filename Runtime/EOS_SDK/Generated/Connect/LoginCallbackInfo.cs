// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Connect
{
	/// <summary>
	/// Output parameters for the <see cref="ConnectInterface.Login" /> function.
	/// </summary>
	public struct LoginCallbackInfo : ICallbackInfo
	{
		/// <summary>
		/// The <see cref="Result" /> code for the operation. <see cref="Result.Success" /> indicates that the operation succeeded; other codes indicate errors.
		/// </summary>
		public Result ResultCode { get; set; }

		/// <summary>
		/// Context that was passed into <see cref="ConnectInterface.Login" />.
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// If login was successful, this is the Product User ID of the local player that logged in.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// If the user was not found with credentials passed into <see cref="ConnectInterface.Login" />,
		/// this continuance token can be passed to either <see cref="ConnectInterface.CreateUser" />
		/// or <see cref="ConnectInterface.LinkAccount" /> to continue the flow.
		/// </summary>
		public ContinuanceToken ContinuanceToken { get; set; }

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
	internal struct LoginCallbackInfoInternal : ICallbackInfoInternal, IGettable<LoginCallbackInfo>
	{
		private Result m_ResultCode;
		private IntPtr m_ClientData;
		private IntPtr m_LocalUserId;
		private IntPtr m_ContinuanceToken;

		public IntPtr ClientDataPointer
		{
			get
			{
				return m_ClientData;
			}
		}

		public void Get(out LoginCallbackInfo other)
		{
			other = default;
			
			other.ResultCode = m_ResultCode;
			object ClientDataPublic;
			Helper.Get(m_ClientData, out ClientDataPublic);
			other.ClientData = ClientDataPublic;
			ProductUserId LocalUserIdPublic;
			Helper.Get(m_LocalUserId, out LocalUserIdPublic);
			other.LocalUserId = LocalUserIdPublic;
			ContinuanceToken ContinuanceTokenPublic;
			Helper.Get(m_ContinuanceToken, out ContinuanceTokenPublic);
			other.ContinuanceToken = ContinuanceTokenPublic;
		}
	}
}
