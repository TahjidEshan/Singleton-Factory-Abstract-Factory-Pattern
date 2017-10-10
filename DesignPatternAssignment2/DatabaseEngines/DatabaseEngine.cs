using System;

namespace DesignPatternAssignment2
{
    abstract class DatabaseEngine : IDatabaseEngine
    {
        public abstract void CreateView();
        public abstract void CreateCommand();
        public abstract void CreateTable();
        public abstract void CreateAdapter();
    }
}
