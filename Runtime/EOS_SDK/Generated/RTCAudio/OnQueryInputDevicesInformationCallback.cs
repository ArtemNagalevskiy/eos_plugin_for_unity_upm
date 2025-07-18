// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTCAudio
{

	/// <summary>
	/// Callback for completion of query input devices information request.
	/// </summary>
	public delegate void OnQueryInputDevicesInformationCallback(ref OnQueryInputDevicesInformationCallbackInfo data);

	[UnmanagedFunctionPointer(Common.LIBRARY_CALLING_CONVENTION)]
	internal delegate void OnQueryInputDevicesInformationCallbackInternal(ref OnQueryInputDevicesInformationCallbackInfoInternal data);

	internal static class OnQueryInputDevicesInformationCallbackInternalImplementation
	{
		private static OnQueryInputDevicesInformationCallbackInternal s_Delegate;
		public static OnQueryInputDevicesInformationCallbackInternal Delegate
		{
			get
			{
				if (s_Delegate == null)
				{
					s_Delegate = new OnQueryInputDevicesInformationCallbackInternal(EntryPoint);
				}

				return s_Delegate;
			}
		}

		[MonoPInvokeCallback(typeof(OnQueryInputDevicesInformationCallbackInternal))]
		public static void EntryPoint(ref OnQueryInputDevicesInformationCallbackInfoInternal data)
		{
			OnQueryInputDevicesInformationCallback callback;
			OnQueryInputDevicesInformationCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback(ref data, out callback, out callbackInfo))
			{
				callback(ref callbackInfo);
			}
		}
	}
}
