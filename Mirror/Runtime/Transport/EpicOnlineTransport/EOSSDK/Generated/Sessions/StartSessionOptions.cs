// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionsInterface.StartSession" /> function.
	/// </summary>
	public struct StartSessionOptions
	{
		/// <summary>
		/// Name of the session to set in progress
		/// </summary>
		public Utf8String SessionName { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct StartSessionOptionsInternal : ISettable<StartSessionOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_SessionName;

		public Utf8String SessionName
		{
			set
			{
				Helper.Set(value, ref m_SessionName);
			}
		}

		public void Set(ref StartSessionOptions other)
		{
			m_ApiVersion = SessionsInterface.StartsessionApiLatest;
			SessionName = other.SessionName;
		}

		public void Set(ref StartSessionOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = SessionsInterface.StartsessionApiLatest;
				SessionName = other.Value.SessionName;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_SessionName);
		}
	}
}