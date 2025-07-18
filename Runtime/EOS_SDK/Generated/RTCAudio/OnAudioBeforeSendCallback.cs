// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{

	public delegate void OnAudioBeforeSendCallback(ref AudioBeforeSendCallbackInfo data);

	[UnmanagedFunctionPointer(Common.LIBRARY_CALLING_CONVENTION)]
	internal delegate void OnAudioBeforeSendCallbackInternal(ref AudioBeforeSendCallbackInfoInternal data);

	internal static class OnAudioBeforeSendCallbackInternalImplementation
	{
		private static OnAudioBeforeSendCallbackInternal s_Delegate;
		public static OnAudioBeforeSendCallbackInternal Delegate
		{
			get
			{
				if (s_Delegate == null)
				{
					s_Delegate = new OnAudioBeforeSendCallbackInternal(EntryPoint);
				}

				return s_Delegate;
			}
		}

		[MonoPInvokeCallback(typeof(OnAudioBeforeSendCallbackInternal))]
		public static void EntryPoint(ref AudioBeforeSendCallbackInfoInternal data)
		{
			OnAudioBeforeSendCallback callback;
			AudioBeforeSendCallbackInfo callbackInfo;
			if (Helper.TryGetCallback(ref data, out callback, out callbackInfo))
			{
				callback(ref callbackInfo);
			}
		}
	}
}
