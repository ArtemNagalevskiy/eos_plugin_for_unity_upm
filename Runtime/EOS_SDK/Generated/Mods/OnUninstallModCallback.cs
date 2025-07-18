// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Mods
{

	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="ModsInterface.UninstallMod" />
	/// </summary>
	/// <param name="data">
	/// A <see cref="UninstallModCallbackInfo" /> containing the output information and result
	/// </param>
	public delegate void OnUninstallModCallback(ref UninstallModCallbackInfo data);

	[UnmanagedFunctionPointer(Common.LIBRARY_CALLING_CONVENTION)]
	internal delegate void OnUninstallModCallbackInternal(ref UninstallModCallbackInfoInternal data);

	internal static class OnUninstallModCallbackInternalImplementation
	{
		private static OnUninstallModCallbackInternal s_Delegate;
		public static OnUninstallModCallbackInternal Delegate
		{
			get
			{
				if (s_Delegate == null)
				{
					s_Delegate = new OnUninstallModCallbackInternal(EntryPoint);
				}

				return s_Delegate;
			}
		}

		[MonoPInvokeCallback(typeof(OnUninstallModCallbackInternal))]
		public static void EntryPoint(ref UninstallModCallbackInfoInternal data)
		{
			OnUninstallModCallback callback;
			UninstallModCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback(ref data, out callback, out callbackInfo))
			{
				callback(ref callbackInfo);
			}
		}
	}
}
