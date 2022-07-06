// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Presence
{
	/// <summary>
	/// Data for the <see cref="PresenceInterface.GetJoinInfo" /> function.
	/// </summary>
	public struct GetJoinInfoOptions
	{
		/// <summary>
		/// The local user's Epic Account ID
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The Epic Account ID to query for join info; this value must either be a logged-in local user, or a friend of that user
		/// </summary>
		public EpicAccountId TargetUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct GetJoinInfoOptionsInternal : ISettable<GetJoinInfoOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_TargetUserId;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public EpicAccountId TargetUserId
		{
			set
			{
				Helper.Set(value, ref m_TargetUserId);
			}
		}

		public void Set(ref GetJoinInfoOptions other)
		{
			m_ApiVersion = PresenceInterface.GetjoininfoApiLatest;
			LocalUserId = other.LocalUserId;
			TargetUserId = other.TargetUserId;
		}

		public void Set(ref GetJoinInfoOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = PresenceInterface.GetjoininfoApiLatest;
				LocalUserId = other.Value.LocalUserId;
				TargetUserId = other.Value.TargetUserId;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_TargetUserId);
		}
	}
}