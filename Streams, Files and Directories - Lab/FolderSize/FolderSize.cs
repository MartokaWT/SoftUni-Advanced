namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
			double totalSizeInKilobytes = CalculateFolderSize(folderPath) / 1024.0;

			File.WriteAllText(outputFilePath, totalSizeInKilobytes.ToString("F9") + " KB");
		}
		public static double CalculateFolderSize(string folderPath)
		{
			double folderSize = 0;

			foreach (string filePath in Directory.GetFiles(folderPath))
			{
				FileInfo fileInfo = new FileInfo(filePath);
				folderSize += fileInfo.Length;
			}

			foreach (string subFolderPath in Directory.GetDirectories(folderPath))
			{
				folderSize += CalculateFolderSize(subFolderPath);
			}

			return folderSize;
		}
	}
}
