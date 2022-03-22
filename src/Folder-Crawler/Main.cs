using System;
using System.Diagnostics;
using TreeNodes;

namespace Folder_Crawler_Algo
{
    // Ini mending file dipisah apa engga ya
    
    class Main
    {
        public static void RunAlgorithm(string fileName, string rootPath, Boolean findAllOccurrence, int algorithm, ref string[] targetPath, ref treeNode[] treeNodes, ref long totalTime)
        {
            //Measure time
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            //Change DFS or BFS
            string[] allDirPath = new string[] { };
            string[] allRootsPath = new string[] { };

            BFSorDFSAlgo.BFSorDFS(algorithm, fileName, rootPath, ref allDirPath,  ref allRootsPath, findAllOccurrence);

            //Check files
            fileChecker(fileName, allDirPath, ref targetPath, findAllOccurrence);

            // Convert to treeNodes
            convertDirsToNodes(allDirPath, allRootsPath, ref treeNodes, findAllOccurrence, fileName);

            stopwatch.Stop();
            totalTime = stopwatch.ElapsedMilliseconds;
        }

        
        static void convertDirsToNodes(string[] tempDirs, string[] tempRoots, ref treeNode[] treeNodes, bool findAllOccurrenc, string fileName)
        {
            //Instantiate tree nodes from dirs in root path
            List<treeNode> newTreeNodes = new List<treeNode>();
            string[] allNewRoots = Directory.GetDirectories(tempRoots[0]).ToArray();
            allNewRoots = allNewRoots.Concat(Directory.GetFiles(tempRoots[0])).ToArray();
            newTreeNodes.Add(new treeNode(tempRoots[0], allNewRoots, 0, false));
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
                    allNewRoots = Directory.GetDirectories(root).ToArray();
                    allNewRoots = allNewRoots.Concat(Directory.GetFiles(root)).ToArray();
                    newTreeNodes.Insert(newTreeNodes.Count - 1, new treeNode(root, allNewRoots, 0, false));
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
                if (Path.GetFileName(dir) == fileName && (!File.GetAttributes(dir).HasFlag(FileAttributes.Directory))) 
                {
                    newTreeNodes.Insert(newTreeNodes.Count - 1, new treeNode(root, new string[] { dir }, 2, true));
                    if (!findAllOccurrenc)
                    {
                        break;
                    }
                }


                i++;
            }

            //newTreeNodes.Insert(0, new treeNode(tempRoots[0], Directory.GetDirectories(tempRoots[0]), 0, false));
            newTreeNodes.RemoveAt(newTreeNodes.Count - 1);
            treeNodes = newTreeNodes.ToArray();
        }

        static void fileChecker(string fileName, string[] allDirPath, ref string[] targetPath, bool findAllOccurrence)
        {
            // Check files
            int i = 0;
            foreach (var dir in allDirPath)
            {
                if (!File.GetAttributes(dir).HasFlag(FileAttributes.Directory))
                {
                    continue;
                }
                if (CheckFileInsideFolder(fileName, dir))
                {
                    //File exisst in root 
                    targetPath = targetPath.Concat(new String[] { Path.Combine(dir, fileName) }).ToArray();

                    if (!findAllOccurrence)
                    {
                        break; // To Stop after target found
                    }
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
