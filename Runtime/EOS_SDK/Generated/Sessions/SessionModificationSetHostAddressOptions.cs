// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionModification.SetHostAddress" /> function.
	/// </summary>
	public struct SessionModificationSetHostAddressOptions
	{
		/// <summary>
		/// A <see cref="Utf8String" /> representing the host address for the session, its meaning is up to the application
		/// </summary>
		public Utf8String HostAddress { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct SessionModificationSetHostAddressOptionsInternal : ISettable<SessionModificationSetHostAddressOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_HostAddress;

		public void Set(ref SessionModificationSetHostAddressOptions other)
		{
			Dispose();

			m_ApiVersion = SessionsInterface.SESSIONMODIFICATION_SETHOSTADDRESS_API_LATEST;
			Helper.Set(other.HostAddress, ref m_HostAddress);
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_HostAddress);
		}
	}
}
