using System.Runtime.Serialization;
using System;

public class VersionDeserializationBinder : SerializationBinder
{
	public override Type BindToType(string assemblyName, string typeName)
	{
		return default(Type);
	}

}
