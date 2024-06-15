namespace ParallelQueryGrouping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[] 
            {
                "ananas", "azbest", "antena", "akordeon", "abecadlo",
                "banan", "beczka", "bit", "bajt",
                "cebula", "czerwien", "czern",
                "dab", "derby",
                "ekran"
            };

            ParallelQuery<IGrouping<char, string>> parallelGroups;
            parallelGroups =
                from text in data.AsParallel()
                orderby text
                group text by text[0];

            foreach (var group in parallelGroups)
            {
                foreach(var item in group)
                {
                    Console.Write(item + ' ');
                }
                Console.WriteLine();
            }

            IDictionary<int, string> map = new Dictionary<int, string>();
        }
    }
}
