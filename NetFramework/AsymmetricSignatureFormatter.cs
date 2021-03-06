public class AsymmetricSignatureFormatter
{

	// Methods
	public abstract virtual void SetKey(AsymmetricAlgorithm key) {}
	public abstract virtual void SetHashAlgorithm(string strName) {}
	public virtual byte[] CreateSignature(HashAlgorithm hash) {}
	public abstract virtual byte[] CreateSignature(byte[] rgbHash) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

