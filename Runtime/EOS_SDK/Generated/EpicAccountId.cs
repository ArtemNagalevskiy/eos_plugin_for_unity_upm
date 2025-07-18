// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;

namespace Epic.OnlineServices
{
	public sealed partial class EpicAccountId : Handle
	{
		public EpicAccountId()
		{
		}

		public EpicAccountId(IntPtr innerHandle) : base(innerHandle)
		{
		}
		/// <summary>
		/// Retrieve an <see cref="EpicAccountId" /> from a raw <see cref="Utf8String" /> representing an Epic Account ID. The input <see cref="Utf8String" /> must be <see langword="null" />-terminated.
		/// NOTE: There is no validation on the <see cref="Utf8String" /> format, this should only be used with values serialized from legitimate sources such as <see cref="ToString" />
		/// </summary>
		/// <param name="accountIdString">
		/// The stringified account ID for which to retrieve the Epic Account ID
		/// </param>
		/// <returns>
		/// The <see cref="EpicAccountId" /> that corresponds to the AccountIdString
		/// </returns>
		public static EpicAccountId FromString(Utf8String accountIdString)
		{
			var accountIdStringPointer = IntPtr.Zero;
			Helper.Set(accountIdString, ref accountIdStringPointer);

			var callResult = Bindings.EOS_EpicAccountId_FromString(accountIdStringPointer);

			Helper.Dispose(ref accountIdStringPointer);

			EpicAccountId callResultReturn;
			Helper.Get(callResult, out callResultReturn);
			return callResultReturn;
		}
		public static explicit operator EpicAccountId(Utf8String accountIdString)
		{
			return FromString(accountIdString);
		}

		/// <summary>
		/// Check whether or not the given Epic Account ID is considered valid
		/// NOTE: This will return <see langword="true" /> for any <see cref="EpicAccountId" /> created with <see cref="FromString" /> as there is no validation
		/// </summary>
		/// <param name="accountId">
		/// The Epic Account ID to check for validity
		/// </param>
		/// <returns>
		/// <see langword="true" /> if the <see cref="EpicAccountId" /> is valid, otherwise <see langword="false" />
		/// </returns>
		public bool IsValid()
		{
			var callResult = Bindings.EOS_EpicAccountId_IsValid(InnerHandle);

			bool callResultReturn;
			Helper.Get(callResult, out callResultReturn);
			return callResultReturn;
		}

		/// <summary>
		/// Retrieve a <see langword="null" />-terminated stringified Epic Account ID from an <see cref="EpicAccountId" />. This is useful for replication of Epic Account IDs in multiplayer games.
		/// This <see cref="Utf8String" /> will be no larger than <see cref="Common.EPICACCOUNTID_MAX_LENGTH" /> + 1 and will only contain UTF8-encoded printable characters as well as a <see langword="null" />-terminator.
		/// </summary>
		/// <param name="accountId">
		/// The Epic Account ID for which to retrieve the stringified version.
		/// </param>
		/// <param name="outBuffer">
		/// The buffer into which the character data should be written
		/// </param>
		/// <param name="inOutBufferLength">
		/// The size of the OutBuffer in characters.
		/// The input buffer should include enough space to be <see langword="null" />-terminated.
		/// When the function returns, this parameter will be filled with the length of the <see cref="Utf8String" /> copied into OutBuffer including the <see langword="null" />-termination character.
		/// </param>
		/// <returns>
		/// An <see cref="Result" /> that indicates whether the Epic Account ID <see cref="Utf8String" /> was copied into the OutBuffer.
		/// <see cref="Result.Success" /> - The OutBuffer was filled, and InOutBufferLength contains the number of characters copied into OutBuffer including the <see langword="null" />-terminator.
		/// <see cref="Result.InvalidParameters" /> - Either OutBuffer or InOutBufferLength were passed as <see langword="null" /> parameters.
		/// <see cref="Result.InvalidUser" /> - The AccountId is invalid and cannot be stringified.
		/// <see cref="Result.LimitExceeded" /> - The OutBuffer is not large enough to receive the Epic Account ID <see cref="Utf8String" />. InOutBufferLength contains the required minimum length to perform the operation successfully.
		/// </returns>
		public Result ToString(out Utf8String outBuffer)
		{
			int inOutBufferLength = Common.EPICACCOUNTID_MAX_LENGTH + 1;
			var outBufferPointer = Helper.AddAllocation(inOutBufferLength);

			var callResult = Bindings.EOS_EpicAccountId_ToString(InnerHandle, outBufferPointer, ref inOutBufferLength);

			Helper.Get(outBufferPointer, out outBuffer);
			Helper.Dispose(ref outBufferPointer);

			return callResult;
		}
		public override string ToString()
		{
			Utf8String callResult;
			ToString(out callResult);
			return callResult;
		}

		public override string ToString(string format, IFormatProvider formatProvider)
		{
			if (format != null)
			{
				return string.Format(format, ToString());
			}

			return ToString();
		}

		public static explicit operator Utf8String(EpicAccountId accountId)
		{
			Utf8String callResult = null;

			if (accountId != null)
			{
				accountId.ToString(out callResult);
			}

			return callResult;
		}
	}
}
