namespace Calculator_WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.equalButton = new System.Windows.Forms.Button();
            this.pointButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.clearLastElemButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.clearEntryButton = new System.Windows.Forms.Button();
            this.modButton = new System.Windows.Forms.Button();
            this.plus_minusButton = new System.Windows.Forms.Button();
            this.closeBracketButton = new System.Windows.Forms.Button();
            this.openBracketButton = new System.Windows.Forms.Button();
            this.roundButton = new System.Windows.Forms.Button();
            this.aButton = new System.Windows.Forms.Button();
            this.bButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.eButton = new System.Windows.Forms.Button();
            this.dButton = new System.Windows.Forms.Button();
            this.fButton = new System.Windows.Forms.Button();
            this.lshButton = new System.Windows.Forms.Button();
            this.rshButton = new System.Windows.Forms.Button();
            this.xorButton = new System.Windows.Forms.Button();
            this.andButton = new System.Windows.Forms.Button();
            this.notButton = new System.Windows.Forms.Button();
            this.orButton = new System.Windows.Forms.Button();
            this.fullResultTextBox = new System.Windows.Forms.TextBox();
            this.binButton = new System.Windows.Forms.Button();
            this.binLabel = new System.Windows.Forms.Label();
            this.octButton = new System.Windows.Forms.Button();
            this.decButton = new System.Windows.Forms.Button();
            this.hexButton = new System.Windows.Forms.Button();
            this.octLabel = new System.Windows.Forms.Label();
            this.decLabel = new System.Windows.Forms.Label();
            this.hexLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Программист";
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.LightGray;
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultTextBox.Location = new System.Drawing.Point(5, 77);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(307, 36);
            this.resultTextBox.TabIndex = 1;
            this.resultTextBox.TabStop = false;
            this.resultTextBox.Text = "0";
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.equalButton.FlatAppearance.BorderSize = 0;
            this.equalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equalButton.Location = new System.Drawing.Point(265, 433);
            this.equalButton.Margin = new System.Windows.Forms.Padding(2);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(48, 36);
            this.equalButton.TabIndex = 37;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // pointButton
            // 
            this.pointButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pointButton.Enabled = false;
            this.pointButton.FlatAppearance.BorderSize = 0;
            this.pointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pointButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pointButton.Location = new System.Drawing.Point(213, 433);
            this.pointButton.Margin = new System.Windows.Forms.Padding(2);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(48, 36);
            this.pointButton.TabIndex = 36;
            this.pointButton.Text = ",";
            this.pointButton.UseVisualStyleBackColor = false;
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.zeroButton.FlatAppearance.BorderSize = 0;
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroButton.Location = new System.Drawing.Point(161, 433);
            this.zeroButton.Margin = new System.Windows.Forms.Padding(2);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(48, 36);
            this.zeroButton.TabIndex = 35;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.twoButton.FlatAppearance.BorderSize = 0;
            this.twoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoButton.Location = new System.Drawing.Point(161, 393);
            this.twoButton.Margin = new System.Windows.Forms.Padding(2);
            this.twoButton.Name = "twoButton";
            this.twoButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.twoButton.Size = new System.Drawing.Size(48, 36);
            this.twoButton.TabIndex = 29;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.threeButton.FlatAppearance.BorderSize = 0;
            this.threeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threeButton.Location = new System.Drawing.Point(213, 393);
            this.threeButton.Margin = new System.Windows.Forms.Padding(2);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(48, 36);
            this.threeButton.TabIndex = 30;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.oneButton.FlatAppearance.BorderSize = 0;
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneButton.Location = new System.Drawing.Point(109, 393);
            this.oneButton.Margin = new System.Windows.Forms.Padding(2);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(48, 36);
            this.oneButton.TabIndex = 28;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fourButton.FlatAppearance.BorderSize = 0;
            this.fourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourButton.Location = new System.Drawing.Point(109, 353);
            this.fourButton.Margin = new System.Windows.Forms.Padding(2);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(48, 36);
            this.fourButton.TabIndex = 22;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sevenButton.FlatAppearance.BorderSize = 0;
            this.sevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sevenButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sevenButton.Location = new System.Drawing.Point(109, 313);
            this.sevenButton.Margin = new System.Windows.Forms.Padding(2);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(48, 36);
            this.sevenButton.TabIndex = 16;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fiveButton.FlatAppearance.BorderSize = 0;
            this.fiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiveButton.Location = new System.Drawing.Point(161, 353);
            this.fiveButton.Margin = new System.Windows.Forms.Padding(2);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(48, 36);
            this.fiveButton.TabIndex = 23;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eightButton.FlatAppearance.BorderSize = 0;
            this.eightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eightButton.Location = new System.Drawing.Point(161, 313);
            this.eightButton.Margin = new System.Windows.Forms.Padding(2);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(48, 36);
            this.eightButton.TabIndex = 17;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sixButton.FlatAppearance.BorderSize = 0;
            this.sixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sixButton.Location = new System.Drawing.Point(213, 353);
            this.sixButton.Margin = new System.Windows.Forms.Padding(2);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(48, 36);
            this.sixButton.TabIndex = 24;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nineButton.FlatAppearance.BorderSize = 0;
            this.nineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nineButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nineButton.Location = new System.Drawing.Point(213, 313);
            this.nineButton.Margin = new System.Windows.Forms.Padding(2);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(48, 36);
            this.nineButton.TabIndex = 18;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plusButton.FlatAppearance.BorderSize = 0;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusButton.Location = new System.Drawing.Point(265, 393);
            this.plusButton.Margin = new System.Windows.Forms.Padding(2);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(48, 36);
            this.plusButton.TabIndex = 31;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.minusButton.FlatAppearance.BorderSize = 0;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusButton.Location = new System.Drawing.Point(265, 353);
            this.minusButton.Margin = new System.Windows.Forms.Padding(2);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(48, 36);
            this.minusButton.TabIndex = 25;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // multButton
            // 
            this.multButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.multButton.FlatAppearance.BorderSize = 0;
            this.multButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multButton.Location = new System.Drawing.Point(265, 313);
            this.multButton.Margin = new System.Windows.Forms.Padding(2);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(48, 36);
            this.multButton.TabIndex = 19;
            this.multButton.Text = "×";
            this.multButton.UseVisualStyleBackColor = false;
            this.multButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // divButton
            // 
            this.divButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.divButton.FlatAppearance.BorderSize = 0;
            this.divButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divButton.Location = new System.Drawing.Point(265, 273);
            this.divButton.Margin = new System.Windows.Forms.Padding(2);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(48, 36);
            this.divButton.TabIndex = 13;
            this.divButton.Text = "÷";
            this.divButton.UseVisualStyleBackColor = false;
            this.divButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // clearLastElemButton
            // 
            this.clearLastElemButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearLastElemButton.FlatAppearance.BorderSize = 0;
            this.clearLastElemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearLastElemButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearLastElemButton.Location = new System.Drawing.Point(213, 273);
            this.clearLastElemButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearLastElemButton.Name = "clearLastElemButton";
            this.clearLastElemButton.Size = new System.Drawing.Size(48, 36);
            this.clearLastElemButton.TabIndex = 12;
            this.clearLastElemButton.Text = "←";
            this.clearLastElemButton.UseVisualStyleBackColor = false;
            this.clearLastElemButton.Click += new System.EventHandler(this.clearLastElemButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(161, 273);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(48, 36);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "С";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // clearEntryButton
            // 
            this.clearEntryButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearEntryButton.FlatAppearance.BorderSize = 0;
            this.clearEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearEntryButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearEntryButton.Location = new System.Drawing.Point(109, 273);
            this.clearEntryButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearEntryButton.Name = "clearEntryButton";
            this.clearEntryButton.Size = new System.Drawing.Size(48, 36);
            this.clearEntryButton.TabIndex = 10;
            this.clearEntryButton.Text = "CE";
            this.clearEntryButton.UseVisualStyleBackColor = false;
            this.clearEntryButton.Click += new System.EventHandler(this.clearEntryButton_Click);
            // 
            // modButton
            // 
            this.modButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.modButton.FlatAppearance.BorderSize = 0;
            this.modButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modButton.Location = new System.Drawing.Point(57, 273);
            this.modButton.Margin = new System.Windows.Forms.Padding(2);
            this.modButton.Name = "modButton";
            this.modButton.Size = new System.Drawing.Size(48, 36);
            this.modButton.TabIndex = 9;
            this.modButton.Text = "Mod";
            this.modButton.UseVisualStyleBackColor = false;
            this.modButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // plus_minusButton
            // 
            this.plus_minusButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plus_minusButton.FlatAppearance.BorderSize = 0;
            this.plus_minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus_minusButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus_minusButton.Location = new System.Drawing.Point(109, 433);
            this.plus_minusButton.Margin = new System.Windows.Forms.Padding(2);
            this.plus_minusButton.Name = "plus_minusButton";
            this.plus_minusButton.Size = new System.Drawing.Size(48, 36);
            this.plus_minusButton.TabIndex = 34;
            this.plus_minusButton.Text = "±";
            this.plus_minusButton.UseVisualStyleBackColor = false;
            this.plus_minusButton.Click += new System.EventHandler(this.plus_minusButton_Click);
            // 
            // closeBracketButton
            // 
            this.closeBracketButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.closeBracketButton.FlatAppearance.BorderSize = 0;
            this.closeBracketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBracketButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBracketButton.Location = new System.Drawing.Point(57, 433);
            this.closeBracketButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeBracketButton.Name = "closeBracketButton";
            this.closeBracketButton.Size = new System.Drawing.Size(48, 36);
            this.closeBracketButton.TabIndex = 33;
            this.closeBracketButton.Text = ")";
            this.closeBracketButton.UseVisualStyleBackColor = false;
            this.closeBracketButton.Click += new System.EventHandler(this.closeBracketButton_Click);
            // 
            // openBracketButton
            // 
            this.openBracketButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.openBracketButton.FlatAppearance.BorderSize = 0;
            this.openBracketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBracketButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openBracketButton.Location = new System.Drawing.Point(5, 433);
            this.openBracketButton.Margin = new System.Windows.Forms.Padding(2);
            this.openBracketButton.Name = "openBracketButton";
            this.openBracketButton.Size = new System.Drawing.Size(48, 36);
            this.openBracketButton.TabIndex = 32;
            this.openBracketButton.Text = "(";
            this.openBracketButton.UseVisualStyleBackColor = false;
            this.openBracketButton.Click += new System.EventHandler(this.openBracketButton_Click);
            // 
            // roundButton
            // 
            this.roundButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roundButton.FlatAppearance.BorderSize = 0;
            this.roundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton.Location = new System.Drawing.Point(5, 273);
            this.roundButton.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton.Name = "roundButton";
            this.roundButton.Size = new System.Drawing.Size(48, 36);
            this.roundButton.TabIndex = 8;
            this.roundButton.Text = "↑";
            this.roundButton.UseVisualStyleBackColor = false;
            this.roundButton.Click += new System.EventHandler(this.roundButton_Click);
            // 
            // aButton
            // 
            this.aButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.aButton.Enabled = false;
            this.aButton.FlatAppearance.BorderSize = 0;
            this.aButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.aButton.Location = new System.Drawing.Point(5, 313);
            this.aButton.Margin = new System.Windows.Forms.Padding(2);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(48, 36);
            this.aButton.TabIndex = 14;
            this.aButton.Text = "A";
            this.aButton.UseVisualStyleBackColor = false;
            this.aButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // bButton
            // 
            this.bButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bButton.Enabled = false;
            this.bButton.FlatAppearance.BorderSize = 0;
            this.bButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bButton.Location = new System.Drawing.Point(57, 313);
            this.bButton.Margin = new System.Windows.Forms.Padding(2);
            this.bButton.Name = "bButton";
            this.bButton.Size = new System.Drawing.Size(48, 36);
            this.bButton.TabIndex = 15;
            this.bButton.Text = "B";
            this.bButton.UseVisualStyleBackColor = false;
            this.bButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // cButton
            // 
            this.cButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cButton.Enabled = false;
            this.cButton.FlatAppearance.BorderSize = 0;
            this.cButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cButton.Location = new System.Drawing.Point(5, 353);
            this.cButton.Margin = new System.Windows.Forms.Padding(2);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(48, 36);
            this.cButton.TabIndex = 20;
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = false;
            this.cButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // eButton
            // 
            this.eButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eButton.Enabled = false;
            this.eButton.FlatAppearance.BorderSize = 0;
            this.eButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.eButton.Location = new System.Drawing.Point(5, 393);
            this.eButton.Margin = new System.Windows.Forms.Padding(2);
            this.eButton.Name = "eButton";
            this.eButton.Size = new System.Drawing.Size(48, 36);
            this.eButton.TabIndex = 26;
            this.eButton.Text = "E";
            this.eButton.UseVisualStyleBackColor = false;
            this.eButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // dButton
            // 
            this.dButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dButton.Enabled = false;
            this.dButton.FlatAppearance.BorderSize = 0;
            this.dButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dButton.Location = new System.Drawing.Point(57, 353);
            this.dButton.Margin = new System.Windows.Forms.Padding(2);
            this.dButton.Name = "dButton";
            this.dButton.Size = new System.Drawing.Size(48, 36);
            this.dButton.TabIndex = 21;
            this.dButton.Text = "D";
            this.dButton.UseVisualStyleBackColor = false;
            this.dButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // fButton
            // 
            this.fButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fButton.Enabled = false;
            this.fButton.FlatAppearance.BorderSize = 0;
            this.fButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fButton.Location = new System.Drawing.Point(57, 393);
            this.fButton.Margin = new System.Windows.Forms.Padding(2);
            this.fButton.Name = "fButton";
            this.fButton.Size = new System.Drawing.Size(48, 36);
            this.fButton.TabIndex = 27;
            this.fButton.Text = "F";
            this.fButton.UseVisualStyleBackColor = false;
            this.fButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // lshButton
            // 
            this.lshButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lshButton.FlatAppearance.BorderSize = 0;
            this.lshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lshButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lshButton.Location = new System.Drawing.Point(5, 233);
            this.lshButton.Margin = new System.Windows.Forms.Padding(2);
            this.lshButton.Name = "lshButton";
            this.lshButton.Size = new System.Drawing.Size(48, 36);
            this.lshButton.TabIndex = 2;
            this.lshButton.Text = "Lsh";
            this.lshButton.UseVisualStyleBackColor = false;
            this.lshButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // rshButton
            // 
            this.rshButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rshButton.FlatAppearance.BorderSize = 0;
            this.rshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rshButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rshButton.Location = new System.Drawing.Point(57, 233);
            this.rshButton.Margin = new System.Windows.Forms.Padding(2);
            this.rshButton.Name = "rshButton";
            this.rshButton.Size = new System.Drawing.Size(48, 36);
            this.rshButton.TabIndex = 3;
            this.rshButton.Text = "Rsh";
            this.rshButton.UseVisualStyleBackColor = false;
            this.rshButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // xorButton
            // 
            this.xorButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.xorButton.FlatAppearance.BorderSize = 0;
            this.xorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xorButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xorButton.Location = new System.Drawing.Point(161, 233);
            this.xorButton.Margin = new System.Windows.Forms.Padding(2);
            this.xorButton.Name = "xorButton";
            this.xorButton.Size = new System.Drawing.Size(48, 36);
            this.xorButton.TabIndex = 5;
            this.xorButton.Text = "Xor";
            this.xorButton.UseVisualStyleBackColor = false;
            this.xorButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // andButton
            // 
            this.andButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.andButton.FlatAppearance.BorderSize = 0;
            this.andButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.andButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.andButton.Location = new System.Drawing.Point(264, 233);
            this.andButton.Margin = new System.Windows.Forms.Padding(2);
            this.andButton.Name = "andButton";
            this.andButton.Size = new System.Drawing.Size(48, 36);
            this.andButton.TabIndex = 7;
            this.andButton.Text = "And";
            this.andButton.UseVisualStyleBackColor = false;
            this.andButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // notButton
            // 
            this.notButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.notButton.FlatAppearance.BorderSize = 0;
            this.notButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notButton.Location = new System.Drawing.Point(213, 233);
            this.notButton.Margin = new System.Windows.Forms.Padding(2);
            this.notButton.Name = "notButton";
            this.notButton.Size = new System.Drawing.Size(48, 36);
            this.notButton.TabIndex = 6;
            this.notButton.Text = "Not";
            this.notButton.UseVisualStyleBackColor = false;
            this.notButton.Click += new System.EventHandler(this.notButton_Click);
            // 
            // orButton
            // 
            this.orButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.orButton.FlatAppearance.BorderSize = 0;
            this.orButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orButton.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orButton.Location = new System.Drawing.Point(109, 233);
            this.orButton.Margin = new System.Windows.Forms.Padding(2);
            this.orButton.Name = "orButton";
            this.orButton.Size = new System.Drawing.Size(48, 36);
            this.orButton.TabIndex = 4;
            this.orButton.Text = "Or";
            this.orButton.UseVisualStyleBackColor = false;
            this.orButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // fullResultTextBox
            // 
            this.fullResultTextBox.BackColor = System.Drawing.Color.LightGray;
            this.fullResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fullResultTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullResultTextBox.Location = new System.Drawing.Point(5, 49);
            this.fullResultTextBox.MaxLength = 34;
            this.fullResultTextBox.Name = "fullResultTextBox";
            this.fullResultTextBox.ReadOnly = true;
            this.fullResultTextBox.Size = new System.Drawing.Size(308, 22);
            this.fullResultTextBox.TabIndex = 38;
            this.fullResultTextBox.TabStop = false;
            this.fullResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // binButton
            // 
            this.binButton.BackColor = System.Drawing.Color.Transparent;
            this.binButton.FlatAppearance.BorderSize = 0;
            this.binButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.binButton.Font = new System.Drawing.Font("Meiryo UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.binButton.Location = new System.Drawing.Point(5, 205);
            this.binButton.Margin = new System.Windows.Forms.Padding(2);
            this.binButton.Name = "binButton";
            this.binButton.Size = new System.Drawing.Size(48, 24);
            this.binButton.TabIndex = 39;
            this.binButton.Text = "BIN";
            this.binButton.UseVisualStyleBackColor = false;
            this.binButton.Click += new System.EventHandler(this.selectNumeralSystemButton_Click);
            // 
            // binLabel
            // 
            this.binLabel.AutoSize = true;
            this.binLabel.Font = new System.Drawing.Font("Meiryo UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.binLabel.Location = new System.Drawing.Point(58, 210);
            this.binLabel.Name = "binLabel";
            this.binLabel.Size = new System.Drawing.Size(14, 14);
            this.binLabel.TabIndex = 40;
            this.binLabel.Text = "0";
            this.binLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // octButton
            // 
            this.octButton.BackColor = System.Drawing.Color.Transparent;
            this.octButton.FlatAppearance.BorderSize = 0;
            this.octButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.octButton.Font = new System.Drawing.Font("Meiryo UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.octButton.Location = new System.Drawing.Point(5, 177);
            this.octButton.Margin = new System.Windows.Forms.Padding(2);
            this.octButton.Name = "octButton";
            this.octButton.Size = new System.Drawing.Size(48, 24);
            this.octButton.TabIndex = 41;
            this.octButton.Text = "OCT";
            this.octButton.UseVisualStyleBackColor = false;
            this.octButton.Click += new System.EventHandler(this.selectNumeralSystemButton_Click);
            // 
            // decButton
            // 
            this.decButton.BackColor = System.Drawing.Color.Transparent;
            this.decButton.FlatAppearance.BorderSize = 0;
            this.decButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decButton.Font = new System.Drawing.Font("Meiryo UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.decButton.Location = new System.Drawing.Point(5, 149);
            this.decButton.Margin = new System.Windows.Forms.Padding(2);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(48, 24);
            this.decButton.TabIndex = 42;
            this.decButton.Text = "DEC";
            this.decButton.UseVisualStyleBackColor = false;
            this.decButton.Click += new System.EventHandler(this.selectNumeralSystemButton_Click);
            // 
            // hexButton
            // 
            this.hexButton.BackColor = System.Drawing.Color.Transparent;
            this.hexButton.FlatAppearance.BorderSize = 0;
            this.hexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hexButton.Font = new System.Drawing.Font("Meiryo UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hexButton.Location = new System.Drawing.Point(5, 121);
            this.hexButton.Margin = new System.Windows.Forms.Padding(2);
            this.hexButton.Name = "hexButton";
            this.hexButton.Size = new System.Drawing.Size(48, 24);
            this.hexButton.TabIndex = 43;
            this.hexButton.Text = "HEX";
            this.hexButton.UseVisualStyleBackColor = false;
            this.hexButton.Click += new System.EventHandler(this.selectNumeralSystemButton_Click);
            // 
            // octLabel
            // 
            this.octLabel.AutoSize = true;
            this.octLabel.Font = new System.Drawing.Font("Meiryo UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.octLabel.Location = new System.Drawing.Point(58, 182);
            this.octLabel.Name = "octLabel";
            this.octLabel.Size = new System.Drawing.Size(14, 14);
            this.octLabel.TabIndex = 44;
            this.octLabel.Text = "0";
            this.octLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // decLabel
            // 
            this.decLabel.AutoSize = true;
            this.decLabel.Font = new System.Drawing.Font("Meiryo UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.decLabel.Location = new System.Drawing.Point(58, 154);
            this.decLabel.Name = "decLabel";
            this.decLabel.Size = new System.Drawing.Size(14, 14);
            this.decLabel.TabIndex = 45;
            this.decLabel.Text = "0";
            this.decLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Font = new System.Drawing.Font("Meiryo UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hexLabel.Location = new System.Drawing.Point(58, 126);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(14, 14);
            this.hexLabel.TabIndex = 46;
            this.hexLabel.Text = "0";
            this.hexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(318, 474);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.decLabel);
            this.Controls.Add(this.octLabel);
            this.Controls.Add(this.hexButton);
            this.Controls.Add(this.decButton);
            this.Controls.Add(this.octButton);
            this.Controls.Add(this.binLabel);
            this.Controls.Add(this.binButton);
            this.Controls.Add(this.fullResultTextBox);
            this.Controls.Add(this.orButton);
            this.Controls.Add(this.notButton);
            this.Controls.Add(this.andButton);
            this.Controls.Add(this.xorButton);
            this.Controls.Add(this.rshButton);
            this.Controls.Add(this.lshButton);
            this.Controls.Add(this.fButton);
            this.Controls.Add(this.dButton);
            this.Controls.Add(this.eButton);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.bButton);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.roundButton);
            this.Controls.Add(this.openBracketButton);
            this.Controls.Add(this.closeBracketButton);
            this.Controls.Add(this.plus_minusButton);
            this.Controls.Add(this.modButton);
            this.Controls.Add(this.clearEntryButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.clearLastElemButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.multButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.pointButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button multButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button clearLastElemButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button clearEntryButton;
        private System.Windows.Forms.Button modButton;
        private System.Windows.Forms.Button plus_minusButton;
        private System.Windows.Forms.Button closeBracketButton;
        private System.Windows.Forms.Button openBracketButton;
        private System.Windows.Forms.Button roundButton;
        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Button bButton;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button eButton;
        private System.Windows.Forms.Button dButton;
        private System.Windows.Forms.Button fButton;
        private System.Windows.Forms.Button lshButton;
        private System.Windows.Forms.Button rshButton;
        private System.Windows.Forms.Button xorButton;
        private System.Windows.Forms.Button andButton;
        private System.Windows.Forms.Button notButton;
        private System.Windows.Forms.Button orButton;
        private System.Windows.Forms.TextBox fullResultTextBox;
        private System.Windows.Forms.Button binButton;
        private System.Windows.Forms.Label binLabel;
        private System.Windows.Forms.Button octButton;
        private System.Windows.Forms.Button decButton;
        private System.Windows.Forms.Button hexButton;
        private System.Windows.Forms.Label octLabel;
        private System.Windows.Forms.Label decLabel;
        private System.Windows.Forms.Label hexLabel;
    }
}

