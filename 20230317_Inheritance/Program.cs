namespace _20230317_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IYuzebilen> Yuzebilenler = new List<IYuzebilen>();

            DenizKaplumbagasi denizKaplumbagasi = new DenizKaplumbagasi();

            Penguen pen= new Penguen();

            Yuzebilenler.Add(denizKaplumbagasi);
            Yuzebilenler.Add(pen);

        }
    }
}