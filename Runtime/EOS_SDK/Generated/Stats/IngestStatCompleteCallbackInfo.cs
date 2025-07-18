// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Stats
{
	/// <summary>
	/// Data containing the result information for an ingest stat request.
	/// 
	/// NOTE: A result code of <see cref="Result.Success" /> indicates the ingest request
	/// reached the server successfully, but does not guarantee successful processing.
	/// For example, if an incorrect StatName value is provided in the ingest call,
	/// processing may still fail.
	/// </summary>
	public struct IngestStatCompleteCallbackInfo : ICallbackInfo
	{
		/// <summary>
		/// Result code for the operation. <see cref="Result.Success" /> is returned for a successful request, other codes indicate an error.
		/// </summary>
		public Result ResultCode { get; set; }

		/// <summary>
		/// Context that was passed into <see cref="StatsInterface.IngestStat" />.
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// The Product User ID for the user requesting the ingest
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The Product User ID for the user whose stat is being ingested
		/// </summary>
		public ProductUserId TargetUserId { get; set; }

		public object GetClientData()
		{
			return ClientData;
		}

		public Result? GetResultCode()
		{
			return ResultCode;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct IngestStatCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<IngestStatCompleteCallbackInfo>
	{
		private Result m_ResultCode;
		private IntPtr m_ClientData;
		private IntPtr m_LocalUserId;
		private IntPtr m_TargetUserId;

		public IntPtr ClientDataPointer
		{
			get
			{
				return m_ClientData;
			}
		}

		public void Get(out IngestStatCompleteCallbackInfo other)
		{
			other = default;
			
			other.ResultCode = m_ResultCode;
			object ClientDataPublic;
			Helper.Get(m_ClientData, out ClientDataPublic);
			other.ClientData = ClientDataPublic;
			ProductUserId LocalUserIdPublic;
			Helper.Get(m_LocalUserId, out LocalUserIdPublic);
			other.LocalUserId = LocalUserIdPublic;
			ProductUserId TargetUserIdPublic;
			Helper.Get(m_TargetUserId, out TargetUserIdPublic);
			other.TargetUserId = TargetUserIdPublic;
		}
	}
}
