// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Presence
{
	/// <summary>
	/// Presence Status states of a user
	/// <see cref="PresenceInterface.CopyPresence" />
	/// <see cref="PresenceModification.SetStatus" />
	/// </summary>
	public enum Status : int
	{
		/// <summary>
		/// The status of the account is offline or not known
		/// </summary>
		Offline = 0,
		/// <summary>
		/// The status of the account is online
		/// </summary>
		Online = 1,
		/// <summary>
		/// The status of the account is away
		/// </summary>
		Away = 2,
		/// <summary>
		/// The status of the account is away, and has been away for a while
		/// </summary>
		ExtendedAway = 3,
		/// <summary>
		/// The status of the account is do-not-disturb
		/// </summary>
		DoNotDisturb = 4
	}

}
