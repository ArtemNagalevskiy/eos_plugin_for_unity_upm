// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionSearch.SetTargetUserId" /> function.
	/// </summary>
	public struct SessionSearchSetTargetUserIdOptions
	{
		/// <summary>
		/// The Product User ID to find; return any sessions where the user matching this ID is currently registered
		/// </summary>
		public ProductUserId TargetUserId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct SessionSearchSetTargetUserIdOptionsInternal : ISettable<SessionSearchSetTargetUserIdOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_TargetUserId;

		public void Set(ref SessionSearchSetTargetUserIdOptions other)
		{
			Dispose();

			m_ApiVersion = SessionsInterface.SESSIONSEARCH_SETTARGETUSERID_API_LATEST;
			Helper.Set(other.TargetUserId, ref m_TargetUserId);
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_TargetUserId);
		}
	}
}
