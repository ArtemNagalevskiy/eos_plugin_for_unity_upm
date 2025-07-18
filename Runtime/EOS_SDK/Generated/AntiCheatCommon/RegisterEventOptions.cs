// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatCommon
{
	public struct RegisterEventOptions
	{
		/// <summary>
		/// Unique event identifier. Must be >= <see cref="AntiCheatCommonInterface.REGISTEREVENT_CUSTOMEVENTBASE" />.
		/// </summary>
		public uint EventId { get; set; }

		/// <summary>
		/// Name of the custom event. Allowed characters are 0-9, A-Z, a-z, '_', '-'
		/// </summary>
		public Utf8String EventName { get; set; }

		/// <summary>
		/// Type of the custom event
		/// </summary>
		public AntiCheatCommonEventType EventType { get; set; }

		/// <summary>
		/// <see cref="IntPtr" /> to an array of <see cref="RegisterEventParamDef" /> with ParamDefsCount elements
		/// </summary>
		public RegisterEventParamDef[] ParamDefs { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct RegisterEventOptionsInternal : ISettable<RegisterEventOptions>
	{
		private int m_ApiVersion;
		private uint m_EventId;
		private IntPtr m_EventName;
		private AntiCheatCommonEventType m_EventType;
		private uint m_ParamDefsCount;
		private IntPtr m_ParamDefs;

		public void Set(ref RegisterEventOptions other)
		{
			Dispose();

			m_ApiVersion = AntiCheatCommonInterface.REGISTEREVENT_API_LATEST;
			m_EventId = other.EventId;
			Helper.Set(other.EventName, ref m_EventName);
			m_EventType = other.EventType;
			Helper.Set<RegisterEventParamDef, RegisterEventParamDefInternal>(other.ParamDefs, ref m_ParamDefs, out m_ParamDefsCount, false);
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_EventName);
			Helper.Dispose(ref m_ParamDefs);
		}
	}
}
