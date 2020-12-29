using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lesson_7
{
    public partial class WF_Game_Double : Form
    {
        /// <summary>
        /// На вход конструктору форму подается число-достижимая цель игры
        /// </summary>
        public WF_Game_Double(int outRand)
        {
            InitializeComponent();
            gameNumber.Text = outRand.ToString();
        }

        Stack<string> revertStack = new Stack<string>();    //Стек комманд х2, +1 и Отмена_Хода
        int tryCounter = 2;     //Счетчик нажатий Отмена_Хода

        /// <summary>
        /// Управляющая кнопка всего приложения, при нажатии Сдаться прекращает работу программы
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Кнопка умножения числа на 2. Реализовано на беззнаковом лонге, обработана ситуация превышения макс числа которое может хранить <ulong>
        /// Обновляет счетчик нажати Отмена_хода
        /// Проводит проверку достижения победы в игре
        /// </summary>
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ulong.Parse(numLabelGame.Text) >= ulong.MaxValue / 2 + 1) throw new ArgumentOutOfRangeException();
                numLabelGame.Text = (ulong.Parse(numLabelGame.Text) * 2).ToString();
                commandCounter.Text = (int.Parse(commandCounter.Text) + 1).ToString();
                revertStack.Push("mult");
                tryCounter = 2;
                revertButton.Enabled = true;
                if (numLabelGame.Text == gameNumber.Text)
                {
                    if (MessageBox.Show($"Поздравляем!\n" +
                        $"Вам понадобилось всего {commandCounter.Text} ходов!\n", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Такие большие числа нельзя показывать!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Кнопка увеличения числа на 1. Реализовано на беззнаковом лонге, обработана ситуация превышения макс числа которое может хранить <ulong>
        /// Обновляет счетчик нажати Отмена_хода
        /// Проводит проверку достижения победы в игре
        /// </summary>
        private void plusButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ulong.Parse(numLabelGame.Text) == ulong.MaxValue) throw new ArgumentOutOfRangeException();
                numLabelGame.Text = (ulong.Parse(numLabelGame.Text) + 1).ToString();
                commandCounter.Text = (int.Parse(commandCounter.Text) + 1).ToString();
                revertStack.Push("plus");
                tryCounter = 2;
                revertButton.Enabled = true;
                if (numLabelGame.Text == gameNumber.Text)
                {
                    if (MessageBox.Show($"Поздравляем!\n" +
                        $"Вам понадобилось всего {commandCounter.Text} ходов!\n", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Такие большие числа нельзя показывать!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Кнопка отмены хода. Проверяет последнюю отданную команду в стеке комманд и совершает инвертированное действие с параметром числа игры
        /// Уменьшает счетчик нажатий Отмена_Хода
        /// Проводит проверку достижения победы в игре
        /// Обрабатывает исключение отсутствия комманд в стеке комманд
        /// </summary>
        private void revertButton_Click(object sender, EventArgs e)
        {


            try
            {
                if (revertStack.Count == 0) throw new ArgumentException();
                string stackPop = revertStack.Pop();
                if (stackPop == "mult") numLabelGame.Text = (int.Parse(numLabelGame.Text) / 2).ToString();
                else if (stackPop == "plus") numLabelGame.Text = (int.Parse(numLabelGame.Text) - 1).ToString();
                commandCounter.Text = (int.Parse(commandCounter.Text) + 1).ToString();
                tryCounter--;
                if (numLabelGame.Text == gameNumber.Text)
                {
                    if (MessageBox.Show($"Поздравляем!\n" +
                        $"Вам понадобилось всего {commandCounter.Text} ходов!\n", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
                if (tryCounter == 0)
                {
                    revertButton.Enabled = false;
                    revertStack.Clear();        //проводится очистка стека комманд после двух подряд Отмена_Хода, чтобы пользователь не смог нечестным образом отменять
                }                               //больше двух ходов 
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Вы пока не отдали ни одной команды", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
