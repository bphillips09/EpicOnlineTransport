// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Friends
{
	/// <summary>
	/// Input parameters for the <see cref="FriendsInterface.QueryFriends" /> function.
	/// </summary>
	public struct QueryFriendsOptions
	{
		/// <summary>
		/// The Epic Account ID of the local, logged-in user whose friends list you want to retrieve
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryFriendsOptionsInternal : ISettable<QueryFriendsOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public void Set(ref QueryFriendsOptions other)
		{
			m_ApiVersion = FriendsInterface.QueryfriendsApiLatest;
			LocalUserId = other.LocalUserId;
		}

		public void Set(ref QueryFriendsOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = FriendsInterface.QueryfriendsApiLatest;
				LocalUserId = other.Value.LocalUserId;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
		}
	}
}