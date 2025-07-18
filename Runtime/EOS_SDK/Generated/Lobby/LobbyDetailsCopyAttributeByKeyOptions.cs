// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Input parameters for the <see cref="LobbyDetails.CopyAttributeByKey" /> function.
	/// </summary>
	public struct LobbyDetailsCopyAttributeByKeyOptions
	{
		/// <summary>
		/// Name of the attribute
		/// </summary>
		public Utf8String AttrKey { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct LobbyDetailsCopyAttributeByKeyOptionsInternal : ISettable<LobbyDetailsCopyAttributeByKeyOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_AttrKey;

		public void Set(ref LobbyDetailsCopyAttributeByKeyOptions other)
		{
			Dispose();

			m_ApiVersion = LobbyInterface.LOBBYDETAILS_COPYATTRIBUTEBYKEY_API_LATEST;
			Helper.Set(other.AttrKey, ref m_AttrKey);
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_AttrKey);
		}
	}
}
