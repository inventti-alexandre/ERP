using System.Collections.Generic;

namespace DomainLayer.App_Model.JsTree
{
    public class JsTreeNode
    {
        public string id { set; get; } // نام اين خواص بايد با مستندات هماهنگ باشد
        public string text { set; get; }
        public string icon { set; get; }

        public string type { set; get; }
        public JsTreeNodeState state { set; get; }
        public List<JsTreeNode> children { set; get; }
        public JsTreeNodeLiAttributes li_attr { set; get; }
        public JsTreeNodeAAttributes a_attr { set; get; }

        public JsTreeNode()
        {
            state = new JsTreeNodeState();
            children = new List<JsTreeNode>();
            li_attr = new JsTreeNodeLiAttributes();
            a_attr = new JsTreeNodeAAttributes();
        }
    }


    public class JsTreeNodeAAttributes
    {
        // به هر تعداد و نام اختياري مي‌توان خاصيت تعريف كرد
        public string href { set; get; }
    }

    public class JsTreeNodeLiAttributes
    {
        // به هر تعداد و نام اختياري مي‌توان خاصيت تعريف كرد
        public string data { set; get; }
    }

    public class JsTreeNodeState
    {
        public bool opened { set; get; }
        public bool disabled { set; get; }
        public bool selected { set; get; }

        public JsTreeNodeState()
        {
            opened = true;
        }
    }


}
