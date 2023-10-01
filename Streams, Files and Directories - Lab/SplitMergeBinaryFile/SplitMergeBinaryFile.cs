namespace SplitMergeBinaryFile
{
	using System;
	using System.IO;
	using System.Linq;

	public class SplitMergeBinaryFile
	{
		static void Main()
		{
			string sourceFilePath = @"..\..\..\Files\example.png";
			string joinedFilePath = @"..\..\..\Files\example-joined.png";
			string partOnePath = @"..\..\..\Files\part-1.bin";
			string partTwoPath = @"..\..\..\Files\part-2.bin";

			SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
			MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
		}

		public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
		{
			using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
			{
				using (FileStream partOneStream = new FileStream(partOneFilePath, FileMode.Create, FileAccess.Write))
				{
					using (FileStream partTwoStream = new FileStream(partTwoFilePath, FileMode.Create, FileAccess.Write))
					{
						long fileSize = sourceStream.Length;
						int bufferSize = 1024;
						byte[] buffer = new byte[bufferSize];

						long bytesToRead = fileSize / 2;
						int bytesRead;

						while (bytesToRead > 0 && (bytesRead = sourceStream.Read(buffer, 0, (int)Math.Min(bufferSize, bytesToRead))) > 0)
						{
							partOneStream.Write(buffer, 0, bytesRead);
							bytesToRead -= bytesRead;
						}

						while ((bytesRead = sourceStream.Read(buffer, 0, bufferSize)) > 0)
						{
							partTwoStream.Write(buffer, 0, bytesRead);
						}
					}
				}
			}
		}

		public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
		{
			using (FileStream partOneStream = new FileStream(partOneFilePath, FileMode.Open, FileAccess.Read))
			{
				using (FileStream partTwoStream = new FileStream(partTwoFilePath, FileMode.Open, FileAccess.Read))
				{
					using (FileStream joinedStream = new FileStream(joinedFilePath, FileMode.Create, FileAccess.Write))
					{
						byte[] buffer = new byte[1024];
						int bytesRead;

						while ((bytesRead = partOneStream.Read(buffer, 0, buffer.Length)) > 0)
						{
							joinedStream.Write(buffer, 0, bytesRead);
						}

						while ((bytesRead = partTwoStream.Read(buffer, 0, buffer.Length)) > 0)
						{
							joinedStream.Write(buffer, 0, bytesRead);
						}
					}
				}
			}
		}
	}
}