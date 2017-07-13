﻿////////////////////////////////////////////////////////////////////////////
//
// Copyright 2017 Rubius
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
////////////////////////////////////////////////////////////////////////////

using System;

namespace Realmius
{
    public interface ILogger
    {
        void Exception(Exception ex, string text = null);
        void Info(string text);
        void Debug(string text);
    }

    internal class Logger : ILogger
    {
        public static Logger Log { get; } = new Logger();

        public void Exception(Exception ex, string text = null)
        {
            System.Diagnostics.Debug.WriteLine($"Exception: {ex}, {text}");
        }

        public void Info(string text)
        {
            System.Diagnostics.Debug.WriteLine(text);
        }

        public void Debug(string text)
        {
            System.Diagnostics.Debug.WriteLine(text);
        }
    }
}
