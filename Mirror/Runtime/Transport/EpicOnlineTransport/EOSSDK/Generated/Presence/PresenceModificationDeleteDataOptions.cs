// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Presence
{
	/// <summary>
	/// Data for the <see cref="PresenceModification.DeleteData" /> function.
	/// </summary>
	public struct PresenceModificationDeleteDataOptions
	{
		/// <summary>
		/// The pointer to start of a sequential array
		/// </summary>
		public PresenceModificationDataRecordId[] Records { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct PresenceModificationDeleteDataOptionsInternal : ISettable<PresenceModificationDeleteDataOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private int m_RecordsCount;
		private System.IntPtr m_Records;

		public PresenceModificationDataRecordId[] Records
		{
			set
			{
				Helper.Set<PresenceModificationDataRecordId, PresenceModificationDataRecordIdInternal>(ref value, ref m_Records, out m_RecordsCount);
			}
		}

		public void Set(ref PresenceModificationDeleteDataOptions other)
		{
			m_ApiVersion = PresenceModification.PresencemodificationDeletedataApiLatest;
			Records = other.Records;
		}

		public void Set(ref PresenceModificationDeleteDataOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = PresenceModification.PresencemodificationDeletedataApiLatest;
				Records = other.Value.Records;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_Records);
		}
	}
}