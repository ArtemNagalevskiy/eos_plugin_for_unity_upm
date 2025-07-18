// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.IntegratedPlatform
{
	/// <summary>
	/// Input parameters for the <see cref="IntegratedPlatformInterface.FinalizeDeferredUserLogout" /> function.
	/// </summary>
	public struct FinalizeDeferredUserLogoutOptions
	{
		/// <summary>
		/// The integrated platform this user belongs to.
		/// </summary>
		public Utf8String PlatformType { get; set; }

		/// <summary>
		/// <see cref="Utf8String" /> version of the integrated platform-dependent user id.
		/// </summary>
		public Utf8String LocalPlatformUserId { get; set; }

		/// <summary>
		/// The logged-in state the user is expected to be (<see cref="LoginStatus.LoggedIn" /> or <see cref="LoginStatus.NotLoggedIn" />). If the provided
		/// state does not match internal EOS state, this function will return in failure. If the state is incorrect,
		/// the application should wait and attempt to call the function again next tick, after both updating its own
		/// state from the system and calling <see cref="Platform.PlatformInterface.Tick" />, allowing the SDK to update its state from the system
		/// as well.
		/// </summary>
		public LoginStatus ExpectedLoginStatus { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct FinalizeDeferredUserLogoutOptionsInternal : ISettable<FinalizeDeferredUserLogoutOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_PlatformType;
		private IntPtr m_LocalPlatformUserId;
		private LoginStatus m_ExpectedLoginStatus;

		public void Set(ref FinalizeDeferredUserLogoutOptions other)
		{
			Dispose();

			m_ApiVersion = IntegratedPlatformInterface.FINALIZEDEFERREDUSERLOGOUT_API_LATEST;
			Helper.Set(other.PlatformType, ref m_PlatformType);
			Helper.Set(other.LocalPlatformUserId, ref m_LocalPlatformUserId);
			m_ExpectedLoginStatus = other.ExpectedLoginStatus;
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_PlatformType);
			Helper.Dispose(ref m_LocalPlatformUserId);
		}
	}
}
