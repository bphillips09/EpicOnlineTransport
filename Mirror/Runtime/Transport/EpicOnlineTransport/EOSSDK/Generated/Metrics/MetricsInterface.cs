// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Metrics
{
	public sealed partial class MetricsInterface : Handle
	{
		public MetricsInterface()
		{
		}

		public MetricsInterface(System.IntPtr innerHandle) : base(innerHandle)
		{
		}

		/// <summary>
		/// The most recent version of the <see cref="BeginPlayerSessionOptions" /> struct.
		/// </summary>
		public const int BeginplayersessionApiLatest = 1;

		/// <summary>
		/// The most recent version of the <see cref="EndPlayerSessionOptions" /> struct.
		/// </summary>
		public const int EndplayersessionApiLatest = 1;

		/// <summary>
		/// Logs the start of a new game session for a local player.
		/// 
		/// The game client should call this function whenever it joins into a new multiplayer, peer-to-peer or single player game session.
		/// Each call to BeginPlayerSession must be matched with a corresponding call to EndPlayerSession.
		/// </summary>
		/// <param name="options">Structure containing the local player's game account and the game session information.</param>
		/// <returns>
		/// Returns <see cref="Result.Success" /> on success, or an error code if the input parameters are invalid or an active session for the player already exists.
		/// </returns>
		public Result BeginPlayerSession(ref BeginPlayerSessionOptions options)
		{
			BeginPlayerSessionOptionsInternal optionsInternal = new BeginPlayerSessionOptionsInternal();
			optionsInternal.Set(ref options);

			var funcResult = Bindings.EOS_Metrics_BeginPlayerSession(InnerHandle, ref optionsInternal);

			Helper.Dispose(ref optionsInternal);

			return funcResult;
		}

		/// <summary>
		/// Logs the end of a game session for a local player.
		/// 
		/// Call once when the game client leaves the active game session.
		/// Each call to BeginPlayerSession must be matched with a corresponding call to EndPlayerSession.
		/// </summary>
		/// <param name="options">Structure containing the account id of the player whose session to end.</param>
		/// <returns>
		/// Returns <see cref="Result.Success" /> on success, or an error code if the input parameters are invalid or there was no active session for the player.
		/// </returns>
		public Result EndPlayerSession(ref EndPlayerSessionOptions options)
		{
			EndPlayerSessionOptionsInternal optionsInternal = new EndPlayerSessionOptionsInternal();
			optionsInternal.Set(ref options);

			var funcResult = Bindings.EOS_Metrics_EndPlayerSession(InnerHandle, ref optionsInternal);

			Helper.Dispose(ref optionsInternal);

			return funcResult;
		}
	}
}