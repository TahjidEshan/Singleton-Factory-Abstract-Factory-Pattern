using System;

namespace DesignPatternAssignment2
{
    class Oracle : ConcreteDatabaseEngine
    {
        public override void CreateView()
        {
            Console.WriteLine("Oracle CreateView");
        }
        public override void CreateCommand()
        {
            Console.WriteLine("Oracle CreateCommand");
        }
        public override void CreateTable()
        {
            Console.WriteLine("Oracle CreateTable");
        }
        public override void CreateAdapter()
        {
            Console.WriteLine("Oracle CreateAdapter");
        }
    }
}
