// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{

	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="LobbyInterface.HardMuteMember" />
	/// </summary>
	/// <param name="data">
	/// A <see cref="LobbyInterface.HardMuteMember" /> CallbackInfo containing the output information and result
	/// </param>
	public delegate void OnHardMuteMemberCallback(ref HardMuteMemberCallbackInfo data);

	[UnmanagedFunctionPointer(Common.LIBRARY_CALLING_CONVENTION)]
	internal delegate void OnHardMuteMemberCallbackInternal(ref HardMuteMemberCallbackInfoInternal data);

	internal static class OnHardMuteMemberCallbackInternalImplementation
	{
		private static OnHardMuteMemberCallbackInternal s_Delegate;
		public static OnHardMuteMemberCallbackInternal Delegate
		{
			get
			{
				if (s_Delegate == null)
				{
					s_Delegate = new OnHardMuteMemberCallbackInternal(EntryPoint);
				}

				return s_Delegate;
			}
		}

		[MonoPInvokeCallback(typeof(OnHardMuteMemberCallbackInternal))]
		public static void EntryPoint(ref HardMuteMemberCallbackInfoInternal data)
		{
			OnHardMuteMemberCallback callback;
			HardMuteMemberCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback(ref data, out callback, out callbackInfo))
			{
				callback(ref callbackInfo);
			}
		}
	}
}
