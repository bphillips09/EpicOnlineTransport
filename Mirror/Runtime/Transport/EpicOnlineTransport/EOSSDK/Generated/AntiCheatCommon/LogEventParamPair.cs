// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatCommon
{
	public struct LogEventParamPair
	{
		public LogEventParamPairParamValue ParamValue { get; set; }

		internal void Set(ref LogEventParamPairInternal other)
		{
			ParamValue = other.ParamValue;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LogEventParamPairInternal : IGettable<LogEventParamPair>, ISettable<LogEventParamPair>, System.IDisposable
	{
		private LogEventParamPairParamValueInternal m_ParamValue;

		public LogEventParamPairParamValue ParamValue
		{
			get
			{
				LogEventParamPairParamValue value;
				Helper.Get(ref m_ParamValue, out value);
				return value;
			}

			set
			{
				Helper.Set(ref value, ref m_ParamValue);
			}
		}

		public void Set(ref LogEventParamPair other)
		{
			ParamValue = other.ParamValue;
		}

		public void Set(ref LogEventParamPair? other)
		{
			if (other.HasValue)
			{
				ParamValue = other.Value.ParamValue;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_ParamValue);
		}

		public void Get(out LogEventParamPair output)
		{
			output = new LogEventParamPair();
			output.Set(ref this);
		}
	}
}