using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Глобальные классы (видимы отовсюду)
namespace DataProcessingSystem
{
    //Глобальные переменные
    public static class Global
    {
        //Имя текущего файла
        public static String filename = "";
        //Директория где лежит текущий файл
        public static String directory = "";
        //Уровень сглаживания
        public static Int32 slip = 50;
        //Значение умножения
        public static Int32 multiplication = 1;
        //Исходящий файл для обработки
        public static String outputfileName = "";
        //Исходящая дирректория для обработки
        public static String outputfileDirectory = "";
        //Файл для удаления
        public static String filenameForDelete = "";
    }
    //Статус программы #разработка#
    public static class Status
    {
        //Указывает есть ли ошибка
        public static Boolean Error = false;
    }
    //Переменные для обрезки графиков
    public static class Points
    {
        public static int xmin = 0;
        public static int xmax = 0;
    }
}
