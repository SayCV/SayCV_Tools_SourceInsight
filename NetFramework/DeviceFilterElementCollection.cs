public class DeviceFilterElementCollection : System.Configuration.ConfigurationElementCollection, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DeviceFilterElementCollection() {}

	// Methods
	public void Add(DeviceFilterElement deviceFilter) {}
	public void Remove(string name) {}
	public void Remove(DeviceFilterElement deviceFilter) {}
	public void RemoveAt(int index) {}
	public void Clear() {}
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void CopyTo(System.Configuration.ConfigurationElement[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public object[] AllKeys { get{} }
	public DeviceFilterElement Item { get{} }
	public DeviceFilterElement Item { get{} set{} }
	public System.Configuration.ConfigurationElementCollectionType CollectionType { get{} }
	public int Count { get{} }
	public bool EmitClear { get{} set{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

