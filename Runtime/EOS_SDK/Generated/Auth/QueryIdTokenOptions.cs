// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Auth
{
	/// <summary>
	/// Input parameters for the <see cref="AuthInterface.QueryIdToken" /> function.
	/// </summary>
	public struct QueryIdTokenOptions
	{
		/// <summary>
		/// The Epic Account ID of the local authenticated user.
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The target Epic Account ID for which to query an ID token.
		/// This account id may be the same as the input LocalUserId or another merged account id associated with the local user's Epic account.
		/// 
		/// An ID token for the selected account id of a locally authenticated user will always be readily available.
		/// To retrieve it for the selected account ID, you can use <see cref="AuthInterface.CopyIdToken" /> directly after a successful user login.
		/// </summary>
		public EpicAccountId TargetAccountId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct QueryIdTokenOptionsInternal : ISettable<QueryIdTokenOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_LocalUserId;
		private IntPtr m_TargetAccountId;

		public void Set(ref QueryIdTokenOptions other)
		{
			Dispose();

			m_ApiVersion = AuthInterface.QUERYIDTOKEN_API_LATEST;
			Helper.Set(other.LocalUserId, ref m_LocalUserId);
			Helper.Set(other.TargetAccountId, ref m_TargetAccountId);
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_TargetAccountId);
		}
	}
}
