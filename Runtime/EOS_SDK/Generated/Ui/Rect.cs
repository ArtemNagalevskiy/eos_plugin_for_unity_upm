// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.UI
{
	/// <summary>
	/// A rectangle.
	/// </summary>
	public struct Rect
	{
		/// <summary>
		/// Left coordinate.
		/// </summary>
		public int X { get; set; }

		/// <summary>
		/// Top coordinate.
		/// </summary>
		public int Y { get; set; }

		/// <summary>
		/// Width.
		/// </summary>
		public uint Width { get; set; }

		/// <summary>
		/// Height.
		/// </summary>
		public uint Height { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct RectInternal : ISettable<Rect>
	{
		private int m_ApiVersion;
		private int m_X;
		private int m_Y;
		private uint m_Width;
		private uint m_Height;

		public void Set(ref Rect other)
		{
			Dispose();

			m_ApiVersion = UIInterface.RECT_API_LATEST;
			m_X = other.X;
			m_Y = other.Y;
			m_Width = other.Width;
			m_Height = other.Height;
		}

		public void Dispose()
		{
		}
	}
}
