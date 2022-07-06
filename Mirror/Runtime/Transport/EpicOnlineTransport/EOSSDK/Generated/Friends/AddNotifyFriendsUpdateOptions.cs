// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Friends
{
	/// <summary>
	/// Input parameters for the <see cref="FriendsInterface.AddNotifyFriendsUpdate" /> function.
	/// </summary>
	public struct AddNotifyFriendsUpdateOptions
	{
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AddNotifyFriendsUpdateOptionsInternal : ISettable<AddNotifyFriendsUpdateOptions>, System.IDisposable
	{
		private int m_ApiVersion;

		public void Set(ref AddNotifyFriendsUpdateOptions other)
		{
			m_ApiVersion = FriendsInterface.AddnotifyfriendsupdateApiLatest;
		}

		public void Set(ref AddNotifyFriendsUpdateOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = FriendsInterface.AddnotifyfriendsupdateApiLatest;
			}
		}

		public void Dispose()
		{
		}
	}
}