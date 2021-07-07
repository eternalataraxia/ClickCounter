
namespace ClickCounter
{
    partial class Counter
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.clickButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.textLabel1 = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.textLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clickButton
            // 
            this.clickButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clickButton.Location = new System.Drawing.Point(144, 177);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(79, 44);
            this.clickButton.TabIndex = 0;
            this.clickButton.Text = "Click";
            this.clickButton.UseVisualStyleBackColor = true;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resetButton.Location = new System.Drawing.Point(302, 177);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(79, 44);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // textLabel1
            // 
            this.textLabel1.AutoSize = true;
            this.textLabel1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textLabel1.Location = new System.Drawing.Point(140, 115);
            this.textLabel1.Name = "textLabel1";
            this.textLabel1.Size = new System.Drawing.Size(142, 20);
            this.textLabel1.TabIndex = 2;
            this.textLabel1.Text = "You have clicked ";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.countLabel.Location = new System.Drawing.Point(291, 115);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(28, 20);
            this.countLabel.TabIndex = 3;
            this.countLabel.Text = " 0 ";
            // 
            // textLabel2
            // 
            this.textLabel2.AutoSize = true;
            this.textLabel2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textLabel2.Location = new System.Drawing.Point(322, 115);
            this.textLabel2.Name = "textLabel2";
            this.textLabel2.Size = new System.Drawing.Size(59, 20);
            this.textLabel2.TabIndex = 4;
            this.textLabel2.Text = " times.";
            // 
            // Counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textLabel2);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.textLabel1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.clickButton);
            this.Name = "Counter";
            this.Text = "Mouse Click Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label textLabel1;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label textLabel2;
    }
}

