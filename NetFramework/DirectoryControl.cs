public class DirectoryControl
{

	// Constructors
	public DirectoryControl(string type, byte[] value, bool isCritical, bool serverSide) {}

	// Methods
	public virtual byte[] GetValue() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Type { get{} }
	public bool IsCritical { get{} set{} }
	public bool ServerSide { get{} set{} }
}

