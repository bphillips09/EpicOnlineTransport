// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Auth
{
	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="AuthInterface.VerifyUserAuth" />
	/// </summary>
	/// <param name="data">A <see cref="VerifyUserAuthCallbackInfo" /> containing the output information and result</param>
	public delegate void OnVerifyUserAuthCallback(ref VerifyUserAuthCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnVerifyUserAuthCallbackInternal(ref VerifyUserAuthCallbackInfoInternal data);
}