// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatClient
{
	public struct EndSessionOptions
	{
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct EndSessionOptionsInternal : ISettable<EndSessionOptions>, System.IDisposable
	{
		private int m_ApiVersion;

		public void Set(ref EndSessionOptions other)
		{
			m_ApiVersion = AntiCheatClientInterface.EndsessionApiLatest;
		}

		public void Set(ref EndSessionOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = AntiCheatClientInterface.EndsessionApiLatest;
			}
		}

		public void Dispose()
		{
		}
	}
}