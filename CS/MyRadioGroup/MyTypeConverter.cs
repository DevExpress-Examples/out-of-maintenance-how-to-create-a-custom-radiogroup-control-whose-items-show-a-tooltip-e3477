using System;
using System.Reflection;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;




namespace DevExpress.MyControl
{
    public class MyRadioGroupItemTypeConverter : ExpandableObjectConverter
    {
        protected InstanceDescriptor GetInstanceDescriptor(object value)
        {
            MyRadioGroupItem item = (MyRadioGroupItem)value;
            ConstructorInfo ctor = null;
            object[] parameters = null;
            if (item.Value == null && item.Description == string.Empty && item.Enabled && item.ToolTip == string.Empty)
            {
                ctor = typeof(MyRadioGroupItem).GetConstructor(new Type[] { });
                parameters = new object[] { };
            }
            else
            {
                ctor = typeof(MyRadioGroupItem).GetConstructor(new Type[] { typeof(object), typeof(string), typeof(bool), typeof(string) });
                parameters = new object[] { item.Value, item.Description, item.Enabled, item.ToolTip };
            }
            return new InstanceDescriptor(ctor, parameters);
        }
    }
}

