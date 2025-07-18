// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatClient
{
	public struct Reserved01Options
	{
		
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct Reserved01OptionsInternal : ISettable<Reserved01Options>
	{
		private int m_ApiVersion;

		public void Set(ref Reserved01Options other)
		{
			Dispose();

			m_ApiVersion = AntiCheatClientInterface.RESERVED01_API_LATEST;
		}

		public void Dispose()
		{
		}
	}
}
