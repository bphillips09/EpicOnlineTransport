// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionsInterface.GetInviteIdByIndex" /> function.
	/// </summary>
	public struct GetInviteIdByIndexOptions
	{
		/// <summary>
		/// The Product User ID of the local user who has an invitation in the cache
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// Index of the invite ID to retrieve
		/// </summary>
		public uint Index { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct GetInviteIdByIndexOptionsInternal : ISettable<GetInviteIdByIndexOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private uint m_Index;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public uint Index
		{
			set
			{
				m_Index = value;
			}
		}

		public void Set(ref GetInviteIdByIndexOptions other)
		{
			m_ApiVersion = SessionsInterface.GetinviteidbyindexApiLatest;
			LocalUserId = other.LocalUserId;
			Index = other.Index;
		}

		public void Set(ref GetInviteIdByIndexOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = SessionsInterface.GetinviteidbyindexApiLatest;
				LocalUserId = other.Value.LocalUserId;
				Index = other.Value.Index;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
		}
	}
}