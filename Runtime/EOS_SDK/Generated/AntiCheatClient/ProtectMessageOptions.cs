// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatClient
{
	public struct ProtectMessageOptions
	{
		/// <summary>
		/// The data to encrypt
		/// </summary>
		public ArraySegment<byte> Data { get; set; }

		/// <summary>
		/// The size in bytes of OutBuffer
		/// </summary>
		public uint OutBufferSizeBytes { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ProtectMessageOptionsInternal : ISettable<ProtectMessageOptions>
	{
		private int m_ApiVersion;
		private uint m_DataLengthBytes;
		private IntPtr m_Data;
		private uint m_OutBufferSizeBytes;

		public void Set(ref ProtectMessageOptions other)
		{
			Dispose();

			m_ApiVersion = AntiCheatClientInterface.PROTECTMESSAGE_API_LATEST;
			Helper.Set(other.Data, ref m_Data, out m_DataLengthBytes);
			m_OutBufferSizeBytes = other.OutBufferSizeBytes;
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_Data);
		}
	}
}
