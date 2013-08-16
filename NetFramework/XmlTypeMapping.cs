public class XmlTypeMapping : XmlMapping
{

	// Methods
	public void SetKey(string key) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string TypeName { get{} }
	public string TypeFullName { get{} }
	public string XsdTypeName { get{} }
	public string XsdTypeNamespace { get{} }
	public string ElementName { get{} }
	public string XsdElementName { get{} }
	public string Namespace { get{} }
}

