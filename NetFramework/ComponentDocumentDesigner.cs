public class ComponentDocumentDesigner : System.ComponentModel.Design.ComponentDesigner, System.ComponentModel.Design.ITreeDesigner, System.ComponentModel.Design.IDesigner, System.IDisposable, System.ComponentModel.Design.IDesignerFilter, System.ComponentModel.Design.IComponentInitializer, System.ComponentModel.Design.IRootDesigner, System.Drawing.Design.IToolboxUser, IOleDragClient, System.ComponentModel.Design.ITypeDescriptorFilterService
{

	// Constructors
	public ComponentDocumentDesigner() {}

	// Methods
	public virtual void Initialize(System.ComponentModel.IComponent component) {}
	public virtual void Dispose() {}
	public virtual void DoDefaultAction() {}
	public virtual void InitializeExistingComponent(System.Collections.IDictionary defaultValues) {}
	public virtual void InitializeNewComponent(System.Collections.IDictionary defaultValues) {}
	public virtual void InitializeNonDefault() {}
	public virtual void OnSetComponentDefaults() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Windows.Forms.Control Control { get{} }
	public bool TrayAutoArrange { get{} set{} }
	public bool TrayLargeIcon { get{} set{} }
	public System.ComponentModel.Design.DesignerActionListCollection ActionLists { get{} }
	public System.Collections.ICollection AssociatedComponents { get{} }
	public System.ComponentModel.IComponent Component { get{} }
	public System.ComponentModel.Design.DesignerVerbCollection Verbs { get{} }
}

