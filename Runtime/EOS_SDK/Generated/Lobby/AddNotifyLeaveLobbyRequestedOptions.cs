// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	public struct AddNotifyLeaveLobbyRequestedOptions
	{
		
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AddNotifyLeaveLobbyRequestedOptionsInternal : ISettable<AddNotifyLeaveLobbyRequestedOptions>
	{
		private int m_ApiVersion;

		public void Set(ref AddNotifyLeaveLobbyRequestedOptions other)
		{
			Dispose();

			m_ApiVersion = LobbyInterface.ADDNOTIFYLEAVELOBBYREQUESTED_API_LATEST;
		}

		public void Dispose()
		{
		}
	}
}
