// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Platform
{
	/// <summary>
	/// Options for initializing the Epic Online Services SDK.
	/// </summary>
	public struct InitializeOptions
	{
		/// <summary>
		/// A custom memory allocator, if desired.
		/// </summary>
		public System.IntPtr AllocateMemoryFunction { get; set; }

		/// <summary>
		/// A corresponding memory reallocator. If the AllocateMemoryFunction is nulled, then this field must also be nulled.
		/// </summary>
		public System.IntPtr ReallocateMemoryFunction { get; set; }

		/// <summary>
		/// A corresponding memory releaser. If the AllocateMemoryFunction is nulled, then this field must also be nulled.
		/// </summary>
		public System.IntPtr ReleaseMemoryFunction { get; set; }

		/// <summary>
		/// The name of the product using the Epic Online Services SDK.
		/// 
		/// The name string is required to be non-empty and at maximum of 64 characters long.
		/// The string buffer can consist of the following characters:
		/// A-Z, a-z, 0-9, dot, underscore, space, exclamation mark, question mark, and sign, hyphen, parenthesis, plus, minus, colon.
		/// </summary>
		public Utf8String ProductName { get; set; }

		/// <summary>
		/// Product version of the running application.
		/// 
		/// The name string has same requirements as the ProductName string.
		/// </summary>
		public Utf8String ProductVersion { get; set; }

		/// <summary>
		/// This field is for system specific initialization if any.
		/// 
		/// If provided then the structure will be located in <System>/eos_<system>.h.
		/// The structure will be named EOS_<System>_InitializeOptions.
		/// </summary>
		public System.IntPtr SystemInitializeOptions { get; set; }

		/// <summary>
		/// The thread affinity override values for each category of thread.
		/// </summary>
		public InitializeThreadAffinity? OverrideThreadAffinity { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct InitializeOptionsInternal : ISettable<InitializeOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_AllocateMemoryFunction;
		private System.IntPtr m_ReallocateMemoryFunction;
		private System.IntPtr m_ReleaseMemoryFunction;
		private System.IntPtr m_ProductName;
		private System.IntPtr m_ProductVersion;
		private System.IntPtr m_Reserved;
		private System.IntPtr m_SystemInitializeOptions;
		private System.IntPtr m_OverrideThreadAffinity;

		public System.IntPtr AllocateMemoryFunction
		{
			set
			{
				m_AllocateMemoryFunction = value;
			}
		}

		public System.IntPtr ReallocateMemoryFunction
		{
			set
			{
				m_ReallocateMemoryFunction = value;
			}
		}

		public System.IntPtr ReleaseMemoryFunction
		{
			set
			{
				m_ReleaseMemoryFunction = value;
			}
		}

		public Utf8String ProductName
		{
			set
			{
				Helper.Set(value, ref m_ProductName);
			}
		}

		public Utf8String ProductVersion
		{
			set
			{
				Helper.Set(value, ref m_ProductVersion);
			}
		}

		public System.IntPtr SystemInitializeOptions
		{
			set
			{
				m_SystemInitializeOptions = value;
			}
		}

		public InitializeThreadAffinity? OverrideThreadAffinity
		{
			set
			{
				Helper.Set<InitializeThreadAffinity, InitializeThreadAffinityInternal>(ref value, ref m_OverrideThreadAffinity);
			}
		}

		public void Set(ref InitializeOptions other)
		{
			m_ApiVersion = PlatformInterface.InitializeApiLatest;
			AllocateMemoryFunction = other.AllocateMemoryFunction;
			ReallocateMemoryFunction = other.ReallocateMemoryFunction;
			ReleaseMemoryFunction = other.ReleaseMemoryFunction;
			ProductName = other.ProductName;
			ProductVersion = other.ProductVersion;
			int[] reservedData = new int[] { 1, 1 };
			System.IntPtr reservedDataAddress = System.IntPtr.Zero;
			Helper.Set(reservedData, ref reservedDataAddress);
			m_Reserved = reservedDataAddress;
			SystemInitializeOptions = other.SystemInitializeOptions;
			OverrideThreadAffinity = other.OverrideThreadAffinity;
		}

		public void Set(ref InitializeOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = PlatformInterface.InitializeApiLatest;
				AllocateMemoryFunction = other.Value.AllocateMemoryFunction;
				ReallocateMemoryFunction = other.Value.ReallocateMemoryFunction;
				ReleaseMemoryFunction = other.Value.ReleaseMemoryFunction;
				ProductName = other.Value.ProductName;
				ProductVersion = other.Value.ProductVersion;
				int[] reservedData = new int[] { 1, 1 };
				System.IntPtr reservedDataAddress = System.IntPtr.Zero;
				Helper.Set(reservedData, ref reservedDataAddress);
				m_Reserved = reservedDataAddress;
				SystemInitializeOptions = other.Value.SystemInitializeOptions;
				OverrideThreadAffinity = other.Value.OverrideThreadAffinity;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_AllocateMemoryFunction);
			Helper.Dispose(ref m_ReallocateMemoryFunction);
			Helper.Dispose(ref m_ReleaseMemoryFunction);
			Helper.Dispose(ref m_ProductName);
			Helper.Dispose(ref m_ProductVersion);
			Helper.Dispose(ref m_Reserved);
			Helper.Dispose(ref m_SystemInitializeOptions);
			Helper.Dispose(ref m_OverrideThreadAffinity);
		}
	}
}