// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Leaderboards
{
	/// <summary>
	/// Data containing the result information for a query leaderboard ranks request.
	/// </summary>
	public struct OnQueryLeaderboardRanksCompleteCallbackInfo : ICallbackInfo
	{
		/// <summary>
		/// The <see cref="Result" /> code for the operation. <see cref="Result.Success" /> indicates that the operation succeeded; other codes indicate errors.
		/// </summary>
		public Result ResultCode { get; set; }

		/// <summary>
		/// Context that was passed into <see cref="LeaderboardsInterface.QueryLeaderboardRanks" />.
		/// </summary>
		public object ClientData { get; set; }

		public Result? GetResultCode()
		{
			return ResultCode;
		}

		internal void Set(ref OnQueryLeaderboardRanksCompleteCallbackInfoInternal other)
		{
			ResultCode = other.ResultCode;
			ClientData = other.ClientData;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct OnQueryLeaderboardRanksCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnQueryLeaderboardRanksCompleteCallbackInfo>, ISettable<OnQueryLeaderboardRanksCompleteCallbackInfo>, System.IDisposable
	{
		private Result m_ResultCode;
		private System.IntPtr m_ClientData;

		public Result ResultCode
		{
			get
			{
				return m_ResultCode;
			}

			set
			{
				m_ResultCode = value;
			}
		}

		public object ClientData
		{
			get
			{
				object value;
				Helper.Get(m_ClientData, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_ClientData);
			}
		}

		public System.IntPtr ClientDataAddress
		{
			get
			{
				return m_ClientData;
			}
		}

		public void Set(ref OnQueryLeaderboardRanksCompleteCallbackInfo other)
		{
			ResultCode = other.ResultCode;
			ClientData = other.ClientData;
		}

		public void Set(ref OnQueryLeaderboardRanksCompleteCallbackInfo? other)
		{
			if (other.HasValue)
			{
				ResultCode = other.Value.ResultCode;
				ClientData = other.Value.ClientData;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_ClientData);
		}

		public void Get(out OnQueryLeaderboardRanksCompleteCallbackInfo output)
		{
			output = new OnQueryLeaderboardRanksCompleteCallbackInfo();
			output.Set(ref this);
		}
	}
}