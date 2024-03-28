namespace SimpleCode
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labDivisionTravo = new System.Windows.Forms.Label();
            this.nudDivisionTravo = new System.Windows.Forms.NumericUpDown();
            this.labGrowthTime = new System.Windows.Forms.Label();
            this.nudGrowthTime = new System.Windows.Forms.NumericUpDown();
            this.labDivision = new System.Windows.Forms.Label();
            this.nudDivision = new System.Windows.Forms.NumericUpDown();
            this.labStarve = new System.Windows.Forms.Label();
            this.nudStarve = new System.Windows.Forms.NumericUpDown();
            this.labAgeCell = new System.Windows.Forms.Label();
            this.nudAgeCell = new System.Windows.Forms.NumericUpDown();
            this.labDecomposition = new System.Windows.Forms.Label();
            this.nudDecomposition = new System.Windows.Forms.NumericUpDown();
            this.GrowthRate = new System.Windows.Forms.Label();
            this.nudGrowthRate = new System.Windows.Forms.NumericUpDown();
            this.BBackToMenu = new System.Windows.Forms.Button();
            this.LabPlantVer = new System.Windows.Forms.Label();
            this.nudPlantVer = new System.Windows.Forms.NumericUpDown();
            this.Brushe = new System.Windows.Forms.Label();
            this.BResult = new System.Windows.Forms.Button();
            this.CountPloto = new System.Windows.Forms.Label();
            this.CountTravo = new System.Windows.Forms.Label();
            this.CountPlants = new System.Windows.Forms.Label();
            this.Bselect_Ploto = new System.Windows.Forms.Button();
            this.CurentMouseStage = new System.Windows.Forms.Label();
            this.Bselect_Plant = new System.Windows.Forms.Button();
            this.Bselect_Travo = new System.Windows.Forms.Button();
            this.bstop = new System.Windows.Forms.Button();
            this.bstart = new System.Windows.Forms.Button();
            this.nudDensity = new System.Windows.Forms.NumericUpDown();
            this.labDensity = new System.Windows.Forms.Label();
            this.nudResolution = new System.Windows.Forms.NumericUpDown();
            this.labResolution = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BAccelX2 = new System.Windows.Forms.Button();
            this.BAccelX5 = new System.Windows.Forms.Button();
            this.BAccelX10 = new System.Windows.Forms.Button();
            this.LabelXnow = new System.Windows.Forms.Label();
            this.BAccelX1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDivisionTravo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrowthTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgeCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecomposition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrowthRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlantVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BAccelX1);
            this.splitContainer1.Panel1.Controls.Add(this.LabelXnow);
            this.splitContainer1.Panel1.Controls.Add(this.BAccelX10);
            this.splitContainer1.Panel1.Controls.Add(this.BAccelX5);
            this.splitContainer1.Panel1.Controls.Add(this.BAccelX2);
            this.splitContainer1.Panel1.Controls.Add(this.labDivisionTravo);
            this.splitContainer1.Panel1.Controls.Add(this.nudDivisionTravo);
            this.splitContainer1.Panel1.Controls.Add(this.labGrowthTime);
            this.splitContainer1.Panel1.Controls.Add(this.nudGrowthTime);
            this.splitContainer1.Panel1.Controls.Add(this.labDivision);
            this.splitContainer1.Panel1.Controls.Add(this.nudDivision);
            this.splitContainer1.Panel1.Controls.Add(this.labStarve);
            this.splitContainer1.Panel1.Controls.Add(this.nudStarve);
            this.splitContainer1.Panel1.Controls.Add(this.labAgeCell);
            this.splitContainer1.Panel1.Controls.Add(this.nudAgeCell);
            this.splitContainer1.Panel1.Controls.Add(this.labDecomposition);
            this.splitContainer1.Panel1.Controls.Add(this.nudDecomposition);
            this.splitContainer1.Panel1.Controls.Add(this.GrowthRate);
            this.splitContainer1.Panel1.Controls.Add(this.nudGrowthRate);
            this.splitContainer1.Panel1.Controls.Add(this.BBackToMenu);
            this.splitContainer1.Panel1.Controls.Add(this.LabPlantVer);
            this.splitContainer1.Panel1.Controls.Add(this.nudPlantVer);
            this.splitContainer1.Panel1.Controls.Add(this.Brushe);
            this.splitContainer1.Panel1.Controls.Add(this.BResult);
            this.splitContainer1.Panel1.Controls.Add(this.CountPloto);
            this.splitContainer1.Panel1.Controls.Add(this.CountTravo);
            this.splitContainer1.Panel1.Controls.Add(this.CountPlants);
            this.splitContainer1.Panel1.Controls.Add(this.Bselect_Ploto);
            this.splitContainer1.Panel1.Controls.Add(this.CurentMouseStage);
            this.splitContainer1.Panel1.Controls.Add(this.Bselect_Plant);
            this.splitContainer1.Panel1.Controls.Add(this.Bselect_Travo);
            this.splitContainer1.Panel1.Controls.Add(this.bstop);
            this.splitContainer1.Panel1.Controls.Add(this.bstart);
            this.splitContainer1.Panel1.Controls.Add(this.nudDensity);
            this.splitContainer1.Panel1.Controls.Add(this.labDensity);
            this.splitContainer1.Panel1.Controls.Add(this.nudResolution);
            this.splitContainer1.Panel1.Controls.Add(this.labResolution);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1753, 1055);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 0;
            // 
            // labDivisionTravo
            // 
            this.labDivisionTravo.AutoSize = true;
            this.labDivisionTravo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDivisionTravo.Location = new System.Drawing.Point(11, 595);
            this.labDivisionTravo.Name = "labDivisionTravo";
            this.labDivisionTravo.Size = new System.Drawing.Size(229, 16);
            this.labDivisionTravo.TabIndex = 33;
            this.labDivisionTravo.Text = "Вероятность деления травоядных";
            // 
            // nudDivisionTravo
            // 
            this.nudDivisionTravo.Location = new System.Drawing.Point(14, 614);
            this.nudDivisionTravo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDivisionTravo.Name = "nudDivisionTravo";
            this.nudDivisionTravo.ReadOnly = true;
            this.nudDivisionTravo.Size = new System.Drawing.Size(164, 22);
            this.nudDivisionTravo.TabIndex = 32;
            this.nudDivisionTravo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDivisionTravo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labGrowthTime
            // 
            this.labGrowthTime.AutoSize = true;
            this.labGrowthTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labGrowthTime.Location = new System.Drawing.Point(11, 383);
            this.labGrowthTime.Name = "labGrowthTime";
            this.labGrowthTime.Size = new System.Drawing.Size(194, 16);
            this.labGrowthTime.TabIndex = 31;
            this.labGrowthTime.Text = "Время созревания растений";
            // 
            // nudGrowthTime
            // 
            this.nudGrowthTime.Location = new System.Drawing.Point(14, 400);
            this.nudGrowthTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGrowthTime.Name = "nudGrowthTime";
            this.nudGrowthTime.ReadOnly = true;
            this.nudGrowthTime.Size = new System.Drawing.Size(164, 22);
            this.nudGrowthTime.TabIndex = 30;
            this.nudGrowthTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGrowthTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labDivision
            // 
            this.labDivision.AutoSize = true;
            this.labDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDivision.Location = new System.Drawing.Point(11, 551);
            this.labDivision.Name = "labDivision";
            this.labDivision.Size = new System.Drawing.Size(229, 16);
            this.labDivision.TabIndex = 29;
            this.labDivision.Text = "Вероятность деления плотоядных";
            // 
            // nudDivision
            // 
            this.nudDivision.Location = new System.Drawing.Point(14, 570);
            this.nudDivision.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDivision.Name = "nudDivision";
            this.nudDivision.ReadOnly = true;
            this.nudDivision.Size = new System.Drawing.Size(164, 22);
            this.nudDivision.TabIndex = 28;
            this.nudDivision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDivision.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labStarve
            // 
            this.labStarve.AutoSize = true;
            this.labStarve.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labStarve.Location = new System.Drawing.Point(11, 509);
            this.labStarve.Name = "labStarve";
            this.labStarve.Size = new System.Drawing.Size(146, 16);
            this.labStarve.TabIndex = 27;
            this.labStarve.Text = "Шкала голода клеток";
            // 
            // nudStarve
            // 
            this.nudStarve.Location = new System.Drawing.Point(14, 526);
            this.nudStarve.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudStarve.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudStarve.Name = "nudStarve";
            this.nudStarve.ReadOnly = true;
            this.nudStarve.Size = new System.Drawing.Size(164, 22);
            this.nudStarve.TabIndex = 26;
            this.nudStarve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudStarve.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labAgeCell
            // 
            this.labAgeCell.AutoSize = true;
            this.labAgeCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labAgeCell.Location = new System.Drawing.Point(11, 467);
            this.labAgeCell.Name = "labAgeCell";
            this.labAgeCell.Size = new System.Drawing.Size(210, 16);
            this.labAgeCell.TabIndex = 25;
            this.labAgeCell.Text = "Максимальный возраст клетки";
            // 
            // nudAgeCell
            // 
            this.nudAgeCell.Location = new System.Drawing.Point(14, 484);
            this.nudAgeCell.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAgeCell.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudAgeCell.Name = "nudAgeCell";
            this.nudAgeCell.ReadOnly = true;
            this.nudAgeCell.Size = new System.Drawing.Size(164, 22);
            this.nudAgeCell.TabIndex = 24;
            this.nudAgeCell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAgeCell.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // labDecomposition
            // 
            this.labDecomposition.AutoSize = true;
            this.labDecomposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDecomposition.Location = new System.Drawing.Point(11, 425);
            this.labDecomposition.Name = "labDecomposition";
            this.labDecomposition.Size = new System.Drawing.Size(174, 16);
            this.labDecomposition.TabIndex = 23;
            this.labDecomposition.Text = "Вероятность разложения";
            // 
            // nudDecomposition
            // 
            this.nudDecomposition.Location = new System.Drawing.Point(14, 442);
            this.nudDecomposition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDecomposition.Name = "nudDecomposition";
            this.nudDecomposition.ReadOnly = true;
            this.nudDecomposition.Size = new System.Drawing.Size(164, 22);
            this.nudDecomposition.TabIndex = 22;
            this.nudDecomposition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDecomposition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GrowthRate
            // 
            this.GrowthRate.AutoSize = true;
            this.GrowthRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GrowthRate.Location = new System.Drawing.Point(11, 341);
            this.GrowthRate.Name = "GrowthRate";
            this.GrowthRate.Size = new System.Drawing.Size(166, 16);
            this.GrowthRate.TabIndex = 21;
            this.GrowthRate.Text = "Частота роста растения";
            // 
            // nudGrowthRate
            // 
            this.nudGrowthRate.Location = new System.Drawing.Point(14, 358);
            this.nudGrowthRate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGrowthRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGrowthRate.Name = "nudGrowthRate";
            this.nudGrowthRate.ReadOnly = true;
            this.nudGrowthRate.Size = new System.Drawing.Size(164, 22);
            this.nudGrowthRate.TabIndex = 20;
            this.nudGrowthRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGrowthRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BBackToMenu
            // 
            this.BBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BBackToMenu.Location = new System.Drawing.Point(108, 797);
            this.BBackToMenu.Name = "BBackToMenu";
            this.BBackToMenu.Size = new System.Drawing.Size(182, 51);
            this.BBackToMenu.TabIndex = 19;
            this.BBackToMenu.Text = "Назад в Меню";
            this.BBackToMenu.UseVisualStyleBackColor = true;
            this.BBackToMenu.Click += new System.EventHandler(this.BBackToMenu_Click);
            // 
            // LabPlantVer
            // 
            this.LabPlantVer.AutoSize = true;
            this.LabPlantVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabPlantVer.Location = new System.Drawing.Point(11, 294);
            this.LabPlantVer.Name = "LabPlantVer";
            this.LabPlantVer.Size = new System.Drawing.Size(196, 16);
            this.LabPlantVer.TabIndex = 18;
            this.LabPlantVer.Text = "Вероятность роста растения";
            // 
            // nudPlantVer
            // 
            this.nudPlantVer.Location = new System.Drawing.Point(14, 313);
            this.nudPlantVer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPlantVer.Name = "nudPlantVer";
            this.nudPlantVer.ReadOnly = true;
            this.nudPlantVer.Size = new System.Drawing.Size(164, 22);
            this.nudPlantVer.TabIndex = 17;
            this.nudPlantVer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPlantVer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Brushe
            // 
            this.Brushe.AutoSize = true;
            this.Brushe.Location = new System.Drawing.Point(10, 130);
            this.Brushe.Name = "Brushe";
            this.Brushe.Size = new System.Drawing.Size(92, 16);
            this.Brushe.TabIndex = 16;
            this.Brushe.Text = "Кисть клеток";
            // 
            // BResult
            // 
            this.BResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BResult.Location = new System.Drawing.Point(10, 92);
            this.BResult.Name = "BResult";
            this.BResult.Size = new System.Drawing.Size(373, 35);
            this.BResult.TabIndex = 15;
            this.BResult.Text = "Вывести результаты";
            this.BResult.UseVisualStyleBackColor = true;
            this.BResult.Click += new System.EventHandler(this.BResult_Click);
            // 
            // CountPloto
            // 
            this.CountPloto.AutoSize = true;
            this.CountPloto.Location = new System.Drawing.Point(134, 215);
            this.CountPloto.Name = "CountPloto";
            this.CountPloto.Size = new System.Drawing.Size(44, 16);
            this.CountPloto.TabIndex = 14;
            this.CountPloto.Text = "label1";
            // 
            // CountTravo
            // 
            this.CountTravo.AutoSize = true;
            this.CountTravo.Location = new System.Drawing.Point(134, 185);
            this.CountTravo.Name = "CountTravo";
            this.CountTravo.Size = new System.Drawing.Size(44, 16);
            this.CountTravo.TabIndex = 13;
            this.CountTravo.Text = "label1";
            // 
            // CountPlants
            // 
            this.CountPlants.AutoSize = true;
            this.CountPlants.Location = new System.Drawing.Point(134, 156);
            this.CountPlants.Name = "CountPlants";
            this.CountPlants.Size = new System.Drawing.Size(44, 16);
            this.CountPlants.TabIndex = 12;
            this.CountPlants.Text = "label1";
            // 
            // Bselect_Ploto
            // 
            this.Bselect_Ploto.Location = new System.Drawing.Point(13, 208);
            this.Bselect_Ploto.Name = "Bselect_Ploto";
            this.Bselect_Ploto.Size = new System.Drawing.Size(119, 23);
            this.Bselect_Ploto.TabIndex = 11;
            this.Bselect_Ploto.Text = "Плотоядное";
            this.Bselect_Ploto.UseVisualStyleBackColor = true;
            this.Bselect_Ploto.Click += new System.EventHandler(this.Bselect_Ploto_Click);
            // 
            // CurentMouseStage
            // 
            this.CurentMouseStage.AutoSize = true;
            this.CurentMouseStage.Location = new System.Drawing.Point(109, 130);
            this.CurentMouseStage.Name = "CurentMouseStage";
            this.CurentMouseStage.Size = new System.Drawing.Size(0, 16);
            this.CurentMouseStage.TabIndex = 10;
            // 
            // Bselect_Plant
            // 
            this.Bselect_Plant.Location = new System.Drawing.Point(12, 149);
            this.Bselect_Plant.Name = "Bselect_Plant";
            this.Bselect_Plant.Size = new System.Drawing.Size(120, 23);
            this.Bselect_Plant.TabIndex = 9;
            this.Bselect_Plant.Text = "Растение";
            this.Bselect_Plant.UseVisualStyleBackColor = true;
            this.Bselect_Plant.Click += new System.EventHandler(this.Bselect_Plant_Click);
            // 
            // Bselect_Travo
            // 
            this.Bselect_Travo.Location = new System.Drawing.Point(12, 178);
            this.Bselect_Travo.Name = "Bselect_Travo";
            this.Bselect_Travo.Size = new System.Drawing.Size(120, 23);
            this.Bselect_Travo.TabIndex = 8;
            this.Bselect_Travo.Text = "Травоядное";
            this.Bselect_Travo.UseVisualStyleBackColor = true;
            this.Bselect_Travo.Click += new System.EventHandler(this.Bselect_Travo_Click);
            // 
            // bstop
            // 
            this.bstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bstop.Location = new System.Drawing.Point(198, 10);
            this.bstop.Name = "bstop";
            this.bstop.Size = new System.Drawing.Size(185, 76);
            this.bstop.TabIndex = 6;
            this.bstop.Text = "Остановить Симуляцию";
            this.bstop.UseVisualStyleBackColor = true;
            this.bstop.Click += new System.EventHandler(this.bstop_Click);
            // 
            // bstart
            // 
            this.bstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bstart.Location = new System.Drawing.Point(10, 10);
            this.bstart.Name = "bstart";
            this.bstart.Size = new System.Drawing.Size(182, 76);
            this.bstart.TabIndex = 5;
            this.bstart.Text = "Начать Симуляцию";
            this.bstart.UseVisualStyleBackColor = true;
            this.bstart.Click += new System.EventHandler(this.bstart_Click);
            // 
            // nudDensity
            // 
            this.nudDensity.Location = new System.Drawing.Point(118, 269);
            this.nudDensity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDensity.Name = "nudDensity";
            this.nudDensity.ReadOnly = true;
            this.nudDensity.Size = new System.Drawing.Size(83, 22);
            this.nudDensity.TabIndex = 4;
            this.nudDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDensity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labDensity
            // 
            this.labDensity.AutoSize = true;
            this.labDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDensity.Location = new System.Drawing.Point(115, 246);
            this.labDensity.Name = "labDensity";
            this.labDensity.Size = new System.Drawing.Size(77, 16);
            this.labDensity.TabIndex = 3;
            this.labDensity.Text = "Плотность";
            // 
            // nudResolution
            // 
            this.nudResolution.Location = new System.Drawing.Point(14, 269);
            this.nudResolution.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudResolution.Name = "nudResolution";
            this.nudResolution.ReadOnly = true;
            this.nudResolution.Size = new System.Drawing.Size(95, 22);
            this.nudResolution.TabIndex = 2;
            this.nudResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudResolution.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labResolution
            // 
            this.labResolution.AutoSize = true;
            this.labResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labResolution.Location = new System.Drawing.Point(10, 246);
            this.labResolution.Name = "labResolution";
            this.labResolution.Size = new System.Drawing.Size(89, 16);
            this.labResolution.TabIndex = 1;
            this.labResolution.Text = "Разрешение";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1448, 1051);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // BAccelX2
            // 
            this.BAccelX2.Location = new System.Drawing.Point(13, 655);
            this.BAccelX2.Name = "BAccelX2";
            this.BAccelX2.Size = new System.Drawing.Size(75, 23);
            this.BAccelX2.TabIndex = 34;
            this.BAccelX2.Text = "X2";
            this.BAccelX2.UseVisualStyleBackColor = true;
            this.BAccelX2.Click += new System.EventHandler(this.BAccelX2_Click);
            // 
            // BAccelX5
            // 
            this.BAccelX5.Location = new System.Drawing.Point(13, 684);
            this.BAccelX5.Name = "BAccelX5";
            this.BAccelX5.Size = new System.Drawing.Size(75, 23);
            this.BAccelX5.TabIndex = 35;
            this.BAccelX5.Text = "X5";
            this.BAccelX5.UseVisualStyleBackColor = true;
            this.BAccelX5.Click += new System.EventHandler(this.BAccelX5_Click);
            // 
            // BAccelX10
            // 
            this.BAccelX10.Location = new System.Drawing.Point(13, 713);
            this.BAccelX10.Name = "BAccelX10";
            this.BAccelX10.Size = new System.Drawing.Size(75, 23);
            this.BAccelX10.TabIndex = 36;
            this.BAccelX10.Text = "X10";
            this.BAccelX10.UseVisualStyleBackColor = true;
            this.BAccelX10.Click += new System.EventHandler(this.BAccelX10_Click);
            // 
            // LabelXnow
            // 
            this.LabelXnow.AutoSize = true;
            this.LabelXnow.Location = new System.Drawing.Point(105, 662);
            this.LabelXnow.Name = "LabelXnow";
            this.LabelXnow.Size = new System.Drawing.Size(0, 16);
            this.LabelXnow.TabIndex = 37;
            // 
            // BAccelX1
            // 
            this.BAccelX1.Location = new System.Drawing.Point(13, 742);
            this.BAccelX1.Name = "BAccelX1";
            this.BAccelX1.Size = new System.Drawing.Size(75, 23);
            this.BAccelX1.TabIndex = 38;
            this.BAccelX1.Text = "X1";
            this.BAccelX1.UseVisualStyleBackColor = true;
            this.BAccelX1.Click += new System.EventHandler(this.BAccelX1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1753, 1055);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDivisionTravo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrowthTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAgeCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecomposition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrowthRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlantVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown nudResolution;
        private System.Windows.Forms.Label labResolution;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudDensity;
        private System.Windows.Forms.Label labDensity;
        private System.Windows.Forms.Button bstop;
        private System.Windows.Forms.Button bstart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Bselect_Plant;
        private System.Windows.Forms.Button Bselect_Travo;
        private System.Windows.Forms.Label CurentMouseStage;
        private System.Windows.Forms.Button Bselect_Ploto;
        private System.Windows.Forms.Label CountPlants;
        private System.Windows.Forms.Label CountPloto;
        private System.Windows.Forms.Label CountTravo;
        private System.Windows.Forms.Label Brushe;
        private System.Windows.Forms.Button BResult;
        private System.Windows.Forms.Label LabPlantVer;
        private System.Windows.Forms.NumericUpDown nudPlantVer;
        private System.Windows.Forms.Button BBackToMenu;
        private System.Windows.Forms.Label GrowthRate;
        private System.Windows.Forms.NumericUpDown nudGrowthRate;
        private System.Windows.Forms.Label labStarve;
        private System.Windows.Forms.NumericUpDown nudStarve;
        private System.Windows.Forms.Label labAgeCell;
        private System.Windows.Forms.NumericUpDown nudAgeCell;
        private System.Windows.Forms.Label labDecomposition;
        private System.Windows.Forms.NumericUpDown nudDecomposition;
        private System.Windows.Forms.Label labDivision;
        private System.Windows.Forms.NumericUpDown nudDivision;
        private System.Windows.Forms.Label labGrowthTime;
        private System.Windows.Forms.NumericUpDown nudGrowthTime;
        private System.Windows.Forms.Label labDivisionTravo;
        private System.Windows.Forms.NumericUpDown nudDivisionTravo;
        private System.Windows.Forms.Button BAccelX1;
        private System.Windows.Forms.Label LabelXnow;
        private System.Windows.Forms.Button BAccelX10;
        private System.Windows.Forms.Button BAccelX5;
        private System.Windows.Forms.Button BAccelX2;
    }
}

