// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.IntegratedPlatform
{
	/// <summary>
	/// Data for the <see cref="IntegratedPlatformInterface.CreateIntegratedPlatformOptionsContainer" /> function.
	/// </summary>
	public struct CreateIntegratedPlatformOptionsContainerOptions
	{
		
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CreateIntegratedPlatformOptionsContainerOptionsInternal : ISettable<CreateIntegratedPlatformOptionsContainerOptions>
	{
		private int m_ApiVersion;

		public void Set(ref CreateIntegratedPlatformOptionsContainerOptions other)
		{
			Dispose();

			m_ApiVersion = IntegratedPlatformInterface.CREATEINTEGRATEDPLATFORMOPTIONSCONTAINER_API_LATEST;
		}

		public void Dispose()
		{
		}
	}
}
