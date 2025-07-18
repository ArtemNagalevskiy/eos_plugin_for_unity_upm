// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Presence
{

	/// <summary>
	/// Callback for information related to <see cref="PresenceInterface.QueryPresence" /> finishing.
	/// </summary>
	public delegate void OnQueryPresenceCompleteCallback(ref QueryPresenceCallbackInfo data);

	[UnmanagedFunctionPointer(Common.LIBRARY_CALLING_CONVENTION)]
	internal delegate void OnQueryPresenceCompleteCallbackInternal(ref QueryPresenceCallbackInfoInternal data);

	internal static class OnQueryPresenceCompleteCallbackInternalImplementation
	{
		private static OnQueryPresenceCompleteCallbackInternal s_Delegate;
		public static OnQueryPresenceCompleteCallbackInternal Delegate
		{
			get
			{
				if (s_Delegate == null)
				{
					s_Delegate = new OnQueryPresenceCompleteCallbackInternal(EntryPoint);
				}

				return s_Delegate;
			}
		}

		[MonoPInvokeCallback(typeof(OnQueryPresenceCompleteCallbackInternal))]
		public static void EntryPoint(ref QueryPresenceCallbackInfoInternal data)
		{
			OnQueryPresenceCompleteCallback callback;
			QueryPresenceCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback(ref data, out callback, out callbackInfo))
			{
				callback(ref callbackInfo);
			}
		}
	}
}
