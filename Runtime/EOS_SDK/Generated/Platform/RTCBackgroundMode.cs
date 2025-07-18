// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Platform
{
	/// <summary>
	/// All background modes supported by the RTC components
	/// </summary>
	public enum RTCBackgroundMode : int
	{
		/// <summary>
		/// Upon entering a background application status, all logged in users leave any RTC rooms. All subsequent attempts to join any RTC rooms will be rejected.
		/// Upon returning to a foreground application status, all subsequent attempts to join any RTC rooms will be allowed.
		/// </summary>
		LeaveRooms = 0,
		/// <summary>
		/// Application status has no effect on RTC rooms. Audio is captured from input devices and is played to output devices.
		/// Games should obtain consent from users and otherwise make users aware this is occurring.
		/// </summary>
		KeepRoomsAlive = 1
	}

}
