using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataProcessingSystem
{
    public partial class Form_Main : Form
    {
        //Установка статуса(делегата)
        public delegate void SetStatus(object ss, String status, Color color);
        //Делегата для статуса(функция делегаты)
        public static SetStatus setStatus = (object ss, String status, Color color) =>
            {
                try
                {
                    //Меняем статус в зависимости от цвета
                    if (color == Color.Red)
                    {
                        Status.Error = true;
                    }
                    else
                    {
                        Status.Error = false;
                    }
                    //Пишем в сам статус
                    ToolStripStatusLabel tssl = (ToolStripStatusLabel)ss;
                    tssl.Text = status;
                    tssl.ForeColor = color;
                }
                catch (Exception)
                {
                }
            };

        //Установка статуса(функция формы)
        private void editstatus(String status, Color color)
        {
            this.statusStrip_Status.BeginInvoke(setStatus, new object[] { toolStripStatusLabel_StatusLable, status, color });
        }
        //Инициализация формы
        public Form_Main()
        {
            try
            {
                InitializeComponent();
                //Видимость кнопок управления графиками(вперед,назад и т.п.)
                VisibleInvisible(false);
                
            }
            catch (Exception)
            {
                editstatus("Ошибка запуска программы. Критическая ошибка инициализации.", Color.Red);
            }
        }
        //Функция очистки значений
        private void Clear()
        {
            //Очиска всех значащих значений
            editstatus("Очистка памяти.", Color.Black);
            chart_MainChart.Series[0].Points.Clear();
            chart_MainChart.Series[1].Points.Clear();
            chart_Mini.Series[0].Points.Clear();
            //
        }
        //Функция меняющая видимость управляющих кнопок в зависимости от параметров
        private void VisibleInvisible(Boolean visibleable = true)
        {
            //Видимость управляющих кнопок
            panel1.Visible = visibleable;
//            button_Next.Visible = visibleable;
//            button_Previous.Visible = visibleable;
//            button_Processing.Visible = visibleable;
//            button_DeleteFile.Visible = visibleable;
//            button_Min.Visible = visibleable;
//            button_Max.Visible = visibleable;
//            button_CutMax.Visible = visibleable;
//            button_CutMin.Visible = visibleable;
//            label1.Visible = visibleable;
//            chart_MainChart.Visible = visibleable;
        }
        //Выбор файла из верхнего-раскрывающегося меню(по сути начало работы)
        private void выборToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog_OpenFIle.ShowDialog();
            //Устанавливаем глобальные значения переменных
            if (String.IsNullOrEmpty(openFileDialog_OpenFIle.FileName))
            {
                return;
            }
            string path = openFileDialog_OpenFIle.FileName;
            Global.filename = System.IO.Path.GetFileName(path);
            Global.directory = System.IO.Path.GetDirectoryName(path);
            //
            editstatus("Имя файла принято.", Color.LawnGreen);
            //
            this.label1.Text = System.IO.Path.GetFileName(path);
            //Собственно занимаемся работой над файлом
            BuildFile(path);
            //Меняем видимость кнопок управления
            //Но только после успешного завершения!
            if(!Status.Error)
                VisibleInvisible(true);
            
        }
        //Обработка файла
        public void BuildFile()
        {
            //Вначале чистим все графики
            Clear();
            try
            {
                //Пытаемся распарсить файл и записать его в Chart
                Parser.ParsFile(chart_MainChart, 0);
                editstatus("Файл успешно обработан.", Color.Green);
            }
            catch (Exception exception)
            {
                //editstatus(exception.Message,Color.Red);
                editstatus("Неверная структура файла. Ошибка форматов.", Color.Red);
                return;
            }
        }
        //Обработка файла
        public void BuildFile(String path)
        {
            //Вначале чистим все графики
            Clear();
            try
            {
                //Пытаемся распарсить файл и записать его в Chart
                Parser.ParsFile(chart_MainChart, 0, path);
                editstatus("Файл успешно обработан.", Color.Green);
            }
            catch (Exception exception)
            {
                //editstatus(exception.Message,Color.Red);
                editstatus("Неверная структура файла. Ошибка форматов.", Color.Red);
                return;
            }
        }
        //Выбор следующего файла из списка
        private void button_Next_Click(object sender, EventArgs e)
        {
            try
            {
                //Получаем список всех файлов в директории
                //Исходя из текущего выбранного файла
                List<String> files = new List<string>();
                files = Directory.GetFiles(Global.directory).ToList();
                for (int i = 0; i < files.Count; i++)
                {
                    //Ищем в среди этих файлов наш файл
                    //И берем следующий (i + 1)
                    if (System.IO.Path.GetFileName(files[i]) == Global.filename)
                    {
                        Global.filename = System.IO.Path.GetFileName(files[i + 1]);
                        label1.Text = Global.filename;
                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                editstatus(exception.Message, Color.Red);
            }
            BuildFile();
        }
        //Выбор предыдущего файла из списка
        private void button_Previous_Click(object sender, EventArgs e)
        {
            try
            {
                //Получаем список всех файлов в директории
                //Исходя из текущего выбранного файла
                List<String> files = new List<string>();
                files = Directory.GetFiles(Global.directory).ToList();
                editstatus("Ищем следующий файл...", Color.Black);
                for (int i = 0; i < files.Count; i++)
                {
                    //Ищем в среди этих файлов наш файл
                    //И берем следующий (i - 1)
                    if (System.IO.Path.GetFileName(files[i]) == Global.filename)
                    {
                        if (i <= 0) break;
                        Global.filename = System.IO.Path.GetFileName(files[i - 1]);
                        label1.Text = Global.filename;
                        editstatus("Файл найден.", Color.LawnGreen);
                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                editstatus(exception.Message, Color.Red);
            }
            BuildFile();
        }
        //После загрузки формы
        private void Form1_Load(object sender, EventArgs e)
        {
            красныйToolStripMenuItem_Click(sender,e);
            синийToolStripMenuItem1_Click(sender,e);
        }
        //Удаление файла
        private void button_DeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                //Запоминаем имя файла для удаления
                Global.filenameForDelete = Global.filename;
                
                //И сразу перескакиваем на следующий
                try
                {
                    button_Next_Click(button_Next, e);
                    //Пытаемся удалить файл по текущему пути
                    File.Delete(Global.directory + "/" + Global.filenameForDelete);
                    Global.filenameForDelete = "";
                }
                //...или если не получилось
                catch (Exception)
                {
                    //то на предыдущий
                    try
                    {
                        button_Previous_Click(button_Next, e);
                        //Пытаемся удалить файл по текущему пути
                        File.Delete(Global.directory + "/" + Global.filenameForDelete);
                        Global.filenameForDelete = "";
                    }
                    //...а если и так не вышло
                    catch (Exception exception)
                    {
                        //то пишем в логи
                        editstatus(exception.Message, Color.Red);
                    }
                }
                editstatus("Файл " + Global.filename + " успешно удален.", Color.Green);
            }
            catch (Exception exception)
            {
                editstatus(exception.Message, Color.Red);
            }
            
        }
        //Кнорка обработки
        //Посылаем файл на обработку
        private void button_Processing_Click(object sender, EventArgs e)
        {
            try
            {
                //Чистим chart для вывода обработанного графика
                chart_Mini.Series[0].Points.Clear();
                //Инициализируем путь к исходящий директории
                Global.outputfileDirectory = Global.directory + "/" + "Processing" + "_" + System.DateTime.Now.Day + "." + System.DateTime.Now.Month + "." + System.DateTime.Now.Year;
                //Создаем исходящий файл исходя из кучи параметров
                Global.outputfileName = System.IO.Path.GetFileNameWithoutExtension(Global.filename) + 
                    "_Processing(" + Global.slip + ")" + 
                    System.IO.Path.GetExtension(Global.filename);
                //Создаем исходящую дирректорию
                Directory.CreateDirectory(Global.outputfileDirectory);
                editstatus("Выходная дирректория успешно создана.", Color.LawnGreen);
            }
            catch (Exception exception)
            {
                editstatus(exception.Message, Color.Red);
            }
            
            try
            {
                //Парсим файл но уже с обработкой
                Parser.ParsFileWithProcessing(chart_Mini, 0);
                editstatus("Файл успешно прошел обработку и распечатан.", Color.Green);
            }
            catch (Exception exception)
            {
                editstatus(exception.Message, Color.Red);
            }
            
        }
        //Меняем значения "скольжения"
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Global.slip = 1;
            toolStripMenuItem6.Checked = true;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem7.Checked = false;
        }
        //Меняем значения "скольжения"
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Global.slip = 50;
            toolStripMenuItem3.Checked = true;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
        }
        //Меняем значения "скольжения"
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Global.slip = 100;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = true;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            toolStripMenuItem5.Checked = false;
        }
        //Меняем значения "скольжения"
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Global.slip = 150;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem5.Checked = true;
            toolStripMenuItem7.Checked = false;
        }
        //Меняем значения "скольжения"
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Global.slip = 200;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem7.Checked = true;
        }
        
        //Выход из приложения
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Выводим автора приложения
        private void авторToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.ShowDialog();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Флаг меняющий видимость графика отвечающего за результат обработки и выводящий его
        private void checkBox_ResultOfProcessing_CheckedChanged(object sender, EventArgs e)
        {
            показыватьГрафикToolStripMenuItem.Checked = chart_Mini.Visible = checkBox_ResultOfProcessing.Checked;
        }
        //Флаг меняющий видимость графика отвечающего за результат обработки и выводящий его
        private void показыватьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (показыватьГрафикToolStripMenuItem.Checked)
                показыватьГрафикToolStripMenuItem.Checked = false;
            else
                показыватьГрафикToolStripMenuItem.Checked = true;
            checkBox_ResultOfProcessing.Checked = chart_Mini.Visible = показыватьГрафикToolStripMenuItem.Checked;
        }
        //Нахождение минимума по выделенной области
        private void button_Min_Click(object sender, EventArgs e)
        {
            double xmax = chart_MainChart.ChartAreas[0].AxisX.ScaleView.Position + chart_MainChart.ChartAreas[0].AxisX.ScaleView.Size;
            double xmin = chart_MainChart.ChartAreas[0].AxisX.ScaleView.Position;
            int index = 0;
            double minumum = 1000000 * Global.multiplication;
            for (int i = 0; i < chart_MainChart.Series[0].Points.Count; i++)
            {
                if (chart_MainChart.Series[0].Points[i].XValue > xmin &&
                    chart_MainChart.Series[0].Points[i].XValue < xmax)
                {
                    if (chart_MainChart.Series[0].Points[i].YValues[0] < minumum)
                    {
                        minumum = chart_MainChart.Series[0].Points[i].YValues[0];
                        index = i;
                    }
                }
                if (chart_MainChart.Series[0].Points.ToList()[i].XValue < xmin)
                {
                    continue;
                }
                if (chart_MainChart.Series[0].Points.ToList()[i].XValue > xmax)
                {
                    break;
                }
            }
            if (index == 0)
                return;
            chart_MainChart.Series[1].Points.AddXY(index,minumum);
            Points.xmin = index;
        }
        //Нахождение максимума по выделенной области
        private void button_Max_Click(object sender, EventArgs e)
        {
            double xmax = chart_MainChart.ChartAreas[0].AxisX.ScaleView.Position + chart_MainChart.ChartAreas[0].AxisX.ScaleView.Size;
            double xmin = chart_MainChart.ChartAreas[0].AxisX.ScaleView.Position;
            int index = 0;
            double maximum = -1000000 *Global.multiplication;
            for (int i = 0; i < chart_MainChart.Series[0].Points.Count; i++)
            {
                if (chart_MainChart.Series[0].Points[i].XValue > xmin &&
                    chart_MainChart.Series[0].Points[i].XValue < xmax)
                {
                    if (chart_MainChart.Series[0].Points[i].YValues[0] > maximum)
                    {
                        maximum = chart_MainChart.Series[0].Points[i].YValues[0];
                        index = i;
                    }
                }
                if (chart_MainChart.Series[0].Points.ToList()[i].XValue < xmin)
                {
                    continue;
                }
                if (chart_MainChart.Series[0].Points.ToList()[i].XValue > xmax)
                {
                    break;
                }
            }
            if (index == 0)
                return;
            chart_MainChart.Series[1].Points.AddXY(index, maximum);
            Points.xmax = index;
        }
        //Обрезка по минемальному значению
        private void поМинимальномуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Чистим chart для вывода обработанного графика
                Clear();
                //Инициализируем путь к исходящий директории
                Global.outputfileDirectory = Global.directory + "/" + "CutMinimum" + "_" + System.DateTime.Now.Day + "." + System.DateTime.Now.Month + "." + System.DateTime.Now.Year;
                //Создаем исходящий файл исходя из кучи параметров
                Global.outputfileName = System.IO.Path.GetFileNameWithoutExtension(Global.filename) +
                    "_CutMinimum(" + Global.slip + ")" +
                    System.IO.Path.GetExtension(Global.filename);
                //Создаем исходящую дирректорию
                Directory.CreateDirectory(Global.outputfileDirectory);
                editstatus("Выходная дирректория успешно создана.", Color.LawnGreen);
            }
            catch (Exception exception)
            {
                editstatus(exception.Message, Color.Red);
            }
            try
            {
                //Режем по минимум без обработки
                Functions.CutMinimumChart(chart_MainChart,0);
                editstatus("Файл успешно прошел обрезку и распечатан.", Color.Green);
            }
            catch (Exception exception)
            {
                editstatus(exception.Message, Color.Red);
            }
        }
        //Обрезка по максимальному значения
        private void поМаксимальномуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Чистим chart для вывода обработанного графика
                Clear();
                //Инициализируем путь к исходящий директории
                Global.outputfileDirectory = Global.directory + "/" + "CutMaximum" + "_" + System.DateTime.Now.Day + "." + System.DateTime.Now.Month + "." + System.DateTime.Now.Year;
                //Создаем исходящий файл исходя из кучи параметров
                Global.outputfileName = System.IO.Path.GetFileNameWithoutExtension(Global.filename) +
                    "_CutMaximum(" + Global.slip + ")" +
                    System.IO.Path.GetExtension(Global.filename);
                //Создаем исходящую дирректорию
                Directory.CreateDirectory(Global.outputfileDirectory);
                editstatus("Выходная дирректория успешно создана.", Color.LawnGreen);
            }
            catch (Exception exception)
            {
                editstatus(exception.Message, Color.Red);
            }
            try
            {
                //Режем по максимуму без обработки
                Functions.CutMaximumChart(chart_MainChart, 0);
                editstatus("Файл успешно прошел обрезку и распечатан.", Color.Green);
            }
            catch (Exception exception)
            {
                editstatus(exception.Message, Color.Red);
            }
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart_MainChart.Series[1].Color = Color.Red;
            красныйToolStripMenuItem.Checked = true;
            зеленыйToolStripMenuItem.Checked = false;
            синийToolStripMenuItem.Checked = false;
            оранжевыйToolStripMenuItem.Checked = false;
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart_MainChart.Series[1].Color = Color.Green;
            красныйToolStripMenuItem.Checked = false;
            зеленыйToolStripMenuItem.Checked = true;
            синийToolStripMenuItem.Checked = false;
            оранжевыйToolStripMenuItem.Checked = false;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart_MainChart.Series[1].Color = Color.Blue;
            красныйToolStripMenuItem.Checked = false;
            зеленыйToolStripMenuItem.Checked = false;
            синийToolStripMenuItem.Checked = true;
            оранжевыйToolStripMenuItem.Checked = false;
        }

        private void оранжевыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart_MainChart.Series[1].Color = Color.Orange;
            красныйToolStripMenuItem.Checked = false;
            зеленыйToolStripMenuItem.Checked = false;
            синийToolStripMenuItem.Checked = false;
            оранжевыйToolStripMenuItem.Checked = true;
        }

        private void красныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            chart_MainChart.Series[0].Color = Color.Red;
            красныйToolStripMenuItem1.Checked = true;
            зеленыйToolStripMenuItem1.Checked = false;
            синийToolStripMenuItem1.Checked = false;
            оранжевыйToolStripMenuItem1.Checked = false;
        }

        private void зеленыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            chart_MainChart.Series[0].Color = Color.Green;
            красныйToolStripMenuItem1.Checked = false;
            зеленыйToolStripMenuItem1.Checked = true;
            синийToolStripMenuItem1.Checked = false;
            оранжевыйToolStripMenuItem1.Checked = false;
        }

        private void синийToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            chart_MainChart.Series[0].Color = Color.Blue;
            красныйToolStripMenuItem1.Checked = false;
            зеленыйToolStripMenuItem1.Checked = false;
            синийToolStripMenuItem1.Checked = true;
            оранжевыйToolStripMenuItem1.Checked = false;
        }

        private void оранжевыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            chart_MainChart.Series[0].Color = Color.Orange;
            красныйToolStripMenuItem1.Checked = false;
            зеленыйToolStripMenuItem1.Checked = false;
            синийToolStripMenuItem1.Checked = false;
            оранжевыйToolStripMenuItem1.Checked = true;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Global.multiplication = 1;
            toolStripMenuItem8.Checked = true;
            toolStripMenuItem2.Checked = false;
            BuildFile(Global.directory + "/" + Global.filename);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Global.multiplication = 1000;
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem2.Checked = true;
            BuildFile(Global.directory + "/" + Global.filename);
        }

       

    }
}
