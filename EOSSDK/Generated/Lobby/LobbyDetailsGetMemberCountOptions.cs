// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Input parameters for the <see cref="LobbyDetails.GetMemberCount" /> function.
	/// </summary>
	public class LobbyDetailsGetMemberCountOptions
	{
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LobbyDetailsGetMemberCountOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;

		public void Set(LobbyDetailsGetMemberCountOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = LobbyDetails.LobbydetailsGetmembercountApiLatest;
			}
		}

		public void Set(object other)
		{
			Set(other as LobbyDetailsGetMemberCountOptions);
		}

		public void Dispose()
		{
		}
	}
}