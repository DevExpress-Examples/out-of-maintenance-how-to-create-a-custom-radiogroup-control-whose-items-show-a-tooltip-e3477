using System;
using System.ComponentModel;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors;



namespace DevExpress.MyControl
{
    [UserRepositoryItem("RegisterMyRadioGroup")]
    public class RepositoryItemMyRadioGroup : RepositoryItemRadioGroup
    {
        internal const string EDITORTypeName = "MyRadioGroup";
        public override string EditorTypeName
        {
            get
            {
                return EDITORTypeName;
            }
        }



        [Browsable(false)]
        public new MyRadioGroup OwnerEdit
        {
            get
            {
                return base.OwnerEdit as MyRadioGroup;
            }
        }



        [Description("Gets the collection of items displayed by the current radio group editor."), 
         Category(CategoryName.Data), 
         DesignerSerializationVisibility(DesignerSerializationVisibility.Content), 
         Editor("System.ComponentModel.Design.CollectionEditor, System.Design", typeof(System.Drawing.Design.UITypeEditor)), 
         Localizable(true)]
        public new MyRadioGroupItemCollection Items 
        {
            get { return base.Items as MyRadioGroupItemCollection; } 
        }



        static RepositoryItemMyRadioGroup()
        {
            RegisterMyRadioGroup();
        }



        public RepositoryItemMyRadioGroup()
            : base()
        {
        }



        public static void RegisterMyRadioGroup()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EDITORTypeName,
            typeof(MyRadioGroup), typeof(RepositoryItemMyRadioGroup),
            typeof(MyRadioGroupViewInfo), new RadioGroupPainter(), true, null));
        }


        protected override RadioGroupItemCollection CreateItemCollection()
        {
            return new MyRadioGroupItemCollection();
        }
    }

}
