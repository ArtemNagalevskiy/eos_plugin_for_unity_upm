// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.TitleStorage
{
	/// <summary>
	/// Input data for the <see cref="TitleStorageInterface.QueryFileList" /> function
	/// </summary>
	public struct QueryFileListOptions
	{
		/// <summary>
		/// Product User ID of the local user who requested file metadata (optional)
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// List of tags to use for lookup.
		/// </summary>
		public Utf8String[] ListOfTags { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct QueryFileListOptionsInternal : ISettable<QueryFileListOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_LocalUserId;
		private IntPtr m_ListOfTags;
		private uint m_ListOfTagsCount;

		public void Set(ref QueryFileListOptions other)
		{
			Dispose();

			m_ApiVersion = TitleStorageInterface.QUERYFILELIST_API_LATEST;
			Helper.Set(other.LocalUserId, ref m_LocalUserId);
			Helper.Set(other.ListOfTags, ref m_ListOfTags, out m_ListOfTagsCount, true);
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_ListOfTags);
		}
	}
}
