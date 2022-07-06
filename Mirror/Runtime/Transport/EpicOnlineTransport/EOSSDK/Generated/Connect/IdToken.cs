// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Connect
{
	/// <summary>
	/// A structure that contains an ID token.
	/// These structures are created by <see cref="ConnectInterface.CopyIdToken" /> and must be passed to <see cref="ConnectInterface.Release" />.
	/// </summary>
	public struct IdToken
	{
		/// <summary>
		/// The Product User ID described by the ID token.
		/// Use <see cref="ProductUserId.FromString" /> to populate this field when validating a received ID token.
		/// </summary>
		public ProductUserId ProductUserId { get; set; }

		/// <summary>
		/// The ID token as a Json Web Token (JWT) string.
		/// </summary>
		public Utf8String JsonWebToken { get; set; }

		internal void Set(ref IdTokenInternal other)
		{
			ProductUserId = other.ProductUserId;
			JsonWebToken = other.JsonWebToken;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct IdTokenInternal : IGettable<IdToken>, ISettable<IdToken>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_ProductUserId;
		private System.IntPtr m_JsonWebToken;

		public ProductUserId ProductUserId
		{
			get
			{
				ProductUserId value;
				Helper.Get(m_ProductUserId, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_ProductUserId);
			}
		}

		public Utf8String JsonWebToken
		{
			get
			{
				Utf8String value;
				Helper.Get(m_JsonWebToken, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_JsonWebToken);
			}
		}

		public void Set(ref IdToken other)
		{
			m_ApiVersion = ConnectInterface.IdtokenApiLatest;
			ProductUserId = other.ProductUserId;
			JsonWebToken = other.JsonWebToken;
		}

		public void Set(ref IdToken? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = ConnectInterface.IdtokenApiLatest;
				ProductUserId = other.Value.ProductUserId;
				JsonWebToken = other.Value.JsonWebToken;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_ProductUserId);
			Helper.Dispose(ref m_JsonWebToken);
		}

		public void Get(out IdToken output)
		{
			output = new IdToken();
			output.Set(ref this);
		}
	}
}