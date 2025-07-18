// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{

	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="LobbyInterface.AddNotifyLobbyMemberStatusReceived" />
	/// </summary>
	/// <param name="data">
	/// A <see cref="LobbyMemberStatusReceivedCallbackInfo" /> CallbackInfo containing the output information and result
	/// </param>
	public delegate void OnLobbyMemberStatusReceivedCallback(ref LobbyMemberStatusReceivedCallbackInfo data);

	[UnmanagedFunctionPointer(Common.LIBRARY_CALLING_CONVENTION)]
	internal delegate void OnLobbyMemberStatusReceivedCallbackInternal(ref LobbyMemberStatusReceivedCallbackInfoInternal data);

	internal static class OnLobbyMemberStatusReceivedCallbackInternalImplementation
	{
		private static OnLobbyMemberStatusReceivedCallbackInternal s_Delegate;
		public static OnLobbyMemberStatusReceivedCallbackInternal Delegate
		{
			get
			{
				if (s_Delegate == null)
				{
					s_Delegate = new OnLobbyMemberStatusReceivedCallbackInternal(EntryPoint);
				}

				return s_Delegate;
			}
		}

		[MonoPInvokeCallback(typeof(OnLobbyMemberStatusReceivedCallbackInternal))]
		public static void EntryPoint(ref LobbyMemberStatusReceivedCallbackInfoInternal data)
		{
			OnLobbyMemberStatusReceivedCallback callback;
			LobbyMemberStatusReceivedCallbackInfo callbackInfo;
			if (Helper.TryGetCallback(ref data, out callback, out callbackInfo))
			{
				callback(ref callbackInfo);
			}
		}
	}
}
