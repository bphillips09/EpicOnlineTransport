// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Presence
{
	/// <summary>
	/// Data for the <see cref="PresenceModification.SetRawRichText" /> API.
	/// </summary>
	public struct PresenceModificationSetRawRichTextOptions
	{
		/// <summary>
		/// The status of the user
		/// </summary>
		public Utf8String RichText { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct PresenceModificationSetRawRichTextOptionsInternal : ISettable<PresenceModificationSetRawRichTextOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_RichText;

		public Utf8String RichText
		{
			set
			{
				Helper.Set(value, ref m_RichText);
			}
		}

		public void Set(ref PresenceModificationSetRawRichTextOptions other)
		{
			m_ApiVersion = PresenceModification.PresencemodificationSetrawrichtextApiLatest;
			RichText = other.RichText;
		}

		public void Set(ref PresenceModificationSetRawRichTextOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = PresenceModification.PresencemodificationSetrawrichtextApiLatest;
				RichText = other.Value.RichText;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_RichText);
		}
	}
}