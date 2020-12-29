using System;
using System.Windows.Forms;

namespace task2
{
    public partial class WF_Guess_Num : Form
    {
        public WF_Guess_Num()
        {
            InitializeComponent();
        }
        private static Random rnd = new Random();
        private int correctNum = rnd.Next(1, 100);        //Генерируем достижимую цель игры
        private int tryCounter = 0;                     //Счетчик попыток, для статистики


        /// <summary>
        /// Событие кнопки Угадать
        /// Если введенная строка действительно число, то проверяет больше/меньше загаданного
        /// Выводить соотвествующий текст подсказки и количество совершенных попыток
        /// В случае успеха выводит сообщение о победе и предлагает сыграть еще
        /// При принятии новой игры, очищает все переменные и буферы, выводит начальную форму без изменений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guessEnter_Click(object sender, EventArgs e)
        {
            ++tryCounter;

            {
                if (correctNum == int.Parse(userGuessNum.Text))
                {
                    if (MessageBox.Show($"Вы правы!\n" +
                        $"Мы загадали {correctNum}!\n" +
                        $"Хотите сыграть еще?", "Победа", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        userGuessNum.Clear();
                        gameAnswer.Text = string.Empty;
                        tryCounter = 0;
                    }
                    else Application.Exit();
                }
                else if (correctNum > int.Parse(userGuessNum.Text))
                {
                    gameAnswer.Text = $"Не-а. {userGuessNum.Text} меньше загаданного числа.\n" +
                        $"Попыток совершено: {tryCounter}\n" +
                        $"Попробуйте еще раз";
                    gameAnswer.Visible = true;
                }
                else
                {
                    gameAnswer.Text = $"Не-а. {userGuessNum.Text} больше загаданного числа.\n" +
                        $"Попыток совершено: {tryCounter}\n" +
                        $"Попробуйте еще раз";
                    gameAnswer.Visible = true;
                }
            }
            userGuessNum.Clear();
        }


        /// <summary>
        /// Событие кнопки Сдаться
        /// Выход из игры. Завершение работы приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Проверка вводимого текста в режиме реального времени
        /// Кнопка Угадать становится неактивной, если вводимые данные НЕ числа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userGuessNum_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(userGuessNum.Text, out int num)) guessEnter.Enabled = false;
            else guessEnter.Enabled = true;
        }
    }
}
