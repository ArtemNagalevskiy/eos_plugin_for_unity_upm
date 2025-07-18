// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Permission level gets more restrictive further down
	/// </summary>
	public enum OnlineSessionPermissionLevel : int
	{
		/// <summary>
		/// Anyone can find this session as long as it isn't full
		/// </summary>
		PublicAdvertised = 0,
		/// <summary>
		/// Players who have access to presence can see this session
		/// </summary>
		JoinViaPresence = 1,
		/// <summary>
		/// Only players with invites registered can see this session
		/// </summary>
		InviteOnly = 2
	}

}
