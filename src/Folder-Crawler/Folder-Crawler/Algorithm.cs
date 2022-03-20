using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folder_Crawler_Algo
{
    // Ini mending file dipisah apa engga ya
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

    class Algorithm
    {
        public static void RunAlgorithm(string fileName, string rootPath, Boolean findAllOccurrence, int algorithm, ref string[] targetPath, ref treeNode[] parentAndChildren, ref long totalTime)
        {
            //Measure time
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            //Change DFS or BFS
            BFSorDFS(algorithm, fileName, rootPath, ref targetPath, findAllOccurrence, ref parentAndChildren);
            
            stopwatch.Stop();
            totalTime = stopwatch.ElapsedMilliseconds;
        }

        static void BFSorDFS(int algorithm, string fileName, string rootPath, ref string[] targetPath, Boolean findAllOccurrence, ref treeNode[] treeNodes)
        {
            String[] allDirPath = new string[] { };
            String[] allRootsPath = new string[] { };

            
            if (algorithm == 0)
            {
                getAllDirsBFS(rootPath, ref allDirPath, ref allRootsPath);
            }
            else if (algorithm == 1)
            {
                getAllDirsDFS(rootPath, ref allDirPath, ref allRootsPath);
            }
              
            //Check files
            //fileChecker(fileName, allDirPath, ref targetPath, findAllOccurrence);
           
            // Convert to treeNodes
            convertDirsToNodes(allDirPath, allRootsPath, ref treeNodes, findAllOccurrence, fileName);
        }

        
        static void getAllDirsDFS(String rootPath, ref String[] allDirs, ref String[] allRoots)
        {
            //Instantiate root dir path
            List<string> tempDirs = Directory.GetDirectories(rootPath).ToList();
            List<string> tempfiles = Directory.GetFiles(rootPath).ToList();
            List<string> tempRoots = new List<string>();
            List<bool> isDir = new List<bool> {};

            foreach (string file in tempfiles)
            {
                tempRoots.Add(rootPath);
                isDir.Add(false);
            }
            foreach (string dir in tempDirs)
            {
                tempRoots.Add(rootPath);
                isDir.Add(true);
                tempfiles.Add(dir);
            }
            tempDirs = tempfiles;

            //for safety measure, incase of list inserting error
            tempDirs.Add("END"); 
            tempRoots.Add("END");
            isDir.Add(false);
                                                                                                        
            int i = 0; 
            //List all of dirs by DFS
            while (i < tempDirs.Count-1)
            {
                if (!isDir[i])
                {
                    i++;
                    continue;
                }
                String dir = tempDirs[i];
                String[] allNewDir = Directory.GetDirectories(dir);
                String[] allNewFiles = Directory.GetFiles(dir);

                int j = 1;           
                foreach (String newDir in allNewDir)
                {
                    //Directories
                    tempDirs.Insert(i + j, newDir);
                    //Roots
                    tempRoots.Insert(i + j, dir);
                    //IsDir
                    isDir.Insert(i + j, true);
                    j++;
                }
                foreach (String newFiles in allNewFiles)
                {
                    //Directories
                    tempDirs.Insert(i + j, newFiles);
                    //Roots
                    tempRoots.Insert(i + j, dir);
                    //IsDir
                    isDir.Insert(i + j, false);
                    j++;
                }

                i++;
            }

            //Add starting root
            tempDirs.Insert(0, rootPath);
            tempRoots.Insert(0, rootPath);
            
            //Removing safety net
            tempDirs.RemoveAt(tempDirs.Count - 1);

            //Returning back to array
            allDirs = tempDirs.ToArray();
            allRoots = tempRoots.ToArray();
        }

        static void getAllDirsBFS(String rootPath, ref String[] allDirs, ref String[] allRoots)
        {
            //Instantiate root dir path
            List<string> tempDirs = new List<string>();
            List<string> tempRoots = new List<string>();
            List<bool> isDir = new List<bool>();

            tempDirs.Add(rootPath);
            tempRoots.Add(rootPath);
            isDir.Add(true);

            int i = 0;
            //List all of dirs by DFS
            while (i < tempDirs.Count)
            {
                if(!isDir[i])
                {
                    i++;
                    continue;
                }
                String dir = tempDirs[i];
                String[] allNewDir = Directory.GetDirectories(dir);
                String[] allNewFiles = Directory.GetFiles(dir);

                foreach (String newFile in allNewFiles)
                {
                    //Directories
                    tempDirs.Add(newFile);
                    //Roots
                    tempRoots.Add(dir);
                    //IsDir
                    isDir.Add(false);
                }

                foreach (String newDir in allNewDir)
                {
                    //Directories
                    tempDirs.Add(newDir);
                    //Roots
                    tempRoots.Add(dir);
                    //isDir
                    isDir.Add(true);
                }

                i++;
            }

            //Returning back to array
            allDirs = tempDirs.ToArray();
            allRoots = tempRoots.ToArray();
        }

        static void convertDirsToNodes(string[] tempDirs, string[] tempRoots, ref treeNode[] treeNodes, bool findAllOccurrenc, string fileName)
        {
            //Instantiate tree nodes from dirs in root path
            List<treeNode> newTreeNodes = new List<treeNode>();
            newTreeNodes.Add(new treeNode(tempRoots[0], Directory.GetDirectories(tempRoots[0]).ToArray(), 0, false));
            newTreeNodes.Add(new treeNode("END", new string[] { "END" }, -1, false));  //for safety measure, incase of list inserting error

            //Check files in root path
            string currRootPath = tempRoots[0];
            int i = 1;

            //List all of dirs by DFS
            while (i < tempDirs.Length && i > 0)
            {
                String dir = tempDirs[i];
                String root = tempRoots[i];

                if (currRootPath != root)
                {
                    newTreeNodes.Insert(newTreeNodes.Count - 1, new treeNode(root, Directory.GetDirectories(root).ToArray(), 0, false));
                    currRootPath = tempRoots[i];

                    /*
                    //Add all files inn dir
                    var files = Directory.GetFiles(root);
                    foreach (string file in files)
                    {
                        // Add checked files to parentAndChildren
                        treeNode newParentAndChild = new treeNode(root, new string[] { file }, 1, true);
                        newTreeNodes.Insert(newTreeNodes.Count - 1, newParentAndChild);

                        //Find all occurence
                        if (Path.GetFileName(file) == fileName && !findAllOccurrenc)
                        {
                            i = -999;
                            break;
                        }
                    }
                    */
                }
                newTreeNodes.Insert(newTreeNodes.Count - 1, new treeNode(root, new string[] { dir }, 1, false));


                i++;
            }

            //newTreeNodes.Insert(0, new treeNode(tempRoots[0], Directory.GetDirectories(tempRoots[0]), 0, false));
            newTreeNodes.RemoveAt(newTreeNodes.Count - 1);
            treeNodes = newTreeNodes.ToArray();
        }

        static void fileChecker(string fileName, string[] allDirPath, ref string[] targetPath, bool findAllOccurrence)
        {
            // Check files
            foreach (var dir in allDirPath)
            {
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
