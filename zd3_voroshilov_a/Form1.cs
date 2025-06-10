namespace zd3_voroshilov_a
{
    public partial class Form1 : Form
    {
        Operator operators = new Operator();
        BuffOperator buffOperators = new BuffOperator();

        public Form1()
        {
            InitializeComponent();
        }

        //проверка на корректный ввод вещественных данных
        private double CheckCorrectNum(string text)
        {
            double value;
            if (double.TryParse(text, out value) && value > 0)
            {
                return value;
            }
            else
            {
                return -1;
            }

        }

        //добавление в таблицу оператора
        private void WriteOperatorsToListBox()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(operators.GetInfoOperators());

        }

        //добавление в таблицу продвинутого оператора
        private void WriteBuffOperatorsToListBox()
        {
            listBox2.Items.Clear();
            listBox2.Items.AddRange(buffOperators.GetInfoOperators());

        }

        //добавление оператора
        private void AddOperator(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim(' ') != "" && textBox2.Text.Trim(' ') != "")
                {
                    if (checkBox1.Checked)//проверка на включение ввода полной информации
                    {
                        if (textBox3.Text.Trim(' ') != "")
                        {
                            double price = CheckCorrectNum(textBox2.Text);
                            double square = CheckCorrectNum(textBox3.Text);

                            if (price != -1 && square != -1)
                            {
                                int tryToAdd;
                                operators.AddOperator(textBox1.Text.Trim(' '), price, square, (int)numericUpDown1.Value, (int)numericUpDown2.Value, out tryToAdd);

                                if (tryToAdd == 1)
                                {
                                    MessageBox.Show("ќператор с таким названием и стоимостью за одну минуту уже добавлен!");
                                }
                                else
                                {
                                    WriteOperatorsToListBox();
                                }
                            }
                            else
                            {
                                MessageBox.Show("—тоимость и площадь покрыти€ должны быть больше нул€!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("«аполните пол€!");
                        }
                    }
                    else//добавление в случае ввода только названи€ и цены за минуту
                    {
                        DialogResult dr = MessageBox.Show("ѕри выборе, полные данные об операторе заполн€тс€ автоматически", "¬ы уверены?", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            double price = CheckCorrectNum(textBox2.Text);

                            if (price != -1)
                            {
                                int tryToAdd;
                                operators.AddOperator(textBox1.Text.Trim(' '), price, out tryToAdd);

                                if (tryToAdd == 1)
                                {
                                    MessageBox.Show("ќператор с таким названием и стоимостью за одну минуту уже добавлен!");
                                }
                                else
                                {
                                    WriteOperatorsToListBox();
                                }
                            }
                            else
                            {
                                MessageBox.Show("—тоимость должна быть больше нул€!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("«аполните пол€!");
                }
            }
            catch
            {
                MessageBox.Show("Ќеверные значени€!");
            }
        }

        //ѕроверка на выбор добавлени€ полной информации
        private void CheckAddFullInfo(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                panel1.Enabled = true;
            }
            else
            {
                panel1.Enabled = false;
            }
        }

        //удаление по названию оператора
        private void DeleteByOpName(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim(' ') != "" && listBox1.Items.Count > 0)
            {
                int result;
                operators.DeleteOperator(textBox1.Text.Trim(' '), out result);

                if (result == 1)
                {
                    MessageBox.Show("“акого названи€ не найдено!");
                }
                else
                {
                    WriteOperatorsToListBox();
                }
            }
            else
            {
                MessageBox.Show("¬ведите название или операторы пусты!");
            }
        }

        //удаление по индексу оператора
        private void DeleteByOpIndex(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count > 0)
                {
                    operators.DeleteOperator(listBox1.SelectedIndex);
                    WriteOperatorsToListBox();
                }
                else
                {
                    MessageBox.Show("ќператоры пусты!");
                }
            }
            catch
            {
                MessageBox.Show("¬ыберите нужное!");
            }
        }

        //удаление продвинутого оператора по индексу
        private void DeleteByBuffIndex(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.Items.Count > 0)
                {
                    buffOperators.DeleteOperator(listBox2.SelectedIndex);
                    WriteBuffOperatorsToListBox();
                }
                else
                {
                    MessageBox.Show("ќператоры пусты!");
                }
            }
            catch
            {
                MessageBox.Show("¬ыберите нужное!");
            }
        }

        //добавление продвинутого оператора 
        private void AddBuffOperator(object sender, EventArgs e)
        {
            if (textBox4.Text.Trim(' ') != "" && textBox5.Text.Trim(' ') != "" && textBox6.Text.Trim(' ') != "")
            {
                double price = CheckCorrectNum(textBox5.Text);
                double square = CheckCorrectNum(textBox4.Text);
                bool payConnect;
                
                if (checkBox2.Checked) payConnect = true;
                else payConnect = false;

                if (price != -1 && square != -1)
                {
                    int tryToAdd;
                    buffOperators.AddBuffOperator(textBox6.Text.Trim(' '), price, square, (int)numericUpDown1.Value, (int)numericUpDown2.Value, payConnect, out tryToAdd);

                    if (tryToAdd == 1)
                    {
                        MessageBox.Show("ќператор с таким названием уже добавлен!");
                    }
                    else
                    {
                        WriteBuffOperatorsToListBox();
                    }
                }
                else
                {
                    MessageBox.Show("—тоимость и площадь покрыти€ должны быть больше нул€!");
                }
            }
            else
            {
                MessageBox.Show("«аполните пол€!");
            }
        }
    }
}
