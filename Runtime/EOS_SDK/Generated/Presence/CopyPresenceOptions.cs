// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Presence
{
	/// <summary>
	/// Data for the <see cref="PresenceInterface.CopyPresence" /> function.
	/// </summary>
	public struct CopyPresenceOptions
	{
		/// <summary>
		/// The Epic Account ID of the local, logged-in user making the request
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The Epic Account ID of the user whose cached presence data you want to copy from the cache
		/// </summary>
		public EpicAccountId TargetUserId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CopyPresenceOptionsInternal : ISettable<CopyPresenceOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_LocalUserId;
		private IntPtr m_TargetUserId;

		public void Set(ref CopyPresenceOptions other)
		{
			Dispose();

			m_ApiVersion = PresenceInterface.COPYPRESENCE_API_LATEST;
			Helper.Set(other.LocalUserId, ref m_LocalUserId);
			Helper.Set(other.TargetUserId, ref m_TargetUserId);
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_TargetUserId);
		}
	}
}
