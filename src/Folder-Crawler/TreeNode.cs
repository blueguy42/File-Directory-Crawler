using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeNodes
{
    public class treeNode
    {
        string parentPath;
        string parentName;
        string[] childPath;
        string[] childName;
        int check;
        bool isFile;

        public treeNode()
        {
            parentPath = "";
            parentName = "";
            childPath = new string[] { };
            childName = new string[] { };
            check = 0;
            isFile = false;
        }

        public treeNode(string parentPath, string[] childPath, int check, bool isFile)
        {
            this.parentPath = parentPath;
            this.parentName = Path.GetFileName(parentPath); ;
            this.childPath = childPath;
            this.childName = new string[] { };
            this.check = check;
            this.isFile = isFile;

            foreach (var child in childPath)
            {
                this.childName = this.childName.Concat(new String[] { Path.GetFileName(child) }).ToArray();
            }
        }

        public string getParentPath()
        {
            return this.parentPath;
        }

        public string getParentName()
        {
            return this.parentName;
        }

        public string[] getChildPath()
        {
            return this.childPath;
        }
        public string[] getChildName()
        {
            return this.childName;
        }

        public int getCheck()
        {
            return this.check;
        }
    }


}
