
global using System;
global using System.Collections.Generic;
global using System.Diagnostics.Contracts;
global using System.Linq;
global using System.Runtime.CompilerServices;
global using Windows.Foundation;
global using Windows.Media.Casting;
global using System.IO;
global using System.Threading;
global using System.Threading.Tasks;

#if WINDOWS_UWP || NETSTANDARD2_0
global using Windows.UI.Composition;
global using Windows.UI.Xaml;
global using Windows.UI.Xaml.Controls;
global using Windows.UI.Xaml.Media;
global using Windows.UI.Xaml.Media.Imaging;
#endif

#if NETCOREAPP
global using Microsoft.UI.Composition;
global using Microsoft.UI.Xaml;
global using Microsoft.UI.Xaml.Controls;
global using Microsoft.UI.Xaml.Media;
global using Microsoft.UI.Xaml.Media.Imaging;
#endif