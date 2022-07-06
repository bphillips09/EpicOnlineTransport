// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.P2P
{
	/// <summary>
	/// Structure containing information about the packet queue to be cleared
	/// </summary>
	public struct ClearPacketQueueOptions
	{
		/// <summary>
		/// The Product User ID of the local user for whom we want to clear the queued packets
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The Product User ID to who (outgoing) or from who (incoming) packets are queued
		/// </summary>
		public ProductUserId RemoteUserId { get; set; }

		/// <summary>
		/// The socket used for packets to be cleared
		/// </summary>
		public SocketId? SocketId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct ClearPacketQueueOptionsInternal : ISettable<ClearPacketQueueOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_RemoteUserId;
		private System.IntPtr m_SocketId;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public ProductUserId RemoteUserId
		{
			set
			{
				Helper.Set(value, ref m_RemoteUserId);
			}
		}

		public SocketId? SocketId
		{
			set
			{
				Helper.Set<SocketId, SocketIdInternal>(ref value, ref m_SocketId);
			}
		}

		public void Set(ref ClearPacketQueueOptions other)
		{
			m_ApiVersion = P2PInterface.ClearpacketqueueApiLatest;
			LocalUserId = other.LocalUserId;
			RemoteUserId = other.RemoteUserId;
			SocketId = other.SocketId;
		}

		public void Set(ref ClearPacketQueueOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = P2PInterface.ClearpacketqueueApiLatest;
				LocalUserId = other.Value.LocalUserId;
				RemoteUserId = other.Value.RemoteUserId;
				SocketId = other.Value.SocketId;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_RemoteUserId);
			Helper.Dispose(ref m_SocketId);
		}
	}
}