using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using System.Reflection;
using System.Runtime.CompilerServices;



namespace DevExpress.MyControl
{
    [ToolboxItem(true), DefaultEvent("SelectedIndexChanged"),
     Description("Supports the selection of one of several options.")
    ]
    public class MyRadioGroup : RadioGroup
    {
        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemMyRadioGroup.EDITORTypeName;
            }
        }



        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyRadioGroup Properties
        {
            get
            {
                return base.Properties as RepositoryItemMyRadioGroup;
            }
        }



        static MyRadioGroup()
        {
            RepositoryItemMyRadioGroup.RegisterMyRadioGroup();
        }



        public MyRadioGroup()
            : base()
        {
        }
    }
}

