public class SqlCacheDependencyDatabaseCollection : System.Configuration.ConfigurationElementCollection, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public SqlCacheDependencyDatabaseCollection() {}

	// Methods
	public void Add(SqlCacheDependencyDatabase name) {}
	public void Clear() {}
	public SqlCacheDependencyDatabase Get(int index) {}
	public SqlCacheDependencyDatabase Get(string name) {}
	public string GetKey(int index) {}
	public void Remove(string name) {}
	public void RemoveAt(int index) {}
	public void Set(SqlCacheDependencyDatabase user) {}
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void CopyTo(System.Configuration.ConfigurationElement[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string[] AllKeys { get{} }
	public SqlCacheDependencyDatabase Item { get{} }
	public SqlCacheDependencyDatabase Item { get{} set{} }
	public int Count { get{} }
	public bool EmitClear { get{} set{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public System.Configuration.ConfigurationElementCollectionType CollectionType { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

