// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{

	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="SessionsInterface.RegisterPlayers" />
	/// </summary>
	/// <param name="data">
	/// A <see cref="RegisterPlayersCallbackInfo" /> containing the output information and result
	/// </param>
	public delegate void OnRegisterPlayersCallback(ref RegisterPlayersCallbackInfo data);

	[UnmanagedFunctionPointer(Common.LIBRARY_CALLING_CONVENTION)]
	internal delegate void OnRegisterPlayersCallbackInternal(ref RegisterPlayersCallbackInfoInternal data);

	internal static class OnRegisterPlayersCallbackInternalImplementation
	{
		private static OnRegisterPlayersCallbackInternal s_Delegate;
		public static OnRegisterPlayersCallbackInternal Delegate
		{
			get
			{
				if (s_Delegate == null)
				{
					s_Delegate = new OnRegisterPlayersCallbackInternal(EntryPoint);
				}

				return s_Delegate;
			}
		}

		[MonoPInvokeCallback(typeof(OnRegisterPlayersCallbackInternal))]
		public static void EntryPoint(ref RegisterPlayersCallbackInfoInternal data)
		{
			OnRegisterPlayersCallback callback;
			RegisterPlayersCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback(ref data, out callback, out callbackInfo))
			{
				callback(ref callbackInfo);
			}
		}
	}
}
