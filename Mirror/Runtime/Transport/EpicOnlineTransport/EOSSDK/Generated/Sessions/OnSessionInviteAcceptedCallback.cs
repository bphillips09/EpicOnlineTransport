// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Function prototype definition for notifications that come from <see cref="SessionsInterface.AddNotifySessionInviteAccepted" />
	/// The session for the invite must be joined.
	/// <seealso cref="SessionsInterface.CopySessionHandleByInviteId" />
	/// <seealso cref="SessionsInterface.JoinSession" />
	/// </summary>
	/// <param name="data">A <see cref="SessionInviteAcceptedCallbackInfo" /> containing the output information and result</param>
	public delegate void OnSessionInviteAcceptedCallback(ref SessionInviteAcceptedCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnSessionInviteAcceptedCallbackInternal(ref SessionInviteAcceptedCallbackInfoInternal data);
}