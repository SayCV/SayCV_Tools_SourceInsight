public class DeviceSpecific : System.Web.UI.Control, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor
{

	// Constructors
	public DeviceSpecific() {}

	// Methods
	public System.Web.UI.ITemplate GetTemplate(string templateName) {}
	public virtual void ApplyStyleSheetSkin(System.Web.UI.Page page) {}
	public virtual void DataBind() {}
	public virtual void Focus() {}
	public virtual void RenderControl(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void Dispose() {}
	public string ResolveUrl(string relativeUrl) {}
	public virtual string ResolveClientUrl(string relativeUrl) {}
	public virtual System.Web.UI.Control FindControl(string id) {}
	public virtual bool HasControls() {}
	public void SetRenderMethodDelegate(System.Web.UI.RenderMethod renderMethod) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Owner { get{} }
	public DeviceSpecificChoiceCollection Choices { get{} }
	public bool HasTemplates { get{} }
	public DeviceSpecificChoice SelectedChoice { get{} }
	public MobilePage MobilePage { get{} }
	public bool Visible { get{} set{} }
	public bool EnableViewState { get{} set{} }
	public string ClientID { get{} }
	public string ID { get{} set{} }
	public bool EnableTheming { get{} set{} }
	public string SkinID { get{} set{} }
	public System.Web.UI.Control NamingContainer { get{} }
	public System.Web.UI.Control BindingContainer { get{} }
	public System.Web.UI.Page Page { get{} set{} }
	public System.Web.UI.TemplateControl TemplateControl { get{} set{} }
	public System.Web.UI.Control Parent { get{} }
	public string TemplateSourceDirectory { get{} }
	public string AppRelativeTemplateSourceDirectory { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public string UniqueID { get{} }
	public System.Web.UI.ControlCollection Controls { get{} }

	// Events
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler Unload;
	public event System.EventHandler PreRender;
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
}

