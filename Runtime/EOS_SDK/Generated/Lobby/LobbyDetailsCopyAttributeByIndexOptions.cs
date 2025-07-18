// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Input parameters for the <see cref="LobbyDetails.CopyAttributeByIndex" /> function.
	/// </summary>
	public struct LobbyDetailsCopyAttributeByIndexOptions
	{
		/// <summary>
		/// The index of the attribute to retrieve
		/// <see cref="LobbyDetails.GetAttributeCount" />
		/// </summary>
		public uint AttrIndex { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct LobbyDetailsCopyAttributeByIndexOptionsInternal : ISettable<LobbyDetailsCopyAttributeByIndexOptions>
	{
		private int m_ApiVersion;
		private uint m_AttrIndex;

		public void Set(ref LobbyDetailsCopyAttributeByIndexOptions other)
		{
			Dispose();

			m_ApiVersion = LobbyInterface.LOBBYDETAILS_COPYATTRIBUTEBYINDEX_API_LATEST;
			m_AttrIndex = other.AttrIndex;
		}

		public void Dispose()
		{
		}
	}
}
