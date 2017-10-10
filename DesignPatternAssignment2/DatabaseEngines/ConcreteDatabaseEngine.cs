using System;

namespace DesignPatternAssignment2
{
    class ConcreteDatabaseEngine : DatabaseEngine
    {
        public override void CreateView()
        {
            Console.WriteLine("Concrete CreateView");
        }
        public override void CreateCommand()
        {
            Console.WriteLine("Concrete CreateCommand");
        }
        public override void CreateTable()
        {
            Console.WriteLine("Concrete CreateTable");
        }
        public override void CreateAdapter()
        {
            Console.WriteLine("Concrete CreateAdapter");
        }
    }
}
