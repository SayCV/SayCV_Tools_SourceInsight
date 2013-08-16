public class ConstructPlatformPieceDelegate : System.MulticastDelegate, System.ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public ConstructPlatformPieceDelegate(object object, System.IntPtr method) {}

	// Methods
	public virtual PlatformPiece Invoke(string platformDetectionErrorMsg, System.Uri supportUrl, System.Threading.ManualResetEvent modalEvent) {}
	public virtual System.IAsyncResult BeginInvoke(string platformDetectionErrorMsg, System.Uri supportUrl, System.Threading.ManualResetEvent modalEvent, System.AsyncCallback callback, object object) {}
	public virtual PlatformPiece EndInvoke(System.IAsyncResult result) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual bool Equals(object obj) {}
	public virtual System.Delegate[] GetInvocationList() {}
	public virtual int GetHashCode() {}
	public object DynamicInvoke(object[] args) {}
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public System.Reflection.MethodInfo Method { get{} }
	public object Target { get{} }
}

