// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	public struct AddNotifyLobbyUpdateReceivedOptions
	{
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AddNotifyLobbyUpdateReceivedOptionsInternal : ISettable<AddNotifyLobbyUpdateReceivedOptions>, System.IDisposable
	{
		private int m_ApiVersion;

		public void Set(ref AddNotifyLobbyUpdateReceivedOptions other)
		{
			m_ApiVersion = LobbyInterface.AddnotifylobbyupdatereceivedApiLatest;
		}

		public void Set(ref AddNotifyLobbyUpdateReceivedOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = LobbyInterface.AddnotifylobbyupdatereceivedApiLatest;
			}
		}

		public void Dispose()
		{
		}
	}
}