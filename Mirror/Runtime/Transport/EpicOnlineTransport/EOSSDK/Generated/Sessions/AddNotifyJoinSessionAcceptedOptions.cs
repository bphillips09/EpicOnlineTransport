// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionsInterface.AddNotifyJoinSessionAccepted" /> function.
	/// </summary>
	public struct AddNotifyJoinSessionAcceptedOptions
	{
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AddNotifyJoinSessionAcceptedOptionsInternal : ISettable<AddNotifyJoinSessionAcceptedOptions>, System.IDisposable
	{
		private int m_ApiVersion;

		public void Set(ref AddNotifyJoinSessionAcceptedOptions other)
		{
			m_ApiVersion = SessionsInterface.AddnotifyjoinsessionacceptedApiLatest;
		}

		public void Set(ref AddNotifyJoinSessionAcceptedOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = SessionsInterface.AddnotifyjoinsessionacceptedApiLatest;
			}
		}

		public void Dispose()
		{
		}
	}
}