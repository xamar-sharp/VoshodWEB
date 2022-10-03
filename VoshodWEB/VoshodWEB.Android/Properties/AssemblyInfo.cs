using System.Reflection;
using System.Runtime.InteropServices;
using Android.App;
using Xamarin.Forms;
using VoshodWEB;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("VoshodWEB")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("dreamwalkers")]
[assembly: AssemblyProduct("VoshodWEB")]
[assembly: AssemblyCopyright("Copyright ©  2022")]
[assembly: AssemblyTrademark("net")]
[assembly: AssemblyCulture("en")]
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Add some common permissions, these can be removed if not needed
[assembly: UsesPermission(Android.Manifest.Permission.Internet)]
[assembly: UsesPermission(Android.Manifest.Permission.WriteExternalStorage)]

// Export renderers
[assembly: ExportRenderer(typeof(TextView), typeof(VoshodWEB.Droid.TextViewRenderer))]

// Dependencies implementation
[assembly: Dependency(typeof(VoshodWEB.Droid.AndroidPlatformInfo))] 