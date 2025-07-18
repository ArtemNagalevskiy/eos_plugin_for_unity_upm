// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Ecom
{

	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="EcomInterface.QueryOwnershipToken" />
	/// </summary>
	/// <param name="data">
	/// A <see cref="QueryOwnershipTokenCallbackInfo" /> containing the output information and result
	/// </param>
	public delegate void OnQueryOwnershipTokenCallback(ref QueryOwnershipTokenCallbackInfo data);

	[UnmanagedFunctionPointer(Common.LIBRARY_CALLING_CONVENTION)]
	internal delegate void OnQueryOwnershipTokenCallbackInternal(ref QueryOwnershipTokenCallbackInfoInternal data);

	internal static class OnQueryOwnershipTokenCallbackInternalImplementation
	{
		private static OnQueryOwnershipTokenCallbackInternal s_Delegate;
		public static OnQueryOwnershipTokenCallbackInternal Delegate
		{
			get
			{
				if (s_Delegate == null)
				{
					s_Delegate = new OnQueryOwnershipTokenCallbackInternal(EntryPoint);
				}

				return s_Delegate;
			}
		}

		[MonoPInvokeCallback(typeof(OnQueryOwnershipTokenCallbackInternal))]
		public static void EntryPoint(ref QueryOwnershipTokenCallbackInfoInternal data)
		{
			OnQueryOwnershipTokenCallback callback;
			QueryOwnershipTokenCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback(ref data, out callback, out callbackInfo))
			{
				callback(ref callbackInfo);
			}
		}
	}
}
