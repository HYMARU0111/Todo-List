namespace ToDo
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Delete = new System.Windows.Forms.Button();
            this.ItemData = new System.Windows.Forms.DataGridView();
            this.Insert = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.registered_todo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemData)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(251, 536);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(180, 50);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "ToDo 削除";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ItemData
            // 
            this.ItemData.AllowUserToAddRows = false;
            this.ItemData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemData.Location = new System.Drawing.Point(19, 133);
            this.ItemData.Name = "ItemData";
            this.ItemData.RowHeadersWidth = 51;
            this.ItemData.RowTemplate.Height = 24;
            this.ItemData.Size = new System.Drawing.Size(625, 268);
            this.ItemData.TabIndex = 2;
            this.ItemData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ItemData_CellFormatting);
            this.ItemData.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.ItemData_RowPrePaint);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(19, 536);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(180, 50);
            this.Insert.TabIndex = 4;
            this.Insert.Text = "登録する";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(19, 436);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(412, 22);
            this.date.TabIndex = 3;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged_1);
            // 
            // registered_todo
            // 
            this.registered_todo.Location = new System.Drawing.Point(19, 491);
            this.registered_todo.Name = "registered_todo";
            this.registered_todo.Size = new System.Drawing.Size(412, 22);
            this.registered_todo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 78);
            this.label1.TabIndex = 6;
            this.label1.Text = "My ToDo List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "登録する日付";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "やること";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(506, 536);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(138, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "閉じる";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(506, 508);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(138, 23);
            this.LoadButton.TabIndex = 11;
            this.LoadButton.Text = "読み込み";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(667, 700);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registered_todo);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.date);
            this.Controls.Add(this.ItemData);
            this.Controls.Add(this.Delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My ToDo List";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView ItemData;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox registered_todo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button LoadButton;
    }
}

