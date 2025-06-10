using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_voroshilov_a
{
    public class BuffOperator : Operator
    {
        //словарь продвинутых операторов
        Dictionary<string, BuffOperator> buffOperators = new Dictionary<string, BuffOperator>();

        public bool PayForConnection { get; set; } //плата за каждое соединение

        //конструктор
        public BuffOperator(string name, double price, double square, int roaming, int speedInternet, bool payConnect) : base(name, price, square, roaming, speedInternet)
        {
            Name = name;
            PricePerMinute = price;
            Square = square;
            PayForConnection = payConnect;
            CalcQ();
        }

        //конструктор
        public BuffOperator()
        {

        }

        //добавление продвинутого оператора
        public void AddBuffOperator(string name, double price, double square, int roaming, int speedInternet, bool payConnect, out int result)
        {
            BuffOperator newBuffOp = new BuffOperator(name, price, square, roaming, speedInternet, payConnect);
            int countOps = buffOperators.Keys.Where(o => o == name).Count(); //проверка на наличие продвинутого оператора с таким же названием И ценой за минуту
            if (countOps > 0)
            {
                result = 1;
            }
            else
            {
                result = 0;
                buffOperators.Add(name, newBuffOp);
            }
        }


        //удаление из списка операторов по индексу
        public override void DeleteOperator(int index)
        {
            buffOperators.Remove(buffOperators.ElementAt(index).Key); // через linq получаем объект по индексу и затем удаляем объект
        }

        //получение списка информации об операторах
        public override string[] GetInfoOperators()
        {
            string[] infos = new string[buffOperators.Count];

            int i = 0;
            foreach (var op in buffOperators)
            {
                infos[i] = op.Value.Info();
                i++;
            }

            return infos;
        }

        //вычисление качества
        public override void CalcQ()
        {
            if (PayForConnection) Math.Round(quality = 0.7 * 100 * Square / PricePerMinute, 2);
            else Math.Round(quality = 1.5 * 100 * Square / PricePerMinute, 2);
        }

        //вывод информации
        protected override string Info()
        {
            return base.Info() + $", наличие платы за каждое соединение - {PayForConnection}";
        }
    }
}
