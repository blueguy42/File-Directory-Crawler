using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folder_Crawler_Algo
{
    public class BFSorDFSAlgo
    {
        public static void BFSorDFS(int algorithm, string fileName, string rootPath, ref string[] allDirPath, ref string[] allRootsPath, Boolean findAllOccurrence)
        {


            if (algorithm == 0)
            {
                getAllDirsBFS(rootPath, ref allDirPath, ref allRootsPath);
            }
            else if (algorithm == 1)
            {
                getAllDirsDFS(rootPath, ref allDirPath, ref allRootsPath);
            }


        }

        static void getAllDirsDFS(String rootPath, ref String[] allDirs, ref String[] allRoots)
        {
            //Instantiate root dir path
            List<string> tempDirs = Directory.GetDirectories(rootPath).ToList();
            List<string> tempfiles = Directory.GetFiles(rootPath).ToList();
            List<string> tempRoots = new List<string>();
            List<bool> isDir = new List<bool> { };

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
            while (i < tempDirs.Count - 1)
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
            isDir.Insert(0, true);


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
                if (!isDir[i])
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

    }
}
