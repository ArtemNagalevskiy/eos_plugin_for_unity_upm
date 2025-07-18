// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="EcomInterface.CopyItemById" /> function.
	/// </summary>
	public struct CopyItemByIdOptions
	{
		/// <summary>
		/// The Epic Account ID of the local user whose item is being copied
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The ID of the item to get.
		/// </summary>
		public Utf8String ItemId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CopyItemByIdOptionsInternal : ISettable<CopyItemByIdOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_LocalUserId;
		private IntPtr m_ItemId;

		public void Set(ref CopyItemByIdOptions other)
		{
			Dispose();

			m_ApiVersion = EcomInterface.COPYITEMBYID_API_LATEST;
			Helper.Set(other.LocalUserId, ref m_LocalUserId);
			Helper.Set(other.ItemId, ref m_ItemId);
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_ItemId);
		}
	}
}
