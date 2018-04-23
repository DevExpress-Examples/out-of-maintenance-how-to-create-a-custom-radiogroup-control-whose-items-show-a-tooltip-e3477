using System;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;




namespace DevExpress.MyControl
{
   [TypeConverter(typeof(MyRadioGroupItemTypeConverter))]
    public class MyRadioGroupItem : RadioGroupItem
    {
        private string toolTip;


        [Browsable(true), Description("Gets or sets tooltip of the item.")]
        public string ToolTip
        {
            get { return toolTip; }
            set
            {
            	toolTip = value;
                this.ItemChanged();
            }
        }



		public MyRadioGroupItem() 
           : this(null, string.Empty, true, string.Empty)  
        {
        }



        public MyRadioGroupItem(object value, [Localizable(true)]string description) 
            : this(value, description, true, string.Empty) 
        { 
        }



        public MyRadioGroupItem(object value, [Localizable(true)]string description, bool enabled)
            : this(value, description, enabled, string.Empty)
        {
        }



        public MyRadioGroupItem(object value, [Localizable(true)]string description, bool enabled, string toolTip)
            : base(value, description, enabled)
        {
            this.toolTip = toolTip;
        }



        public override object Clone() 
        {
            return new MyRadioGroupItem(Value, Description, Enabled, ToolTip); 
        }
    }
}
