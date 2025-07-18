// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.PlayerDataStorage
{

	/// <summary>
	/// Callback for when we have data ready to be read from the requested file. It is undefined how often this will be called during a single tick.
	/// </summary>
	/// <param name="data">
	/// Struct containing a chunk of data to read, as well as some metadata for the file being read
	/// </param>
	/// <returns>
	/// The result of the read operation. If this value is not <see cref="ReadResult.ContinueReading" />, this callback will not be called again for the same request
	/// </returns>
	public delegate ReadResult OnReadFileDataCallback(ref ReadFileDataCallbackInfo data);

	[UnmanagedFunctionPointer(Common.LIBRARY_CALLING_CONVENTION)]
	internal delegate ReadResult OnReadFileDataCallbackInternal(ref ReadFileDataCallbackInfoInternal data);

	internal static class OnReadFileDataCallbackInternalImplementation
	{
		private static OnReadFileDataCallbackInternal s_Delegate;
		public static OnReadFileDataCallbackInternal Delegate
		{
			get
			{
				if (s_Delegate == null)
				{
					s_Delegate = new OnReadFileDataCallbackInternal(EntryPoint);
				}

				return s_Delegate;
			}
		}

		[MonoPInvokeCallback(typeof(OnReadFileDataCallbackInternal))]
		public static ReadResult EntryPoint(ref ReadFileDataCallbackInfoInternal data)
		{
			OnReadFileDataCallback callback;
			ReadFileDataCallbackInfo callbackInfo;
			if (Helper.TryGetStructCallback(ref data, out callback, out callbackInfo))
			{
				var callResult = callback(ref callbackInfo);

				return callResult;
			}

			return default;
		}
	}
}
