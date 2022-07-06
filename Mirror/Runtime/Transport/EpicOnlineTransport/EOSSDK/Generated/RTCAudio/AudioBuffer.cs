// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTCAudio
{
	/// <summary>
	/// This struct is used to represent an audio buffer received in callbacks from <see cref="RTCAudioInterface.AddNotifyAudioBeforeSend" /> and <see cref="RTCAudioInterface.AddNotifyAudioBeforeRender" />.
	/// </summary>
	public struct AudioBuffer
	{
		/// <summary>
		/// Pointer to the data with the interleaved audio frames in signed 16 bits format.
		/// </summary>
		public short[] Frames { get; set; }

		/// <summary>
		/// Sample rate for the samples in the Frames buffer.
		/// </summary>
		public uint SampleRate { get; set; }

		/// <summary>
		/// Number of channels for the samples in the Frames buffer.
		/// </summary>
		public uint Channels { get; set; }

		internal void Set(ref AudioBufferInternal other)
		{
			Frames = other.Frames;
			SampleRate = other.SampleRate;
			Channels = other.Channels;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AudioBufferInternal : IGettable<AudioBuffer>, ISettable<AudioBuffer>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_Frames;
		private uint m_FramesCount;
		private uint m_SampleRate;
		private uint m_Channels;

		public short[] Frames
		{
			get
			{
				short[] value;
				Helper.Get(m_Frames, out value, m_FramesCount);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_Frames, out m_FramesCount);
			}
		}

		public uint SampleRate
		{
			get
			{
				return m_SampleRate;
			}

			set
			{
				m_SampleRate = value;
			}
		}

		public uint Channels
		{
			get
			{
				return m_Channels;
			}

			set
			{
				m_Channels = value;
			}
		}

		public void Set(ref AudioBuffer other)
		{
			m_ApiVersion = RTCAudioInterface.AudiobufferApiLatest;
			Frames = other.Frames;
			SampleRate = other.SampleRate;
			Channels = other.Channels;
		}

		public void Set(ref AudioBuffer? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = RTCAudioInterface.AudiobufferApiLatest;
				Frames = other.Value.Frames;
				SampleRate = other.Value.SampleRate;
				Channels = other.Value.Channels;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_Frames);
		}

		public void Get(out AudioBuffer output)
		{
			output = new AudioBuffer();
			output.Set(ref this);
		}
	}
}