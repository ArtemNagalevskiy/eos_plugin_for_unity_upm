// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Presence
{
	/// <summary>
	/// All the known presence information for a specific user. This object must be released by calling <see cref="PresenceInterface.Release" />.
	/// <see cref="PresenceInterface.CopyPresence" />
	/// <see cref="PresenceInterface.Release" />
	/// </summary>
	public struct Info
	{
		/// <summary>
		/// The status of the user
		/// </summary>
		public Status Status { get; set; }

		/// <summary>
		/// The Epic Account ID of the user
		/// </summary>
		public EpicAccountId UserId { get; set; }

		/// <summary>
		/// The product ID that the user is logged in from
		/// </summary>
		public Utf8String ProductId { get; set; }

		/// <summary>
		/// The version of the product the user is logged in from
		/// </summary>
		public Utf8String ProductVersion { get; set; }

		/// <summary>
		/// The platform of that the user is logged in from
		/// </summary>
		public Utf8String Platform { get; set; }

		/// <summary>
		/// Rich text of the user.
		/// </summary>
		public Utf8String RichText { get; set; }

		/// <summary>
		/// The first data record, or <see langword="null" /> if RecordsCount is not at least 1
		/// </summary>
		public DataRecord[] Records { get; set; }

		/// <summary>
		/// The user-facing name for the product the user is logged in from
		/// </summary>
		public Utf8String ProductName { get; set; }

		/// <summary>
		/// The integrated platform that the user is logged in with
		/// </summary>
		public Utf8String IntegratedPlatform { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct InfoInternal : IGettable<Info>
	{
		private int m_ApiVersion;
		private Status m_Status;
		private IntPtr m_UserId;
		private IntPtr m_ProductId;
		private IntPtr m_ProductVersion;
		private IntPtr m_Platform;
		private IntPtr m_RichText;
		private int m_RecordsCount;
		private IntPtr m_Records;
		private IntPtr m_ProductName;
		private IntPtr m_IntegratedPlatform;

		public void Get(out Info other)
		{
			other = default;
			
			other.Status = m_Status;
			EpicAccountId UserIdPublic;
			Helper.Get(m_UserId, out UserIdPublic);
			other.UserId = UserIdPublic;
			Utf8String ProductIdPublic;
			Helper.Get(m_ProductId, out ProductIdPublic);
			other.ProductId = ProductIdPublic;
			Utf8String ProductVersionPublic;
			Helper.Get(m_ProductVersion, out ProductVersionPublic);
			other.ProductVersion = ProductVersionPublic;
			Utf8String PlatformPublic;
			Helper.Get(m_Platform, out PlatformPublic);
			other.Platform = PlatformPublic;
			Utf8String RichTextPublic;
			Helper.Get(m_RichText, out RichTextPublic);
			other.RichText = RichTextPublic;
			DataRecord[] RecordsPublic;
			Helper.Get<DataRecordInternal, DataRecord>(m_Records, out RecordsPublic, m_RecordsCount, false);
			other.Records = RecordsPublic;
			Utf8String ProductNamePublic;
			Helper.Get(m_ProductName, out ProductNamePublic);
			other.ProductName = ProductNamePublic;
			Utf8String IntegratedPlatformPublic;
			Helper.Get(m_IntegratedPlatform, out IntegratedPlatformPublic);
			other.IntegratedPlatform = IntegratedPlatformPublic;
		}
	}
}
