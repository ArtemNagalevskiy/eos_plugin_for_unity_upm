// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;

namespace Epic.OnlineServices.CustomInvites
{
	public sealed partial class CustomInvitesInterface : Handle
	{
		public CustomInvitesInterface()
		{
		}

		public CustomInvitesInterface(IntPtr innerHandle) : base(innerHandle)
		{
		}

		/// <summary>
		/// The most recent version of the <see cref="AcceptRequestToJoin" /> API.
		/// </summary>
		public const int ACCEPTREQUESTTOJOIN_API_LATEST = 1;
		/// <summary>
		/// The most recent version of the <see cref="AddNotifyCustomInviteAccepted" /> API.
		/// </summary>
		public const int ADDNOTIFYCUSTOMINVITEACCEPTED_API_LATEST = 1;
		/// <summary>
		/// The most recent version of the <see cref="AddNotifyCustomInviteReceived" /> API.
		/// </summary>
		public const int ADDNOTIFYCUSTOMINVITERECEIVED_API_LATEST = 1;
		/// <summary>
		/// The most recent version of the <see cref="AddNotifyCustomInviteRejected" /> API.
		/// </summary>
		public const int ADDNOTIFYCUSTOMINVITEREJECTED_API_LATEST = 1;
		/// <summary>
		/// The most recent version of the <see cref="AddNotifyCustomInviteAccepted" /> API.
		/// </summary>
		public const int ADDNOTIFYREQUESTTOJOINACCEPTED_API_LATEST = 1;
		/// <summary>
		/// The most recent version of the AddNotifyRequestToJoinReceived API.
		/// </summary>
		public const int ADDNOTIFYREQUESTTOJOINRECEIVED_API_LATEST = 1;
		/// <summary>
		/// The most recent version of the <see cref="AddNotifyRequestToJoinRejected" /> API.
		/// </summary>
		public const int ADDNOTIFYREQUESTTOJOINREJECTED_API_LATEST = 1;
		/// <summary>
		/// The most recent version of the <see cref="AddNotifyRequestToJoinResponseReceived" /> API.
		/// </summary>
		public const int ADDNOTIFYREQUESTTOJOINRESPONSERECEIVED_API_LATEST = 1;
		/// <summary>
		/// The most recent version of the <see cref="AddNotifySendCustomNativeInviteRequested" /> API.
		/// </summary>
		public const int ADDNOTIFYSENDCUSTOMNATIVEINVITEREQUESTED_API_LATEST = 1;
		/// <summary>
		/// The most recent version of the <see cref="FinalizeInvite" /> API.
		/// </summary>
		public const int FINALIZEINVITE_API_LATEST = 1;
		/// <summary>
		/// Maximum size of the custom invite payload <see cref="Utf8String" />
		/// </summary>
		public const int MAX_PAYLOAD_LENGTH = 500;
		/// <summary>
		/// The most recent version of the <see cref="RejectRequestToJoin" /> API.
		/// </summary>
		public const int REJECTREQUESTTOJOIN_API_LATEST = 1;
		/// <summary>
		/// The most recent version of the <see cref="SendCustomInvite" /> API.
		/// </summary>
		public const int SENDCUSTOMINVITE_API_LATEST = 1;
		/// <summary>
		/// The most recent version of the <see cref="SendRequestToJoinOptions" /> API.
		/// </summary>
		public const int SENDREQUESTTOJOIN_API_LATEST = 1;
		/// <summary>
		/// The most recent version of the <see cref="SetCustomInvite" /> API.
		/// </summary>
		public const int SETCUSTOMINVITE_API_LATEST = 1;

		/// <summary>
		/// Accept a request to join from another user
		/// </summary>
		/// <param name="options">
		/// Structure containing information about the request.
		/// </param>
		/// <param name="clientData">
		/// Arbitrary data that is passed back to you in the CompletionDelegate
		/// </param>
		/// <param name="completionDelegate">
		/// A callback that is fired when the operation completes, either successfully or in error
		/// </param>
		/// <returns>
		/// <see cref="Result.Success" /> if the query completes successfully
		/// <see cref="Result.InvalidParameters" /> if any of the options values are incorrect
		/// </returns>
		public void AcceptRequestToJoin(ref AcceptRequestToJoinOptions options, object clientData, OnAcceptRequestToJoinCallback completionDelegate)
		{
			if (completionDelegate == null)
			{
				throw new ArgumentNullException("completionDelegate");
			}

			var optionsInternal = default(AcceptRequestToJoinOptionsInternal);
			optionsInternal.Set(ref options);

			var clientDataPointer = IntPtr.Zero;

			Helper.AddCallback(out clientDataPointer, clientData, completionDelegate);

			Bindings.EOS_CustomInvites_AcceptRequestToJoin(InnerHandle, ref optionsInternal, clientDataPointer, OnAcceptRequestToJoinCallbackInternalImplementation.Delegate);

			Helper.Dispose(ref optionsInternal);
		}

		/// <summary>
		/// Register to receive notifications when a Custom Invite for any logged in local user is accepted via the Social Overlay
		/// Invites accepted in this way still need to have FinalizeInvite called on them after you have finished processing the invite accept (e.g. after joining the game)
		/// If the returned NotificationId is valid, you must call <see cref="RemoveNotifyCustomInviteAccepted" /> when you no longer wish to have your NotificationHandler called.
		/// </summary>
		/// <param name="options">
		/// Structure containing information about the request.
		/// </param>
		/// <param name="clientData">
		/// Arbitrary data that is passed back to you in the CompletionDelegate.
		/// </param>
		/// <param name="notificationFn">
		/// A callback that is fired when a Custom Invite is accepted via the Social Overlay.
		/// </param>
		/// <returns>
		/// handle representing the registered callback
		/// </returns>
		public ulong AddNotifyCustomInviteAccepted(ref AddNotifyCustomInviteAcceptedOptions options, object clientData, OnCustomInviteAcceptedCallback notificationFn)
		{
			if (notificationFn == null)
			{
				throw new ArgumentNullException("notificationFn");
			}

			var optionsInternal = default(AddNotifyCustomInviteAcceptedOptionsInternal);
			optionsInternal.Set(ref options);

			var clientDataPointer = IntPtr.Zero;

			Helper.AddCallback(out clientDataPointer, clientData, notificationFn);

			var callResult = Bindings.EOS_CustomInvites_AddNotifyCustomInviteAccepted(InnerHandle, ref optionsInternal, clientDataPointer, OnCustomInviteAcceptedCallbackInternalImplementation.Delegate);

			Helper.Dispose(ref optionsInternal);

			Helper.AssignNotificationIdToCallback(clientDataPointer, callResult);

			return callResult;
		}

		/// <summary>
		/// Register to receive notifications when a Custom Invite for any logged in local user is received
		/// If the returned NotificationId is valid, you must call <see cref="RemoveNotifyCustomInviteReceived" /> when you no longer wish to have your NotificationHandler called.
		/// </summary>
		/// <param name="options">
		/// Structure containing information about the request.
		/// </param>
		/// <param name="clientData">
		/// Arbitrary data that is passed back to you in the CompletionDelegate.
		/// </param>
		/// <param name="notificationFn">
		/// A callback that is fired when a Custom Invite is received.
		/// </param>
		/// <returns>
		/// handle representing the registered callback
		/// </returns>
		public ulong AddNotifyCustomInviteReceived(ref AddNotifyCustomInviteReceivedOptions options, object clientData, OnCustomInviteReceivedCallback notificationFn)
		{
			if (notificationFn == null)
			{
				throw new ArgumentNullException("notificationFn");
			}

			var optionsInternal = default(AddNotifyCustomInviteReceivedOptionsInternal);
			optionsInternal.Set(ref options);

			var clientDataPointer = IntPtr.Zero;

			Helper.AddCallback(out clientDataPointer, clientData, notificationFn);

			var callResult = Bindings.EOS_CustomInvites_AddNotifyCustomInviteReceived(InnerHandle, ref optionsInternal, clientDataPointer, OnCustomInviteReceivedCallbackInternalImplementation.Delegate);

			Helper.Dispose(ref optionsInternal);

			Helper.AssignNotificationIdToCallback(clientDataPointer, callResult);

			return callResult;
		}

		/// <summary>
		/// Register to receive notifications when a Custom Invite for any logged in local user is rejected via the Social Overlay
		/// Invites rejected in this way do not need to have FinalizeInvite called on them, it is called automatically internally by the SDK.
		/// If the returned NotificationId is valid, you must call <see cref="RemoveNotifyCustomInviteRejected" /> when you no longer wish to have your NotificationHandler called.
		/// </summary>
		/// <param name="options">
		/// Structure containing information about the request.
		/// </param>
		/// <param name="clientData">
		/// Arbitrary data that is passed back to you in the CompletionDelegate.
		/// </param>
		/// <param name="notificationFn">
		/// A callback that is fired when a Custom Invite is rejected via the Social Overlay.
		/// </param>
		/// <returns>
		/// handle representing the registered callback
		/// </returns>
		public ulong AddNotifyCustomInviteRejected(ref AddNotifyCustomInviteRejectedOptions options, object clientData, OnCustomInviteRejectedCallback notificationFn)
		{
			if (notificationFn == null)
			{
				throw new ArgumentNullException("notificationFn");
			}

			var optionsInternal = default(AddNotifyCustomInviteRejectedOptionsInternal);
			optionsInternal.Set(ref options);

			var clientDataPointer = IntPtr.Zero;

			Helper.AddCallback(out clientDataPointer, clientData, notificationFn);

			var callResult = Bindings.EOS_CustomInvites_AddNotifyCustomInviteRejected(InnerHandle, ref optionsInternal, clientDataPointer, OnCustomInviteRejectedCallbackInternalImplementation.Delegate);

			Helper.Dispose(ref optionsInternal);

			Helper.AssignNotificationIdToCallback(clientDataPointer, callResult);

			return callResult;
		}

		/// <summary>
		/// Register to receive notifications when a Request to Join for any logged in local user is accepted via the Social Overlay
		/// If the returned NotificationId is valid, you must call <see cref="RemoveNotifyRequestToJoinAccepted" /> when you no longer wish to have your NotificationHandler called.
		/// </summary>
		/// <param name="options">
		/// Structure containing information about the request.
		/// </param>
		/// <param name="clientData">
		/// Arbitrary data that is passed back to you in the CompletionDelegate.
		/// </param>
		/// <param name="notificationFn">
		/// A callback that is fired when a Request to Join is accepted via the Social Overlay.
		/// </param>
		/// <returns>
		/// handle representing the registered callback
		/// </returns>
		public ulong AddNotifyRequestToJoinAccepted(ref AddNotifyRequestToJoinAcceptedOptions options, object clientData, OnRequestToJoinAcceptedCallback notificationFn)
		{
			if (notificationFn == null)
			{
				throw new ArgumentNullException("notificationFn");
			}

			var optionsInternal = default(AddNotifyRequestToJoinAcceptedOptionsInternal);
			optionsInternal.Set(ref options);

			var clientDataPointer = IntPtr.Zero;

			Helper.AddCallback(out clientDataPointer, clientData, notificationFn);

			var callResult = Bindings.EOS_CustomInvites_AddNotifyRequestToJoinAccepted(InnerHandle, ref optionsInternal, clientDataPointer, OnRequestToJoinAcceptedCallbackInternalImplementation.Delegate);

			Helper.Dispose(ref optionsInternal);

			Helper.AssignNotificationIdToCallback(clientDataPointer, callResult);

			return callResult;
		}

		/// <summary>
		/// Register to receive notifications when a request to join is received for a local user
		/// If the returned NotificationId is valid, you must call <see cref="RemoveNotifyRequestToJoinReceived" /> when you no longer wish to have your NotificationHandler called.
		/// </summary>
		/// <param name="options">
		/// Structure containing information about the request.
		/// </param>
		/// <param name="clientData">
		/// Arbitrary data that is passed back to you in the CompletionDelegate.
		/// </param>
		/// <param name="notificationFn">
		/// A callback that is fired when a response is received for an invite request.
		/// </param>
		/// <returns>
		/// handle representing the registered callback
		/// </returns>
		public ulong AddNotifyRequestToJoinReceived(ref AddNotifyRequestToJoinReceivedOptions options, object clientData, OnRequestToJoinReceivedCallback notificationFn)
		{
			if (notificationFn == null)
			{
				throw new ArgumentNullException("notificationFn");
			}

			var optionsInternal = default(AddNotifyRequestToJoinReceivedOptionsInternal);
			optionsInternal.Set(ref options);

			var clientDataPointer = IntPtr.Zero;

			Helper.AddCallback(out clientDataPointer, clientData, notificationFn);

			var callResult = Bindings.EOS_CustomInvites_AddNotifyRequestToJoinReceived(InnerHandle, ref optionsInternal, clientDataPointer, OnRequestToJoinReceivedCallbackInternalImplementation.Delegate);

			Helper.Dispose(ref optionsInternal);

			Helper.AssignNotificationIdToCallback(clientDataPointer, callResult);

			return callResult;
		}

		/// <summary>
		/// Register to receive notifications when a Request to Join for any logged in local user is rejected via the Social Overlay
		/// If the returned NotificationId is valid, you must call <see cref="RemoveNotifyRequestToJoinRejected" /> when you no longer wish to have your NotificationHandler called.
		/// </summary>
		/// <param name="options">
		/// Structure containing information about the request.
		/// </param>
		/// <param name="clientData">
		/// Arbitrary data that is passed back to you in the CompletionDelegate.
		/// </param>
		/// <param name="notificationFn">
		/// A callback that is fired when a Request to Join is accepted via the Social Overlay.
		/// </param>
		/// <returns>
		/// handle representing the registered callback
		/// </returns>
		public ulong AddNotifyRequestToJoinRejected(ref AddNotifyRequestToJoinRejectedOptions options, object clientData, OnRequestToJoinRejectedCallback notificationFn)
		{
			if (notificationFn == null)
			{
				throw new ArgumentNullException("notificationFn");
			}

			var optionsInternal = default(AddNotifyRequestToJoinRejectedOptionsInternal);
			optionsInternal.Set(ref options);

			var clientDataPointer = IntPtr.Zero;

			Helper.AddCallback(out clientDataPointer, clientData, notificationFn);

			var callResult = Bindings.EOS_CustomInvites_AddNotifyRequestToJoinRejected(InnerHandle, ref optionsInternal, clientDataPointer, OnRequestToJoinRejectedCallbackInternalImplementation.Delegate);

			Helper.Dispose(ref optionsInternal);

			Helper.AssignNotificationIdToCallback(clientDataPointer, callResult);

			return callResult;
		}

		/// <summary>
		/// Register to receive notifications when a request to join is responded to by a target user. Note that there is no guarantee a response will be received for every request to join.
		/// A player is free to ignore a Request to Join until it expires at which point it will be deleted without sending a response.
		/// If the returned NotificationId is valid, you must call <see cref="RemoveNotifyRequestToJoinResponseReceived" /> when you no longer wish to have your NotificationHandler called.
		/// </summary>
		/// <param name="options">
		/// Structure containing information about the request.
		/// </param>
		/// <param name="clientData">
		/// Arbitrary data that is passed back to you in the CompletionDelegate.
		/// </param>
		/// <param name="notificationFn">
		/// A callback that is fired when a response is received for an invite request.
		/// </param>
		/// <returns>
		/// handle representing the registered callback
		/// </returns>
		public ulong AddNotifyRequestToJoinResponseReceived(ref AddNotifyRequestToJoinResponseReceivedOptions options, object clientData, OnRequestToJoinResponseReceivedCallback notificationFn)
		{
			if (notificationFn == null)
			{
				throw new ArgumentNullException("notificationFn");
			}

			var optionsInternal = default(AddNotifyRequestToJoinResponseReceivedOptionsInternal);
			optionsInternal.Set(ref options);

			var clientDataPointer = IntPtr.Zero;

			Helper.AddCallback(out clientDataPointer, clientData, notificationFn);

			var callResult = Bindings.EOS_CustomInvites_AddNotifyRequestToJoinResponseReceived(InnerHandle, ref optionsInternal, clientDataPointer, OnRequestToJoinResponseReceivedCallbackInternalImplementation.Delegate);

			Helper.Dispose(ref optionsInternal);

			Helper.AssignNotificationIdToCallback(clientDataPointer, callResult);

			return callResult;
		}

		/// <summary>
		/// Register to receive notifications about a custom invite "INVITE" performed by a local user via the overlay.
		/// This is only needed when a configured integrated platform has <see cref="IntegratedPlatform.IntegratedPlatformManagementFlags.DisableSDKManagedSessions" /> set. The EOS SDK will
		/// then use the state of <see cref="IntegratedPlatform.IntegratedPlatformManagementFlags.PreferEOSIdentity" /> and <see cref="IntegratedPlatform.IntegratedPlatformManagementFlags.PreferIntegratedIdentity" /> to determine when the NotificationFn is
		/// called.
		/// If the returned NotificationId is valid, you must call <see cref="RemoveNotifySendCustomNativeInviteRequested" /> when you no longer wish to have your NotificationHandler called.
		/// <see cref="IntegratedPlatform.IntegratedPlatformManagementFlags.DisableSDKManagedSessions" />
		/// <see cref="IntegratedPlatform.IntegratedPlatformManagementFlags.PreferEOSIdentity" />
		/// <see cref="IntegratedPlatform.IntegratedPlatformManagementFlags.PreferIntegratedIdentity" />
		/// </summary>
		/// <param name="options">
		/// Structure containing information about the request.
		/// </param>
		/// <param name="clientData">
		/// Arbitrary data that is passed back to you in the CompletionDelegate.
		/// </param>
		/// <param name="notificationFn">
		/// A callback that is fired when a notification is received.
		/// </param>
		/// <returns>
		/// handle representing the registered callback
		/// </returns>
		public ulong AddNotifySendCustomNativeInviteRequested(ref AddNotifySendCustomNativeInviteRequestedOptions options, object clientData, OnSendCustomNativeInviteRequestedCallback notificationFn)
		{
			if (notificationFn == null)
			{
				throw new ArgumentNullException("notificationFn");
			}

			var optionsInternal = default(AddNotifySendCustomNativeInviteRequestedOptionsInternal);
			optionsInternal.Set(ref options);

			var clientDataPointer = IntPtr.Zero;

			Helper.AddCallback(out clientDataPointer, clientData, notificationFn);

			var callResult = Bindings.EOS_CustomInvites_AddNotifySendCustomNativeInviteRequested(InnerHandle, ref optionsInternal, clientDataPointer, OnSendCustomNativeInviteRequestedCallbackInternalImplementation.Delegate);

			Helper.Dispose(ref optionsInternal);

			Helper.AssignNotificationIdToCallback(clientDataPointer, callResult);

			return callResult;
		}

		/// <summary>
		/// Signal that the title has completed processing a received Custom Invite, and that it should be cleaned up internally and in the Overlay
		/// </summary>
		/// <param name="options">
		/// Structure containing information about the request.
		/// </param>
		/// <returns>
		/// <see cref="Result.Success" /> if the operation completes successfully
		/// <see cref="Result.InvalidParameters" /> if any of the option values are incorrect
		/// </returns>
		public Result FinalizeInvite(ref FinalizeInviteOptions options)
		{
			var optionsInternal = default(FinalizeInviteOptionsInternal);
			optionsInternal.Set(ref options);

			var callResult = Bindings.EOS_CustomInvites_FinalizeInvite(InnerHandle, ref optionsInternal);

			Helper.Dispose(ref optionsInternal);

			return callResult;
		}

		/// <summary>
		/// Reject a request to join from another user
		/// </summary>
		/// <param name="options">
		/// Structure containing information about the request.
		/// </param>
		/// <param name="clientData">
		/// Arbitrary data that is passed back to you in the CompletionDelegate
		/// </param>
		/// <param name="completionDelegate">
		/// A callback that is fired when the operation completes, either successfully or in error
		/// </param>
		/// <returns>
		/// <see cref="Result.Success" /> if the query completes successfully
		/// <see cref="Result.InvalidParameters" /> if any of the options values are incorrect
		/// </returns>
		public void RejectRequestToJoin(ref RejectRequestToJoinOptions options, object clientData, OnRejectRequestToJoinCallback completionDelegate)
		{
			if (completionDelegate == null)
			{
				throw new ArgumentNullException("completionDelegate");
			}

			var optionsInternal = default(RejectRequestToJoinOptionsInternal);
			optionsInternal.Set(ref options);

			var clientDataPointer = IntPtr.Zero;

			Helper.AddCallback(out clientDataPointer, clientData, completionDelegate);

			Bindings.EOS_CustomInvites_RejectRequestToJoin(InnerHandle, ref optionsInternal, clientDataPointer, OnRejectRequestToJoinCallbackInternalImplementation.Delegate);

			Helper.Dispose(ref optionsInternal);
		}

		/// <summary>
		/// Unregister from receiving notifications when a Custom Invite for any logged in local user is accepted via the Social Overlay
		/// </summary>
		/// <param name="inId">
		/// Handle representing the registered callback
		/// </param>
		public void RemoveNotifyCustomInviteAccepted(ulong inId)
		{
			Bindings.EOS_CustomInvites_RemoveNotifyCustomInviteAccepted(InnerHandle, inId);

			Helper.RemoveCallbackByNotificationId(inId);
		}

		/// <summary>
		/// Unregister from receiving notifications when a Custom Invite for any logged in local user is received
		/// </summary>
		/// <param name="inId">
		/// Handle representing the registered callback
		/// </param>
		public void RemoveNotifyCustomInviteReceived(ulong inId)
		{
			Bindings.EOS_CustomInvites_RemoveNotifyCustomInviteReceived(InnerHandle, inId);

			Helper.RemoveCallbackByNotificationId(inId);
		}

		/// <summary>
		/// Unregister from receiving notifications when a Custom Invite for any logged in local user is rejected via the Social Overlay
		/// </summary>
		/// <param name="inId">
		/// Handle representing the registered callback
		/// </param>
		public void RemoveNotifyCustomInviteRejected(ulong inId)
		{
			Bindings.EOS_CustomInvites_RemoveNotifyCustomInviteRejected(InnerHandle, inId);

			Helper.RemoveCallbackByNotificationId(inId);
		}

		/// <summary>
		/// Unregister from receiving notifications when a Request to Join for any logged in local user is accepted via the Social Overlay
		/// </summary>
		/// <param name="inId">
		/// Handle representing the registered callback
		/// </param>
		public void RemoveNotifyRequestToJoinAccepted(ulong inId)
		{
			Bindings.EOS_CustomInvites_RemoveNotifyRequestToJoinAccepted(InnerHandle, inId);

			Helper.RemoveCallbackByNotificationId(inId);
		}

		/// <summary>
		/// Unregister from receiving notifications when a request to join for any logged in local user is received
		/// </summary>
		/// <param name="inId">
		/// Handle representing the registered callback
		/// </param>
		public void RemoveNotifyRequestToJoinReceived(ulong inId)
		{
			Bindings.EOS_CustomInvites_RemoveNotifyRequestToJoinReceived(InnerHandle, inId);

			Helper.RemoveCallbackByNotificationId(inId);
		}

		/// <summary>
		/// Unregister from receiving notifications when a Request to Join for any logged in local user is rejected via the Social Overlay
		/// </summary>
		/// <param name="inId">
		/// Handle representing the registered callback
		/// </param>
		public void RemoveNotifyRequestToJoinRejected(ulong inId)
		{
			Bindings.EOS_CustomInvites_RemoveNotifyRequestToJoinRejected(InnerHandle, inId);

			Helper.RemoveCallbackByNotificationId(inId);
		}

		/// <summary>
		/// Unregister from receiving notifications when a request to join for any logged in local user is received
		/// </summary>
		/// <param name="inId">
		/// Handle representing the registered callback
		/// </param>
		public void RemoveNotifyRequestToJoinResponseReceived(ulong inId)
		{
			Bindings.EOS_CustomInvites_RemoveNotifyRequestToJoinResponseReceived(InnerHandle, inId);

			Helper.RemoveCallbackByNotificationId(inId);
		}

		/// <summary>
		/// Unregister from receiving notifications when a user requests a send invite via the overlay.
		/// </summary>
		/// <param name="inId">
		/// Handle representing the registered callback
		/// </param>
		public void RemoveNotifySendCustomNativeInviteRequested(ulong inId)
		{
			Bindings.EOS_CustomInvites_RemoveNotifySendCustomNativeInviteRequested(InnerHandle, inId);

			Helper.RemoveCallbackByNotificationId(inId);
		}

		/// <summary>
		/// Sends a Custom Invite that has previously been initialized via SetCustomInvite to a group of users.
		/// </summary>
		/// <param name="options">
		/// Structure containing information about the request.
		/// </param>
		/// <param name="clientData">
		/// Arbitrary data that is passed back to you in the CompletionDelegate
		/// </param>
		/// <param name="completionDelegate">
		/// A callback that is fired when the operation completes, either successfully or in error
		/// </param>
		/// <returns>
		/// <see cref="Result.Success" /> if the query completes successfully
		/// <see cref="Result.InvalidParameters" /> if any of the options values are incorrect
		/// <see cref="Result.TooManyRequests" /> if the number of allowed queries is exceeded
		/// <see cref="Result.NotFound" /> if SetCustomInvite has not been previously successfully called for this user
		/// </returns>
		public void SendCustomInvite(ref SendCustomInviteOptions options, object clientData, OnSendCustomInviteCallback completionDelegate)
		{
			if (completionDelegate == null)
			{
				throw new ArgumentNullException("completionDelegate");
			}

			var optionsInternal = default(SendCustomInviteOptionsInternal);
			optionsInternal.Set(ref options);

			var clientDataPointer = IntPtr.Zero;

			Helper.AddCallback(out clientDataPointer, clientData, completionDelegate);

			Bindings.EOS_CustomInvites_SendCustomInvite(InnerHandle, ref optionsInternal, clientDataPointer, OnSendCustomInviteCallbackInternalImplementation.Delegate);

			Helper.Dispose(ref optionsInternal);
		}

		/// <summary>
		/// Request that another user send an invitation.
		/// </summary>
		/// <param name="options">
		/// Structure containing information about the request.
		/// </param>
		/// <param name="clientData">
		/// Arbitrary data that is passed back to you in the CompletionDelegate
		/// </param>
		/// <param name="completionDelegate">
		/// A callback that is fired when the operation completes, either successfully or in error
		/// </param>
		/// <returns>
		/// <see cref="Result.Success" /> if the query completes successfully
		/// <see cref="Result.InvalidParameters" /> if any of the options values are incorrect
		/// </returns>
		public void SendRequestToJoin(ref SendRequestToJoinOptions options, object clientData, OnSendRequestToJoinCallback completionDelegate)
		{
			if (completionDelegate == null)
			{
				throw new ArgumentNullException("completionDelegate");
			}

			var optionsInternal = default(SendRequestToJoinOptionsInternal);
			optionsInternal.Set(ref options);

			var clientDataPointer = IntPtr.Zero;

			Helper.AddCallback(out clientDataPointer, clientData, completionDelegate);

			Bindings.EOS_CustomInvites_SendRequestToJoin(InnerHandle, ref optionsInternal, clientDataPointer, OnSendRequestToJoinCallbackInternalImplementation.Delegate);

			Helper.Dispose(ref optionsInternal);
		}

		/// <summary>
		/// Initializes a Custom Invite with a specified payload in preparation for it to be sent to another user or users.
		/// </summary>
		/// <param name="options">
		/// Structure containing information about the request.
		/// </param>
		/// <returns>
		/// <see cref="Result.Success" /> if the operation completes successfully
		/// <see cref="Result.InvalidParameters" /> if any of the options values are incorrect
		/// </returns>
		public Result SetCustomInvite(ref SetCustomInviteOptions options)
		{
			var optionsInternal = default(SetCustomInviteOptionsInternal);
			optionsInternal.Set(ref options);

			var callResult = Bindings.EOS_CustomInvites_SetCustomInvite(InnerHandle, ref optionsInternal);

			Helper.Dispose(ref optionsInternal);

			return callResult;
		}
	}
}
