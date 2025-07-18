// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionDetails.CopyInfo" /> function.
	/// </summary>
	public struct SessionDetailsCopyInfoOptions
	{
		
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct SessionDetailsCopyInfoOptionsInternal : ISettable<SessionDetailsCopyInfoOptions>
	{
		private int m_ApiVersion;

		public void Set(ref SessionDetailsCopyInfoOptions other)
		{
			Dispose();

			m_ApiVersion = SessionsInterface.SESSIONDETAILS_COPYINFO_API_LATEST;
		}

		public void Dispose()
		{
		}
	}
}
