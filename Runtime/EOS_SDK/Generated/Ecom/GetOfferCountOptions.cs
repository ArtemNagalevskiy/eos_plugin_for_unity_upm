// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="EcomInterface.GetOfferCount" /> function.
	/// </summary>
	public struct GetOfferCountOptions
	{
		/// <summary>
		/// The Epic Account ID of the local user whose offers are being accessed
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetOfferCountOptionsInternal : ISettable<GetOfferCountOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_LocalUserId;

		public void Set(ref GetOfferCountOptions other)
		{
			Dispose();

			m_ApiVersion = EcomInterface.GETOFFERCOUNT_API_LATEST;
			Helper.Set(other.LocalUserId, ref m_LocalUserId);
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
		}
	}
}
