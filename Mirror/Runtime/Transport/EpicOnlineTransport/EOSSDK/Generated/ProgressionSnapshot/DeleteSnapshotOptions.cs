// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.ProgressionSnapshot
{
	public struct DeleteSnapshotOptions
	{
		/// <summary>
		/// The Product User ID of the local user to whom the key/value pair belong
		/// </summary>
		public ProductUserId LocalUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct DeleteSnapshotOptionsInternal : ISettable<DeleteSnapshotOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public void Set(ref DeleteSnapshotOptions other)
		{
			m_ApiVersion = ProgressionSnapshotInterface.DeletesnapshotApiLatest;
			LocalUserId = other.LocalUserId;
		}

		public void Set(ref DeleteSnapshotOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = ProgressionSnapshotInterface.DeletesnapshotApiLatest;
				LocalUserId = other.Value.LocalUserId;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
		}
	}
}