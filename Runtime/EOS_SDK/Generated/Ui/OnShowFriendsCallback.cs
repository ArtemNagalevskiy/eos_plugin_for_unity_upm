// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.UI
{

	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="UIInterface.ShowFriends" />
	/// </summary>
	/// <param name="data">
	/// A <see cref="ShowFriendsCallbackInfo" /> containing the output information and result
	/// </param>
	public delegate void OnShowFriendsCallback(ref ShowFriendsCallbackInfo data);

	[UnmanagedFunctionPointer(Common.LIBRARY_CALLING_CONVENTION)]
	internal delegate void OnShowFriendsCallbackInternal(ref ShowFriendsCallbackInfoInternal data);

	internal static class OnShowFriendsCallbackInternalImplementation
	{
		private static OnShowFriendsCallbackInternal s_Delegate;
		public static OnShowFriendsCallbackInternal Delegate
		{
			get
			{
				if (s_Delegate == null)
				{
					s_Delegate = new OnShowFriendsCallbackInternal(EntryPoint);
				}

				return s_Delegate;
			}
		}

		[MonoPInvokeCallback(typeof(OnShowFriendsCallbackInternal))]
		public static void EntryPoint(ref ShowFriendsCallbackInfoInternal data)
		{
			OnShowFriendsCallback callback;
			ShowFriendsCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback(ref data, out callback, out callbackInfo))
			{
				callback(ref callbackInfo);
			}
		}
	}
}
