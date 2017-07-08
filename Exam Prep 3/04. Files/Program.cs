using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class Program
{
    static void Main()
    {
            var number = int.Parse(Console.ReadLine());
            List<Files> info = new List<Files>();
            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split('\\');
                var root = input.First();
                var sizeSplit = input.Last().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                long size = long.Parse(sizeSplit.Last());
                var file = sizeSplit.First();
                var extention = file.Substring(file.LastIndexOf('.') + 1);

                Files infos = new Files()
                {
                    Root = root,
                    FileName = file,
                    Extention = extention,
                    Size = size
                };
                info.Add(infos);
            }

            var query = Regex.Split(Console.ReadLine(), @"\sin\s");
            var formatSearch = query[0];
            var querySearch = query[1];

            var result = info.Where(x => x.Root == querySearch).Where(x => x.Extention == formatSearch)
                .OrderByDescending(x => x.Size).ThenBy(x => x.FileName);

            var count = 0;
            foreach (var item in result)
            {
                Console.WriteLine($"{item.FileName} - {item.Size} KB ");
            }
            if (result.Count() == 0)
            {
                Console.WriteLine("No");
            }
    }
}
class Files
{
    public string Root { get; set; }
    public string FileName { get; set; }
    public string Extention { get; set; }
    public long Size { get; set; }
}