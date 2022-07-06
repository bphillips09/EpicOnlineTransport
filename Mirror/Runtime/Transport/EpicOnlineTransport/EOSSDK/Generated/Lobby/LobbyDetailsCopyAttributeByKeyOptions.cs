// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Input parameters for the <see cref="LobbyDetails.CopyAttributeByKey" /> function.
	/// </summary>
	public struct LobbyDetailsCopyAttributeByKeyOptions
	{
		/// <summary>
		/// Name of the attribute
		/// </summary>
		public Utf8String AttrKey { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LobbyDetailsCopyAttributeByKeyOptionsInternal : ISettable<LobbyDetailsCopyAttributeByKeyOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_AttrKey;

		public Utf8String AttrKey
		{
			set
			{
				Helper.Set(value, ref m_AttrKey);
			}
		}

		public void Set(ref LobbyDetailsCopyAttributeByKeyOptions other)
		{
			m_ApiVersion = LobbyDetails.LobbydetailsCopyattributebykeyApiLatest;
			AttrKey = other.AttrKey;
		}

		public void Set(ref LobbyDetailsCopyAttributeByKeyOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = LobbyDetails.LobbydetailsCopyattributebykeyApiLatest;
				AttrKey = other.Value.AttrKey;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_AttrKey);
		}
	}
}