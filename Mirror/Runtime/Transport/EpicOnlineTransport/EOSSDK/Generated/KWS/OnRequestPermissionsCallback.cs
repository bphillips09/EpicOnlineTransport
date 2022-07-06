// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.KWS
{
	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="KWSInterface.RequestPermissions" />
	/// </summary>
	/// <param name="data">A <see cref="RequestPermissionsCallbackInfo" /> containing the output information and result</param>
	public delegate void OnRequestPermissionsCallback(ref RequestPermissionsCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnRequestPermissionsCallbackInternal(ref RequestPermissionsCallbackInfoInternal data);
}