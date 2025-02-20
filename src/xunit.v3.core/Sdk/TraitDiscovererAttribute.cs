using System;

namespace Xunit.Sdk;

/// <summary>
/// An attribute used to decorate classes which implement <see cref="ITraitAttribute"/>,
/// to indicate how trait values should be discovered. The discoverer type must implement
/// <see cref="ITraitDiscoverer"/>.
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
public sealed class TraitDiscovererAttribute : Attribute
{
	/// <summary>
	/// Initializes an instance of <see cref="TraitDiscovererAttribute"/>.
	/// </summary>
	/// <param name="typeName">The fully qualified type name of the discoverer
	/// (f.e., 'Xunit.Sdk.TraitDiscoverer')</param>
	/// <param name="assemblyName">The name of the assembly that the discoverer type
	/// is located in, without file extension (f.e., 'xunit.v3.core')</param>
	public TraitDiscovererAttribute(
		string typeName,
		string assemblyName)
	{ }

	/// <summary>
	/// Initializes an instance of <see cref="TraitDiscovererAttribute"/>.
	/// </summary>
	/// <param name="discovererType">The type of the trait discoverer</param>
	public TraitDiscovererAttribute(Type discovererType)
	{ }
}
