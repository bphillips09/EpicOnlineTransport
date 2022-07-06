// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionSearch.SetParameter" /> function.
	/// 
	/// A search key may be set more than once to make multiple comparisons
	/// The two comparisons are AND'd together
	/// (ie, Key GREATER_THAN 5, Key NOT_EQUALS 10)
	/// </summary>
	public struct SessionSearchSetParameterOptions
	{
		/// <summary>
		/// Search parameter describing a key and a value to compare
		/// </summary>
		public AttributeData? Parameter { get; set; }

		/// <summary>
		/// The type of comparison to make against the search parameter
		/// </summary>
		public ComparisonOp ComparisonOp { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SessionSearchSetParameterOptionsInternal : ISettable<SessionSearchSetParameterOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_Parameter;
		private ComparisonOp m_ComparisonOp;

		public AttributeData? Parameter
		{
			set
			{
				Helper.Set<AttributeData, AttributeDataInternal>(ref value, ref m_Parameter);
			}
		}

		public ComparisonOp ComparisonOp
		{
			set
			{
				m_ComparisonOp = value;
			}
		}

		public void Set(ref SessionSearchSetParameterOptions other)
		{
			m_ApiVersion = SessionSearch.SessionsearchSetparameterApiLatest;
			Parameter = other.Parameter;
			ComparisonOp = other.ComparisonOp;
		}

		public void Set(ref SessionSearchSetParameterOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = SessionSearch.SessionsearchSetparameterApiLatest;
				Parameter = other.Value.Parameter;
				ComparisonOp = other.Value.ComparisonOp;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_Parameter);
		}
	}
}