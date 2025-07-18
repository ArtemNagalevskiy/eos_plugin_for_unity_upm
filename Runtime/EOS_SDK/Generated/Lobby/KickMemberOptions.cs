// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Input parameters for the <see cref="LobbyInterface.KickMember" /> function.
	/// </summary>
	public struct KickMemberOptions
	{
		/// <summary>
		/// The ID of the lobby
		/// </summary>
		public Utf8String LobbyId { get; set; }

		/// <summary>
		/// The Product User ID of the local user requesting the removal; this user must be the lobby owner
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The Product User ID of the lobby member to remove
		/// </summary>
		public ProductUserId TargetUserId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct KickMemberOptionsInternal : ISettable<KickMemberOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_LobbyId;
		private IntPtr m_LocalUserId;
		private IntPtr m_TargetUserId;

		public void Set(ref KickMemberOptions other)
		{
			Dispose();

			m_ApiVersion = LobbyInterface.KICKMEMBER_API_LATEST;
			Helper.Set(other.LobbyId, ref m_LobbyId);
			Helper.Set(other.LocalUserId, ref m_LocalUserId);
			Helper.Set(other.TargetUserId, ref m_TargetUserId);
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LobbyId);
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_TargetUserId);
		}
	}
}
