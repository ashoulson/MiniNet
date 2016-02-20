﻿/*
 *  MiniUDP - A Simple UDP Layer for Shipping and Receiving Byte Arrays
 *  Copyright (c) 2015-2016 - Alexander Shoulson - http://ashoulson.com
 *
 *  This software is provided 'as-is', without any express or implied
 *  warranty. In no event will the authors be held liable for any damages
 *  arising from the use of this software.
 *  Permission is granted to anyone to use this software for any purpose,
 *  including commercial applications, and to alter it and redistribute it
 *  freely, subject to the following restrictions:
 *  
 *  1. The origin of this software must not be misrepresented; you must not
 *     claim that you wrote the original software. If you use this software
 *     in a product, an acknowledgment in the product documentation would be
 *     appreciated but is not required.
 *  2. Altered source versions must be plainly marked as such, and must not be
 *     misrepresented as being the original software.
 *  3. This notice may not be removed or altered from any source distribution.
*/

using System;
using System.Diagnostics;

namespace MiniUDP
{
  public class NetTime
  {
    private static readonly long start = Stopwatch.GetTimestamp();
    private static readonly double frequency = 
      1.0 / (double)Stopwatch.Frequency;

    /// <summary>
    /// Time represented as elapsed seconds.
    /// </summary>
    public static double Time
    {
      get
      {
        long diff = Stopwatch.GetTimestamp() - start;
        return (double)diff * frequency;
      }
    }
  }
}
