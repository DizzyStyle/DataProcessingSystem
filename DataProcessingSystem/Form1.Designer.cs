using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DataProcessingSystem
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.chart_MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip_Menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.следующийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предыдущийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обработкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скользящийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.умножитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показыватьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обрезкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поМинимальномуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поМаксимальномуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветТочекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.красныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оранжевыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветЛинииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.красныйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.синийToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оранжевыйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_Status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_StatusLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog_OpenFIle = new System.Windows.Forms.OpenFileDialog();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Previous = new System.Windows.Forms.Button();
            this.button_Processing = new System.Windows.Forms.Button();
            this.button_DeleteFile = new System.Windows.Forms.Button();
            this.chart_Mini = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox_ResultOfProcessing = new System.Windows.Forms.CheckBox();
            this.button_Browser = new System.Windows.Forms.Button();
            this.button_Min = new System.Windows.Forms.Button();
            this.button_Max = new System.Windows.Forms.Button();
            this.button_CutMax = new System.Windows.Forms.Button();
            this.button_CutMin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MainChart)).BeginInit();
            this.menuStrip_Menu.SuspendLayout();
            this.statusStrip_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Mini)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_MainChart
            // 
            chartArea1.CursorX.Interval = 1E-09D;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.Interval = 1E-09D;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chart_MainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_MainChart.Legends.Add(legend1);
            this.chart_MainChart.Location = new System.Drawing.Point(4, 51);
            this.chart_MainChart.Name = "chart_MainChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Импульс";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Точки";
            this.chart_MainChart.Series.Add(series1);
            this.chart_MainChart.Series.Add(series2);
            this.chart_MainChart.Size = new System.Drawing.Size(736, 350);
            this.chart_MainChart.TabIndex = 0;
            this.chart_MainChart.Text = "chart1";
            // 
            // menuStrip_Menu
            // 
            this.menuStrip_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.обработкаToolStripMenuItem,
            this.настройкаToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip_Menu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Menu.Name = "menuStrip_Menu";
            this.menuStrip_Menu.Size = new System.Drawing.Size(739, 24);
            this.menuStrip_Menu.TabIndex = 1;
            this.menuStrip_Menu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборToolStripMenuItem,
            this.следующийToolStripMenuItem,
            this.предыдущийToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.файлToolStripMenuItem.Text = "Меню";
            // 
            // выборToolStripMenuItem
            // 
            this.выборToolStripMenuItem.Name = "выборToolStripMenuItem";
            this.выборToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.выборToolStripMenuItem.Text = "Открыть";
            this.выборToolStripMenuItem.Click += new System.EventHandler(this.выборToolStripMenuItem_Click);
            // 
            // следующийToolStripMenuItem
            // 
            this.следующийToolStripMenuItem.Name = "следующийToolStripMenuItem";
            this.следующийToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.следующийToolStripMenuItem.Text = "Следующий";
            this.следующийToolStripMenuItem.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // предыдущийToolStripMenuItem
            // 
            this.предыдущийToolStripMenuItem.Name = "предыдущийToolStripMenuItem";
            this.предыдущийToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.предыдущийToolStripMenuItem.Text = "Предыдущий";
            this.предыдущийToolStripMenuItem.Click += new System.EventHandler(this.button_Previous_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // обработкаToolStripMenuItem
            // 
            this.обработкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скользящийToolStripMenuItem,
            this.умножитьToolStripMenuItem,
            this.результатыToolStripMenuItem,
            this.обрезкаToolStripMenuItem});
            this.обработкаToolStripMenuItem.Name = "обработкаToolStripMenuItem";
            this.обработкаToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.обработкаToolStripMenuItem.Text = "Обработка";
            // 
            // скользящийToolStripMenuItem
            // 
            this.скользящийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem7});
            this.скользящийToolStripMenuItem.Name = "скользящийToolStripMenuItem";
            this.скользящийToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.скользящийToolStripMenuItem.Text = "Скользящий";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Checked = true;
            this.toolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "50";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = "100";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem5.Text = "150";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem7.Text = "200";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // умножитьToolStripMenuItem
            // 
            this.умножитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem2});
            this.умножитьToolStripMenuItem.Name = "умножитьToolStripMenuItem";
            this.умножитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.умножитьToolStripMenuItem.Text = "Размерность";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Checked = true;
            this.toolStripMenuItem8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem8.Text = "В";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "мВ";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // результатыToolStripMenuItem
            // 
            this.результатыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показыватьГрафикToolStripMenuItem});
            this.результатыToolStripMenuItem.Name = "результатыToolStripMenuItem";
            this.результатыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.результатыToolStripMenuItem.Text = "Результаты";
            // 
            // показыватьГрафикToolStripMenuItem
            // 
            this.показыватьГрафикToolStripMenuItem.Checked = true;
            this.показыватьГрафикToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.показыватьГрафикToolStripMenuItem.Name = "показыватьГрафикToolStripMenuItem";
            this.показыватьГрафикToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.показыватьГрафикToolStripMenuItem.Text = "Показывать график";
            this.показыватьГрафикToolStripMenuItem.Click += new System.EventHandler(this.показыватьГрафикToolStripMenuItem_Click);
            // 
            // обрезкаToolStripMenuItem
            // 
            this.обрезкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поМинимальномуToolStripMenuItem,
            this.поМаксимальномуToolStripMenuItem});
            this.обрезкаToolStripMenuItem.Name = "обрезкаToolStripMenuItem";
            this.обрезкаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.обрезкаToolStripMenuItem.Text = "Обрезка";
            // 
            // поМинимальномуToolStripMenuItem
            // 
            this.поМинимальномуToolStripMenuItem.Name = "поМинимальномуToolStripMenuItem";
            this.поМинимальномуToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.поМинимальномуToolStripMenuItem.Text = "По минимальному";
            this.поМинимальномуToolStripMenuItem.Click += new System.EventHandler(this.поМинимальномуToolStripMenuItem_Click);
            // 
            // поМаксимальномуToolStripMenuItem
            // 
            this.поМаксимальномуToolStripMenuItem.Name = "поМаксимальномуToolStripMenuItem";
            this.поМаксимальномуToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.поМаксимальномуToolStripMenuItem.Text = "По максимальному";
            this.поМаксимальномуToolStripMenuItem.Click += new System.EventHandler(this.поМаксимальномуToolStripMenuItem_Click);
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветТочекToolStripMenuItem,
            this.цветЛинииToolStripMenuItem});
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.настройкаToolStripMenuItem.Text = "Настройка";
            // 
            // цветТочекToolStripMenuItem
            // 
            this.цветТочекToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.красныйToolStripMenuItem,
            this.зеленыйToolStripMenuItem,
            this.синийToolStripMenuItem,
            this.оранжевыйToolStripMenuItem});
            this.цветТочекToolStripMenuItem.Name = "цветТочекToolStripMenuItem";
            this.цветТочекToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.цветТочекToolStripMenuItem.Text = "Цвет точек";
            // 
            // красныйToolStripMenuItem
            // 
            this.красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            this.красныйToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.красныйToolStripMenuItem.Text = "Красный";
            this.красныйToolStripMenuItem.Click += new System.EventHandler(this.красныйToolStripMenuItem_Click);
            // 
            // зеленыйToolStripMenuItem
            // 
            this.зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            this.зеленыйToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.зеленыйToolStripMenuItem.Text = "Зеленый";
            this.зеленыйToolStripMenuItem.Click += new System.EventHandler(this.зеленыйToolStripMenuItem_Click);
            // 
            // синийToolStripMenuItem
            // 
            this.синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            this.синийToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.синийToolStripMenuItem.Text = "Синий";
            this.синийToolStripMenuItem.Click += new System.EventHandler(this.синийToolStripMenuItem_Click);
            // 
            // оранжевыйToolStripMenuItem
            // 
            this.оранжевыйToolStripMenuItem.Checked = true;
            this.оранжевыйToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.оранжевыйToolStripMenuItem.Name = "оранжевыйToolStripMenuItem";
            this.оранжевыйToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.оранжевыйToolStripMenuItem.Text = "Оранжевый";
            this.оранжевыйToolStripMenuItem.Click += new System.EventHandler(this.оранжевыйToolStripMenuItem_Click);
            // 
            // цветЛинииToolStripMenuItem
            // 
            this.цветЛинииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.красныйToolStripMenuItem1,
            this.зеленыйToolStripMenuItem1,
            this.синийToolStripMenuItem1,
            this.оранжевыйToolStripMenuItem1});
            this.цветЛинииToolStripMenuItem.Name = "цветЛинииToolStripMenuItem";
            this.цветЛинииToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.цветЛинииToolStripMenuItem.Text = "Цвет линии";
            // 
            // красныйToolStripMenuItem1
            // 
            this.красныйToolStripMenuItem1.Name = "красныйToolStripMenuItem1";
            this.красныйToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.красныйToolStripMenuItem1.Text = "Красный";
            this.красныйToolStripMenuItem1.Click += new System.EventHandler(this.красныйToolStripMenuItem1_Click);
            // 
            // зеленыйToolStripMenuItem1
            // 
            this.зеленыйToolStripMenuItem1.Name = "зеленыйToolStripMenuItem1";
            this.зеленыйToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.зеленыйToolStripMenuItem1.Text = "Зеленый";
            this.зеленыйToolStripMenuItem1.Click += new System.EventHandler(this.зеленыйToolStripMenuItem1_Click);
            // 
            // синийToolStripMenuItem1
            // 
            this.синийToolStripMenuItem1.Checked = true;
            this.синийToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.синийToolStripMenuItem1.Name = "синийToolStripMenuItem1";
            this.синийToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.синийToolStripMenuItem1.Text = "Синий";
            this.синийToolStripMenuItem1.Click += new System.EventHandler(this.синийToolStripMenuItem1_Click);
            // 
            // оранжевыйToolStripMenuItem1
            // 
            this.оранжевыйToolStripMenuItem1.Name = "оранжевыйToolStripMenuItem1";
            this.оранжевыйToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.оранжевыйToolStripMenuItem1.Text = "Оранжевый";
            this.оранжевыйToolStripMenuItem1.Click += new System.EventHandler(this.оранжевыйToolStripMenuItem1_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // statusStrip_Status
            // 
            this.statusStrip_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_StatusLable});
            this.statusStrip_Status.Location = new System.Drawing.Point(0, 432);
            this.statusStrip_Status.Name = "statusStrip_Status";
            this.statusStrip_Status.Size = new System.Drawing.Size(739, 22);
            this.statusStrip_Status.TabIndex = 2;
            this.statusStrip_Status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_StatusLable
            // 
            this.toolStripStatusLabel_StatusLable.Name = "toolStripStatusLabel_StatusLable";
            this.toolStripStatusLabel_StatusLable.Size = new System.Drawing.Size(132, 17);
            this.toolStripStatusLabel_StatusLable.Text = "Программа загружена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя Файла";
            // 
            // openFileDialog_OpenFIle
            // 
            this.openFileDialog_OpenFIle.Filter = "Text Files (.txt)|*.txt|CSV Files (.csv)|*.csv|Dat Files (.dat)|*.dat|All Files (" +
    "*.*)|*.*";
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(87, 7);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(32, 23);
            this.button_Next.TabIndex = 4;
            this.button_Next.Text = "→";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Previous
            // 
            this.button_Previous.Location = new System.Drawing.Point(49, 7);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(32, 23);
            this.button_Previous.TabIndex = 5;
            this.button_Previous.Text = "←";
            this.button_Previous.UseVisualStyleBackColor = true;
            this.button_Previous.Click += new System.EventHandler(this.button_Previous_Click);
            // 
            // button_Processing
            // 
            this.button_Processing.Location = new System.Drawing.Point(125, 7);
            this.button_Processing.Name = "button_Processing";
            this.button_Processing.Size = new System.Drawing.Size(32, 23);
            this.button_Processing.TabIndex = 6;
            this.button_Processing.Text = "✔";
            this.button_Processing.UseVisualStyleBackColor = true;
            this.button_Processing.Click += new System.EventHandler(this.button_Processing_Click);
            // 
            // button_DeleteFile
            // 
            this.button_DeleteFile.Location = new System.Drawing.Point(183, 7);
            this.button_DeleteFile.Name = "button_DeleteFile";
            this.button_DeleteFile.Size = new System.Drawing.Size(32, 23);
            this.button_DeleteFile.TabIndex = 7;
            this.button_DeleteFile.Text = "✖";
            this.button_DeleteFile.UseVisualStyleBackColor = true;
            this.button_DeleteFile.Click += new System.EventHandler(this.button_DeleteFile_Click);
            // 
            // chart_Mini
            // 
            chartArea2.CursorX.Interval = 1E-09D;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorY.Interval = 1E-09D;
            chartArea2.CursorY.IsUserSelectionEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.chart_Mini.ChartAreas.Add(chartArea2);
            this.chart_Mini.Location = new System.Drawing.Point(562, 272);
            this.chart_Mini.Name = "chart_Mini";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series1";
            this.chart_Mini.Series.Add(series3);
            this.chart_Mini.Size = new System.Drawing.Size(172, 116);
            this.chart_Mini.TabIndex = 8;
            this.chart_Mini.Text = "chart2";
            // 
            // checkBox_ResultOfProcessing
            // 
            this.checkBox_ResultOfProcessing.AutoSize = true;
            this.checkBox_ResultOfProcessing.Checked = true;
            this.checkBox_ResultOfProcessing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ResultOfProcessing.Location = new System.Drawing.Point(530, 385);
            this.checkBox_ResultOfProcessing.Name = "checkBox_ResultOfProcessing";
            this.checkBox_ResultOfProcessing.Size = new System.Drawing.Size(207, 17);
            this.checkBox_ResultOfProcessing.TabIndex = 9;
            this.checkBox_ResultOfProcessing.Text = "Показывать результаты обработки";
            this.checkBox_ResultOfProcessing.UseVisualStyleBackColor = true;
            this.checkBox_ResultOfProcessing.CheckedChanged += new System.EventHandler(this.checkBox_ResultOfProcessing_CheckedChanged);
            // 
            // button_Browser
            // 
            this.button_Browser.Location = new System.Drawing.Point(12, 7);
            this.button_Browser.Name = "button_Browser";
            this.button_Browser.Size = new System.Drawing.Size(32, 23);
            this.button_Browser.TabIndex = 10;
            this.button_Browser.Text = "...";
            this.button_Browser.UseVisualStyleBackColor = true;
            this.button_Browser.Click += new System.EventHandler(this.выборToolStripMenuItem_Click);
            // 
            // button_Min
            // 
            this.button_Min.Location = new System.Drawing.Point(625, 103);
            this.button_Min.Name = "button_Min";
            this.button_Min.Size = new System.Drawing.Size(35, 23);
            this.button_Min.TabIndex = 11;
            this.button_Min.Text = "Min";
            this.button_Min.UseVisualStyleBackColor = true;
            this.button_Min.Click += new System.EventHandler(this.button_Min_Click);
            // 
            // button_Max
            // 
            this.button_Max.Location = new System.Drawing.Point(625, 132);
            this.button_Max.Name = "button_Max";
            this.button_Max.Size = new System.Drawing.Size(35, 23);
            this.button_Max.TabIndex = 12;
            this.button_Max.Text = "Max";
            this.button_Max.UseVisualStyleBackColor = true;
            this.button_Max.Click += new System.EventHandler(this.button_Max_Click);
            // 
            // button_CutMax
            // 
            this.button_CutMax.Location = new System.Drawing.Point(666, 132);
            this.button_CutMax.Name = "button_CutMax";
            this.button_CutMax.Size = new System.Drawing.Size(53, 23);
            this.button_CutMax.TabIndex = 13;
            this.button_CutMax.Text = "CutMax";
            this.button_CutMax.UseVisualStyleBackColor = true;
            this.button_CutMax.Click += new System.EventHandler(this.поМаксимальномуToolStripMenuItem_Click);
            // 
            // button_CutMin
            // 
            this.button_CutMin.Location = new System.Drawing.Point(666, 103);
            this.button_CutMin.Name = "button_CutMin";
            this.button_CutMin.Size = new System.Drawing.Size(53, 23);
            this.button_CutMin.TabIndex = 14;
            this.button_CutMin.Text = "CutMin";
            this.button_CutMin.UseVisualStyleBackColor = true;
            this.button_CutMin.Click += new System.EventHandler(this.поМинимальномуToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_CutMin);
            this.panel1.Controls.Add(this.checkBox_ResultOfProcessing);
            this.panel1.Controls.Add(this.button_Next);
            this.panel1.Controls.Add(this.button_CutMax);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_Previous);
            this.panel1.Controls.Add(this.button_Max);
            this.panel1.Controls.Add(this.button_Processing);
            this.panel1.Controls.Add(this.button_Min);
            this.panel1.Controls.Add(this.button_DeleteFile);
            this.panel1.Controls.Add(this.button_Browser);
            this.panel1.Controls.Add(this.chart_Mini);
            this.panel1.Controls.Add(this.chart_MainChart);
            this.panel1.Location = new System.Drawing.Point(-1, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 400);
            this.panel1.TabIndex = 15;
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem6.Text = "1";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // Form_Main
            // 
            this.ClientSize = new System.Drawing.Size(739, 454);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip_Status);
            this.Controls.Add(this.menuStrip_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Menu;
            this.Name = "Form_Main";
            this.Text = "Система обработки данных ©";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_MainChart)).EndInit();
            this.menuStrip_Menu.ResumeLayout(false);
            this.menuStrip_Menu.PerformLayout();
            this.statusStrip_Status.ResumeLayout(false);
            this.statusStrip_Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Mini)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Chart chart_MainChart;
        private MenuStrip menuStrip_Menu;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem выборToolStripMenuItem;
        private ToolStripMenuItem следующийToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem обработкаToolStripMenuItem;
        private ToolStripMenuItem скользящийToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem умножитьToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private StatusStrip statusStrip_Status;
        private Label label1;
        private OpenFileDialog openFileDialog_OpenFIle;
        private ToolStripStatusLabel toolStripStatusLabel_StatusLable;
        private Button button_Next;
        private Button button_Previous;
        private Button button_Processing;
        private Button button_DeleteFile;
        private Chart chart_Mini;
        private ToolStripMenuItem toolStripMenuItem7;
        private CheckBox checkBox_ResultOfProcessing;
        private ToolStripMenuItem предыдущийToolStripMenuItem;
        private Button button_Browser;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolStripMenuItem результатыToolStripMenuItem;
        private ToolStripMenuItem показыватьГрафикToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem8;
        private Button button_Min;
        private Button button_Max;
        private ToolStripMenuItem обрезкаToolStripMenuItem;
        private ToolStripMenuItem поМинимальномуToolStripMenuItem;
        private ToolStripMenuItem поМаксимальномуToolStripMenuItem;
        private Button button_CutMax;
        private Button button_CutMin;
        private Panel panel1;
        private ToolStripMenuItem настройкаToolStripMenuItem;
        private ToolStripMenuItem цветТочекToolStripMenuItem;
        private ToolStripMenuItem красныйToolStripMenuItem;
        private ToolStripMenuItem зеленыйToolStripMenuItem;
        private ToolStripMenuItem синийToolStripMenuItem;
        private ToolStripMenuItem оранжевыйToolStripMenuItem;
        private ToolStripMenuItem цветЛинииToolStripMenuItem;
        private ToolStripMenuItem красныйToolStripMenuItem1;
        private ToolStripMenuItem зеленыйToolStripMenuItem1;
        private ToolStripMenuItem синийToolStripMenuItem1;
        private ToolStripMenuItem оранжевыйToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem6;
    }
}

