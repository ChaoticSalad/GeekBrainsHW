using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база данных, обращение к несуществующему вопросу,
//    открытие слишком большого файла и т.д.).
//б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
//в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия, авторские права и др.).
//г)*Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).
//    Черников Олег
namespace hw8ex3
{
    [Serializable]
    class Question
    {
        string text;       
        bool trueFalse;    

        public string Text { 
            get { return text; } 
            set { if (value.GetType() == typeof(string)) text = value; } 
        }
        public bool TrueFalse { 
            get { return trueFalse; } 
            set { if (value.GetType() == typeof(bool)) trueFalse = value; } 
        }


        /// <summary>Empty constructor for serialization</summary>
        public Question()
        {
        }

        /// <summary>Write question method</summary>
        /// <param name="text">Quation text</param>
        /// <param name="trueFalse">Rigth answer</param>
        public Question(string text, bool trueFalse)
        {
            this.text = text;
            this.trueFalse = trueFalse;
        }
    }
}
