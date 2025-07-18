// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.P2P
{
	/// <summary>
	/// Categories of NAT strictness.
	/// </summary>
	public enum NATType : int
	{
		/// <summary>
		/// NAT type either unknown (remote) or we are unable to determine it (local)
		/// </summary>
		Unknown = 0,
		/// <summary>
		/// All peers can directly-connect to you
		/// </summary>
		Open = 1,
		/// <summary>
		/// You can directly-connect to other Moderate and Open peers
		/// </summary>
		Moderate = 2,
		/// <summary>
		/// You can only directly-connect to Open peers
		/// </summary>
		Strict = 3
	}

}
