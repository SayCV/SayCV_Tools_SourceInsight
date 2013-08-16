public class ResXResourceSet : ResourceSet, System.IDisposable, System.Collections.IEnumerable
{

	// Constructors
	public ResXResourceSet(string fileName) {}
	public ResXResourceSet(System.IO.Stream stream) {}

	// Methods
	public virtual Type GetDefaultReader() {}
	public virtual Type GetDefaultWriter() {}
	public virtual void Close() {}
	public virtual void Dispose() {}
	public virtual System.Collections.IDictionaryEnumerator GetEnumerator() {}
	public virtual string GetString(string name) {}
	public virtual string GetString(string name, bool ignoreCase) {}
	public virtual object GetObject(string name) {}
	public virtual object GetObject(string name, bool ignoreCase) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

