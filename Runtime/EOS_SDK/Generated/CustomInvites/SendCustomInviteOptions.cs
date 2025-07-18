// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.CustomInvites
{
	/// <summary>
	/// Input parameters for the <see cref="CustomInvitesInterface.SendCustomInvite" /> function.
	/// </summary>
	public struct SendCustomInviteOptions
	{
		/// <summary>
		/// Local user sending a CustomInvite
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// Users to whom the invites should be sent
		/// </summary>
		public ProductUserId[] TargetUserIds { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct SendCustomInviteOptionsInternal : ISettable<SendCustomInviteOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_LocalUserId;
		private IntPtr m_TargetUserIds;
		private uint m_TargetUserIdsCount;

		public void Set(ref SendCustomInviteOptions other)
		{
			Dispose();

			m_ApiVersion = CustomInvitesInterface.SENDCUSTOMINVITE_API_LATEST;
			Helper.Set(other.LocalUserId, ref m_LocalUserId);
			Helper.Set(other.TargetUserIds, ref m_TargetUserIds, out m_TargetUserIdsCount, false);
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_TargetUserIds);
		}
	}
}
