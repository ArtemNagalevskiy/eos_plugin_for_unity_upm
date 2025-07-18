// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Connect
{
	/// <summary>
	/// Contains information about an external account linked with a Product User ID.
	/// </summary>
	public struct ExternalAccountInfo
	{
		/// <summary>
		/// The Product User ID of the target user.
		/// </summary>
		public ProductUserId ProductUserId { get; set; }

		/// <summary>
		/// Display name, can be <see langword="null" /> if not set.
		/// </summary>
		public Utf8String DisplayName { get; set; }

		/// <summary>
		/// External account ID.
		/// 
		/// May be set to an empty <see cref="Utf8String" /> if the AccountIdType of another user belongs
		/// to different account system than the local user's authenticated account.
		/// The availability of this field is dependent on account system specifics.
		/// </summary>
		public Utf8String AccountId { get; set; }

		/// <summary>
		/// The identity provider that owns the external account.
		/// </summary>
		public ExternalAccountType AccountIdType { get; set; }

		/// <summary>
		/// The POSIX timestamp for the time the user last logged in, or <see cref="ConnectInterface.TIME_UNDEFINED" />.
		/// </summary>
		public DateTimeOffset? LastLoginTime { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ExternalAccountInfoInternal : IGettable<ExternalAccountInfo>
	{
		private int m_ApiVersion;
		private IntPtr m_ProductUserId;
		private IntPtr m_DisplayName;
		private IntPtr m_AccountId;
		private ExternalAccountType m_AccountIdType;
		private long m_LastLoginTime;

		public void Get(out ExternalAccountInfo other)
		{
			other = default;
			
			ProductUserId ProductUserIdPublic;
			Helper.Get(m_ProductUserId, out ProductUserIdPublic);
			other.ProductUserId = ProductUserIdPublic;
			Utf8String DisplayNamePublic;
			Helper.Get(m_DisplayName, out DisplayNamePublic);
			other.DisplayName = DisplayNamePublic;
			Utf8String AccountIdPublic;
			Helper.Get(m_AccountId, out AccountIdPublic);
			other.AccountId = AccountIdPublic;
			other.AccountIdType = m_AccountIdType;
			DateTimeOffset? LastLoginTimePublic;
			Helper.Get(m_LastLoginTime, out LastLoginTimePublic);
			other.LastLoginTime = LastLoginTimePublic;
		}
	}
}
