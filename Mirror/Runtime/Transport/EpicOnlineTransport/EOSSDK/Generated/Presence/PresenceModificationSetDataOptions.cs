// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Presence
{
	/// <summary>
	/// Data for the <see cref="PresenceModification.SetData" /> function.
	/// </summary>
	public struct PresenceModificationSetDataOptions
	{
		/// <summary>
		/// The pointer to start of a sequential array of Presence DataRecords
		/// </summary>
		public DataRecord[] Records { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct PresenceModificationSetDataOptionsInternal : ISettable<PresenceModificationSetDataOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private int m_RecordsCount;
		private System.IntPtr m_Records;

		public DataRecord[] Records
		{
			set
			{
				Helper.Set<DataRecord, DataRecordInternal>(ref value, ref m_Records, out m_RecordsCount);
			}
		}

		public void Set(ref PresenceModificationSetDataOptions other)
		{
			m_ApiVersion = PresenceModification.PresencemodificationSetdataApiLatest;
			Records = other.Records;
		}

		public void Set(ref PresenceModificationSetDataOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = PresenceModification.PresencemodificationSetdataApiLatest;
				Records = other.Value.Records;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_Records);
		}
	}
}