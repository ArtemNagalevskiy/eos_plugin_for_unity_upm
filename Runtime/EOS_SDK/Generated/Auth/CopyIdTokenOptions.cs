// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Auth
{
	/// <summary>
	/// Input parameters for the <see cref="AuthInterface.CopyIdToken" /> function.
	/// </summary>
	public struct CopyIdTokenOptions
	{
		/// <summary>
		/// The Epic Account ID of the user being queried.
		/// </summary>
		public EpicAccountId AccountId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CopyIdTokenOptionsInternal : ISettable<CopyIdTokenOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_AccountId;

		public void Set(ref CopyIdTokenOptions other)
		{
			Dispose();

			m_ApiVersion = AuthInterface.COPYIDTOKEN_API_LATEST;
			Helper.Set(other.AccountId, ref m_AccountId);
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_AccountId);
		}
	}
}
