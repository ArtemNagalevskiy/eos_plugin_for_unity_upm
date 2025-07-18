// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTC
{
	/// <summary>
	/// This struct is used to get information about a specific participant metadata item.
	/// </summary>
	public struct ParticipantMetadata
	{
		/// <summary>
		/// The unique key of this metadata item. The max size of the <see cref="Utf8String" /> is <see cref="RTCInterface.PARTICIPANTMETADATA_KEY_MAXCHARCOUNT" />.
		/// </summary>
		public Utf8String Key { get; set; }

		/// <summary>
		/// The value of this metadata item. The max size of the <see cref="Utf8String" /> is <see cref="RTCInterface.PARTICIPANTMETADATA_VALUE_MAXCHARCOUNT" />.
		/// </summary>
		public Utf8String Value { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct ParticipantMetadataInternal : IGettable<ParticipantMetadata>
	{
		private int m_ApiVersion;
		private IntPtr m_Key;
		private IntPtr m_Value;

		public void Get(out ParticipantMetadata other)
		{
			other = default;
			
			Utf8String KeyPublic;
			Helper.Get(m_Key, out KeyPublic);
			other.Key = KeyPublic;
			Utf8String ValuePublic;
			Helper.Get(m_Value, out ValuePublic);
			other.Value = ValuePublic;
		}
	}
}
