// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Platform
{

	/// <summary>
	/// Function prototype type definition for functions that allocate memory.
	/// 
	/// Functions passed to <see cref="PlatformInterface.Initialize" /> to serve as memory allocators should return a <see cref="IntPtr" /> to the allocated memory.
	/// 
	/// The returned <see cref="IntPtr" /> should have at least SizeInBytes available capacity and the memory address should be a multiple of Alignment.
	/// The SDK will always call the provided function with an Alignment that is a power of 2.
	/// Allocation failures should return a <see langword="null" /> <see cref="IntPtr" />.
	/// </summary>
	[UnmanagedFunctionPointer(Common.LIBRARY_CALLING_CONVENTION)]
	public delegate IntPtr AllocateMemoryFunc(UIntPtr sizeInBytes, UIntPtr alignment);
}
