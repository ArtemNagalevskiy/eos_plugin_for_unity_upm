// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="EcomInterface.CopyOfferImageInfoByIndex" /> function.
	/// </summary>
	public struct CopyOfferImageInfoByIndexOptions
	{
		/// <summary>
		/// The Epic Account ID of the local user whose offer image is being copied.
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The ID of the offer to get the images for.
		/// </summary>
		public Utf8String OfferId { get; set; }

		/// <summary>
		/// The index of the image to get.
		/// </summary>
		public uint ImageInfoIndex { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CopyOfferImageInfoByIndexOptionsInternal : ISettable<CopyOfferImageInfoByIndexOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_LocalUserId;
		private IntPtr m_OfferId;
		private uint m_ImageInfoIndex;

		public void Set(ref CopyOfferImageInfoByIndexOptions other)
		{
			Dispose();

			m_ApiVersion = EcomInterface.COPYOFFERIMAGEINFOBYINDEX_API_LATEST;
			Helper.Set(other.LocalUserId, ref m_LocalUserId);
			Helper.Set(other.OfferId, ref m_OfferId);
			m_ImageInfoIndex = other.ImageInfoIndex;
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_OfferId);
		}
	}
}
