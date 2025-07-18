// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTC
{
	/// <summary>
	/// Join room flags.
	/// </summary>
	[Flags]
	public enum JoinRoomFlags : uint
	{
		/// <summary>
		/// No flags.
		/// </summary>
		None = 0x0,
		/// <summary>
		/// Enables echo mode.
		/// This can be used during development to have the server send your voice back to you so you don't need 2 clients to test
		/// if voice is being sent and received.
		/// <see cref="JoinRoomOptions.Flags" />
		/// </summary>
		EnableEcho = 0x01,
		/// <summary>
		/// Enables the (optional) data channel feature for RTC rooms. This feature allows members of a room to send packets to all
		/// members of a room they are in, and automatically receive data packets sent by other players in that room.
		/// Data packets sent this way will be automatically relayed by EOS RTC servers to all other members of the room that are listening.
		/// It is not currently possible to send packets to only a subset of members of a room chosen by the sender, all members
		/// listening will receive the data.
		/// <see cref="JoinRoomOptions.Flags" />
		/// </summary>
		EnableDatachannel = 0x04,
		/// <summary>
		/// The flag is reserved for future use.
		/// <see cref="JoinRoomOptions.Flags" />
		/// </summary>
		ReservedVoiceFeature = 0x08
	}

}
