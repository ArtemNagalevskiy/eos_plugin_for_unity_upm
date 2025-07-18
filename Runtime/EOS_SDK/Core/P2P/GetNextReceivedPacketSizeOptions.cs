// Copyright Epic Games, Inc. All Rights Reserved.

using System;

namespace Epic.OnlineServices.P2P
{
	/// <summary>
	/// Structure containing information about who would like to receive a packet.
	/// </summary>
	public struct GetNextReceivedPacketSizeOptions
	{
		internal byte[] m_RequestedChannel;
		/// <summary>
		/// The Product User ID of the local user who is receiving the packet
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// An optional channel to request the data for. If <see langword="null" />, we're retrieving the size of the next packet on any channel.
		/// </summary>
		public byte? RequestedChannel
		{
			get
			{
				if (m_RequestedChannel == null)
				{
					return null;
				}

				return m_RequestedChannel[0];
			}
			set
			{
				if (value != null)
				{
					if (m_RequestedChannel == null)
					{
						m_RequestedChannel = new byte[1];
					}
					m_RequestedChannel[0] = value.Value;
				}
				else
				{
					m_RequestedChannel = null;
				}
			}
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct GetNextReceivedPacketSizeOptionsInternal : ISettable<GetNextReceivedPacketSizeOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private IntPtr m_LocalUserId;
		private IntPtr m_RequestedChannel;

		public void Set(ref GetNextReceivedPacketSizeOptions other)
		{
			m_ApiVersion = P2PInterface.GETNEXTRECEIVEDPACKETSIZE_API_LATEST;
			m_LocalUserId = other.LocalUserId.InnerHandle;
			m_RequestedChannel = IntPtr.Zero;
			if (other.RequestedChannel.HasValue)
			{
				m_RequestedChannel = Helper.AddPinnedBuffer(other.m_RequestedChannel);
			}
		}

		public void Set(ref GetNextReceivedPacketSizeOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = P2PInterface.GETNEXTRECEIVEDPACKETSIZE_API_LATEST;
				m_LocalUserId = other.Value.LocalUserId.InnerHandle;
				m_RequestedChannel = IntPtr.Zero;
				if (other.Value.RequestedChannel.HasValue)
				{
					m_RequestedChannel = Helper.AddPinnedBuffer(other.Value.m_RequestedChannel);
				}
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_RequestedChannel);
		}
	}
}