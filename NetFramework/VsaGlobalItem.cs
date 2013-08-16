public class VsaGlobalItem : VsaItem, Microsoft.Vsa.IVsaItem, Microsoft.Vsa.IVsaGlobalItem
{

	// Methods
	public virtual object GetOption(string Name) {}
	public virtual void SetOption(string Name, object value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string TypeString { set{} }
	public bool ExposeMembers { get{} set{} }
	public Microsoft.Vsa.IVsaItem _item { get{} set{} }
	public string Name { get{} set{} }
	public Microsoft.Vsa.VsaItemType ItemType { get{} }
	public bool IsDirty { get{} }
}

