#if !UNITY_WINRT || UNITY_EDITOR || (UNITY_WP8 &&  !UNITY_WP_8_1)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
    [Preserve]
    public delegate void NotifyCollectionChangedEventHandler(Object sender, NotifyCollectionChangedEventArgs e);
}

#endif