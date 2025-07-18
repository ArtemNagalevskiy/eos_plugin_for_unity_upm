// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.AntiCheatServer
{

	/// <summary>
	/// Optional callback issued when a connected client's authentication status has changed.
	/// This callback is always issued from within <see cref="Platform.PlatformInterface.Tick" /> on its calling thread.
	/// </summary>
	public delegate void OnClientAuthStatusChangedCallback(ref AntiCheatCommon.OnClientAuthStatusChangedCallbackInfo data);

	[UnmanagedFunctionPointer(Common.LIBRARY_CALLING_CONVENTION)]
	internal delegate void OnClientAuthStatusChangedCallbackInternal(ref AntiCheatCommon.OnClientAuthStatusChangedCallbackInfoInternal data);

	internal static class OnClientAuthStatusChangedCallbackInternalImplementation
	{
		private static OnClientAuthStatusChangedCallbackInternal s_Delegate;
		public static OnClientAuthStatusChangedCallbackInternal Delegate
		{
			get
			{
				if (s_Delegate == null)
				{
					s_Delegate = new OnClientAuthStatusChangedCallbackInternal(EntryPoint);
				}

				return s_Delegate;
			}
		}

		[MonoPInvokeCallback(typeof(OnClientAuthStatusChangedCallbackInternal))]
		public static void EntryPoint(ref AntiCheatCommon.OnClientAuthStatusChangedCallbackInfoInternal data)
		{
			OnClientAuthStatusChangedCallback callback;
			AntiCheatCommon.OnClientAuthStatusChangedCallbackInfo callbackInfo;
			if (Helper.TryGetCallback(ref data, out callback, out callbackInfo))
			{
				callback(ref callbackInfo);
			}
		}
	}
}
