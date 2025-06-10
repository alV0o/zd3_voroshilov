using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_voroshilov_a
{
    public class Operator
    {
        private List<Operator> operators = new List<Operator>(); //список операторов

        public string Name { get; set; } //название оператора
        public double PricePerMinute { get; set; } //цена за минуту
        public double Square { get; set; } // площадь покрытия
        public int Roaming { get; set; } // цена за роуминг
        public int SpeedOfInternet { get; set; } //скорость интернета в Мбит/c

        protected double quality; //качество

        //конструктор
        public Operator(string name, double price, double square, int roaming, int speedInternet)
        {
            Name = name;
            PricePerMinute = price;
            Square = square;
            Roaming = roaming;
            SpeedOfInternet = speedInternet;
            CalcQ();
        }

        //конструктор
        public Operator()
        {

        }

        //вычисление качества
        public virtual void CalcQ()
        {
            quality = Math.Round(100 * Square / PricePerMinute, 2);
        }

        //добавление в список операторов
        public void AddOperator(string name, double price, double square, int roaming, int speedInternet, out int result)
        {
            Operator newOp = new Operator(name, price, square, roaming, speedInternet);
            int countOps = operators.Where(o => o.Name == name && o.PricePerMinute == price).Count(); //проверка на наличие оператора с таким же названием И ценой за минуту
            if (countOps > 0)
            {
                result = 1;
            }
            else
            {
                result = 0;
                operators.Add(newOp);
            }
        }

        //добавление в список операторов с минимальными данными
        public void AddOperator(string name, double price, out int result)
        {
            Operator newOp = new Operator(name, price, 100, 0, 500);
            int countOps = operators.Where(o => o.Name == name && o.PricePerMinute == price).Count(); //проверка на наличие оператора с таким же названием И ценой за минуту
            if (countOps > 0)
            {
                result = 1;
            }
            else
            {
                result = 0;
                operators.Add(newOp);
            }
        }

        //удаление из списка операторов по названию
        public void DeleteOperator(string name, out int correctRemove)
        {
            correctRemove = 0;
            int countBefore = operators.Count();
            operators = operators.Where(o => o.Name != name).ToList(); //через linq выбираем все операторы кроме операторов с введенным названием и перезаписываем список

            if (countBefore == operators.Count())//проверка на успешное удаление
            {
                correctRemove = 1;
            }
        }

        //удаление из списка операторов по индексу
        public virtual void DeleteOperator(int index)
        {
            operators.Remove(operators.ElementAt(index)); // через linq получаем объект по индексу и затем удаляем объект
        }

        //получение списка информации об операторах
        public virtual string[] GetInfoOperators()
        {
            string[] infos = new string[operators.Count];

            for (int i = 0; i < operators.Count; i++)
            {
                infos[i] = operators[i].Info();
            }

            return infos;
        }



        //получение информации об операторе
        protected virtual string Info()
        {
            return $"Оператор {Name}: стоимость минуты - {PricePerMinute}р., площадь покрытия - {Square}Км^2, цена роуминга - {Roaming}р., скорость интернета - {SpeedOfInternet}Мбит/с, качество - {quality}";
        }
    }
}
