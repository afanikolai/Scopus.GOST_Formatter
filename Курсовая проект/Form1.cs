using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Курсовая_проект
{
    public partial class Form1 : Form
    {
        Article obj = new Article();
        string[] strmas = new string[0];
        string separator = ".";
        string link = "";
        bool article = false;
        bool book = false;
        int globalcount = 0;
        bool testTime = false;
        DateTime dtStart = new DateTime();
        DateTime dtEnd = new DateTime();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            pb1.Visible = false;
        }


        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)     // Открытие из файла.
        {
            //  Тут надо создать массив строк между строкой с @ и строкой с } и передать его в коструктор класса. 
            //
            try
            {
                

                // Открытие файла через OFDialog.
                OpenFileDialog OFDialog = new OpenFileDialog();
                OFDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                OFDialog.DefaultExt = ".txt";
                OFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                OFDialog.FilterIndex = 2;
                OFDialog.RestoreDirectory = false;

                if (OFDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                // Начать засекать время. 
                dtStart = DateTime.Now;

                // Рассчет количества строк в открытом файле.
                string directory = OFDialog.FileName;
                StreamReader sr = new StreamReader(directory);
                string tmpline;
                int count = 0;  // Переменная, хранящая количество строк. 
                while(!sr.EndOfStream)
                {
                    tmpline = sr.ReadLine();
                    count++;
                }
                sr.Close(); // Конец рассчета количества строк. 

                pb1.Show(); // Вывод ПрогрессБара.
                pb1.Visible = true;
                pb1.Minimum = 1;
                pb1.Maximum = count+1 + Convert.ToInt32(count/10);
                pb1.Value = 1;
                pb1.Step = 1;

                using (StreamReader str = new StreamReader(OFDialog.FileName))
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    tb_main.Text = "";
                    link = "";

                    globalcount = 0;
                    int k = 0;
                    bool ok = false;
                    string line = str.ReadLine();
                    while (line != null)
                    {
                        if (line == "")
                        {
                            
                        }
                        else
                        {
                            // Если строка начинается с @ то создать массив и обнулить К.
                            if (line[0] == '@')
                            {
                                if ((line.Substring(0, 12) == "@CONFERENCE{") || (line.Substring(0, 9) == "@ARTICLE{"))
                                {
                                    article = true;
                                    book = false;
                                }
                                else
                                {
                                    if (line.Substring(0, 6) == "@BOOK{")
                                    {
                                        book = true;
                                        article = false;
                                    }
                                }

                                globalcount++;
                                ok = true;
                                k = 0;
                                strmas = new string[30];
                            }
                            else
                            // Если строка это "}" то закончить заполнять массив и отправить его на обработку.
                            if (line == "}")
                            {
                                ok = false;
                                if (article)   // Если после @ идет ARTICLE.
                                {
                                    Article obj1 = new Article(strmas);
                                    obj = obj1;
                                    
                                    if (obj.nauthors < 5)
                                    {
                                        link += globalcount + "). " + obj.authors + ". " + obj.title + " // " + obj.journal +
                                            separator + " " + obj.year;
                                        if (obj.volume != "")
                                        {
                                            link += separator + " № " + obj.volume;
                                        }
                                        if (obj.pages != "")
                                        {
                                            link += separator + " p. " + obj.pages;
                                        }
                                    }
                                    else
                                    {
                                        link += globalcount + "). " + obj.title + " / " + obj.authors + " // " + obj.journal +
                                            separator + " " + obj.year;
                                        if (obj.volume != "")
                                        {
                                            link += separator + " № " + obj.volume;
                                        }
                                        if (obj.pages != "")
                                        {
                                            link += separator + " p. " + obj.pages;
                                        }
                                    }
                                    link += ". \r\n\r\n";
                                    article = false;
                                }
                                else        // Если после @ НЕ идет ARTICLE.
                                {
                                    if (book)
                                    {

                                        link += "Тут описана книга  \r\n\r\n";

                                        book = false;
                                    }
                                }
                            }               // Если после @ идет ARTICLE.
                            else
                            if (ok)
                            {
                                // Иначе добавить строку в массив и увеличить К.
                                strmas[k] = line;
                                k++;
                            }
                        }
                        
                        pb1.Value += 1; // ПрогрессБар смещается. 

                        // Выгрузка 100 ссылок в временный файл. 
                        if ((globalcount % 100) == 0)
                        {
                            File.AppendAllText(Application.StartupPath + "\\tmp.txt", link);
                            link = "";
                        }
                        else
                        {
                            // Nothing. 
                        }

                        line = str.ReadLine();
                    }   // Пока строка не равна null.
                    File.AppendAllText(Application.StartupPath + "\\tmp.txt", link);

                    
                    // Вывести обработанный список в текстбокс.
                    tb_main.Text = File.ReadAllText(Application.StartupPath + "\\tmp.txt");
                    pb1.Value += Convert.ToInt32(count / 10);
                    // Снять показатели времени выполнения.
                    dtEnd = DateTime.Now;
                }

                File.Delete(Application.StartupPath + "\\tmp.txt");

                if (testTime)
                {
                    MessageBox.Show($"Полученные результаты:\r\n{dtEnd.Subtract(dtStart)} сек. на {globalcount} " +
                        $"ссылок.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Что-то пошло не так. Проверьте формат открываемого файла.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_main.Text = "";
                pb1.Visible = false;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFDialog = new SaveFileDialog();
            SFDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            SFDialog.RestoreDirectory = true;
            SFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            SFDialog.FilterIndex = 2;
            

            if (SFDialog.ShowDialog() == DialogResult.Cancel)
                return;

            File.WriteAllText(SFDialog.FileName, tb_main.Text);

        }

        private void rb_dot_CheckedChanged(object sender, EventArgs e)
        {
            separator = ".";
            label1.Visible = true;
            label2.Visible = true;
        }

        private void rb_dotDash_CheckedChanged(object sender, EventArgs e)
        {
            separator = ".-";
            label1.Visible = true;
            label2.Visible = true;
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вас приветствует приложение Scopus.BibTeX.GOST Formatter!\r\n" +
                "Данное приложение позволит вам в считанные секунды создать список источников, оформленный в соответствии с ГОСТ." +
                $"\r\n{Convert.ToChar(8226)} Перед началом работы выберите разделитель для вашего списка (\".\" или \".-\"). " +
                $"Обратите внимание, что по умолчанию используется первый вариант." +
                $"\r\n{(Char)8226} Для начала работы откройте файл с метаданными, загруженными с сайта Scopus, и программа автоматически" +
                $" обработает ваш список." +
                $"\r\n{(Char)8226} После обработки вы можете скопировать список из окна приложения или сохранить его как отдельный файл " +
                $"с расширением .txt в память вашего компьютера." +
                $"\r\n{(Char)8226} Несмотря на ограничения сайта Scopus в 2000 экспортирумые ссылки, вы можете самостоятельно объединить " +
                $"файлы в один и обработать его разом. К сожалению, функционал автоматизации этого процесса еще не доступен и вам придется " +
                $"вручную объединять файлы." +
                $"\r\n{(Char)8226} В случе любых проблем и затруднений обращайтесь на scopus.gost.techsup@mail.ru",
                $"Справка.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void тестироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testTime = true;
        }

        private void неТестироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testTime = false;
        }

        
    }
}
