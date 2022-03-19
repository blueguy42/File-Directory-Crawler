using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folder_Crawler_Algo
{
    // Ini mending file dipisah apa engga ya
    public class parentAndChild
    {
        string parentPath;
        string parentName;
        string[] childPath;
        string[] childName;

        public parentAndChild()
        {
            parentPath = "";
            parentName = "";
            childPath = new string[] { };
            childName = new string[] { };
        }

        public parentAndChild(string parentPath, string[] childPath)
        {
            this.parentPath = parentPath;   
            this.parentName = Path.GetFileName(parentPath); ; 
            this.childPath = childPath;
            this.childName = new string[] { };

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
    }

    class Algorithm
    {
        public static void RunAlgorithm(string fileName, string rootPath, Boolean findAllOccurrence, int algorithm, ref string[] targetPath, ref string[] dirPath, ref parentAndChild[] parentAndChildren)
        {
            /*
            parentAndChild = {{parent_path}, {parent_name}, {child_path}, {child_name}}
            */
                        

            //Change DFS or BFS
            BFSorDFS(algorithm, fileName, rootPath, ref targetPath, findAllOccurrence, ref dirPath, ref parentAndChildren);
            
            //Debugging
            dirPath = dirPath.Concat(new String[] { "===================================" }).ToArray();
            dirPath = dirPath.Concat(targetPath).ToArray();
                       
        }

        static void BFSorDFS(int algorithm, string fileName, string rootPath, ref string[] targetPath, Boolean findAllOccurrence, ref string[] dirPath, ref parentAndChild[] parentAndChildren)
        {
            String[] allDirPath = new string[] { };

            if (algorithm == 0)
            {
                getAllDirsBFS(rootPath, ref allDirPath, ref parentAndChildren);
            }
            else if (algorithm == 1)
            {
                getAllDirsDFS(rootPath, ref allDirPath, ref parentAndChildren);
            }
              ;

            foreach (var dir in allDirPath)
            {
                dirPath = dirPath.Concat(new String[] { dir }).ToArray();
                if (CheckFileInsideFolder(fileName, dir))
                {
                    //File exisst in root 
                    targetPath = targetPath.Concat(new String[] { Path.Combine(dir, fileName) }).ToArray();

                    if (!findAllOccurrence)
                    {
                        break; // To Stop after target found
                    }
                }
            }
        }
        static void getAllDirsDFS(String rootPath, ref String[] allDirs, ref parentAndChild[] parentAndChildren)
        {
            allDirs = new string[] { rootPath };
            List<string> tempDirs = allDirs.ToList();
           

            int i = 0;

            //List all of dirs by DFS
            while (i < tempDirs.Count)
            {
                String dir = tempDirs[i];
                String[] allNewDir = Directory.GetDirectories(dir);

                int j = 1;
                foreach (String newDir in allNewDir)
                {
                    tempDirs.Insert(i + j, newDir);
                    j++;
                }

                //Add to parent and child list
                if (allNewDir.Length != 0)
                {
                    parentAndChild newParentAndChild = new parentAndChild(dir, allNewDir);
                    parentAndChildren = parentAndChildren.Concat(new parentAndChild[] { newParentAndChild }).ToArray();
                }

                i++;
            }

            tempDirs.Insert(0, rootPath);

            allDirs = tempDirs.ToArray();
        }
        static void getAllDirsBFS(String rootPath, ref String[] allDirs, ref parentAndChild[] parentAndChildren)
        {
            allDirs = new string[] { rootPath };
            int i = 0;

            //List all of dirs by BFS
            while (i < allDirs.Length)
            {
                String dir = allDirs[i];
                String[] allNewDir = Directory.GetDirectories(dir);
                allDirs = allDirs.Concat(allNewDir).ToArray();

                //Add to parent and child list
                if (allNewDir.Length != 0)
                {
                    parentAndChild newParentAndChild = new parentAndChild(dir, allNewDir);
                    parentAndChildren = parentAndChildren.Concat(new parentAndChild[] { newParentAndChild }).ToArray();
                }

                i++;
            }
        }

        static Boolean CheckFileInsideFolder(String fileName, String path)
        {
            var files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                if (Path.GetFileName(file) == fileName)
                {
                    Console.WriteLine("Found");
                    return true;
                }
            }


            return false;
        }
    }
}
