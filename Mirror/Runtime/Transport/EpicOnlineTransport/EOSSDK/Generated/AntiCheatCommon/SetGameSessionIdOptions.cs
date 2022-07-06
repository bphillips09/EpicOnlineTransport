// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatCommon
{
	public struct SetGameSessionIdOptions
	{
		/// <summary>
		/// Game session identifier
		/// </summary>
		public Utf8String GameSessionId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SetGameSessionIdOptionsInternal : ISettable<SetGameSessionIdOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_GameSessionId;

		public Utf8String GameSessionId
		{
			set
			{
				Helper.Set(value, ref m_GameSessionId);
			}
		}

		public void Set(ref SetGameSessionIdOptions other)
		{
			m_ApiVersion = AntiCheatCommonInterface.SetgamesessionidApiLatest;
			GameSessionId = other.GameSessionId;
		}

		public void Set(ref SetGameSessionIdOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = AntiCheatCommonInterface.SetgamesessionidApiLatest;
				GameSessionId = other.Value.GameSessionId;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_GameSessionId);
		}
	}
}