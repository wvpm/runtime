// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace System;

public static class AssertExtensions {
	public static void ThrowsContains<T>(Action action, string expectedMessageContent)
		where T : Exception {
		Assert.Contains(expectedMessageContent, Assert.Throws<T>(action).Message);
	}

	public static T Throws<T>(string expectedParamName, Func<object> testCode)
		where T : ArgumentException {
		T exception = Assert.Throws<T>(testCode);

		Assert.Equal(expectedParamName, exception.ParamName);

		return exception;
	}
}