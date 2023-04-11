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
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Firebase;
using Kingdox.UniFlux;
namespace Kingdox.UniFlux.Firebase
{
    public static partial class Key
    {
        public const string Initialize   = nameof(Firebase) + nameof(Initialize);
        public const string OnFirebaseAppIsReady = nameof(Firebase) + nameof(OnFirebaseAppIsReady);
        public const string Get = nameof(Firebase) + nameof(Get);
    }
    public sealed partial class FirebaseFlux : MonoFlux
    {
        private FirebaseApp app = default;
        private bool isAvailable = default;

        [Flux(Key.Initialize)] private async Task<bool> Initialize()
        {
            isAvailable = await FirebaseApp.CheckAndFixDependenciesAsync() == DependencyStatus.Available;
            app = isAvailable ? FirebaseApp.DefaultInstance : null;
            if (isAvailable)
            {
                Key.OnFirebaseAppIsReady.Dispatch();
            }
            return isAvailable;
        }

        [Flux(Key.Get)]private FirebaseApp Get_App()
        {
            if(app == null) Debug.LogWarning("[Module.Firebase]: App is null");
            return app;
        }
    }
}
