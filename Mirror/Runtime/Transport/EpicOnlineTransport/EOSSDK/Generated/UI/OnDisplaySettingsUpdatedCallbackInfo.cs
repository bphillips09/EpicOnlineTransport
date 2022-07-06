// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.UI
{
	public struct OnDisplaySettingsUpdatedCallbackInfo : ICallbackInfo
	{
		/// <summary>
		/// Context that was passed into <see cref="UIInterface.AddNotifyDisplaySettingsUpdated" />
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// True when any portion of the overlay is visible.
		/// </summary>
		public bool IsVisible { get; set; }

		/// <summary>
		/// True when the overlay has switched to exclusive input mode.
		/// While in exclusive input mode, no keyboard or mouse input will be sent to the game.
		/// </summary>
		public bool IsExclusiveInput { get; set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(ref OnDisplaySettingsUpdatedCallbackInfoInternal other)
		{
			ClientData = other.ClientData;
			IsVisible = other.IsVisible;
			IsExclusiveInput = other.IsExclusiveInput;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct OnDisplaySettingsUpdatedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnDisplaySettingsUpdatedCallbackInfo>, ISettable<OnDisplaySettingsUpdatedCallbackInfo>, System.IDisposable
	{
		private System.IntPtr m_ClientData;
		private int m_IsVisible;
		private int m_IsExclusiveInput;

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

		public bool IsVisible
		{
			get
			{
				bool value;
				Helper.Get(m_IsVisible, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_IsVisible);
			}
		}

		public bool IsExclusiveInput
		{
			get
			{
				bool value;
				Helper.Get(m_IsExclusiveInput, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_IsExclusiveInput);
			}
		}

		public void Set(ref OnDisplaySettingsUpdatedCallbackInfo other)
		{
			ClientData = other.ClientData;
			IsVisible = other.IsVisible;
			IsExclusiveInput = other.IsExclusiveInput;
		}

		public void Set(ref OnDisplaySettingsUpdatedCallbackInfo? other)
		{
			if (other.HasValue)
			{
				ClientData = other.Value.ClientData;
				IsVisible = other.Value.IsVisible;
				IsExclusiveInput = other.Value.IsExclusiveInput;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_ClientData);
		}

		public void Get(out OnDisplaySettingsUpdatedCallbackInfo output)
		{
			output = new OnDisplaySettingsUpdatedCallbackInfo();
			output.Set(ref this);
		}
	}
}