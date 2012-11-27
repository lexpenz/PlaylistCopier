namespace SimplePlayListCorier
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._btnOpenFile = new System.Windows.Forms.Button();
            this._tbFile = new System.Windows.Forms.TextBox();
            this._tbFolder = new System.Windows.Forms.TextBox();
            this._btnOpenFolder = new System.Windows.Forms.Button();
            this._btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnOpenFile
            // 
            this._btnOpenFile.Location = new System.Drawing.Point(292, 10);
            this._btnOpenFile.Name = "_btnOpenFile";
            this._btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this._btnOpenFile.TabIndex = 0;
            this._btnOpenFile.Text = "Открыть...";
            this._btnOpenFile.UseVisualStyleBackColor = true;
            this._btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // _tbFile
            // 
            this._tbFile.Location = new System.Drawing.Point(12, 12);
            this._tbFile.Name = "_tbFile";
            this._tbFile.Size = new System.Drawing.Size(272, 20);
            this._tbFile.TabIndex = 1;
            // 
            // _tbFolder
            // 
            this._tbFolder.Location = new System.Drawing.Point(12, 39);
            this._tbFolder.Name = "_tbFolder";
            this._tbFolder.Size = new System.Drawing.Size(272, 20);
            this._tbFolder.TabIndex = 2;
            // 
            // _btnOpenFolder
            // 
            this._btnOpenFolder.Location = new System.Drawing.Point(292, 36);
            this._btnOpenFolder.Name = "_btnOpenFolder";
            this._btnOpenFolder.Size = new System.Drawing.Size(75, 23);
            this._btnOpenFolder.TabIndex = 3;
            this._btnOpenFolder.Text = "Выбрать...";
            this._btnOpenFolder.UseVisualStyleBackColor = true;
            this._btnOpenFolder.Click += new System.EventHandler(this._btnOpenFolder_Click);
            // 
            // _btnCopy
            // 
            this._btnCopy.Location = new System.Drawing.Point(12, 66);
            this._btnCopy.Name = "_btnCopy";
            this._btnCopy.Size = new System.Drawing.Size(355, 23);
            this._btnCopy.TabIndex = 4;
            this._btnCopy.Text = "Копировать!";
            this._btnCopy.UseVisualStyleBackColor = true;
            this._btnCopy.Click += new System.EventHandler(this._btnCopy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 266);
            this.Controls.Add(this._btnCopy);
            this.Controls.Add(this._btnOpenFolder);
            this.Controls.Add(this._tbFolder);
            this.Controls.Add(this._tbFile);
            this.Controls.Add(this._btnOpenFile);
            this.Name = "MainForm";
            this.Text = "M3U copier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnOpenFile;
        private System.Windows.Forms.TextBox _tbFile;
        private System.Windows.Forms.TextBox _tbFolder;
        private System.Windows.Forms.Button _btnOpenFolder;
        private System.Windows.Forms.Button _btnCopy;
    }
}

