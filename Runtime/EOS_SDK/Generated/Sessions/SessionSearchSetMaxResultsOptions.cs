// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionSearch.SetMaxResults" /> function.
	/// </summary>
	public struct SessionSearchSetMaxResultsOptions
	{
		/// <summary>
		/// Maximum number of search results returned with this query, may not exceed <see cref="SessionsInterface.MAX_SEARCH_RESULTS" />
		/// </summary>
		public uint MaxSearchResults { get; set; }
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct SessionSearchSetMaxResultsOptionsInternal : ISettable<SessionSearchSetMaxResultsOptions>
	{
		private int m_ApiVersion;
		private uint m_MaxSearchResults;

		public void Set(ref SessionSearchSetMaxResultsOptions other)
		{
			Dispose();

			m_ApiVersion = SessionsInterface.SESSIONSEARCH_SETMAXSEARCHRESULTS_API_LATEST;
			m_MaxSearchResults = other.MaxSearchResults;
		}

		public void Dispose()
		{
		}
	}
}
