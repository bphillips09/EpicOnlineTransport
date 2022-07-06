// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Stats
{
	/// <summary>
	/// Contains information about a single player stat.
	/// </summary>
	public struct Stat
	{
		/// <summary>
		/// Name of the stat.
		/// </summary>
		public Utf8String Name { get; set; }

		/// <summary>
		/// If not <see cref="StatsInterface.TimeUndefined" /> then this is the POSIX timestamp for start time.
		/// </summary>
		public System.DateTimeOffset? StartTime { get; set; }

		/// <summary>
		/// If not <see cref="StatsInterface.TimeUndefined" /> then this is the POSIX timestamp for end time.
		/// </summary>
		public System.DateTimeOffset? EndTime { get; set; }

		/// <summary>
		/// Current value for the stat.
		/// </summary>
		public int Value { get; set; }

		internal void Set(ref StatInternal other)
		{
			Name = other.Name;
			StartTime = other.StartTime;
			EndTime = other.EndTime;
			Value = other.Value;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct StatInternal : IGettable<Stat>, ISettable<Stat>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_Name;
		private long m_StartTime;
		private long m_EndTime;
		private int m_Value;

		public Utf8String Name
		{
			get
			{
				Utf8String value;
				Helper.Get(m_Name, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_Name);
			}
		}

		public System.DateTimeOffset? StartTime
		{
			get
			{
				System.DateTimeOffset? value;
				Helper.Get(m_StartTime, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_StartTime);
			}
		}

		public System.DateTimeOffset? EndTime
		{
			get
			{
				System.DateTimeOffset? value;
				Helper.Get(m_EndTime, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_EndTime);
			}
		}

		public int Value
		{
			get
			{
				return m_Value;
			}

			set
			{
				m_Value = value;
			}
		}

		public void Set(ref Stat other)
		{
			m_ApiVersion = StatsInterface.StatApiLatest;
			Name = other.Name;
			StartTime = other.StartTime;
			EndTime = other.EndTime;
			Value = other.Value;
		}

		public void Set(ref Stat? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = StatsInterface.StatApiLatest;
				Name = other.Value.Name;
				StartTime = other.Value.StartTime;
				EndTime = other.Value.EndTime;
				Value = other.Value.Value;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_Name);
		}

		public void Get(out Stat output)
		{
			output = new Stat();
			output.Set(ref this);
		}
	}
}