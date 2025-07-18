// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.PlayerDataStorage
{
	/// <summary>
	/// Data containing data for a chunk of a file being written
	/// </summary>
	public struct WriteFileDataCallbackInfo : ICallbackInfo
	{
		/// <summary>
		/// Client-specified data passed into the file write request
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// The Product User ID of the local user who initiated this request
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The file name that is being written to
		/// </summary>
		public Utf8String Filename { get; set; }

		/// <summary>
		/// The maximum amount of data in bytes that can be written safely to DataBuffer
		/// </summary>
		public uint DataBufferLengthBytes { get; set; }

		public object GetClientData()
		{
			return ClientData;
		}

		public Result? GetResultCode()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct WriteFileDataCallbackInfoInternal : ICallbackInfoInternal, IGettable<WriteFileDataCallbackInfo>
	{
		private IntPtr m_ClientData;
		private IntPtr m_LocalUserId;
		private IntPtr m_Filename;
		private uint m_DataBufferLengthBytes;

		public IntPtr ClientDataPointer
		{
			get
			{
				return m_ClientData;
			}
		}

		public void Get(out WriteFileDataCallbackInfo other)
		{
			other = default;
			
			object ClientDataPublic;
			Helper.Get(m_ClientData, out ClientDataPublic);
			other.ClientData = ClientDataPublic;
			ProductUserId LocalUserIdPublic;
			Helper.Get(m_LocalUserId, out LocalUserIdPublic);
			other.LocalUserId = LocalUserIdPublic;
			Utf8String FilenamePublic;
			Helper.Get(m_Filename, out FilenamePublic);
			other.Filename = FilenamePublic;
			other.DataBufferLengthBytes = m_DataBufferLengthBytes;
		}
	}
}
