using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//** Считайте файл различными способами.Смотрите “Пример записи файла различными способами”. 
//    Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), строку для StreamReader и массив int для BinaryReader.
//    Черников Олег
namespace hw6ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            long kb = 1024;
            long mb = 1024 * kb;
            long size = mb;
            Console.WriteLine("Запишем файлы при помощи разных потоков:");
            Console.WriteLine("FileStream. Milliseconds:{0}", WriteFileStream("bigdata0.bin", size, random));
            Console.WriteLine("BinaryStream. Milliseconds:{0}", WriteBinaryStream("bigdata1.bin", size, random));
            Console.WriteLine("StreamWriter. Milliseconds:{0}", WriteStreamWriter("bigdata2.bin", size, random));
            Console.WriteLine("BufferedStream. Milliseconds:{0}", WriteBufferedStream("bigdata3.bin", size, random));

            Console.WriteLine("Прочтём файлы при помощи разных потоков:");
            byte[] bytesFromFileStream = ReadFileStream("bigdata0.bin");
            int[] integersFromBinatyStream = ReadBinaryStream("bigdata1.bin");
            string stringFromSreamReader = ReadStreamReader("bigdata2.bin");
            byte[] bytesFromBufferedStream = ReadBufferedStream("bigdata3.bin");

            Console.ReadKey();
        }

        static long WriteFileStream(string filename, long size, Random random)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            for (int i = 0; i < size; i++)
                fs.WriteByte(Convert.ToByte(random.Next(255)));
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static byte[] ReadFileStream(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            byte[] byteArray = new byte[fs.Length];
            for (int i = 0; i < fs.Length; i++)
                byteArray[i] = (byte)fs.ReadByte();
            fs.Close();
            return byteArray;
        }

        static long WriteBinaryStream(string filename, long size, Random random)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < size; i++)
                bw.Write(Convert.ToByte(random.Next(255)));
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static int[] ReadBinaryStream(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            int[] intArr = new int[fs.Length / 4];
            BinaryReader br = new BinaryReader(fs);
            for (int i = 0; i < fs.Length / 4; i++)
                intArr[i] = br.ReadInt32();
            fs.Close();
            return intArr;
        }

        static long WriteStreamWriter(string filename, long size, Random random)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < size; i++)
                sw.Write(random.Next(9));
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static string ReadStreamReader(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string result = sr.ReadToEnd();
            fs.Close();
            return result;
        }

        static long WriteBufferedStream(string filename, long size, Random random)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            int countPart = 4; //number of parts
            int bufsize = (int)(size / countPart);
            byte[] buffer = new byte[size];
            for (int i = 0; i < buffer.Length; i++)
                buffer[i] = Convert.ToByte(random.Next(255));
            BufferedStream bs = new BufferedStream(fs, bufsize);
            for (int i = 0; i < countPart; i++)
                bs.Write(buffer, 0, (int)bufsize);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static byte[] ReadBufferedStream(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            int countPart = 4; //number of parts
            int bufsize = (int)(fs.Length / countPart);
            byte[] buffer = new byte[fs.Length];
            BufferedStream bs = new BufferedStream(fs, bufsize);
            for (int i = 0; i < countPart; i++)
                bs.Read(buffer, 0, (int)bufsize);
            fs.Close();
            return buffer;
        }
    }
}
