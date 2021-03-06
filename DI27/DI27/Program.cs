using System;
using System.IO;

namespace DI27
{
    public interface IReader
    {
        ConsoleKeyInfo Read();
    }
    public interface IWriter : IDisposable
    {
        void Writer(char character);
    }
    public class ConsoleReader : IReader
    {
        public ConsoleKeyInfo Read()
        {
            return Console.ReadKey(true);
        }
    }
    public class ConsoleWriter : IWriter
    {
        public void Writer(char character)
        {
            Console.Write(character);
        }
        public void Dispose()
        {
        }
    }
    public class FileWriter : IWriter
    {
        private readonly StreamWriter writer;
        public FileWriter(string filePath)
        {
            writer = new StreamWriter(filePath);
        }

        public void Dispose()
        {
            writer.Dispose();
        }

        public void Writer(char character)
        {
            writer.Write(character);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Composition Root
            // Pure DI / Pool Man DI
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            Copy(reader, writer);
            writer.Dispose();
        }
        private static void Copy(IReader reader, IWriter writer)
        {
            #region 這樣的寫法會造成緊密耦合
            //IReader reader = new ConsoleReader();
            //IWriter writer = new ConsoleWriter();
            #endregion

            while (true)
            {
                var consoleKeyInfo = reader.Read();
                if (consoleKeyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
                writer.Writer(consoleKeyInfo.KeyChar);
            }
        }
    }
}
