namespace CalculatorWF
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            equalsBtn = new Button();
            commaBtn = new Button();
            zeroBtn = new Button();
            clearBtn = new Button();
            addBtn = new Button();
            threeBtn = new Button();
            twoBtn = new Button();
            oneBtn = new Button();
            subtractBtn = new Button();
            sixBtn = new Button();
            fiveBtn = new Button();
            fourBtn = new Button();
            multiplyBtn = new Button();
            nineBtn = new Button();
            eightBtn = new Button();
            sevenBtn = new Button();
            divideBtn = new Button();
            displayLabel = new Label();
            deleteLastBtn = new Button();
            leftParenthesisBtn = new Button();
            rightParenthesisBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(equalsBtn, 3, 5);
            tableLayoutPanel1.Controls.Add(commaBtn, 2, 5);
            tableLayoutPanel1.Controls.Add(zeroBtn, 1, 5);
            tableLayoutPanel1.Controls.Add(clearBtn, 0, 5);
            tableLayoutPanel1.Controls.Add(addBtn, 3, 4);
            tableLayoutPanel1.Controls.Add(threeBtn, 2, 4);
            tableLayoutPanel1.Controls.Add(twoBtn, 1, 4);
            tableLayoutPanel1.Controls.Add(oneBtn, 0, 4);
            tableLayoutPanel1.Controls.Add(subtractBtn, 3, 3);
            tableLayoutPanel1.Controls.Add(sixBtn, 2, 3);
            tableLayoutPanel1.Controls.Add(fiveBtn, 1, 3);
            tableLayoutPanel1.Controls.Add(fourBtn, 0, 3);
            tableLayoutPanel1.Controls.Add(multiplyBtn, 3, 2);
            tableLayoutPanel1.Controls.Add(nineBtn, 2, 2);
            tableLayoutPanel1.Controls.Add(eightBtn, 1, 2);
            tableLayoutPanel1.Controls.Add(sevenBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(divideBtn, 3, 1);
            tableLayoutPanel1.Controls.Add(displayLabel, 3, -1);
            tableLayoutPanel1.Controls.Add(deleteLastBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(leftParenthesisBtn, 1, 1);
            tableLayoutPanel1.Controls.Add(rightParenthesisBtn, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(309, 486);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // equalsBtn
            // 
            equalsBtn.Dock = DockStyle.Fill;
            equalsBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            equalsBtn.Location = new Point(234, 408);
            equalsBtn.Name = "equalsBtn";
            equalsBtn.Size = new Size(72, 75);
            equalsBtn.TabIndex = 20;
            equalsBtn.Text = "=";
            equalsBtn.UseVisualStyleBackColor = true;
            equalsBtn.Click += EqualsBtn_Click;
            // 
            // commaBtn
            // 
            commaBtn.Dock = DockStyle.Fill;
            commaBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            commaBtn.Location = new Point(157, 408);
            commaBtn.Name = "commaBtn";
            commaBtn.Size = new Size(71, 75);
            commaBtn.TabIndex = 19;
            commaBtn.Text = ",";
            commaBtn.UseVisualStyleBackColor = true;
            commaBtn.Click += InsertSymbolBtn_Click;
            // 
            // zeroBtn
            // 
            zeroBtn.Dock = DockStyle.Fill;
            zeroBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            zeroBtn.Location = new Point(80, 408);
            zeroBtn.Name = "zeroBtn";
            zeroBtn.Size = new Size(71, 75);
            zeroBtn.TabIndex = 18;
            zeroBtn.Text = "0";
            zeroBtn.UseVisualStyleBackColor = true;
            zeroBtn.Click += InsertNumberBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Dock = DockStyle.Fill;
            clearBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.ForeColor = Color.Red;
            clearBtn.Location = new Point(3, 408);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(71, 75);
            clearBtn.TabIndex = 17;
            clearBtn.Text = "CE";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += ClearBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Dock = DockStyle.Fill;
            addBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.Location = new Point(234, 327);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(72, 75);
            addBtn.TabIndex = 16;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += InsertSymbolBtn_Click;
            // 
            // threeBtn
            // 
            threeBtn.Dock = DockStyle.Fill;
            threeBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            threeBtn.Location = new Point(157, 327);
            threeBtn.Name = "threeBtn";
            threeBtn.Size = new Size(71, 75);
            threeBtn.TabIndex = 15;
            threeBtn.Text = "3";
            threeBtn.UseVisualStyleBackColor = true;
            threeBtn.Click += InsertNumberBtn_Click;
            // 
            // twoBtn
            // 
            twoBtn.Dock = DockStyle.Fill;
            twoBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            twoBtn.Location = new Point(80, 327);
            twoBtn.Name = "twoBtn";
            twoBtn.Size = new Size(71, 75);
            twoBtn.TabIndex = 14;
            twoBtn.Text = "2";
            twoBtn.UseVisualStyleBackColor = true;
            twoBtn.Click += InsertNumberBtn_Click;
            // 
            // oneBtn
            // 
            oneBtn.Dock = DockStyle.Fill;
            oneBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            oneBtn.Location = new Point(3, 327);
            oneBtn.Name = "oneBtn";
            oneBtn.Size = new Size(71, 75);
            oneBtn.TabIndex = 13;
            oneBtn.Text = "1";
            oneBtn.UseVisualStyleBackColor = true;
            oneBtn.Click += InsertNumberBtn_Click;
            // 
            // subtractBtn
            // 
            subtractBtn.Dock = DockStyle.Fill;
            subtractBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            subtractBtn.Location = new Point(234, 246);
            subtractBtn.Name = "subtractBtn";
            subtractBtn.Size = new Size(72, 75);
            subtractBtn.TabIndex = 12;
            subtractBtn.Text = "-";
            subtractBtn.UseVisualStyleBackColor = true;
            subtractBtn.Click += InsertSymbolBtn_Click;
            // 
            // sixBtn
            // 
            sixBtn.Dock = DockStyle.Fill;
            sixBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sixBtn.Location = new Point(157, 246);
            sixBtn.Name = "sixBtn";
            sixBtn.Size = new Size(71, 75);
            sixBtn.TabIndex = 11;
            sixBtn.Text = "6";
            sixBtn.UseVisualStyleBackColor = true;
            sixBtn.Click += InsertNumberBtn_Click;
            // 
            // fiveBtn
            // 
            fiveBtn.Dock = DockStyle.Fill;
            fiveBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            fiveBtn.Location = new Point(80, 246);
            fiveBtn.Name = "fiveBtn";
            fiveBtn.Size = new Size(71, 75);
            fiveBtn.TabIndex = 10;
            fiveBtn.Text = "5";
            fiveBtn.UseVisualStyleBackColor = true;
            fiveBtn.Click += InsertNumberBtn_Click;
            // 
            // fourBtn
            // 
            fourBtn.Dock = DockStyle.Fill;
            fourBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            fourBtn.Location = new Point(3, 246);
            fourBtn.Name = "fourBtn";
            fourBtn.Size = new Size(71, 75);
            fourBtn.TabIndex = 9;
            fourBtn.Text = "4";
            fourBtn.UseVisualStyleBackColor = true;
            fourBtn.Click += InsertNumberBtn_Click;
            // 
            // multiplyBtn
            // 
            multiplyBtn.Dock = DockStyle.Fill;
            multiplyBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            multiplyBtn.Location = new Point(234, 165);
            multiplyBtn.Name = "multiplyBtn";
            multiplyBtn.Size = new Size(72, 75);
            multiplyBtn.TabIndex = 8;
            multiplyBtn.Text = "x";
            multiplyBtn.UseVisualStyleBackColor = true;
            multiplyBtn.Click += InsertSymbolBtn_Click;
            // 
            // nineBtn
            // 
            nineBtn.Dock = DockStyle.Fill;
            nineBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nineBtn.Location = new Point(157, 165);
            nineBtn.Name = "nineBtn";
            nineBtn.Size = new Size(71, 75);
            nineBtn.TabIndex = 7;
            nineBtn.Text = "9";
            nineBtn.UseVisualStyleBackColor = true;
            nineBtn.Click += InsertNumberBtn_Click;
            // 
            // eightBtn
            // 
            eightBtn.Dock = DockStyle.Fill;
            eightBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            eightBtn.Location = new Point(80, 165);
            eightBtn.Name = "eightBtn";
            eightBtn.Size = new Size(71, 75);
            eightBtn.TabIndex = 6;
            eightBtn.Text = "8";
            eightBtn.UseVisualStyleBackColor = true;
            eightBtn.Click += InsertNumberBtn_Click;
            // 
            // sevenBtn
            // 
            sevenBtn.Dock = DockStyle.Fill;
            sevenBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sevenBtn.Location = new Point(3, 165);
            sevenBtn.Name = "sevenBtn";
            sevenBtn.Size = new Size(71, 75);
            sevenBtn.TabIndex = 5;
            sevenBtn.Text = "7";
            sevenBtn.UseVisualStyleBackColor = true;
            sevenBtn.Click += InsertNumberBtn_Click;
            // 
            // divideBtn
            // 
            divideBtn.Dock = DockStyle.Fill;
            divideBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            divideBtn.Location = new Point(234, 84);
            divideBtn.Name = "divideBtn";
            divideBtn.Size = new Size(72, 75);
            divideBtn.TabIndex = 4;
            divideBtn.Text = "/";
            divideBtn.UseVisualStyleBackColor = true;
            divideBtn.Click += InsertSymbolBtn_Click;
            // 
            // displayLabel
            // 
            displayLabel.AutoSize = true;
            displayLabel.BackColor = SystemColors.Window;
            tableLayoutPanel1.SetColumnSpan(displayLabel, 4);
            displayLabel.Dock = DockStyle.Fill;
            displayLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            displayLabel.ForeColor = SystemColors.ControlText;
            displayLabel.Location = new Point(3, 0);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(303, 81);
            displayLabel.TabIndex = 0;
            displayLabel.Text = "0";
            displayLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // deleteLastBtn
            // 
            deleteLastBtn.Dock = DockStyle.Fill;
            deleteLastBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deleteLastBtn.ForeColor = Color.Red;
            deleteLastBtn.Location = new Point(3, 84);
            deleteLastBtn.Name = "deleteLastBtn";
            deleteLastBtn.Size = new Size(71, 75);
            deleteLastBtn.TabIndex = 21;
            deleteLastBtn.Text = "Corregir";
            deleteLastBtn.UseVisualStyleBackColor = true;
            deleteLastBtn.Click += DeleteLastBtn_Click;
            // 
            // leftParenthesisBtn
            // 
            leftParenthesisBtn.Dock = DockStyle.Fill;
            leftParenthesisBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            leftParenthesisBtn.Location = new Point(80, 84);
            leftParenthesisBtn.Name = "leftParenthesisBtn";
            leftParenthesisBtn.Size = new Size(71, 75);
            leftParenthesisBtn.TabIndex = 22;
            leftParenthesisBtn.Text = "(";
            leftParenthesisBtn.UseVisualStyleBackColor = true;
            leftParenthesisBtn.Click += InsertParenthesisBtn_Click;
            // 
            // rightParenthesisBtn
            // 
            rightParenthesisBtn.Dock = DockStyle.Fill;
            rightParenthesisBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rightParenthesisBtn.Location = new Point(157, 84);
            rightParenthesisBtn.Name = "rightParenthesisBtn";
            rightParenthesisBtn.Size = new Size(71, 75);
            rightParenthesisBtn.TabIndex = 23;
            rightParenthesisBtn.Text = ")";
            rightParenthesisBtn.UseVisualStyleBackColor = true;
            rightParenthesisBtn.Click += InsertParenthesisBtn_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 486);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Calculadora";
            Text = "Calculadora";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label displayLabel;
        private Button addBtn;
        private Button threeBtn;
        private Button twoBtn;
        private Button oneBtn;
        private Button subtractBtn;
        private Button sixBtn;
        private Button fiveBtn;
        private Button fourBtn;
        private Button multiplyBtn;
        private Button nineBtn;
        private Button eightBtn;
        private Button sevenBtn;
        private Button divideBtn;
        private Button equalsBtn;
        private Button commaBtn;
        private Button zeroBtn;
        private Button clearBtn;
        private Button deleteLastBtn;
        private Button leftParenthesisBtn;
        private Button rightParenthesisBtn;
    }
}