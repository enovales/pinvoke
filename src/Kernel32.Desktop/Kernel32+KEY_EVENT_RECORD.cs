﻿// Copyright (c) to owners found in https://github.com/AArnott/pinvoke/blob/master/COPYRIGHT.md. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

namespace PInvoke
{
    using System;
    using System.Runtime.InteropServices;

    /// <content>
    /// Contains the <see cref="KEY_EVENT_RECORD"/> nested type.
    /// </content>
    public partial class Kernel32
    {
        /// <summary>
        /// Describes a keyboard input event in a console <see cref="INPUT_RECORD"/> structure.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct KEY_EVENT_RECORD
        {
            /// <summary>
            /// If the key is pressed, this member is TRUE. Otherwise, this member is FALSE (the key is released).
            /// </summary>
            [MarshalAs(UnmanagedType.Bool)]
            public bool bKeyDown;

            /// <summary>
            /// The repeat count, which indicates that a key is being held down.
            /// For example, when a key is held down, you might get five events with this member equal to 1,
            /// one event with this member equal to 5, or multiple events with this member greater than or equal to 1.
            /// </summary>
            public ushort wRepeatCount;

            /// <summary>
            /// A virtual-key code that identifies the given key in a device-independent manner.
            /// </summary>
            public ushort wVirtualKeyCode;

            /// <summary>
            /// The virtual scan code of the given key that represents the device-dependent value generated by the keyboard hardware.
            /// </summary>
            public ushort wVirtualScanCode;

            /// <summary>
            /// A union of the Unicode and Ascii encodings.
            /// </summary>
            public CHAR_INFO_ENCODING uChar;

            /// <summary>
            /// The state of the control keys.
            /// </summary>
            public ControlKeyStates dwControlKeyState;
        }
    }
}
