// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.UserInfo
{
	/// <summary>
	/// Input parameters for the <see cref="UserInfoInterface.QueryUserInfoByExternalAccount" /> function.
	/// </summary>
	public struct QueryUserInfoByExternalAccountOptions
	{
		/// <summary>
		/// The Epic Account ID of the local player requesting the information
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// External account ID of the user whose information is being retrieved
		/// </summary>
		public Utf8String ExternalAccountId { get; set; }

		/// <summary>
		/// Account type of the external user info to query
		/// </summary>
		public ExternalAccountType AccountType { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct QueryUserInfoByExternalAccountOptionsInternal : ISettable<QueryUserInfoByExternalAccountOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_LocalUserId;
		private IntPtr m_ExternalAccountId;
		private ExternalAccountType m_AccountType;

		public void Set(ref QueryUserInfoByExternalAccountOptions other)
		{
			Dispose();

			m_ApiVersion = UserInfoInterface.QUERYUSERINFOBYEXTERNALACCOUNT_API_LATEST;
			Helper.Set(other.LocalUserId, ref m_LocalUserId);
			Helper.Set(other.ExternalAccountId, ref m_ExternalAccountId);
			m_AccountType = other.AccountType;
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_ExternalAccountId);
		}
	}
}
