using System;
using System.Drawing;
using System.Collections.Generic;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils;



namespace DevExpress.MyControl
{
    public class MyRadioGroupViewInfo : RadioGroupViewInfo
    {
        public MyRadioGroupViewInfo(RepositoryItem item)
            : base(item)
        {
        }


        public override ToolTipControlInfo GetToolTipInfo(Point point)
        {
            ToolTipControlInfo resInfo = base.GetToolTipInfo(point);

            RepositoryItemMyRadioGroup ri = Item as RepositoryItemMyRadioGroup;
            if (ri.OwnerEdit != null)
            {
                for (int itemIndex = 0; itemIndex < Item.Items.Count; itemIndex++)
                {
                    Rectangle rect = ri.OwnerEdit.GetItemRectangle(itemIndex);
                    if (rect.Contains(point) && ri.Items[itemIndex].ToolTip != string.Empty)
                    {
                        resInfo = null;
                        resInfo = new ToolTipControlInfo(itemIndex, ri.Items[itemIndex].ToolTip);
                    }
                }
            }

            return resInfo;
        }
    }
}
