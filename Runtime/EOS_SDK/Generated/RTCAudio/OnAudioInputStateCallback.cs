// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{

	public delegate void OnAudioInputStateCallback(ref AudioInputStateCallbackInfo data);

	[UnmanagedFunctionPointer(Common.LIBRARY_CALLING_CONVENTION)]
	internal delegate void OnAudioInputStateCallbackInternal(ref AudioInputStateCallbackInfoInternal data);

	internal static class OnAudioInputStateCallbackInternalImplementation
	{
		private static OnAudioInputStateCallbackInternal s_Delegate;
		public static OnAudioInputStateCallbackInternal Delegate
		{
			get
			{
				if (s_Delegate == null)
				{
					s_Delegate = new OnAudioInputStateCallbackInternal(EntryPoint);
				}

				return s_Delegate;
			}
		}

		[MonoPInvokeCallback(typeof(OnAudioInputStateCallbackInternal))]
		public static void EntryPoint(ref AudioInputStateCallbackInfoInternal data)
		{
			OnAudioInputStateCallback callback;
			AudioInputStateCallbackInfo callbackInfo;
			if (Helper.TryGetCallback(ref data, out callback, out callbackInfo))
			{
				callback(ref callbackInfo);
			}
		}
	}
}
