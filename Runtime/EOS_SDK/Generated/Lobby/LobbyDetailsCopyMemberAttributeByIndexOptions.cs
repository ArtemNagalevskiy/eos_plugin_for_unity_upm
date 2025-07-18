// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Input parameters for the <see cref="LobbyDetails.CopyMemberAttributeByIndex" /> function.
	/// </summary>
	public struct LobbyDetailsCopyMemberAttributeByIndexOptions
	{
		/// <summary>
		/// The Product User ID of the lobby member
		/// </summary>
		public ProductUserId TargetUserId { get; set; }

		/// <summary>
		/// The index of the attribute to copy
		/// </summary>
		public uint AttrIndex { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct LobbyDetailsCopyMemberAttributeByIndexOptionsInternal : ISettable<LobbyDetailsCopyMemberAttributeByIndexOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_TargetUserId;
		private uint m_AttrIndex;

		public void Set(ref LobbyDetailsCopyMemberAttributeByIndexOptions other)
		{
			Dispose();

			m_ApiVersion = LobbyInterface.LOBBYDETAILS_COPYMEMBERATTRIBUTEBYINDEX_API_LATEST;
			Helper.Set(other.TargetUserId, ref m_TargetUserId);
			m_AttrIndex = other.AttrIndex;
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_TargetUserId);
		}
	}
}
