string path = "C:/Users/ulis8/Documents/Учеба/4 Знакомство с языками программирования";
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);    
}

void CatalogInfo (string path, string intend = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{intend}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, intend + " ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{intend}{files[i].Name}");
    }
}

CatalogInfo(path);