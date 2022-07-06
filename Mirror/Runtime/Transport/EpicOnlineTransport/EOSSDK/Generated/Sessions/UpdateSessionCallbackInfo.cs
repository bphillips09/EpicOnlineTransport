// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Output parameters for the <see cref="SessionsInterface.UpdateSession" /> function.
	/// </summary>
	public struct UpdateSessionCallbackInfo : ICallbackInfo
	{
		/// <summary>
		/// The <see cref="Result" /> code for the operation. <see cref="Result.Success" /> indicates that the operation succeeded; other codes indicate errors.
		/// </summary>
		public Result ResultCode { get; set; }

		/// <summary>
		/// Context that was passed into <see cref="SessionsInterface.UpdateSession" />
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// Name of the session that was created/modified
		/// </summary>
		public Utf8String SessionName { get; set; }

		/// <summary>
		/// ID of the session that was created/modified
		/// </summary>
		public Utf8String SessionId { get; set; }

		public Result? GetResultCode()
		{
			return ResultCode;
		}

		internal void Set(ref UpdateSessionCallbackInfoInternal other)
		{
			ResultCode = other.ResultCode;
			ClientData = other.ClientData;
			SessionName = other.SessionName;
			SessionId = other.SessionId;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct UpdateSessionCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateSessionCallbackInfo>, ISettable<UpdateSessionCallbackInfo>, System.IDisposable
	{
		private Result m_ResultCode;
		private System.IntPtr m_ClientData;
		private System.IntPtr m_SessionName;
		private System.IntPtr m_SessionId;

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

		public Utf8String SessionName
		{
			get
			{
				Utf8String value;
				Helper.Get(m_SessionName, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_SessionName);
			}
		}

		public Utf8String SessionId
		{
			get
			{
				Utf8String value;
				Helper.Get(m_SessionId, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_SessionId);
			}
		}

		public void Set(ref UpdateSessionCallbackInfo other)
		{
			ResultCode = other.ResultCode;
			ClientData = other.ClientData;
			SessionName = other.SessionName;
			SessionId = other.SessionId;
		}

		public void Set(ref UpdateSessionCallbackInfo? other)
		{
			if (other.HasValue)
			{
				ResultCode = other.Value.ResultCode;
				ClientData = other.Value.ClientData;
				SessionName = other.Value.SessionName;
				SessionId = other.Value.SessionId;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_ClientData);
			Helper.Dispose(ref m_SessionName);
			Helper.Dispose(ref m_SessionId);
		}

		public void Get(out UpdateSessionCallbackInfo output)
		{
			output = new UpdateSessionCallbackInfo();
			output.Set(ref this);
		}
	}
}