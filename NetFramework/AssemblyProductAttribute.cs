public class AssemblyProductAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public AssemblyProductAttribute(string product) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Product { get{} }
	public object TypeId { get{} }
}

