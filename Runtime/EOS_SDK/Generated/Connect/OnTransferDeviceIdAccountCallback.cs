// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Connect
{

	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="ConnectInterface.TransferDeviceIdAccount" />.
	/// </summary>
	/// <param name="data">
	/// A <see cref="TransferDeviceIdAccountCallbackInfo" /> containing the output information and result.
	/// </param>
	public delegate void OnTransferDeviceIdAccountCallback(ref TransferDeviceIdAccountCallbackInfo data);

	[UnmanagedFunctionPointer(Common.LIBRARY_CALLING_CONVENTION)]
	internal delegate void OnTransferDeviceIdAccountCallbackInternal(ref TransferDeviceIdAccountCallbackInfoInternal data);

	internal static class OnTransferDeviceIdAccountCallbackInternalImplementation
	{
		private static OnTransferDeviceIdAccountCallbackInternal s_Delegate;
		public static OnTransferDeviceIdAccountCallbackInternal Delegate
		{
			get
			{
				if (s_Delegate == null)
				{
					s_Delegate = new OnTransferDeviceIdAccountCallbackInternal(EntryPoint);
				}

				return s_Delegate;
			}
		}

		[MonoPInvokeCallback(typeof(OnTransferDeviceIdAccountCallbackInternal))]
		public static void EntryPoint(ref TransferDeviceIdAccountCallbackInfoInternal data)
		{
			OnTransferDeviceIdAccountCallback callback;
			TransferDeviceIdAccountCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback(ref data, out callback, out callbackInfo))
			{
				callback(ref callbackInfo);
			}
		}
	}
}
