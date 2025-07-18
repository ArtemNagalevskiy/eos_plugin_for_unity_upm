// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Platform
{
	/// <summary>
	/// All possible states of the network.
	/// </summary>
	public enum NetworkStatus : int
	{
		/// <summary>
		/// Networking unavailable.
		/// </summary>
		Disabled = 0,
		/// <summary>
		/// Not connected to the internet. Only local area networking (LAN) may be available.
		/// </summary>
		Offline = 1,
		/// <summary>
		/// Connected to the internet.
		/// </summary>
		Online = 2
	}

}
