﻿/*============================================================================
 * Copyright (C) Microsoft Corporation, All rights reserved.
 *============================================================================
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Microsoft.Management.Infrastructure.Generic;
using Microsoft.Management.Infrastructure.Internal;
using Microsoft.Management.Infrastructure.Internal.Data;
using Microsoft.Management.Infrastructure.Native;
using Microsoft.Management.Infrastructure.Serialization;
using System.IO;

namespace Microsoft.Management.Infrastructure.Internal
{
    internal static class ValueHelpers
    {
        internal static void ThrowIfMismatchedType(MI_Type type, object managedValue)
        {
            // TODO: Implement this
            /*
              MI_Value throwAway;
              memset(&throwAway, 0, sizeof(MI_Value));
              IEnumerable<DangerousHandleAccessor^>^ dangerousHandleAccesorsFromConversion = nullptr;
              try
              {
              dangerousHandleAccesorsFromConversion = ConvertToMiValue(type, managedValue, &throwAway);
              }
              finally
              {
              ReleaseMiValue(type, &throwAway, dangerousHandleAccesorsFromConversion);
              }
            */
        }
    }
}