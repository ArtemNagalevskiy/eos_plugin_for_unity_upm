// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{
	/// <summary>
	/// Input parameters for the <see cref="RTCAudioInterface.CopyInputDeviceInformationByIndex" /> function.
	/// </summary>
	public struct CopyInputDeviceInformationByIndexOptions
	{
		/// <summary>
		/// Index of the audio input device's information to retrieve.
		/// </summary>
		public uint DeviceIndex { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CopyInputDeviceInformationByIndexOptionsInternal : ISettable<CopyInputDeviceInformationByIndexOptions>
	{
		private int m_ApiVersion;
		private uint m_DeviceIndex;

		public void Set(ref CopyInputDeviceInformationByIndexOptions other)
		{
			Dispose();

			m_ApiVersion = RTCAudioInterface.COPYINPUTDEVICEINFORMATIONBYINDEX_API_LATEST;
			m_DeviceIndex = other.DeviceIndex;
		}

		public void Dispose()
		{
		}
	}
}
