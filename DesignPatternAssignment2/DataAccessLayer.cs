﻿namespace DesignPatternAssignment2
{
    public abstract class DataAccessLayer<T> where T : class, new()
    {
        private static T _instance;

        public static T GetInstance()
        {
            if (_instance == null)
                _instance = new T();
            return _instance;
        }
        public IEngineCreator GetCreator()
        {
            return new EngineCreator();
        }
    }
}