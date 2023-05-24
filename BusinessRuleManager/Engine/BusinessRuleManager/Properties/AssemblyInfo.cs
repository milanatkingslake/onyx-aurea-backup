using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.EnterpriseServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Business Rule Manager")]
[assembly: AssemblyDescription("Core Business Rule Manager")]
[assembly: AssemblyCompany("AVOLIN")]
[assembly: AssemblyProduct("Onyx Business Rule Manager")]
[assembly: AssemblyCopyright("Copyright © Avolin 2020. All rights reserved.")]
[assembly: AssemblyTrademark("Onyx is a registered trademark of Avolin.")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(true)]

// Configure the COM+ application that contains the component
[assembly: ApplicationNameAttribute("BusinessRuleManager")]
[assembly: Guid("994e04bf-3014-418b-a10f-6764489fad81")]
[assembly: Description("Consona CRM Business Rule Manager")]
[assembly: ApplicationActivationAttribute(ActivationOption.Server)]
[assembly: ApplicationAccessControl(true,
									AccessChecksLevel = AccessChecksLevelOption.ApplicationComponent,
									Authentication = AuthenticationOption.Packet)]
[assembly: SecurityRole("BusinessRuleOnyx")]
[assembly: SecurityRole("BusinessRulePublic")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("7.9.0.0")]
[assembly: AssemblyFileVersion("7.9.0.0")]
[assembly: AssemblyInformationalVersion("7.9.0.0")]