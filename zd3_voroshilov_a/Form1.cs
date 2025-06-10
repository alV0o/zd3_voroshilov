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

        //�������� �� ���������� ���� ������������ ������
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

        //���������� � ������� ���������
        private void WriteOperatorsToListBox()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(operators.GetInfoOperators());

        }

        //���������� � ������� ������������ ���������
        private void WriteBuffOperatorsToListBox()
        {
            listBox2.Items.Clear();
            listBox2.Items.AddRange(buffOperators.GetInfoOperators());

        }

        //���������� ���������
        private void AddOperator(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim(' ') != "" && textBox2.Text.Trim(' ') != "")
                {
                    if (checkBox1.Checked)//�������� �� ��������� ����� ������ ����������
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
                                    MessageBox.Show("�������� � ����� ��������� � ���������� �� ���� ������ ��� ��������!");
                                }
                                else
                                {
                                    WriteOperatorsToListBox();
                                }
                            }
                            else
                            {
                                MessageBox.Show("��������� � ������� �������� ������ ���� ������ ����!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("��������� ����!");
                        }
                    }
                    else//���������� � ������ ����� ������ �������� � ���� �� ������
                    {
                        DialogResult dr = MessageBox.Show("��� ������, ������ ������ �� ��������� ���������� �������������", "�� �������?", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            double price = CheckCorrectNum(textBox2.Text);

                            if (price != -1)
                            {
                                int tryToAdd;
                                operators.AddOperator(textBox1.Text.Trim(' '), price, out tryToAdd);

                                if (tryToAdd == 1)
                                {
                                    MessageBox.Show("�������� � ����� ��������� � ���������� �� ���� ������ ��� ��������!");
                                }
                                else
                                {
                                    WriteOperatorsToListBox();
                                }
                            }
                            else
                            {
                                MessageBox.Show("��������� ������ ���� ������ ����!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("��������� ����!");
                }
            }
            catch
            {
                MessageBox.Show("�������� ��������!");
            }
        }

        //�������� �� ����� ���������� ������ ����������
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

        //�������� �� �������� ���������
        private void DeleteByOpName(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim(' ') != "" && listBox1.Items.Count > 0)
            {
                int result;
                operators.DeleteOperator(textBox1.Text.Trim(' '), out result);

                if (result == 1)
                {
                    MessageBox.Show("������ �������� �� �������!");
                }
                else
                {
                    WriteOperatorsToListBox();
                }
            }
            else
            {
                MessageBox.Show("������� �������� ��� ��������� �����!");
            }
        }

        //�������� �� ������� ���������
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
                    MessageBox.Show("��������� �����!");
                }
            }
            catch
            {
                MessageBox.Show("�������� ������!");
            }
        }

        //�������� ������������ ��������� �� �������
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
                    MessageBox.Show("��������� �����!");
                }
            }
            catch
            {
                MessageBox.Show("�������� ������!");
            }
        }

        //���������� ������������ ��������� 
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
                        MessageBox.Show("�������� � ����� ��������� ��� ��������!");
                    }
                    else
                    {
                        WriteBuffOperatorsToListBox();
                    }
                }
                else
                {
                    MessageBox.Show("��������� � ������� �������� ������ ���� ������ ����!");
                }
            }
            else
            {
                MessageBox.Show("��������� ����!");
            }
        }
    }
}
