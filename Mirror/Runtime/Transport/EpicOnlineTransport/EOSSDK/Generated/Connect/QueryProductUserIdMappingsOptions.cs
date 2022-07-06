// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Connect
{
	/// <summary>
	/// Input parameters for the <see cref="ConnectInterface.QueryProductUserIdMappings" /> function.
	/// </summary>
	public struct QueryProductUserIdMappingsOptions
	{
		/// <summary>
		/// Game Clients set this field to the Product User ID of the local authenticated user querying account mappings.
		/// Game Servers set this field to <see langword="null" />. Usage is allowed given that the configured client policy for server credentials permit it.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// Deprecated - all external mappings are included in this call, it is no longer necessary to specify this value.
		/// </summary>
		public ExternalAccountType AccountIdType_DEPRECATED { get; set; }

		/// <summary>
		/// An array of Product User IDs to query for the given external account representation.
		/// </summary>
		public ProductUserId[] ProductUserIds { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryProductUserIdMappingsOptionsInternal : ISettable<QueryProductUserIdMappingsOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private ExternalAccountType m_AccountIdType_DEPRECATED;
		private System.IntPtr m_ProductUserIds;
		private uint m_ProductUserIdCount;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public ExternalAccountType AccountIdType_DEPRECATED
		{
			set
			{
				m_AccountIdType_DEPRECATED = value;
			}
		}

		public ProductUserId[] ProductUserIds
		{
			set
			{
				Helper.Set(value, ref m_ProductUserIds, out m_ProductUserIdCount);
			}
		}

		public void Set(ref QueryProductUserIdMappingsOptions other)
		{
			m_ApiVersion = ConnectInterface.QueryproductuseridmappingsApiLatest;
			LocalUserId = other.LocalUserId;
			AccountIdType_DEPRECATED = other.AccountIdType_DEPRECATED;
			ProductUserIds = other.ProductUserIds;
		}

		public void Set(ref QueryProductUserIdMappingsOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = ConnectInterface.QueryproductuseridmappingsApiLatest;
				LocalUserId = other.Value.LocalUserId;
				AccountIdType_DEPRECATED = other.Value.AccountIdType_DEPRECATED;
				ProductUserIds = other.Value.ProductUserIds;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_ProductUserIds);
		}
	}
}