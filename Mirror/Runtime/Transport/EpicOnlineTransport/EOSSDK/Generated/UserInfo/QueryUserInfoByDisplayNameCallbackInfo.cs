// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.UserInfo
{
	/// <summary>
	/// Output parameters for the <see cref="UserInfoInterface.QueryUserInfoByDisplayName" /> Function.
	/// </summary>
	public struct QueryUserInfoByDisplayNameCallbackInfo : ICallbackInfo
	{
		/// <summary>
		/// The <see cref="Result" /> code for the operation. <see cref="Result.Success" /> indicates that the operation succeeded; other codes indicate errors.
		/// </summary>
		public Result ResultCode { get; set; }

		/// <summary>
		/// Context that was passed into <see cref="UserInfoInterface.QueryUserInfoByDisplayName" />
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// The Epic Account ID of the local player requesting the information
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The Epic Account ID of the player whose information is being retrieved
		/// </summary>
		public EpicAccountId TargetUserId { get; set; }

		/// <summary>
		/// Display name (un-sanitized) of the player being queried. This memory is only valid during the scope of the callback.
		/// </summary>
		public Utf8String DisplayName { get; set; }

		public Result? GetResultCode()
		{
			return ResultCode;
		}

		internal void Set(ref QueryUserInfoByDisplayNameCallbackInfoInternal other)
		{
			ResultCode = other.ResultCode;
			ClientData = other.ClientData;
			LocalUserId = other.LocalUserId;
			TargetUserId = other.TargetUserId;
			DisplayName = other.DisplayName;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryUserInfoByDisplayNameCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryUserInfoByDisplayNameCallbackInfo>, ISettable<QueryUserInfoByDisplayNameCallbackInfo>, System.IDisposable
	{
		private Result m_ResultCode;
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_TargetUserId;
		private System.IntPtr m_DisplayName;

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

		public EpicAccountId LocalUserId
		{
			get
			{
				EpicAccountId value;
				Helper.Get(m_LocalUserId, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_LocalUserId);
			}
		}

		public EpicAccountId TargetUserId
		{
			get
			{
				EpicAccountId value;
				Helper.Get(m_TargetUserId, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_TargetUserId);
			}
		}

		public Utf8String DisplayName
		{
			get
			{
				Utf8String value;
				Helper.Get(m_DisplayName, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_DisplayName);
			}
		}

		public void Set(ref QueryUserInfoByDisplayNameCallbackInfo other)
		{
			ResultCode = other.ResultCode;
			ClientData = other.ClientData;
			LocalUserId = other.LocalUserId;
			TargetUserId = other.TargetUserId;
			DisplayName = other.DisplayName;
		}

		public void Set(ref QueryUserInfoByDisplayNameCallbackInfo? other)
		{
			if (other.HasValue)
			{
				ResultCode = other.Value.ResultCode;
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				TargetUserId = other.Value.TargetUserId;
				DisplayName = other.Value.DisplayName;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_ClientData);
			Helper.Dispose(ref m_LocalUserId);
			Helper.Dispose(ref m_TargetUserId);
			Helper.Dispose(ref m_DisplayName);
		}

		public void Get(out QueryUserInfoByDisplayNameCallbackInfo output)
		{
			output = new QueryUserInfoByDisplayNameCallbackInfo();
			output.Set(ref this);
		}
	}
}