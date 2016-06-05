﻿using System;

namespace Microsoft.Management.Infrastructure.Native
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal class MI_String
    {
        private IntPtr ptr;

        private MI_String()
        {
        }

        internal MI_String(IntPtr ptr)
        {
            this.ptr = ptr;
        }

        public static implicit operator IntPtr(MI_String wrapper)
        {
            return wrapper.ptr;
        }

        internal static MI_String NewIndirectPtr()
        {
            return new MI_String();
        }

        internal string Value
        {
            get
            {
                return this.ptr == IntPtr.Zero ? null : MI_PlatformSpecific.PtrToString(this.ptr);
            }
        }
    }
}