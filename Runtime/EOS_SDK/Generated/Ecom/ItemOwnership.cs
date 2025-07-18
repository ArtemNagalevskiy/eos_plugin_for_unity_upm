// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Contains information about a single item ownership associated with an account. This structure is
	/// returned as part of the <see cref="QueryOwnershipCallbackInfo" /> structure.
	/// </summary>
	public struct ItemOwnership
	{
		/// <summary>
		/// ID of the catalog item
		/// </summary>
		public Utf8String Id { get; set; }

		/// <summary>
		/// Is this catalog item owned by the local user
		/// </summary>
		public OwnershipStatus OwnershipStatus { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ItemOwnershipInternal : IGettable<ItemOwnership>
	{
		private int m_ApiVersion;
		private IntPtr m_Id;
		private OwnershipStatus m_OwnershipStatus;

		public void Get(out ItemOwnership other)
		{
			other = default;
			
			Utf8String IdPublic;
			Helper.Get(m_Id, out IdPublic);
			other.Id = IdPublic;
			other.OwnershipStatus = m_OwnershipStatus;
		}
	}
}
