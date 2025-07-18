// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="EcomInterface.QueryOwnership" /> function.
	/// </summary>
	public struct QueryOwnershipOptions
	{
		/// <summary>
		/// The Epic Account ID of the local user whose ownership to query
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The array of Catalog Item IDs to check for ownership
		/// </summary>
		public Utf8String[] CatalogItemIds { get; set; }

		/// <summary>
		/// Optional product namespace, if not the one specified during initialization
		/// </summary>
		public Utf8String CatalogNamespace { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct QueryOwnershipOptionsInternal : ISettable<QueryOwnershipOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_LocalUserId;
		private IntPtr m_CatalogItemIds;
		private uint m_CatalogItemIdCount;
		private IntPtr m_CatalogNamespace;

		public void Set(ref QueryOwnershipOptions other)
		{
			Dispose();

			m_ApiVersion = EcomInterface.QUERYOWNERSHIP_API_LATEST;
			Helper.Set(other.LocalUserId, ref m_LocalUserId);
			Helper.Set(other.CatalogItemIds, ref m_CatalogItemIds, out m_CatalogItemIdCount, true);
			Helper.Set(other.CatalogNamespace, ref m_CatalogNamespace);
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_CatalogItemIds);
			Helper.Dispose(ref m_CatalogNamespace);
		}
	}
}
