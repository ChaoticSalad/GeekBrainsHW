using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
//*Используя полученные знания и класс TrueFalse в качестве шаблона, 
//    разработать собственную утилиту хранения данных (Например: Дни рождения, Траты, Напоминалка, Английские слова и другие).
//    Черников Олег
namespace hw8ex4
{
    /// <summary>Class to storage words' list. And for serialization to XML and desrialization from XML</summary>
    class Words
    {
        string fileName;
        List<Dictionary> list;
        public string FileName
        {
            set { fileName = value; }
        }

        /// <summary>Constructor writes path to a file and initializes empty list of words</summary>
        /// <param name="fileName">File's name and path</param>
        public Words(string fileName)
        {
            this.fileName = fileName;
            list = new List<Dictionary>();
        }

        /// <summary>Add word method</summary>
        /// <param name="engText">English word</param>
        /// <param name="ruText">Russian word</param>
        public void Add(string engText, string ruText)
        {
            bool contain = list.Contains(new Dictionary(engText, ruText));
            if (!contain)
                list.Add(new Dictionary(engText, ruText));
            else
                MessageBox.Show("Such word already im the list", "Attention");
        }

        /// <summary>Delete word method</summary>
        /// <param name="wordToRemove">List's word</param>
        public void Remove(Dictionary wordToRemove)
        {
            int index = list.IndexOf(wordToRemove);
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }

        /// <summary>Indexator - property to access to a closed object</summary>
        /// <param name="index">Word's index</param>
        /// <returns></returns>
        public Dictionary this[int index]
        {
            get { return list[index]; }
        }

        /// <summary>Words serialization method</summary>
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Dictionary>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        /// <summary>Words deserialization method</summary>
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Dictionary>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Dictionary>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        /// <summary>Property returns size of words' list</summary>
        public int Count
        {
            get { return list.Count; }
        }
    }
}
