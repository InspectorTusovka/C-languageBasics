using System;
using System.Windows.Forms;

namespace lesson_7
{
    public partial class WF_Double : Form
    {
        public WF_Double()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Кнопка умножения числа на 2. Реализовано на беззнаковом лонге, обработана ситуация превышения макс числа которое может хранить <ulong>
        /// </summary>
        private void Multiply_buttonClick(object sender, EventArgs e)
        {
            try
            {
                if (ulong.Parse(numLabel.Text) >= ulong.MaxValue / 2 + 1) throw new ArgumentOutOfRangeException();
                numLabel.Text = (ulong.Parse(numLabel.Text) * 2).ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Такие большие числа нельзя показывать!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Кнопка увеличения числа на 1. Реализовано на беззнаковом лонге, обработана ситуация превышения макс числа которое может хранить <ulong>
        /// </summary>
        private void Plus_buttonClick(object sender, EventArgs e)
        {
            try
            {
                if (ulong.Parse(numLabel.Text) == ulong.MaxValue) throw new ArgumentOutOfRangeException();
                numLabel.Text = (ulong.Parse(numLabel.Text) + 1).ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Такие большие числа нельзя показывать!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Кнопка с предложением игры
        /// В качестве достижимой цели предлагается случайное число от 9 до 9999
        /// Выводится сообщение с правилами
        /// НЕигровая форма переходит в невидимое состояние, управление приложением переходит к игровой форме
        /// </summary>
        private void Play_buttonClick(object sender, EventArgs e)
        {
            Random rand = new Random();
            var gameNum = rand.Next(9, 9999);

            if (MessageBox.Show($"Получите {gameNum} за наименьшее число ходов.\n" +
                $"Используйте кнопки [{multiplyButton.Text}] и [{plusButton.Text}].\n" +
                $"Вы можете отменить два своих последних хода." +
                $"\n\t\t Удачи!", "Правила", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Visible = false;
                WF_Game_Double gameForm = new WF_Game_Double(gameNum);
                gameForm.Show();
            }
        }
    }
}
