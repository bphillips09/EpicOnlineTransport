// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Auth
{
	/// <summary>
	/// Input parameters for the <see cref="AuthInterface.VerifyUserAuth" /> function.
	/// This operation is destructive, the pointer will remain the same but the data pointers inside will update
	/// </summary>
	public struct VerifyUserAuthOptions
	{
		/// <summary>
		/// Auth token to verify against the backend service
		/// </summary>
		public Token? AuthToken { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct VerifyUserAuthOptionsInternal : ISettable<VerifyUserAuthOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_AuthToken;

		public Token? AuthToken
		{
			set
			{
				Helper.Set<Token, TokenInternal>(ref value, ref m_AuthToken);
			}
		}

		public void Set(ref VerifyUserAuthOptions other)
		{
			m_ApiVersion = AuthInterface.VerifyuserauthApiLatest;
			AuthToken = other.AuthToken;
		}

		public void Set(ref VerifyUserAuthOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = AuthInterface.VerifyuserauthApiLatest;
				AuthToken = other.Value.AuthToken;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_AuthToken);
		}
	}
}