// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace System.Reflection
{
    public class ExceptionHelper
    {
        public static Exception AsError(Exception exception)
        {
            return exception;
        }

        public static PlatformNotSupportedException PlatformNotSupported()
        {
            return new PlatformNotSupportedException();
        }

        public static PlatformNotSupportedException PlatformNotSupported(string message)
        {
            return new PlatformNotSupportedException(message);
        }
    }
}
