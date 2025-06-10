using System.Xml.Linq;
using zd3_voroshilov_a;
namespace OperatorTests
{
    [TestClass]
    public sealed class OperatorTests
    {
        [TestMethod]
        public void CheckAddOperator_CorrectDatas_return0()//тест добавления оператора с верными данными
        {
            Operator op = new Operator();

            int expected = 0;//ожидаемый результат

            int actual;//сам результат

            op.AddOperator("Мегафон", 2.5, 100, 50, 500 , out actual);

            Assert.AreEqual(expected, actual);//сравнение
        }

        [TestMethod]
        public void CheckAddOperator_IncorrectDatas_return1()//тест добавления оператора с неверными данными
        {
            Operator op = new Operator();
            op.AddOperator("Мегафон", 2.5, 100, 50, 500, out int x);

            int expected = 1;//ожидаемый результат

            int actual;//сам результат

            op.AddOperator("Мегафон", 2.5, 100, 50, 500, out actual);

            Assert.AreEqual(expected, actual); //сравнение
        }

        [TestMethod]
        public void CheckAddOperator_CorrectSmallDatas_return0()//тест добавления оператора с верными краткими данными
        {
            Operator op = new Operator();

            int expected = 0;//ожидаемый результат

            int actual;//сам результат

            op.AddOperator("Мегафон", 2.5, out actual);

            Assert.AreEqual(expected, actual); //сравнение
        }

        [TestMethod]
        public void CheckAddOperator_IncorrectSmallDatas_return1()//тест добавления оператора с неверными краткими данными
        {
            Operator op = new Operator();
            op.AddOperator("Мегафон", 2.5, out int x);

            int expected = 1;//ожидаемый результат

            int actual;//сам результат

            op.AddOperator("Мегафон", 2.5, out actual);

            Assert.AreEqual(expected, actual); //сравнение
        }

        [TestMethod]
        public void CheckDeleteOperator_CorrectDatas_return0()//тест удаления оператора по имени с верными данными
        {
            Operator op = new Operator();
            op.AddOperator("Мегафон", 2.5, out int x);

            int expected = 0;//ожидаемый результат

            int actual;//сам результат

            op.DeleteOperator("Мегафон", out actual);

            Assert.AreEqual(expected, actual); //сравнение
        }

        [TestMethod]
        public void CheckDeleteOperator_IncorrectDatas_return1()//тест удаления оператора с неверными данными
        {
            Operator op = new Operator();
            op.AddOperator("Мегафон", 2.5, out int x);

            int expected = 1;//ожидаемый результат

            int actual;//сам результат

            op.DeleteOperator("МТС", out actual);

            Assert.AreEqual(expected, actual); //сравнение
        }

    }

    [TestClass]//тест продвинутого оператора
    public sealed class BuffOperatorTests
    {
        [TestMethod]
        public void CheckAddBuffOperator_CorrectDatas_return0()//тест добавления продвинутого оператора с верными данными
        {
            BuffOperator buffOp = new BuffOperator();
            buffOp.AddBuffOperator("МТС", 3.5, 150, 25, 450, true, out int x);

            int expected = 0;//ожидаемый результат

            int actual;//сам результат

            buffOp.AddBuffOperator("Мегафон", 2.5, 100, 50, 500, true, out actual);

            Assert.AreEqual(expected, actual);//сравнение
        }

        [TestMethod]
        public void CheckAddBuffOperator_IncorrectDatas_return0()//тест добавления продвинутого оператора с неверными данными
        {
            BuffOperator buffOp = new BuffOperator();
            buffOp.AddBuffOperator("МТС", 3.5, 150, 25, 450, true, out int x);

            int expected = 1;//ожидаемый результат

            int actual;//сам результат

            buffOp.AddBuffOperator("МТС", 2.5, 100, 50, 500, true, out actual);

            Assert.AreEqual(expected, actual);//сравнение
        }


    }
}
