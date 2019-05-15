<!-- default file list -->
*Files to look at*:

* [PersistentObject1.cs](./CS/MyXPOClassLibrary/PersistentObject1.cs) (VB: [PersistentObject1.vb](./VB/MyXPOClassLibrary/PersistentObject1.vb))
* [PersistentObject2.cs](./CS/MyXPOClassLibrary/PersistentObject2.cs) (VB: [PersistentObject2.vb](./VB/MyXPOClassLibrary/PersistentObject2.vb))
* [Module.cs](./CS/WinSolution.Module/Module.cs) (VB: [Module.vb](./VB/WinSolution.Module/Module.vb))
<!-- default file list end -->
# How to customize an XPO business model at runtime (Example)

Sometimes there is a requirement to extend existing business classes when you cannot modify their source code.

For instance, you have an assembly where some persistent classes are declared. You want to use it in your XAF application and add attributes, new members, etc..

To use types from external assemblies, add them to the [ModuleBase.AdditionalExportedTypes](https://documentation.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ModuleBase.AdditionalExportedTypes.property) collection, or use the **Exported Types** section of the [Module Designer](https://documentation.devexpress.com/eXpressAppFramework/112828/Design-Time-Features/Module-Designer).

To learn how to extend business classes at runtime, refer to the [eXpressApp Framework > Concepts > Business Model Design > Types Info Subsystem > Use Metadata to Customize Business Classes Dynamically](https://documentation.devexpress.com/eXpressAppFramework/113583/Concepts/Business-Model-Design/Types-Info-Subsystem/Use-Metadata-to-Customize-Business-Classes-Dynamically) article.

This example demonstrates how to:
- Add an attribute to an existing class
- Create a new simple persistent property
- Create new reference and collection properties linked by an association

### Important notes

1. By design you cannot dynamically add or remove the *OptimisticLocking* and *DeferredDeletion* attributes.
2. Adding custom members for Domain Components (DC) should be done on the *XafApplication.SettingUp* event as described in [How do I define a custom member for a domain component (DC) at runtime?](https://www.devexpress.com/Support/Center/p/S34769).
3. In XAF versions prior to 15.1.4, you cannot dynamically establish an association between two persistent classes via the XafTypesInfo API. Use the [XPDictionary API](https://www.devexpress.com/Support/Center/Example/Details/E5139/) instead.

### See also:
[How to: Access Business Class Metadata](https://www.devexpress.com/Support/Center/p/E1649)
