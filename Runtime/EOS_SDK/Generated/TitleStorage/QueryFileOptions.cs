// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.TitleStorage
{
	/// <summary>
	/// Input data for the <see cref="TitleStorageInterface.QueryFile" /> function
	/// </summary>
	public struct QueryFileOptions
	{
		/// <summary>
		/// Product User ID of the local user requesting file metadata (optional)
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The requested file's name
		/// </summary>
		public Utf8String Filename { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct QueryFileOptionsInternal : ISettable<QueryFileOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_LocalUserId;
		private IntPtr m_Filename;

		public void Set(ref QueryFileOptions other)
		{
			Dispose();

			m_ApiVersion = TitleStorageInterface.QUERYFILE_API_LATEST;
			Helper.Set(other.LocalUserId, ref m_LocalUserId);
			Helper.Set(other.Filename, ref m_Filename);
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_Filename);
		}
	}
}
