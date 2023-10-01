namespace ExtractSpecialBytes
{
	using System;
	using System.IO;
	using System.Linq;
	using System.Collections.Generic;
	using System.Text;

	public class ExtractSpecialBytes
	{
		static void Main()
		{
			string binaryFilePath = @"..\..\..\Files\example.png";
			string bytesFilePath = @"..\..\..\Files\bytes.txt";
			string outputPath = @"..\..\..\Files\output.bin";

			ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
		}

		public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
		{
			byte[] bytesToExtract = File.ReadAllBytes(bytesFilePath);

			using (FileStream inputFileStream = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read))
			{
				using (FileStream outputFileStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
				{
					int bytesRead;
					byte[] buffer = new byte[1024];

					while ((bytesRead = inputFileStream.Read(buffer, 0, buffer.Length)) > 0)
					{
						for (int i = 0; i < bytesRead; i++)
						{
							if (Array.IndexOf(bytesToExtract, buffer[i]) >= 0)
							{
								outputFileStream.WriteByte(buffer[i]);
							}
						}
					}
				}
			}
		}
	}
}