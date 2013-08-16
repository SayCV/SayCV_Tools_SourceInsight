public class ObjectDataSourceDesigner : System.Web.UI.Design.DataSourceDesigner, System.ComponentModel.Design.ITreeDesigner, System.ComponentModel.Design.IDesigner, System.IDisposable, System.ComponentModel.Design.IDesignerFilter, System.ComponentModel.Design.IComponentInitializer, System.Web.UI.Design.IDataSourceDesigner
{

	// Constructors
	public ObjectDataSourceDesigner() {}

	// Methods
	public virtual void Configure() {}
	public virtual System.Web.UI.Design.DesignerDataSourceView GetView(string viewName) {}
	public virtual string[] GetViewNames() {}
	public virtual void RefreshSchema(bool preferSilent) {}
	public virtual string GetDesignTimeHtml() {}
	public virtual void ResumeDataSourceEvents() {}
	public virtual void SuppressDataSourceEvents() {}
	public System.Drawing.Rectangle GetBounds() {}
	public virtual string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) {}
	public virtual string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) {}
	public virtual string GetPersistInnerHtml() {}
	public virtual string GetPersistenceContent() {}
	public void Localize(System.Web.UI.Design.IDesignTimeResourceWriter resourceWriter) {}
	public System.Web.UI.Design.ViewRendering GetViewRendering() {}
	public virtual void Initialize(System.ComponentModel.IComponent component) {}
	public void Invalidate() {}
	public void Invalidate(System.Drawing.Rectangle rectangle) {}
	public bool IsPropertyBound(string propName) {}
	public virtual void OnAutoFormatApplied(System.Web.UI.Design.DesignerAutoFormat appliedAutoFormat) {}
	public virtual void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) {}
	public virtual void OnComponentChanging(object sender, System.ComponentModel.Design.ComponentChangingEventArgs ce) {}
	public void RaiseResizeEvent() {}
	public void RegisterClone(object original, object clone) {}
	public virtual void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) {}
	public virtual void UpdateDesignTimeHtml() {}
	public virtual void OnSetParent() {}
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
	public bool CanConfigure { get{} }
	public bool CanRefreshSchema { get{} }
	public string SelectMethod { get{} set{} }
	public string TypeName { get{} set{} }
	public System.ComponentModel.Design.DesignerActionListCollection ActionLists { get{} }
	public bool AllowResize { get{} }
	public System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get{} }
	public bool DesignTimeHtmlRequiresLoadComplete { get{} }
	public string ID { get{} set{} }
	public bool IsDirty { get{} set{} }
	public bool ViewControlCreated { get{} set{} }
	public bool ReadOnly { get{} set{} }
	public System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get{} }
	public System.Web.UI.Control ViewControl { get{} set{} }
	public System.Web.UI.Design.IHtmlControlDesignerBehavior Behavior { get{} set{} }
	public System.Web.UI.DataBindingCollection DataBindings { get{} }
	public System.Web.UI.ExpressionBindingCollection Expressions { get{} }
	public bool ShouldCodeSerialize { get{} set{} }
	public System.Collections.ICollection AssociatedComponents { get{} }
	public System.ComponentModel.IComponent Component { get{} }
	public System.ComponentModel.Design.DesignerVerbCollection Verbs { get{} }

	// Events
	public event System.EventHandler DataSourceChanged;
	public event System.EventHandler SchemaRefreshed;
}
