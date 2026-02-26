using System.Windows.Forms;

namespace lab1.Managers
{
    public class TextInfoManager
    {
        public void ShowTaskStatement()
        {
            MessageBox.Show("Постановка задачи будет добавлена позже.",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowGrammar()
        {
            MessageBox.Show("Грамматика будет добавлена позже.",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowGrammarClassification()
        {
            MessageBox.Show("Классификация грамматики будет добавлена позже.",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowAnalysisMethod()
        {
            MessageBox.Show("Метод анализа будет добавлен позже.",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowTestExample()
        {
            MessageBox.Show("Тестовый пример будет добавлен позже.",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowReferences()
        {
            MessageBox.Show("Список литературы будет добавлен позже.",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowSourceCode()
        {
            MessageBox.Show("Исходный код программы будет доступен позже.",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}