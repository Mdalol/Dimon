using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    ///     Описываем класс Изделие
    /// </summary>
    class Bibliotik
    {
        public string Name { get; set; }
        public string Adres { get; set; }
        public int God { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Bibliotik()
        {
        }
        /// <summary>
        /// Ввод объектов класса с клавиатуры
        /// </summary>
        public void Input()
        {
            Name = Console.ReadLine();
            Adres = Console.ReadLine();
            God = int.Parse(Console.ReadLine());
        }
    }
}
