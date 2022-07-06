// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="EcomInterface.GetOfferCount" /> function.
	/// </summary>
	public struct GetOfferCountOptions
	{
		/// <summary>
		/// The Epic Account ID of the local user whose offers are being accessed
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct GetOfferCountOptionsInternal : ISettable<GetOfferCountOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public void Set(ref GetOfferCountOptions other)
		{
			m_ApiVersion = EcomInterface.GetoffercountApiLatest;
			LocalUserId = other.LocalUserId;
		}

		public void Set(ref GetOfferCountOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = EcomInterface.GetoffercountApiLatest;
				LocalUserId = other.Value.LocalUserId;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
		}
	}
}