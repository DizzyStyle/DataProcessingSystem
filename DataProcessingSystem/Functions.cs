using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO.MemoryMappedFiles;

namespace DataProcessingSystem
{
    //Класс для координаты/точки..)
    //Содержит два значения
    //Int32 - x - значение по оси X
    //Double - y - значение по оси Y
    public class XY
    {
        //Конструктор этого класса получающий два числа
        public XY(int _x, double _y)
        {
            x = _x;
            y = _y;
        }
        //Собственно координаты
        public int x;
        public double y;
    }
    //Массив точек(точнее их список)
    //И функции для работы с ним
    //Вычисление среднего
    //Получение первого X
    //Добавление значения
    //Сдвиг значений на один влево и добавление еще одного
    public class Massive
    {
        //Сам массив
        public List<XY> massive = new List<XY>(Global.slip); 
        //Конструктор, инициализирует массив
        public Massive()
        {
            massive = new List<XY>(Global.slip);
            for (int i = 0; i < Global.slip; i++)
            {
                massive.Add(null);
            }
        }
        //Сдвиг массива на один влево и добавление нового элемента
        public void Shift(XY element)
        {
            for (int i = 0; i < Global.slip - 1; i++)
            {
                massive[i] = massive[i + 1];
            }
            massive[Global.slip - 1] = element;
        }
        //Добавление нового элемента
        //Вернет false, если это невозможно
        public bool Add(XY element)
        {
            for (int i = 0; i < Global.slip; i++)
            {
                if (massive[i] == null)
                {
                    massive[i] = element;
                    return true;
                }
            }
            return false;
        }
        //Нахождение среднего среди всех элементов по Y
        public double Middle()
        {
            double S = 0;
            foreach (var xy in massive)
            {
                S += xy.y;
            }
            return S/Global.slip;
        }
        //Получение X
        public int GetXById(int id = 0)
        {
            try
            {
                return massive[id].x;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        //Получение Y
        public double GetYById(int id = 0)
        {
            try
            {
                return massive[id].y;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        //Получение первого X
        public int GetXFirst()
        {
            try
            {
                return massive[0].x;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        //Получение последнего X
        public int GetXLast()
        {
            try
            {
                return massive[Global.slip - 1].x;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        //Получение последнего Y
        public double GetYLast()
        {
            try
            {
                return massive[Global.slip - 1].y;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        //Получение последнего Y
        public double GetYFirst()
        {
            try
            {
                return massive[0].y;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
    //Набор функций
    public static class Functions
    {
        //Построение графика по точкам (XY)(всех в массиве!)
        public static void BuildChart(List<XY> points , Chart chart, int seriesID)
        {
            foreach (var point in points)
            {
                //Добавление точек на график
                chart.Series[seriesID].Points.AddXY(point.x,point.y);
            }
            return;
        }
        //Добавление точки на график(одной!)
        public static void BuildChart(XY point, Chart chart, int seriesID)
        {
            chart.Series[seriesID].Points.AddXY(point.x, point.y);
            return;
        }

        //Обрезка файла по минимуму
        public static void CutMinimumChart(Chart chart, int seriesID, String path = null)
        {
            //Открывам поток на чтение файла(читалку) с кодировкой для русского формата
            StreamReader sr = new StreamReader(Global.directory + "/" + Global.filename, Encoding.GetEncoding("windows-1251"));
            //Проверяем, существует ли исходящий файл уже
            if (System.IO.File.Exists(Global.outputfileDirectory + "/" + Global.outputfileName))
            {
                //Если да - стираем его
                System.IO.File.Delete(Global.outputfileDirectory + "/" + Global.outputfileName);
            }
            //Открываем исходящий поток и создаем исходящий файл по указанному ранее(в Form пути)
            StreamWriter sw = new StreamWriter(Global.outputfileDirectory + "/" + Global.outputfileName, true, Encoding.GetEncoding("windows-1251"));
            //Записываем первую строчку из одного файла в другой 
            sw.WriteLine(sr.ReadLine());
            //Читаем до упора
            while (!sr.EndOfStream)
            {
                //Записываем каждую считаную строку в буффер
                String buffer = sr.ReadLine();
                //Парсим ее на значения
                int x = Int32.Parse(buffer.Split(';')[0]);
                if (x < 0)
                    continue;
                double y = Double.Parse(buffer.Split(';')[1]);
                //Инициализруем точку
                XY point = new XY(x, y);
                //Если точка стала дальше минимума то пишем в файл
                if (x>Points.xmin)
                {
                    //Получаем строку для записи в другой файл
                    string value = x + ";" + y + ";";
                    //Записываем в него уже новые значения с посчитаным средним
                    sw.WriteLine(value);
                    //Добавляем точки на график
                    Functions.BuildChart(new XY(x, y), chart, seriesID);
                }
            }
            //Закрываем потоки которые блокируют этот файл
            sr.Close();
            sw.Close();

        }
        //Обрезка файла по минимуму
        public static void CutMaximumChart(Chart chart, int seriesID, String path = null)
        {
            //Открывам поток на чтение файла(читалку) с кодировкой для русского формата
            StreamReader sr = new StreamReader(Global.directory + "/" + Global.filename, Encoding.GetEncoding("windows-1251"));
            //Проверяем, существует ли исходящий файл уже
            if (System.IO.File.Exists(Global.outputfileDirectory + "/" + Global.outputfileName))
            {
                //Если да - стираем его
                System.IO.File.Delete(Global.outputfileDirectory + "/" + Global.outputfileName);
            }
            //Открываем исходящий поток и создаем исходящий файл по указанному ранее(в Form пути)
            StreamWriter sw = new StreamWriter(Global.outputfileDirectory + "/" + Global.outputfileName, true, Encoding.GetEncoding("windows-1251"));
            //Записываем первую строчку из одного файла в другой 
            sw.WriteLine(sr.ReadLine());
            //Читаем до упора
            while (!sr.EndOfStream)
            {
                //Записываем каждую считаную строку в буффер
                String buffer = sr.ReadLine();
                //Парсим ее на значения
                int x = Int32.Parse(buffer.Split(';')[0]);
                if (x < 0)
                    continue;
                double y = Double.Parse(buffer.Split(';')[1]);
                //Инициализруем точку
                XY point = new XY(x, y);
                //Если точка стала дальше минимума то пишем в файл
                if (x > Points.xmax)
                {
                    //Получаем строку для записи в другой файл
                    string value = x + ";" + y + ";";
                    //Записываем в него уже новые значения с посчитаным средним
                    sw.WriteLine(value);
                    //Добавляем точки на график
                    Functions.BuildChart(new XY(x, y), chart, seriesID);
                }
            }
            //Закрываем потоки которые блокируют этот файл
            sr.Close();
            sw.Close();

        }
    }
    //Функции для обработки файла
    public static class Parser
    {
        //Парсинг самого файла и рисование графика
        public static void ParsFile(Chart chart, int seriesID, String path = null)
        {
            //Если входная строка пути не задана, значит берем значение из глобальной переменной
            //Сделано для возможности как управлять читаемым файлом, так и чтением из
            //объекта по умолчанию
            if (String.IsNullOrEmpty(path))
                path = Global.directory + "/" + Global.filename;
            //Открываем поток для чтения(читалку) с кодировкой для русского формата
            StreamReader sr = new StreamReader(path,Encoding.GetEncoding("windows-1251"));
            //Пропускаем первую линию
            sr.ReadLine();
            //...а теперь читаем до  упора
            while (!sr.EndOfStream)
            {
                //Записываем каждую строку в буффер
                String buffer = sr.ReadLine();
                //Парсим наш буффер
                int x = Int32.Parse(buffer.Split(';')[0]);
                if (x < 0)
                    continue;
                double y = Double.Parse(buffer.Split(';')[1]) * Global.multiplication;
                //Инициализруем точку
                XY point = new XY(x, y);
                //Печатаем точку
                Functions.BuildChart(point, chart, seriesID);
                //points.Add(point);
            }
            //Закрываем читалку
            sr.Close();
        }
        //Парсер с обработкой и рисование графика
        public static void ParsFileWithProcessing(Chart chart, int seriesID)
        {
            //Создаем массив на необходимый набор значений
            Massive massive = new Massive();
            //Открывам поток на чтение файла(читалку) с кодировкой для русского формата
            StreamReader sr = new StreamReader(Global.directory + "/" + Global.filename, Encoding.GetEncoding("windows-1251"));
            //Проверяем, существует ли исходящий файл уже
            if (System.IO.File.Exists(Global.outputfileDirectory + "/" + Global.outputfileName))
            {
                //Если да - стираем его
                System.IO.File.Delete(Global.outputfileDirectory + "/" + Global.outputfileName);
            }
            //Открываем исходящий поток и создаем исходящий файл по указанному ранее(в Form пути)
            StreamWriter sw = new StreamWriter(Global.outputfileDirectory + "/" + Global.outputfileName, true, Encoding.GetEncoding("windows-1251"));
            //Записываем первую строчку из одного файла в другой 
            sw.WriteLine(sr.ReadLine());
            //Читаем до упора
            while (!sr.EndOfStream)
            {
                //Записываем каждую считаную строку в буффер
                String buffer = sr.ReadLine();
                //Парсим ее на значения
                int x = Int32.Parse(buffer.Split(';')[0]);
                if (x < 0)
                    continue;
                double y = Double.Parse(buffer.Split(';')[1]) * Global.multiplication;
                //Инициализруем точку
                XY point = new XY(x, y);
                //Пытаемся добавить ее в массив значений для дальнейшей обработки
                //если это удалось идем дальше
                if (!massive.Add(point))
                {
                    //если нет, значит массив уже заполнен, пора рисовать и считать
                    //Получаем строку для записи в другой файл
                    string value = massive.GetXFirst() + ";" + massive.Middle() + ";";
                    //Записываем в него уже новые значения с посчитаным средним
                    sw.WriteLine(value);
                    //Добавляем точки на график
                    Functions.BuildChart(new XY(massive.GetXFirst(), massive.Middle()), chart, seriesID);
                    //Сдвигаем массив и добавляем новое значение
                    massive.Shift(point);
                }
            }
            //Закрываем потоки которые блокируют этот файл
            sr.Close();
            sw.Close();
        }
    }
}
