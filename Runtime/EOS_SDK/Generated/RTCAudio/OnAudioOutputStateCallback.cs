// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{

	public delegate void OnAudioOutputStateCallback(ref AudioOutputStateCallbackInfo data);

	[UnmanagedFunctionPointer(Common.LIBRARY_CALLING_CONVENTION)]
	internal delegate void OnAudioOutputStateCallbackInternal(ref AudioOutputStateCallbackInfoInternal data);

	internal static class OnAudioOutputStateCallbackInternalImplementation
	{
		private static OnAudioOutputStateCallbackInternal s_Delegate;
		public static OnAudioOutputStateCallbackInternal Delegate
		{
			get
			{
				if (s_Delegate == null)
				{
					s_Delegate = new OnAudioOutputStateCallbackInternal(EntryPoint);
				}

				return s_Delegate;
			}
		}

		[MonoPInvokeCallback(typeof(OnAudioOutputStateCallbackInternal))]
		public static void EntryPoint(ref AudioOutputStateCallbackInfoInternal data)
		{
			OnAudioOutputStateCallback callback;
			AudioOutputStateCallbackInfo callbackInfo;
			if (Helper.TryGetCallback(ref data, out callback, out callbackInfo))
			{
				callback(ref callbackInfo);
			}
		}
	}
}
