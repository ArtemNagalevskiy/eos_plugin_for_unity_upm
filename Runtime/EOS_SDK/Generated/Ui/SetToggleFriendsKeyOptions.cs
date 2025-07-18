// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.UI
{
	/// <summary>
	/// Input parameters for the <see cref="UIInterface.SetToggleFriendsKey" /> function.
	/// </summary>
	public struct SetToggleFriendsKeyOptions
	{
		/// <summary>
		/// The new key combination which will be used to toggle the friends overlay.
		/// The combination can be any set of modifiers and one key.
		/// A value of <see cref="KeyCombination.None" /> will cause the key to revert to the default.
		/// </summary>
		public KeyCombination KeyCombination { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct SetToggleFriendsKeyOptionsInternal : ISettable<SetToggleFriendsKeyOptions>
	{
		private int m_ApiVersion;
		private KeyCombination m_KeyCombination;

		public void Set(ref SetToggleFriendsKeyOptions other)
		{
			Dispose();

			m_ApiVersion = UIInterface.SETTOGGLEFRIENDSKEY_API_LATEST;
			m_KeyCombination = other.KeyCombination;
		}

		public void Dispose()
		{
		}
	}
}
