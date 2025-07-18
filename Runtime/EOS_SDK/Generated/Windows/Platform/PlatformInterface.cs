// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

#if UNITY_EDITOR_WIN
	#define EOS_PLATFORM_WINDOWS_64
#elif UNITY_STANDALONE_WIN
	#if UNITY_64
		#define EOS_PLATFORM_WINDOWS_64
	#else
		#define EOS_PLATFORM_WINDOWS_32
	#endif
#endif

#if EOS_PLATFORM_WINDOWS_32 || EOS_PLATFORM_WINDOWS_64
using System;

namespace Epic.OnlineServices.Platform
{
	public sealed partial class PlatformInterface
	{
		/// <summary>
		/// The most recent version of the <see cref="WindowsRTCOptionsPlatformSpecificOptions" /> structure.
		/// </summary>
		public const int WINDOWS_RTCOPTIONS_API_LATEST = 1;

		/// <summary>
		/// Create a single Epic Online Services Platform Instance.
		/// 
		/// The platform instance is used to gain access to the various Epic Online Services.
		/// 
		/// This function returns an opaque handle to the platform instance, and that handle must be passed to <see cref="Release" /> to release the instance.
		/// </summary>
		/// <returns>
		/// An opaque handle to the platform instance.
		/// </returns>
		public static PlatformInterface Create(ref WindowsOptions options)
		{
			var optionsInternal = default(WindowsOptionsInternal);
			optionsInternal.Set(ref options);

			var callResult = WindowsBindings.EOS_Platform_Create_Windows(ref optionsInternal);

			Helper.Dispose(ref optionsInternal);

			PlatformInterface callResultReturn;
			Helper.Get(callResult, out callResultReturn);
			return callResultReturn;
		}
	}
}
#endif
