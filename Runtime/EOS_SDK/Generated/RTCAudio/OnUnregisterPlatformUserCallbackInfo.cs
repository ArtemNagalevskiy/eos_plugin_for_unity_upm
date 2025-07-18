// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{
	/// <summary>
	/// This struct is passed in with a call to <see cref="OnUnregisterPlatformUserCallback" />.
	/// </summary>
	public struct OnUnregisterPlatformUserCallbackInfo : ICallbackInfo
	{
		/// <summary>
		/// This returns:
		/// <see cref="Result.Success" /> if the user was successfully unregistered.
		/// <see cref="Result.InvalidParameters" /> if any of the parameters are incorrect.
		/// <see cref="Result.UnexpectedError" /> otherwise.
		/// </summary>
		public Result ResultCode { get; set; }

		/// <summary>
		/// Client-specified data passed into <see cref="RTCAudioInterface.UnregisterPlatformUser" />.
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// Platform dependent user id.
		/// </summary>
		public Utf8String PlatformUserId { get; set; }

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
	internal struct OnUnregisterPlatformUserCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnUnregisterPlatformUserCallbackInfo>
	{
		private Result m_ResultCode;
		private IntPtr m_ClientData;
		private IntPtr m_PlatformUserId;

		public IntPtr ClientDataPointer
		{
			get
			{
				return m_ClientData;
			}
		}

		public void Get(out OnUnregisterPlatformUserCallbackInfo other)
		{
			other = default;
			
			other.ResultCode = m_ResultCode;
			object ClientDataPublic;
			Helper.Get(m_ClientData, out ClientDataPublic);
			other.ClientData = ClientDataPublic;
			Utf8String PlatformUserIdPublic;
			Helper.Get(m_PlatformUserId, out PlatformUserIdPublic);
			other.PlatformUserId = PlatformUserIdPublic;
		}
	}
}
