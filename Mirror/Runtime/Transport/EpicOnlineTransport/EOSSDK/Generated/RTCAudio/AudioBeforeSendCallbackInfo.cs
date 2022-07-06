// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTCAudio
{
	/// <summary>
	/// This struct is passed in with a call to <see cref="RTCAudioInterface.AddNotifyAudioBeforeSend" /> registered event.
	/// </summary>
	public struct AudioBeforeSendCallbackInfo : ICallbackInfo
	{
		/// <summary>
		/// Client-specified data passed into <see cref="RTCAudioInterface.AddNotifyAudioBeforeSend" />.
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// The Product User ID of the user who initiated this request.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The room associated with this event.
		/// </summary>
		public Utf8String RoomName { get; set; }

		/// <summary>
		/// Audio buffer.
		/// </summary>
		public AudioBuffer? Buffer { get; set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(ref AudioBeforeSendCallbackInfoInternal other)
		{
			ClientData = other.ClientData;
			LocalUserId = other.LocalUserId;
			RoomName = other.RoomName;
			Buffer = other.Buffer;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AudioBeforeSendCallbackInfoInternal : ICallbackInfoInternal, IGettable<AudioBeforeSendCallbackInfo>, ISettable<AudioBeforeSendCallbackInfo>, System.IDisposable
	{
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_RoomName;
		private System.IntPtr m_Buffer;

		public object ClientData
		{
			get
			{
				object value;
				Helper.Get(m_ClientData, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_ClientData);
			}
		}

		public System.IntPtr ClientDataAddress
		{
			get
			{
				return m_ClientData;
			}
		}

		public ProductUserId LocalUserId
		{
			get
			{
				ProductUserId value;
				Helper.Get(m_LocalUserId, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public Utf8String RoomName
		{
			get
			{
				Utf8String value;
				Helper.Get(m_RoomName, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_RoomName);
			}
		}

		public AudioBuffer? Buffer
		{
			get
			{
				AudioBuffer? value;
				Helper.Get<AudioBufferInternal, AudioBuffer>(m_Buffer, out value);
				return value;
			}

			set
			{
				Helper.Set<AudioBuffer, AudioBufferInternal>(ref value, ref m_Buffer);
			}
		}

		public void Set(ref AudioBeforeSendCallbackInfo other)
		{
			ClientData = other.ClientData;
			LocalUserId = other.LocalUserId;
			RoomName = other.RoomName;
			Buffer = other.Buffer;
		}

		public void Set(ref AudioBeforeSendCallbackInfo? other)
		{
			if (other.HasValue)
			{
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				RoomName = other.Value.RoomName;
				Buffer = other.Value.Buffer;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_ClientData);
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_RoomName);
			Helper.Dispose(ref m_Buffer);
		}

		public void Get(out AudioBeforeSendCallbackInfo output)
		{
			output = new AudioBeforeSendCallbackInfo();
			output.Set(ref this);
		}
	}
}