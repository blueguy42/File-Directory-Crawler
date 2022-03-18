using System;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Xs.txt";
            string rootPath = @"C:\Users\rioau\Documents\ITB\2Tingkat 2\Sem2\Tugas\STIMA\Folder-Crawler\test";
            Boolean findAllOccurrence = false;
            int algorithm = 1; //0 for BFS, 1 for DFS


            string[] targetPath = new String[] { };

            //Change DFS or BFS
            if (algorithm == 0)
            {
                BFS(fileName, rootPath, ref targetPath, findAllOccurrence);
            }
            else if (algorithm == 1)
            {
                DFS(fileName, rootPath, ref targetPath, findAllOccurrence);
            }

            Console.WriteLine("===================================");
            foreach (String path in targetPath)
            {
                Console.WriteLine(path);
            }
            Console.ReadLine();
        }

        static void DFS(string fileName, string rootPath, ref string[] targetPath, Boolean findAllOccurrence)
        {
            String[] listOfDirs = new String[] { };
            getAllDirsDFS(rootPath, ref listOfDirs);

            foreach (var dir in listOfDirs)
            {
                //Print current dir to check
                Console.WriteLine(dir);

                if (CheckFileInsideFolder(fileName, dir))
                {
                    //File exisst in root 
                    targetPath = targetPath.Concat(new String[] { Path.Combine(rootPath, fileName) }).ToArray();

                    if (!findAllOccurrence)
                    {
                        break; // To Stop after target found
                    }
                }
            }
        }
        static void getAllDirsDFS(String rootPath, ref String[] allDirs)
        {
            List<string> tempDirs = Directory.GetDirectories(rootPath).ToList();

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
                i++;
            }

            tempDirs.Insert(0, rootPath);

            allDirs = tempDirs.ToArray();
        }


        static void BFS(String fileName, String rootPath, ref String[] targetPath, Boolean findAllOccurrence)
        {
            String[] listOfDirs = new String[] { };
            getAllDirsBFS(rootPath, ref listOfDirs);

            foreach (var dir in listOfDirs)
            {
                //Print current dir to check
                Console.WriteLine(dir);

                if (CheckFileInsideFolder(fileName, dir))
                {
                    //File exisst in root 
                    targetPath = targetPath.Concat(new String[] { Path.Combine(rootPath, fileName) }).ToArray();

                    if (!findAllOccurrence)
                    {
                        break; // To Stop after target found
                    }
                }
            }
        }

        static void getAllDirsBFS(String rootPath, ref String[] allDirs)
        {
            allDirs = new string[] { rootPath };
            allDirs = allDirs.Concat(Directory.GetDirectories(rootPath)).ToArray();
            int i = 1;

            //List all of dirs by BFS
            while (i < allDirs.Length)
            {
                String dir = allDirs[i];
                String[] allNewDir = Directory.GetDirectories(dir);
                allDirs = allDirs.Concat(allNewDir).ToArray();
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