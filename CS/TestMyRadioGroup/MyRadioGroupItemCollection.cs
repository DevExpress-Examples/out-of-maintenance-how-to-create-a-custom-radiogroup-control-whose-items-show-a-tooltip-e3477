using System;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;



namespace TestMyRadioGroup
{
    [ListBindable(false)]
    public class MyRadioGroupItemCollection : RadioGroupItemCollection
    {
        public new MyRadioGroupItem this[int index]
        {
            get { return List[index] as MyRadioGroupItem; }
            set { List[index] = value; }
        }


        public MyRadioGroupItemCollection()
            : base()
        {
        }
   }
}
