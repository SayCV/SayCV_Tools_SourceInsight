public class RuntimeWrappedException : System.Exception, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual System.Exception GetBaseException() {}
	public virtual string ToString() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object WrappedException { get{} }
	public string Message { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

