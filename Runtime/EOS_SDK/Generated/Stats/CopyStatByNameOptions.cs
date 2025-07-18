// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Stats
{
	/// <summary>
	/// Input parameters for the <see cref="StatsInterface.CopyStatByName" /> function.
	/// </summary>
	public struct CopyStatByNameOptions
	{
		/// <summary>
		/// The Product User ID of the user who owns the stat
		/// </summary>
		public ProductUserId TargetUserId { get; set; }

		/// <summary>
		/// Name of the stat to retrieve from the cache
		/// </summary>
		public Utf8String Name { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct CopyStatByNameOptionsInternal : ISettable<CopyStatByNameOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_TargetUserId;
		private IntPtr m_Name;

		public void Set(ref CopyStatByNameOptions other)
		{
			Dispose();

			m_ApiVersion = StatsInterface.COPYSTATBYNAME_API_LATEST;
			Helper.Set(other.TargetUserId, ref m_TargetUserId);
			Helper.Set(other.Name, ref m_Name);
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_TargetUserId);
			Helper.Dispose(ref m_Name);
		}
	}
}
