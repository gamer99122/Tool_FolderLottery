using NetExtensions;
using System.Diagnostics;

string targetPath = @"G:\尚未分類";

targetPath.pDirectoryEnsureExists();

string[] folders = Directory.GetDirectories(targetPath);

if (folders.Length == 0)
{
    Console.WriteLine("資料夾內沒有任何子資料夾！");
    return;
}

Random random = new Random();
int index = random.Next(folders.Length);
string selectedFolder = folders[index];

Console.WriteLine("隨機選到的資料夾是：");
Console.WriteLine(selectedFolder);

// 打開資料夾
Process.Start("explorer.exe", selectedFolder);