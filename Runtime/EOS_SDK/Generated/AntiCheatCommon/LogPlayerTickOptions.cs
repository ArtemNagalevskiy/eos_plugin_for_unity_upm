// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatCommon
{
	public struct LogPlayerTickOptions
	{
		/// <summary>
		/// Locally unique value used in RegisterClient/RegisterPeer
		/// </summary>
		public IntPtr PlayerHandle { get; set; }

		/// <summary>
		/// Player character's current world position as a 3D vector. This should be the center of the character.
		/// </summary>
		public Vec3f? PlayerPosition { get; set; }

		/// <summary>
		/// Player camera's current world rotation as a quaternion.
		/// </summary>
		public Quat? PlayerViewRotation { get; set; }

		/// <summary>
		/// True if the player's view is zoomed (e.g. using a sniper rifle), otherwise <see langword="false" />
		/// </summary>
		public bool IsPlayerViewZoomed { get; set; }

		/// <summary>
		/// Player's current health value
		/// </summary>
		public float PlayerHealth { get; set; }

		/// <summary>
		/// Any movement state applicable
		/// </summary>
		public AntiCheatCommonPlayerMovementState PlayerMovementState { get; set; }

		/// <summary>
		/// Player camera's current world position as a 3D vector.
		/// </summary>
		public Vec3f? PlayerViewPosition { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct LogPlayerTickOptionsInternal : ISettable<LogPlayerTickOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_PlayerHandle;
		private IntPtr m_PlayerPosition;
		private IntPtr m_PlayerViewRotation;
		private int m_IsPlayerViewZoomed;
		private float m_PlayerHealth;
		private AntiCheatCommonPlayerMovementState m_PlayerMovementState;
		private IntPtr m_PlayerViewPosition;

		public void Set(ref LogPlayerTickOptions other)
		{
			Dispose();

			m_ApiVersion = AntiCheatCommonInterface.LOGPLAYERTICK_API_LATEST;
			m_PlayerHandle = other.PlayerHandle;
			Helper.Set<Vec3f, Vec3fInternal>(other.PlayerPosition, ref m_PlayerPosition);
			Helper.Set<Quat, QuatInternal>(other.PlayerViewRotation, ref m_PlayerViewRotation);
			Helper.Set(other.IsPlayerViewZoomed, ref m_IsPlayerViewZoomed);
			m_PlayerHealth = other.PlayerHealth;
			m_PlayerMovementState = other.PlayerMovementState;
			Helper.Set<Vec3f, Vec3fInternal>(other.PlayerViewPosition, ref m_PlayerViewPosition);
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_PlayerHandle);
			Helper.Dispose(ref m_PlayerPosition);
			Helper.Dispose(ref m_PlayerViewRotation);
			Helper.Dispose(ref m_PlayerViewPosition);
		}
	}
}
