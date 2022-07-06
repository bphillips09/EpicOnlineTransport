// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Auth
{
	/// <summary>
	/// Input parameters for the <see cref="AuthInterface.Logout" /> function.
	/// </summary>
	public struct LogoutOptions
	{
		/// <summary>
		/// The Epic Account ID of the local user who is being logged out
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LogoutOptionsInternal : ISettable<LogoutOptions>, System.IDisposable
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

		public void Set(ref LogoutOptions other)
		{
			m_ApiVersion = AuthInterface.LogoutApiLatest;
			LocalUserId = other.LocalUserId;
		}

		public void Set(ref LogoutOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = AuthInterface.LogoutApiLatest;
				LocalUserId = other.Value.LocalUserId;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
		}
	}
}