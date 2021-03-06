﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Synapse Network Core Library")]
[assembly: AssemblyDescription("Network handler facade")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCompany("Synapse Project Contributor(s)")]
[assembly: AssemblyProduct("Synapse: network handler interfaces and classes")]
[assembly: AssemblyCopyright("Copyright © Zoltan Juhasz, 2004-2019")]
[assembly: AssemblyTrademark("Forge")]
//[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
//[assembly: CLSCompliant(true)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("b3a837dc-275c-40ef-a3a2-ff4f1e810f49")]

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
[assembly: AssemblyVersion("4.0.0.7")]
[assembly: AssemblyFileVersion("4.0.0.7")]
[assembly: AssemblyInformationalVersion("4.0.0.7")]
[assembly: AllowPartiallyTrustedCallers]

[assembly: SecurityRules(SecurityRuleSet.Level1, SkipVerificationInFullTrust = true)]
