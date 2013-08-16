public class LdapException : DirectoryException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public LdapException() {}
	public LdapException(string message) {}
	public LdapException(string message, System.Exception inner) {}
	public LdapException(int errorCode) {}
	public LdapException(int errorCode, string message) {}
	public LdapException(int errorCode, string message, string serverErrorMessage) {}
	public LdapException(int errorCode, string message, System.Exception inner) {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) {}
	public virtual System.Exception GetBaseException() {}
	public virtual string ToString() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ErrorCode { get{} }
	public string ServerErrorMessage { get{} }
	public PartialResultsCollection PartialResults { get{} }
	public string Message { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

