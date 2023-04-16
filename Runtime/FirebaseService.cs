/*
Copyright (c) 2023 Xavier Arpa López Thomas Peter ('Kingdox')

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kingdox.UniFlux;
using Firebase;
namespace Kingdox.UniFlux.Firebase
{
    public static partial class FirebaseService // Data
    {
        private static partial class Data
        {

        }
    }
    public static partial class FirebaseService // Key
    {
        public static partial class Key
        {
            private const string _FirebaseService =  nameof(FirebaseService) + ".";
            public const string Initialize   = _FirebaseService + nameof(Initialize);
            public const string OnFirebaseAppIsReady = _FirebaseService + nameof(OnFirebaseAppIsReady);
            public const string Get = _FirebaseService + nameof(Get);
        }
    }
    public static partial class FirebaseService // Methods
    {
        // public static void Example() => Key.Example.Dispatch();
    }
}