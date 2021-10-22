// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatServer
{
	public class BeginSessionOptions
	{
		/// <summary>
		/// Time in seconds to allow newly registered clients to complete anti-cheat authentication.
		/// Recommended value: 60
		/// </summary>
		public uint RegisterTimeoutSeconds { get; set; }

		/// <summary>
		/// Optional name of this game server
		/// </summary>
		public string ServerName { get; set; }

		/// <summary>
		/// Gameplay data collection APIs such as LogPlayerTick will be enabled if set to true.
		/// If you do not use these APIs, it is more efficient to set this value to false.
		/// </summary>
		public bool EnableGameplayData { get; set; }

		/// <summary>
		/// The Product User ID of the local user who is associated with this session. Dedicated servers should set this to null.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct BeginSessionOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private uint m_RegisterTimeoutSeconds;
		private System.IntPtr m_ServerName;
		private int m_EnableGameplayData;
		private System.IntPtr m_LocalUserId;

		public uint RegisterTimeoutSeconds
		{
			set
			{
				m_RegisterTimeoutSeconds = value;
			}
		}

		public string ServerName
		{
			set
			{
				Helper.TryMarshalSet(ref m_ServerName, value);
			}
		}

		public bool EnableGameplayData
		{
			set
			{
				Helper.TryMarshalSet(ref m_EnableGameplayData, value);
			}
		}

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public void Set(BeginSessionOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = AntiCheatServerInterface.BeginsessionApiLatest;
				RegisterTimeoutSeconds = other.RegisterTimeoutSeconds;
				ServerName = other.ServerName;
				EnableGameplayData = other.EnableGameplayData;
				LocalUserId = other.LocalUserId;
			}
		}

		public void Set(object other)
		{
			Set(other as BeginSessionOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_ServerName);
			Helper.TryMarshalDispose(ref m_LocalUserId);
		}
	}
}