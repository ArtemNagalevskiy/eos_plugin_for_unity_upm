// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.RTC
{
	/// <summary>
	/// This struct is used to call <see cref="RTCInterface.JoinRoom" />.
	/// </summary>
	public struct JoinRoomOptions
	{
		/// <summary>
		/// The product user id of the user trying to request this operation.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The room the user would like to join.
		/// </summary>
		public Utf8String RoomName { get; set; }

		/// <summary>
		/// The room the user would like to join.
		/// </summary>
		public Utf8String ClientBaseUrl { get; set; }

		/// <summary>
		/// Authorization credential token to join the room.
		/// </summary>
		public Utf8String ParticipantToken { get; set; }

		/// <summary>
		/// The participant id used to join the room. If set to <see langword="null" /> the LocalUserId will be used instead.
		/// </summary>
		public ProductUserId ParticipantId { get; set; }

		/// <summary>
		/// Join room flags, e.g. <see cref="JoinRoomFlags.EnableEcho" />. This is a bitwise-or union of the defined flags.
		/// </summary>
		public JoinRoomFlags Flags { get; set; }

		/// <summary>
		/// Enable or disable Manual Audio Input. If manual audio input is enabled audio recording is not started and the audio
		/// buffers must be passed manually using <see cref="RTCAudio.RTCAudioInterface.SendAudio" />.
		/// </summary>
		public bool ManualAudioInputEnabled { get; set; }

		/// <summary>
		/// Enable or disable Manual Audio Output. If manual audio output is enabled audio rendering is not started and the audio
		/// buffers must be received with <see cref="RTCAudio.RTCAudioInterface.AddNotifyAudioBeforeRender" /> and rendered manually.
		/// </summary>
		public bool ManualAudioOutputEnabled { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct JoinRoomOptionsInternal : ISettable<JoinRoomOptions>
	{
		private int m_ApiVersion;
		private IntPtr m_LocalUserId;
		private IntPtr m_RoomName;
		private IntPtr m_ClientBaseUrl;
		private IntPtr m_ParticipantToken;
		private IntPtr m_ParticipantId;
		private JoinRoomFlags m_Flags;
		private int m_ManualAudioInputEnabled;
		private int m_ManualAudioOutputEnabled;

		public void Set(ref JoinRoomOptions other)
		{
			Dispose();

			m_ApiVersion = RTCInterface.JOINROOM_API_LATEST;
			Helper.Set(other.LocalUserId, ref m_LocalUserId);
			Helper.Set(other.RoomName, ref m_RoomName);
			Helper.Set(other.ClientBaseUrl, ref m_ClientBaseUrl);
			Helper.Set(other.ParticipantToken, ref m_ParticipantToken);
			Helper.Set(other.ParticipantId, ref m_ParticipantId);
			m_Flags = other.Flags;
			Helper.Set(other.ManualAudioInputEnabled, ref m_ManualAudioInputEnabled);
			Helper.Set(other.ManualAudioOutputEnabled, ref m_ManualAudioOutputEnabled);
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_RoomName);
			Helper.Dispose(ref m_ClientBaseUrl);
			Helper.Dispose(ref m_ParticipantToken);
			Helper.Dispose(ref m_ParticipantId);
		}
	}
}
