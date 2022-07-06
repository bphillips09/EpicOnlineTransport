// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTC
{
	/// <summary>
	/// This struct is used to call <see cref="RTCInterface.AddNotifyDisconnected" />.
	/// </summary>
	public struct AddNotifyDisconnectedOptions
	{
		/// <summary>
		/// The Product User ID of the user trying to request this operation.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The room this event is registered on.
		/// </summary>
		public Utf8String RoomName { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AddNotifyDisconnectedOptionsInternal : ISettable<AddNotifyDisconnectedOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_RoomName;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public Utf8String RoomName
		{
			set
			{
				Helper.Set(value, ref m_RoomName);
			}
		}

		public void Set(ref AddNotifyDisconnectedOptions other)
		{
			m_ApiVersion = RTCInterface.AddnotifydisconnectedApiLatest;
			LocalUserId = other.LocalUserId;
			RoomName = other.RoomName;
		}

		public void Set(ref AddNotifyDisconnectedOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = RTCInterface.AddnotifydisconnectedApiLatest;
				LocalUserId = other.Value.LocalUserId;
				RoomName = other.Value.RoomName;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_RoomName);
		}
	}
}