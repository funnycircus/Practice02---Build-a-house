namespace Practice02___Build_a_house
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.goThroughTheDoor = new System.Windows.Forms.Button();
            this.Exits = new System.Windows.Forms.ComboBox();
            this.goHere = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.goThroughTheStair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goThroughTheDoor
            // 
            this.goThroughTheDoor.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.goThroughTheDoor.Location = new System.Drawing.Point(12, 347);
            this.goThroughTheDoor.Name = "goThroughTheDoor";
            this.goThroughTheDoor.Size = new System.Drawing.Size(826, 87);
            this.goThroughTheDoor.TabIndex = 7;
            this.goThroughTheDoor.Text = "走過這扇門";
            this.goThroughTheDoor.UseVisualStyleBackColor = true;
            this.goThroughTheDoor.Click += new System.EventHandler(this.goThroughTheDoor_Click);
            // 
            // Exits
            // 
            this.Exits.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Exits.FormattingEnabled = true;
            this.Exits.Location = new System.Drawing.Point(363, 287);
            this.Exits.Name = "Exits";
            this.Exits.Size = new System.Drawing.Size(475, 32);
            this.Exits.TabIndex = 6;
            // 
            // goHere
            // 
            this.goHere.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.goHere.Location = new System.Drawing.Point(12, 287);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(315, 42);
            this.goHere.TabIndex = 5;
            this.goHere.Text = "我要到:";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.description.Location = new System.Drawing.Point(12, 10);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(826, 254);
            this.description.TabIndex = 4;
            // 
            // goThroughTheStair
            // 
            this.goThroughTheStair.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.goThroughTheStair.Location = new System.Drawing.Point(13, 453);
            this.goThroughTheStair.Name = "goThroughTheStair";
            this.goThroughTheStair.Size = new System.Drawing.Size(826, 87);
            this.goThroughTheStair.TabIndex = 8;
            this.goThroughTheStair.Text = "走過這樓梯";
            this.goThroughTheStair.UseVisualStyleBackColor = true;
            this.goThroughTheStair.Click += new System.EventHandler(this.goThroughTheStair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 552);
            this.Controls.Add(this.goThroughTheStair);
            this.Controls.Add(this.goThroughTheDoor);
            this.Controls.Add(this.Exits);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.description);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goThroughTheDoor;
        private System.Windows.Forms.ComboBox Exits;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button goThroughTheStair;
    }
}

