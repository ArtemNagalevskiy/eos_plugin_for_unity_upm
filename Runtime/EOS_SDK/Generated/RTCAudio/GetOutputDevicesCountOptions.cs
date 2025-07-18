// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{
	/// <summary>
	/// Output parameters for the <see cref="RTCAudioInterface.GetOutputDevicesCount" /> function.
	/// </summary>
	public struct GetOutputDevicesCountOptions
	{
		
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct GetOutputDevicesCountOptionsInternal : ISettable<GetOutputDevicesCountOptions>
	{
		private int m_ApiVersion;

		public void Set(ref GetOutputDevicesCountOptions other)
		{
			Dispose();

			m_ApiVersion = RTCAudioInterface.GETOUTPUTDEVICESCOUNT_API_LATEST;
		}

		public void Dispose()
		{
		}
	}
}
