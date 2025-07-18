// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Achievements
{

	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="AchievementsInterface.QueryPlayerAchievements" />
	/// <see cref="AchievementsInterface.Release" />
	/// </summary>
	/// <param name="data">
	/// An <see cref="OnQueryPlayerAchievementsCompleteCallbackInfo" /> containing the output information and result
	/// </param>
	public delegate void OnQueryPlayerAchievementsCompleteCallback(ref OnQueryPlayerAchievementsCompleteCallbackInfo data);

	[UnmanagedFunctionPointer(Common.LIBRARY_CALLING_CONVENTION)]
	internal delegate void OnQueryPlayerAchievementsCompleteCallbackInternal(ref OnQueryPlayerAchievementsCompleteCallbackInfoInternal data);

	internal static class OnQueryPlayerAchievementsCompleteCallbackInternalImplementation
	{
		private static OnQueryPlayerAchievementsCompleteCallbackInternal s_Delegate;
		public static OnQueryPlayerAchievementsCompleteCallbackInternal Delegate
		{
			get
			{
				if (s_Delegate == null)
				{
					s_Delegate = new OnQueryPlayerAchievementsCompleteCallbackInternal(EntryPoint);
				}

				return s_Delegate;
			}
		}

		[MonoPInvokeCallback(typeof(OnQueryPlayerAchievementsCompleteCallbackInternal))]
		public static void EntryPoint(ref OnQueryPlayerAchievementsCompleteCallbackInfoInternal data)
		{
			OnQueryPlayerAchievementsCompleteCallback callback;
			OnQueryPlayerAchievementsCompleteCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback(ref data, out callback, out callbackInfo))
			{
				callback(ref callbackInfo);
			}
		}
	}
}
