using DevExpress.ExpressApp;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using MyXPOClassLibrary;

namespace WinSolution.Module {
    public sealed partial class WinSolutionModule : ModuleBase {
        public WinSolutionModule() {
            InitializeComponent();
        }
        public override void CustomizeTypesInfo(DevExpress.ExpressApp.DC.ITypesInfo typesInfo) {
            base.CustomizeTypesInfo(typesInfo);
            typesInfo.FindTypeInfo(typeof(PersistentObject1)).AddAttribute(new DevExpress.Persistent.Base.DefaultClassOptionsAttribute());

            //Dennis: simple creation of a new member.
            typesInfo.FindTypeInfo(typeof(PersistentObject1)).CreateMember("NewIntField", typeof(int));

            //Dennis: establishing a One-To-Many relationship between two classes.
            XPDictionary xpDictionary = XafTypesInfo.XpoTypeInfoSource.XPDictionary;
            if (xpDictionary.GetClassInfo(typeof(PersistentObject1)).FindMember("PersistentObject2s") == null) {
                xpDictionary.GetClassInfo(typeof(PersistentObject1)).CreateMember("PersistentObject2s", typeof(XPCollection<PersistentObject2>), true,
                    new AggregatedAttribute(), new AssociationAttribute("PersistentObject1-PersistentObject2s", typeof(PersistentObject2)));
            }
            if (xpDictionary.GetClassInfo(typeof(PersistentObject2)).FindMember("PersistentObject1") == null) {
                xpDictionary.GetClassInfo(typeof(PersistentObject2)).CreateMember("PersistentObject1", typeof(PersistentObject1), new AssociationAttribute("PersistentObject1-PersistentObject2s"));
            }
            //Dennis: take special note of the fact that you have to refresh information about type, only if you made the changes in the XPDictionary. If you made the changes directly in the TypeInfo, refreshing is not necessary.
            XafTypesInfo.Instance.RefreshInfo(typeof(PersistentObject1));
            XafTypesInfo.Instance.RefreshInfo(typeof(PersistentObject2));
        }
    }
}
