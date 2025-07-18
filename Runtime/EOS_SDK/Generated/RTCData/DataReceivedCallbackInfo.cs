// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;

namespace Epic.OnlineServices.RTCData
{
	/// <summary>
	/// This struct is passed in with a call to <see cref="RTCDataInterface.AddNotifyDataReceived" /> registered event.
	/// </summary>
	public struct DataReceivedCallbackInfo : ICallbackInfo
	{
		/// <summary>
		/// Client-specified data passed into <see cref="RTCDataInterface.AddNotifyDataReceived" />.
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// The Product User ID of the user who initiated this request.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The room associated with this event.
		/// </summary>
		public Utf8String RoomName { get; set; }

		/// <summary>
		/// The data received.
		/// </summary>
		public System.ArraySegment<byte> Data { get; set; }

		/// <summary>
		/// The Product User ID of the participant which sent the data.
		/// </summary>
		public ProductUserId ParticipantId { get; set; }

        public object GetClientData()
        {
            throw new System.NotImplementedException();
        }

        public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(ref DataReceivedCallbackInfoInternal other)
		{
			ClientData = other.ClientData;
			LocalUserId = other.LocalUserId;
			RoomName = other.RoomName;
			Data = other.Data;
			ParticipantId = other.ParticipantId;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct DataReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<DataReceivedCallbackInfo>, ISettable<DataReceivedCallbackInfo>, System.IDisposable
	{
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_RoomName;
		private uint m_DataLengthBytes;
		private System.IntPtr m_Data;
		private System.IntPtr m_ParticipantId;

		public object ClientData
		{
			get
			{
				object value;
				Helper.Get(m_ClientData, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_ClientData);
			}
		}

		public System.IntPtr ClientDataAddress
		{
			get
			{
				return m_ClientData;
			}
		}

		public ProductUserId LocalUserId
		{
			get
			{
				ProductUserId value;
				Helper.Get(m_LocalUserId, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public Utf8String RoomName
		{
			get
			{
				Utf8String value;
				Helper.Get(m_RoomName, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_RoomName);
			}
		}

		public System.ArraySegment<byte> Data
		{
			get
			{
				System.ArraySegment<byte> value;
				Helper.Get(m_Data, out value, m_DataLengthBytes);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_Data, out m_DataLengthBytes);
			}
		}

		public ProductUserId ParticipantId
		{
			get
			{
				ProductUserId value;
				Helper.Get(m_ParticipantId, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_ParticipantId);
			}
		}

        public IntPtr ClientDataPointer => throw new NotImplementedException();

        public void Set(ref DataReceivedCallbackInfo other)
		{
			ClientData = other.ClientData;
			LocalUserId = other.LocalUserId;
			RoomName = other.RoomName;
			Data = other.Data;
			ParticipantId = other.ParticipantId;
		}

		public void Set(ref DataReceivedCallbackInfo? other)
		{
			if (other.HasValue)
			{
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				RoomName = other.Value.RoomName;
				Data = other.Value.Data;
				ParticipantId = other.Value.ParticipantId;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_ClientData);
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_RoomName);
			Helper.Dispose(ref m_Data);
			Helper.Dispose(ref m_ParticipantId);
		}

		public void Get(out DataReceivedCallbackInfo output)
		{
			output = new DataReceivedCallbackInfo();
			output.Set(ref this);
		}
	}
}