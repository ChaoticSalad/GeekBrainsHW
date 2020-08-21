using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*Используя полученные знания и класс TrueFalse в качестве шаблона, 
//    разработать собственную утилиту хранения данных (Например: Дни рождения, Траты, Напоминалка, Английские слова и другие).
//    Черников Олег
namespace hw8ex4
{
    /// <summary>
    /// Translation class
    /// </summary>
    [Serializable]
    public class Dictionary : IEquatable<Dictionary>
    {
        string englishText;
        string russianText;

        public string EnglishText { 
            get 
            { 
                return englishText; 
            } 
            set 
            { 
                if (value.GetType() == typeof(string)) englishText = value; 
            } 
        }
        public string RussianText 
        { 
            get 
            { 
                return russianText; 
            } 
            set 
            { 
                if (value.GetType() == typeof(string)) russianText = value; 
            } 
        }

        /// <summary>Compare words method</summary>
        /// <param name="another">Dictionary rype word to compare</param>
        /// <returns></returns>
        public bool Equals(Dictionary another)
        {
            if (this.englishText == another.englishText && this.russianText == another.russianText)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>Empty constructor for serialization</summary>
        public Dictionary()
        {
        }

        /// <summary>Write word constructor</summary>
        /// <param name="engtext">Englsih text</param>
        /// <param name="rutext">Russian text</param>
        public Dictionary(string engtext, string rutext)
        {
            this.englishText = engtext;
            this.russianText = rutext;
        }
    }
}
