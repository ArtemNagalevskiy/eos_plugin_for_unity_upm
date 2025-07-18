// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Platform
{
	/// <summary>
	/// All possible states of the application.
	/// </summary>
	public enum ApplicationStatus : int
	{
		/// <summary>
		/// Xbox only.
		/// 
		/// Notifies the SDK that the application has entered constrained mode.
		/// While in constrained mode, the application has reduced access to reserved system resources.
		/// </summary>
		BackgroundConstrained = 0,
		/// <summary>
		/// Xbox only.
		/// 
		/// Notifies the SDK that the application has returned from constrained mode,
		/// and is back to running in a regular state with full access to system resources.
		/// 
		/// The SDK will handle this state change and automatically transition its active state to <see cref="Foreground" />.
		/// As result, after the application has set the <see cref="BackgroundUnconstrained" /> state,
		/// calling <see cref="PlatformInterface.GetApplicationStatus" /> will return <see cref="Foreground" /> as the persisted active state.
		/// </summary>
		BackgroundUnconstrained = 1,
		/// <summary>
		/// Notifies the SDK that the application has been put into suspended state by the platform system.
		/// </summary>
		BackgroundSuspended = 2,
		/// <summary>
		/// Notifies the SDK that the application has been resumed from suspended state.
		/// 
		/// This is the default active state on all platforms.
		/// </summary>
		Foreground = 3
	}

}
