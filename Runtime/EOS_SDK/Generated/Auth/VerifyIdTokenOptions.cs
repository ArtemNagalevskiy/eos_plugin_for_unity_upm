// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Auth
{
	/// <summary>
	/// Input parameters for the <see cref="AuthInterface.VerifyIdToken" /> function.
	/// </summary>
	public struct VerifyIdTokenOptions
	{
		/// <summary>
		/// The ID token to verify.
		/// Use <see cref="EpicAccountId.FromString" /> to populate the AccountId field of this struct.
		/// </summary>
		public IdToken? IdToken { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct VerifyIdTokenOptionsInternal : ISettable<VerifyIdTokenOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_IdToken;

		public void Set(ref VerifyIdTokenOptions other)
		{
			Dispose();

			m_ApiVersion = AuthInterface.VERIFYIDTOKEN_API_LATEST;
			Helper.Set<IdToken, IdTokenInternal>(other.IdToken, ref m_IdToken);
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_IdToken);
		}
	}
}
