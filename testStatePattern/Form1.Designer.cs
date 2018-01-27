namespace testStatePattern
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboState = new System.Windows.Forms.ComboBox();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboState
            // 
            this.comboState.FormattingEnabled = true;
            this.comboState.Location = new System.Drawing.Point(0, 144);
            this.comboState.Name = "comboState";
            this.comboState.Size = new System.Drawing.Size(283, 20);
            this.comboState.TabIndex = 0;
            this.comboState.SelectedIndexChanged += new System.EventHandler(this.comboState_SelectedIndexChanged);
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(0, 0);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.Size = new System.Drawing.Size(283, 142);
            this.textOutput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 167);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.comboState);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboState;
        private System.Windows.Forms.TextBox textOutput;
    }
}

