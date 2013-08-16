public class ModuleElement : System.Configuration.ConfigurationElement
{

	// Constructors
	public ModuleElement() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Type { get{} set{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

