﻿using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Forge.DatabaseManagement.SqlServerCe40")]
[assembly: AssemblyDescription("Forge Patterns and Practices")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCompany("Forge Project Contributor(s)")]
[assembly: AssemblyProduct("Forge: reference, practice and patterns implementations and helper(s)")]
[assembly: AssemblyCopyright("Copyright © Zoltan Juhasz, 2004-2019")]
[assembly: AssemblyTrademark("Forge")]
//[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("3272bbd5-1e0f-42ba-95d8-4b23f3564d65")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.1.5")]
[assembly: AssemblyFileVersion("1.0.1.5")]
[assembly: AssemblyInformationalVersion("1.0.1.5")]
[assembly: AllowPartiallyTrustedCallers]

[assembly: SecurityRules(SecurityRuleSet.Level1, SkipVerificationInFullTrust = true)]
