// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatClient
{

	/// <summary>
	/// Callback issued when the local client triggers an integrity violation.
	/// 
	/// The message contains descriptive <see cref="Utf8String" /> of up to 256 characters and must be displayed to the player.
	/// 
	/// This callback is always issued from within <see cref="Platform.PlatformInterface.Tick" /> on its calling thread.
	/// </summary>
	public delegate void OnClientIntegrityViolatedCallback(ref OnClientIntegrityViolatedCallbackInfo data);

	[UnmanagedFunctionPointer(Common.LIBRARY_CALLING_CONVENTION)]
	internal delegate void OnClientIntegrityViolatedCallbackInternal(ref OnClientIntegrityViolatedCallbackInfoInternal data);

	internal static class OnClientIntegrityViolatedCallbackInternalImplementation
	{
		private static OnClientIntegrityViolatedCallbackInternal s_Delegate;
		public static OnClientIntegrityViolatedCallbackInternal Delegate
		{
			get
			{
				if (s_Delegate == null)
				{
					s_Delegate = new OnClientIntegrityViolatedCallbackInternal(EntryPoint);
				}

				return s_Delegate;
			}
		}

		[MonoPInvokeCallback(typeof(OnClientIntegrityViolatedCallbackInternal))]
		public static void EntryPoint(ref OnClientIntegrityViolatedCallbackInfoInternal data)
		{
			OnClientIntegrityViolatedCallback callback;
			OnClientIntegrityViolatedCallbackInfo callbackInfo;
			if (Helper.TryGetCallback(ref data, out callback, out callbackInfo))
			{
				callback(ref callbackInfo);
			}
		}
	}
}
