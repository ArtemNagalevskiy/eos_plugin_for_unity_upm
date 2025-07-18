// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAdmin
{
	/// <summary>
	/// Input parameters for the <see cref="RTCAdminInterface.CopyUserTokenByIndex" /> function.
	/// </summary>
	public struct CopyUserTokenByIndexOptions
	{
		/// <summary>
		/// Index of the user token to retrieve from the cache.
		/// </summary>
		public uint UserTokenIndex { get; set; }

		/// <summary>
		/// Query identifier received as part of a previous query.
		/// <see cref="QueryJoinRoomTokenCompleteCallbackInfo" />
		/// </summary>
		public uint QueryId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CopyUserTokenByIndexOptionsInternal : ISettable<CopyUserTokenByIndexOptions>
	{
		private int m_ApiVersion;
		private uint m_UserTokenIndex;
		private uint m_QueryId;

		public void Set(ref CopyUserTokenByIndexOptions other)
		{
			Dispose();

			m_ApiVersion = RTCAdminInterface.COPYUSERTOKENBYINDEX_API_LATEST;
			m_UserTokenIndex = other.UserTokenIndex;
			m_QueryId = other.QueryId;
		}

		public void Dispose()
		{
		}
	}
}
