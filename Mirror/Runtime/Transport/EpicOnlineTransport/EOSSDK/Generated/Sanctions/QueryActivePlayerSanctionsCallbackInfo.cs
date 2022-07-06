// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sanctions
{
	/// <summary>
	/// Output parameters for the <see cref="SanctionsInterface.QueryActivePlayerSanctions" /> function.
	/// </summary>
	public struct QueryActivePlayerSanctionsCallbackInfo : ICallbackInfo
	{
		/// <summary>
		/// The <see cref="Result" /> code for the operation. <see cref="Result.Success" /> indicates that the operation succeeded; other codes indicate errors.
		/// </summary>
		public Result ResultCode { get; set; }

		/// <summary>
		/// Context that was passed into <see cref="SanctionsInterface.QueryActivePlayerSanctions" />.
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// Target Product User ID that was passed to <see cref="SanctionsInterface.QueryActivePlayerSanctions" />.
		/// </summary>
		public ProductUserId TargetUserId { get; set; }

		/// <summary>
		/// The Product User ID of the local user who initiated this request, if applicable.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		public Result? GetResultCode()
		{
			return ResultCode;
		}

		internal void Set(ref QueryActivePlayerSanctionsCallbackInfoInternal other)
		{
			ResultCode = other.ResultCode;
			ClientData = other.ClientData;
			TargetUserId = other.TargetUserId;
			LocalUserId = other.LocalUserId;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryActivePlayerSanctionsCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryActivePlayerSanctionsCallbackInfo>, ISettable<QueryActivePlayerSanctionsCallbackInfo>, System.IDisposable
	{
		private Result m_ResultCode;
		private System.IntPtr m_ClientData;
		private System.IntPtr m_TargetUserId;
		private System.IntPtr m_LocalUserId;

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

		public ProductUserId TargetUserId
		{
			get
			{
				ProductUserId value;
				Helper.Get(m_TargetUserId, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_TargetUserId);
			}
		}

		public ProductUserId LocalUserId
		{
			get
			{
				ProductUserId value;
				Helper.Get(m_LocalUserId, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public void Set(ref QueryActivePlayerSanctionsCallbackInfo other)
		{
			ResultCode = other.ResultCode;
			ClientData = other.ClientData;
			TargetUserId = other.TargetUserId;
			LocalUserId = other.LocalUserId;
		}

		public void Set(ref QueryActivePlayerSanctionsCallbackInfo? other)
		{
			if (other.HasValue)
			{
				ResultCode = other.Value.ResultCode;
				ClientData = other.Value.ClientData;
				TargetUserId = other.Value.TargetUserId;
				LocalUserId = other.Value.LocalUserId;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_ClientData);
			Helper.Dispose(ref m_TargetUserId);
			Helper.Dispose(ref m_LocalUserId);
		}

		public void Get(out QueryActivePlayerSanctionsCallbackInfo output)
		{
			output = new QueryActivePlayerSanctionsCallbackInfo();
			output.Set(ref this);
		}
	}
}