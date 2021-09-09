
namespace SQLite_WinForms_NETFramework_CodeFirst
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label numberLabel1;
            System.Windows.Forms.Label shiftIdLabel;
            this.butAddShift = new System.Windows.Forms.Button();
            this.butAddCashVoucher = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBoxNumberShift = new System.Windows.Forms.TextBox();
            this.tBoxCashVoucherNumber = new System.Windows.Forms.TextBox();
            this.tBoxShiftId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butGetAllCashVoucher = new System.Windows.Forms.Button();
            this.cashVoucherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shiftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBoxConsole = new System.Windows.Forms.TextBox();
            numberLabel = new System.Windows.Forms.Label();
            numberLabel1 = new System.Windows.Forms.Label();
            shiftIdLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashVoucherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // butAddShift
            // 
            this.butAddShift.Location = new System.Drawing.Point(12, 48);
            this.butAddShift.Name = "butAddShift";
            this.butAddShift.Size = new System.Drawing.Size(184, 23);
            this.butAddShift.TabIndex = 5;
            this.butAddShift.Text = "Добавить смену";
            this.butAddShift.UseVisualStyleBackColor = true;
            this.butAddShift.Click += new System.EventHandler(this.butAddShift_Click);
            // 
            // butAddCashVoucher
            // 
            this.butAddCashVoucher.Location = new System.Drawing.Point(13, 71);
            this.butAddCashVoucher.Name = "butAddCashVoucher";
            this.butAddCashVoucher.Size = new System.Drawing.Size(184, 23);
            this.butAddCashVoucher.TabIndex = 11;
            this.butAddCashVoucher.Text = "Добавить чек в смену";
            this.butAddCashVoucher.UseVisualStyleBackColor = true;
            this.butAddCashVoucher.Click += new System.EventHandler(this.butAddCashVoucher_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(numberLabel);
            this.groupBox1.Controls.Add(this.tBoxNumberShift);
            this.groupBox1.Controls.Add(this.butAddShift);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 84);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить смену";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new System.Drawing.Point(9, 25);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(81, 13);
            numberLabel.TabIndex = 7;
            numberLabel.Text = "Номер смены:";
            // 
            // tBoxNumberShift
            // 
            this.tBoxNumberShift.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shiftBindingSource, "Number", true));
            this.tBoxNumberShift.Location = new System.Drawing.Point(96, 22);
            this.tBoxNumberShift.Name = "tBoxNumberShift";
            this.tBoxNumberShift.Size = new System.Drawing.Size(100, 20);
            this.tBoxNumberShift.TabIndex = 8;
            // 
            // numberLabel1
            // 
            numberLabel1.AutoSize = true;
            numberLabel1.Location = new System.Drawing.Point(10, 22);
            numberLabel1.Name = "numberLabel1";
            numberLabel1.Size = new System.Drawing.Size(70, 13);
            numberLabel1.TabIndex = 19;
            numberLabel1.Text = "Номер чека:";
            // 
            // tBoxCashVoucherNumber
            // 
            this.tBoxCashVoucherNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashVoucherBindingSource, "Number", true));
            this.tBoxCashVoucherNumber.Location = new System.Drawing.Point(88, 19);
            this.tBoxCashVoucherNumber.Name = "tBoxCashVoucherNumber";
            this.tBoxCashVoucherNumber.Size = new System.Drawing.Size(109, 20);
            this.tBoxCashVoucherNumber.TabIndex = 20;
            // 
            // shiftIdLabel
            // 
            shiftIdLabel.AutoSize = true;
            shiftIdLabel.Location = new System.Drawing.Point(10, 48);
            shiftIdLabel.Name = "shiftIdLabel";
            shiftIdLabel.Size = new System.Drawing.Size(58, 13);
            shiftIdLabel.TabIndex = 21;
            shiftIdLabel.Text = "ID смены:";
            // 
            // tBoxShiftId
            // 
            this.tBoxShiftId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashVoucherBindingSource, "ShiftId", true));
            this.tBoxShiftId.Location = new System.Drawing.Point(88, 45);
            this.tBoxShiftId.Name = "tBoxShiftId";
            this.tBoxShiftId.Size = new System.Drawing.Size(109, 20);
            this.tBoxShiftId.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBoxCashVoucherNumber);
            this.groupBox2.Controls.Add(numberLabel1);
            this.groupBox2.Controls.Add(this.butAddCashVoucher);
            this.groupBox2.Controls.Add(this.tBoxShiftId);
            this.groupBox2.Controls.Add(shiftIdLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 106);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить новый чек";
            // 
            // butGetAllCashVoucher
            // 
            this.butGetAllCashVoucher.Location = new System.Drawing.Point(463, 12);
            this.butGetAllCashVoucher.Name = "butGetAllCashVoucher";
            this.butGetAllCashVoucher.Size = new System.Drawing.Size(152, 23);
            this.butGetAllCashVoucher.TabIndex = 24;
            this.butGetAllCashVoucher.Text = "Получить все чеки";
            this.butGetAllCashVoucher.UseVisualStyleBackColor = true;
            this.butGetAllCashVoucher.Click += new System.EventHandler(this.butGetAllCashVoucher_Click);
            // 
            // cashVoucherBindingSource
            // 
            this.cashVoucherBindingSource.DataSource = typeof(SQLite_WinForms_NETFramework_CodeFirst.Entities.CashVoucher);
            // 
            // shiftBindingSource
            // 
            this.shiftBindingSource.DataSource = typeof(SQLite_WinForms_NETFramework_CodeFirst.Entities.Shift);
            // 
            // tBoxConsole
            // 
            this.tBoxConsole.Location = new System.Drawing.Point(286, 41);
            this.tBoxConsole.Multiline = true;
            this.tBoxConsole.Name = "tBoxConsole";
            this.tBoxConsole.Size = new System.Drawing.Size(502, 425);
            this.tBoxConsole.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.tBoxConsole);
            this.Controls.Add(this.butGetAllCashVoucher);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashVoucherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butAddShift;
        private System.Windows.Forms.BindingSource cashVoucherBindingSource;
        private System.Windows.Forms.Button butAddCashVoucher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBoxNumberShift;
        private System.Windows.Forms.BindingSource shiftBindingSource;
        private System.Windows.Forms.TextBox tBoxCashVoucherNumber;
        private System.Windows.Forms.TextBox tBoxShiftId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butGetAllCashVoucher;
        private System.Windows.Forms.TextBox tBoxConsole;
    }
}

