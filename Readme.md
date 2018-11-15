<!-- default file list -->
*Files to look at*:

* [PersistentObject1.cs](./CS/MyXPOClassLibrary/PersistentObject1.cs) (VB: [PersistentObject1.vb](./VB/MyXPOClassLibrary/PersistentObject1.vb))
* [PersistentObject2.cs](./CS/MyXPOClassLibrary/PersistentObject2.cs) (VB: [PersistentObject2.vb](./VB/MyXPOClassLibrary/PersistentObject2.vb))
* [Module.cs](./CS/WinSolution.Module/Module.cs) (VB: [Module.vb](./VB/WinSolution.Module/Module.vb))
<!-- default file list end -->
# How to customize an XPO business model at runtime (Example)


<p>Sometimes there is a requirement to extend existing business classes from other libraries, add new members, etc.</p>
<p>For instance, you have an assembly where you have declared your persistent classes. Now, you want to use these classes in your XAF application.</p>
<p>Note that to use the types from external assemblies, you should add them to your business model. To do that, you should use the Business Classes section of the <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2828"><u>Module Designer</u></a>.</p>
<p><br /> For instance, to force XAF to create navigation items for business classes, usually you can mark them with the DevExpress.Persistent.Base.DefaultClassOptionsAttribute, but what to do if your classes "live" in a separate assembly, which has no references to DevExpress.ExpressApp assemblies.</p>
<p>What to do? In this instance, <a href="http://documentation.devexpress.com/#Xaf/CustomDocument3224"><u>the XafTypesInfo / XPDictionary customization</u></a> may be helpful. Currently in XAF using this approach, you can add new attributes to your classes and their members, declare new associations, etc. The only thing, which is not currently supported in XAF, by default, is the capability to declare new classes "on the fly" via customization of the XafTypesInfo / XPDictionary. <u></u></p>
<p><u></u><strong>IMPORTANT NOTES</strong></p>
<p>1. By design you cannot dynamically add or remove the OptimisticLocking and DeferredDeletion attributes.<br />2. Adding custom members for Domain Components (DC) should be done on the <em>XafApplication.SettingUp</em> event as described at <a href="https://www.devexpress.com/Support/Center/p/S34769">How do I define a custom member for a domain component (DC) at runtime?</a>.</p>
<p>3. For XAF versions older than 15.1.4 you cannot dynamically establish an association between two persistent classes via the XafTypesInfo API. Use the XPDictionary API instead as shown in this example.</p>
<p>Starting with <strong>v15.1.4</strong>, use the solution described in the <a href="https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument113583">eXpressApp Framework > Concepts > Business Model Design > Types Info Subsystem > Customize Business Object's Metadata > Create Associations in Code</a> article.</p>
<p><br /> <strong>See also:<br /> </strong><a href="https://www.devexpress.com/Support/Center/p/E1649">How to: Access Business Class Metadata</a></p>

<br/>


