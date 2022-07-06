// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Platform
{
	/// <summary>
	/// Platform options for <see cref="PlatformInterface.Create" />.
	/// </summary>
	public struct WindowsOptions
	{
		/// <summary>
		/// A reserved field that should always be nulled.
		/// </summary>
		public System.IntPtr Reserved { get; set; }

		/// <summary>
		/// The product ID for the running application, found on the dev portal
		/// </summary>
		public Utf8String ProductId { get; set; }

		/// <summary>
		/// The sandbox ID for the running application, found on the dev portal
		/// </summary>
		public Utf8String SandboxId { get; set; }

		/// <summary>
		/// Set of service permissions associated with the running application
		/// </summary>
		public ClientCredentials ClientCredentials { get; set; }

		/// <summary>
		/// Set this to <see langword="false" /> if the application is running as a client with a local user, otherwise set to <see langword="true" /> (e.g. for a dedicated game server)
		/// </summary>
		public bool IsServer { get; set; }

		/// <summary>
		/// Used by Player Data Storage and Title Storage. Must be null initialized if unused. 256-bit Encryption Key for file encryption in hexadecimal format (64 hex chars)
		/// </summary>
		public Utf8String EncryptionKey { get; set; }

		/// <summary>
		/// The override country code to use for the logged in user. (<see cref="PlatformInterface.CountrycodeMaxLength" />)
		/// </summary>
		public Utf8String OverrideCountryCode { get; set; }

		/// <summary>
		/// The override locale code to use for the logged in user. This follows ISO 639. (<see cref="PlatformInterface.LocalecodeMaxLength" />)
		/// </summary>
		public Utf8String OverrideLocaleCode { get; set; }

		/// <summary>
		/// The deployment ID for the running application, found on the dev portal
		/// </summary>
		public Utf8String DeploymentId { get; set; }

		/// <summary>
		/// Platform creation flags, e.g. <see cref="PlatformFlags.LoadingInEditor" />. This is a bitwise-or union of the defined flags.
		/// </summary>
		public PlatformFlags Flags { get; set; }

		/// <summary>
		/// Used by Player Data Storage and Title Storage. Must be null initialized if unused. Cache directory path. Absolute path to the folder that is going to be used for caching temporary data. The path is created if it's missing.
		/// </summary>
		public Utf8String CacheDirectory { get; set; }

		/// <summary>
		/// A budget, measured in milliseconds, for <see cref="PlatformInterface.Tick" /> to do its work. When the budget is met or exceeded (or if no work is available), <see cref="PlatformInterface.Tick" /> will return.
		/// This allows your game to amortize the cost of SDK work across multiple frames in the event that a lot of work is queued for processing.
		/// Zero is interpreted as "perform all available work".
		/// </summary>
		public uint TickBudgetInMilliseconds { get; set; }

		/// <summary>
		/// RTC options. Setting to <see langword="null" /> will disable RTC features (e.g. voice)
		/// </summary>
		public WindowsRTCOptions? RTCOptions { get; set; }

		/// <summary>
		/// A handle that contains all the options for setting up integrated platforms.
		/// When set to <see langword="null" />, the default integrated platform behavior for the host platform will be used.
		/// </summary>
		public IntegratedPlatform.IntegratedPlatformOptionsContainer IntegratedPlatformOptionsContainerHandle { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct WindowsOptionsInternal : ISettable<WindowsOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_Reserved;
		private System.IntPtr m_ProductId;
		private System.IntPtr m_SandboxId;
		private ClientCredentialsInternal m_ClientCredentials;
		private int m_IsServer;
		private System.IntPtr m_EncryptionKey;
		private System.IntPtr m_OverrideCountryCode;
		private System.IntPtr m_OverrideLocaleCode;
		private System.IntPtr m_DeploymentId;
		private PlatformFlags m_Flags;
		private System.IntPtr m_CacheDirectory;
		private uint m_TickBudgetInMilliseconds;
		private System.IntPtr m_RTCOptions;
		private System.IntPtr m_IntegratedPlatformOptionsContainerHandle;

		public System.IntPtr Reserved
		{
			set
			{
				m_Reserved = value;
			}
		}

		public Utf8String ProductId
		{
			set
			{
				Helper.Set(value, ref m_ProductId);
			}
		}

		public Utf8String SandboxId
		{
			set
			{
				Helper.Set(value, ref m_SandboxId);
			}
		}

		public ClientCredentials ClientCredentials
		{
			set
			{
				Helper.Set(ref value, ref m_ClientCredentials);
			}
		}

		public bool IsServer
		{
			set
			{
				Helper.Set(value, ref m_IsServer);
			}
		}

		public Utf8String EncryptionKey
		{
			set
			{
				Helper.Set(value, ref m_EncryptionKey);
			}
		}

		public Utf8String OverrideCountryCode
		{
			set
			{
				Helper.Set(value, ref m_OverrideCountryCode);
			}
		}

		public Utf8String OverrideLocaleCode
		{
			set
			{
				Helper.Set(value, ref m_OverrideLocaleCode);
			}
		}

		public Utf8String DeploymentId
		{
			set
			{
				Helper.Set(value, ref m_DeploymentId);
			}
		}

		public PlatformFlags Flags
		{
			set
			{
				m_Flags = value;
			}
		}

		public Utf8String CacheDirectory
		{
			set
			{
				Helper.Set(value, ref m_CacheDirectory);
			}
		}

		public uint TickBudgetInMilliseconds
		{
			set
			{
				m_TickBudgetInMilliseconds = value;
			}
		}

		public WindowsRTCOptions? RTCOptions
		{
			set
			{
				Helper.Set<WindowsRTCOptions, WindowsRTCOptionsInternal>(ref value, ref m_RTCOptions);
			}
		}

		public IntegratedPlatform.IntegratedPlatformOptionsContainer IntegratedPlatformOptionsContainerHandle
		{
			set
			{
				Helper.Set(value, ref m_IntegratedPlatformOptionsContainerHandle);
			}
		}

		public void Set(ref WindowsOptions other)
		{
			m_ApiVersion = PlatformInterface.OptionsApiLatest;
			Reserved = other.Reserved;
			ProductId = other.ProductId;
			SandboxId = other.SandboxId;
			ClientCredentials = other.ClientCredentials;
			IsServer = other.IsServer;
			EncryptionKey = other.EncryptionKey;
			OverrideCountryCode = other.OverrideCountryCode;
			OverrideLocaleCode = other.OverrideLocaleCode;
			DeploymentId = other.DeploymentId;
			Flags = other.Flags;
			CacheDirectory = other.CacheDirectory;
			TickBudgetInMilliseconds = other.TickBudgetInMilliseconds;
			RTCOptions = other.RTCOptions;
			IntegratedPlatformOptionsContainerHandle = other.IntegratedPlatformOptionsContainerHandle;
		}

		public void Set(ref WindowsOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = PlatformInterface.OptionsApiLatest;
				Reserved = other.Value.Reserved;
				ProductId = other.Value.ProductId;
				SandboxId = other.Value.SandboxId;
				ClientCredentials = other.Value.ClientCredentials;
				IsServer = other.Value.IsServer;
				EncryptionKey = other.Value.EncryptionKey;
				OverrideCountryCode = other.Value.OverrideCountryCode;
				OverrideLocaleCode = other.Value.OverrideLocaleCode;
				DeploymentId = other.Value.DeploymentId;
				Flags = other.Value.Flags;
				CacheDirectory = other.Value.CacheDirectory;
				TickBudgetInMilliseconds = other.Value.TickBudgetInMilliseconds;
				RTCOptions = other.Value.RTCOptions;
				IntegratedPlatformOptionsContainerHandle = other.Value.IntegratedPlatformOptionsContainerHandle;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_Reserved);
			Helper.Dispose(ref m_ProductId);
			Helper.Dispose(ref m_SandboxId);
			Helper.Dispose(ref m_ClientCredentials);
			Helper.Dispose(ref m_EncryptionKey);
			Helper.Dispose(ref m_OverrideCountryCode);
			Helper.Dispose(ref m_OverrideLocaleCode);
			Helper.Dispose(ref m_DeploymentId);
			Helper.Dispose(ref m_CacheDirectory);
			Helper.Dispose(ref m_RTCOptions);
			Helper.Dispose(ref m_IntegratedPlatformOptionsContainerHandle);
		}
	}
}