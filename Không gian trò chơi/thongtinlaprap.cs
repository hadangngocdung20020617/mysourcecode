﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: Title("Không_gian_trò_chơi")]
[assembly: AssemblyDescription("")]
[assembly: Configuration("")]
[assembly: Company("")]
[assembly: Product("AirSpace")]
[assembly: AssemblyCopyright("Copyright ©  2019")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("bfad5357-eb54-4e69-a5ec-b075e5a2c66c")]

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
[assembly: Version("1.0.0.0")]
[assembly: FileVersion("1.0.0.0")]

internal class TitleAttribute : Attribute
{
    public TitleAttribute(string v)
    {
    }
}

internal class ConfigurationAttribute : Attribute
{
    public ConfigurationAttribute(string v)
    {
    }
}

internal class CompanyAttribute : Attribute
{
    public CompanyAttribute(string v)
    {
    }
}

internal class ProductAttribute : Attribute
{
    public ProductAttribute(string v)
    {
    }
}

internal class VersionAttribute : Attribute
{
    public VersionAttribute(string v)
    {
    }
}

internal class FileVersionAttribute : Attribute
{
    public FileVersionAttribute(string v)
    {
    }
}