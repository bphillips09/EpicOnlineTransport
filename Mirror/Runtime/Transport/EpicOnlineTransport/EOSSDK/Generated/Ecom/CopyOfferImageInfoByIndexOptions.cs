// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="EcomInterface.CopyOfferImageInfoByIndex" /> function.
	/// </summary>
	public struct CopyOfferImageInfoByIndexOptions
	{
		/// <summary>
		/// The Epic Account ID of the local user whose offer image is being copied.
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The ID of the offer to get the images for.
		/// </summary>
		public Utf8String OfferId { get; set; }

		/// <summary>
		/// The index of the image to get.
		/// </summary>
		public uint ImageInfoIndex { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct CopyOfferImageInfoByIndexOptionsInternal : ISettable<CopyOfferImageInfoByIndexOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_OfferId;
		private uint m_ImageInfoIndex;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public Utf8String OfferId
		{
			set
			{
				Helper.Set(value, ref m_OfferId);
			}
		}

		public uint ImageInfoIndex
		{
			set
			{
				m_ImageInfoIndex = value;
			}
		}

		public void Set(ref CopyOfferImageInfoByIndexOptions other)
		{
			m_ApiVersion = EcomInterface.CopyofferimageinfobyindexApiLatest;
			LocalUserId = other.LocalUserId;
			OfferId = other.OfferId;
			ImageInfoIndex = other.ImageInfoIndex;
		}

		public void Set(ref CopyOfferImageInfoByIndexOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = EcomInterface.CopyofferimageinfobyindexApiLatest;
				LocalUserId = other.Value.LocalUserId;
				OfferId = other.Value.OfferId;
				ImageInfoIndex = other.Value.ImageInfoIndex;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_OfferId);
		}
	}
}