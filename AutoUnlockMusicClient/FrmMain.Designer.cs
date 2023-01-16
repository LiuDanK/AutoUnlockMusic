namespace AutoUnlockMusicClient
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.log_panel = new HZH_Controls.Controls.UCPanelTitle();
            this.log_richTextBox = new System.Windows.Forms.RichTextBox();
            this.log_timer = new System.Windows.Forms.Timer(this.components);
            this.set_panel = new HZH_Controls.Controls.UCPanelTitle();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_HeartbeatInterval = new HZH_Controls.Controls.TextBoxEx();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_RetryDelayInterval = new HZH_Controls.Controls.TextBoxEx();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaxRetries = new HZH_Controls.Controls.TextBoxEx();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.switch_IsDeleteOrigin = new HZH_Controls.Controls.UCSwitch();
            this.txt_OutputPath = new HZH_Controls.Controls.TextBoxEx();
            this.txt_InputPath = new HZH_Controls.Controls.TextBoxEx();
            this.log_panel.SuspendLayout();
            this.set_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // log_panel
            // 
            this.log_panel.BackColor = System.Drawing.Color.Transparent;
            this.log_panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.log_panel.ConerRadius = 10;
            this.log_panel.Controls.Add(this.log_richTextBox);
            this.log_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.log_panel.FillColor = System.Drawing.Color.White;
            this.log_panel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.log_panel.IsCanExpand = true;
            this.log_panel.IsExpand = false;
            this.log_panel.IsRadius = true;
            this.log_panel.IsShowRect = false;
            this.log_panel.Location = new System.Drawing.Point(0, 301);
            this.log_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.log_panel.Name = "log_panel";
            this.log_panel.Padding = new System.Windows.Forms.Padding(1);
            this.log_panel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.log_panel.RectWidth = 0;
            this.log_panel.Size = new System.Drawing.Size(600, 199);
            this.log_panel.TabIndex = 7;
            this.log_panel.Title = "日志";
            // 
            // log_richTextBox
            // 
            this.log_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log_richTextBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.log_richTextBox.Location = new System.Drawing.Point(1, 35);
            this.log_richTextBox.Name = "log_richTextBox";
            this.log_richTextBox.ReadOnly = true;
            this.log_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.log_richTextBox.Size = new System.Drawing.Size(598, 165);
            this.log_richTextBox.TabIndex = 2;
            this.log_richTextBox.Text = "";
            // 
            // log_timer
            // 
            this.log_timer.Interval = 1000;
            this.log_timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // set_panel
            // 
            this.set_panel.BackColor = System.Drawing.Color.Transparent;
            this.set_panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.set_panel.ConerRadius = 10;
            this.set_panel.Controls.Add(this.btnSave);
            this.set_panel.Controls.Add(this.label6);
            this.set_panel.Controls.Add(this.txt_HeartbeatInterval);
            this.set_panel.Controls.Add(this.label5);
            this.set_panel.Controls.Add(this.txt_RetryDelayInterval);
            this.set_panel.Controls.Add(this.label4);
            this.set_panel.Controls.Add(this.txt_MaxRetries);
            this.set_panel.Controls.Add(this.label3);
            this.set_panel.Controls.Add(this.label2);
            this.set_panel.Controls.Add(this.label1);
            this.set_panel.Controls.Add(this.switch_IsDeleteOrigin);
            this.set_panel.Controls.Add(this.txt_OutputPath);
            this.set_panel.Controls.Add(this.txt_InputPath);
            this.set_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.set_panel.FillColor = System.Drawing.Color.White;
            this.set_panel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.set_panel.IsCanExpand = true;
            this.set_panel.IsExpand = false;
            this.set_panel.IsRadius = true;
            this.set_panel.IsShowRect = true;
            this.set_panel.Location = new System.Drawing.Point(0, 63);
            this.set_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.set_panel.Name = "set_panel";
            this.set_panel.Padding = new System.Windows.Forms.Padding(1);
            this.set_panel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.set_panel.RectWidth = 1;
            this.set_panel.Size = new System.Drawing.Size(600, 238);
            this.set_panel.TabIndex = 9;
            this.set_panel.Title = "设定";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(504, 198);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 32);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(377, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "心跳间隔";
            // 
            // txt_HeartbeatInterval
            // 
            this.txt_HeartbeatInterval.DecLength = 2;
            this.txt_HeartbeatInterval.InputType = HZH_Controls.TextInputType.PositiveInteger;
            this.txt_HeartbeatInterval.Location = new System.Drawing.Point(488, 42);
            this.txt_HeartbeatInterval.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_HeartbeatInterval.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_HeartbeatInterval.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txt_HeartbeatInterval.Name = "txt_HeartbeatInterval";
            this.txt_HeartbeatInterval.OldText = null;
            this.txt_HeartbeatInterval.PlaceholderText = "单位：秒";
            this.txt_HeartbeatInterval.PromptColor = System.Drawing.Color.Gray;
            this.txt_HeartbeatInterval.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_HeartbeatInterval.PromptText = "";
            this.txt_HeartbeatInterval.RegexPattern = "";
            this.txt_HeartbeatInterval.Size = new System.Drawing.Size(100, 27);
            this.txt_HeartbeatInterval.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(377, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "失败重试间隔";
            // 
            // txt_RetryDelayInterval
            // 
            this.txt_RetryDelayInterval.DecLength = 2;
            this.txt_RetryDelayInterval.InputType = HZH_Controls.TextInputType.PositiveInteger;
            this.txt_RetryDelayInterval.Location = new System.Drawing.Point(488, 124);
            this.txt_RetryDelayInterval.MaxValue = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.txt_RetryDelayInterval.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_RetryDelayInterval.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txt_RetryDelayInterval.Name = "txt_RetryDelayInterval";
            this.txt_RetryDelayInterval.OldText = null;
            this.txt_RetryDelayInterval.PlaceholderText = "单位：秒";
            this.txt_RetryDelayInterval.PromptColor = System.Drawing.Color.Gray;
            this.txt_RetryDelayInterval.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_RetryDelayInterval.PromptText = "";
            this.txt_RetryDelayInterval.RegexPattern = "";
            this.txt_RetryDelayInterval.Size = new System.Drawing.Size(100, 27);
            this.txt_RetryDelayInterval.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(377, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "失败重试次数";
            // 
            // txt_MaxRetries
            // 
            this.txt_MaxRetries.DecLength = 2;
            this.txt_MaxRetries.InputType = HZH_Controls.TextInputType.PositiveInteger;
            this.txt_MaxRetries.Location = new System.Drawing.Point(488, 83);
            this.txt_MaxRetries.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txt_MaxRetries.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_MaxRetries.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txt_MaxRetries.Name = "txt_MaxRetries";
            this.txt_MaxRetries.OldText = null;
            this.txt_MaxRetries.PlaceholderText = "0为不重试";
            this.txt_MaxRetries.PromptColor = System.Drawing.Color.Gray;
            this.txt_MaxRetries.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_MaxRetries.PromptText = "";
            this.txt_MaxRetries.RegexPattern = "";
            this.txt_MaxRetries.Size = new System.Drawing.Size(100, 27);
            this.txt_MaxRetries.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "删除源文件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "输出路径";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "监听或输入";
            // 
            // switch_IsDeleteOrigin
            // 
            this.switch_IsDeleteOrigin.BackColor = System.Drawing.Color.Transparent;
            this.switch_IsDeleteOrigin.Checked = false;
            this.switch_IsDeleteOrigin.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.switch_IsDeleteOrigin.FalseTextColr = System.Drawing.Color.White;
            this.switch_IsDeleteOrigin.Location = new System.Drawing.Point(105, 122);
            this.switch_IsDeleteOrigin.Name = "switch_IsDeleteOrigin";
            this.switch_IsDeleteOrigin.Size = new System.Drawing.Size(83, 31);
            this.switch_IsDeleteOrigin.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.switch_IsDeleteOrigin.TabIndex = 3;
            this.switch_IsDeleteOrigin.Texts = null;
            this.switch_IsDeleteOrigin.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.switch_IsDeleteOrigin.TrueTextColr = System.Drawing.Color.White;
            // 
            // txt_OutputPath
            // 
            this.txt_OutputPath.DecLength = 2;
            this.txt_OutputPath.InputType = HZH_Controls.TextInputType.NotControl;
            this.txt_OutputPath.Location = new System.Drawing.Point(105, 83);
            this.txt_OutputPath.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_OutputPath.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txt_OutputPath.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txt_OutputPath.Name = "txt_OutputPath";
            this.txt_OutputPath.OldText = null;
            this.txt_OutputPath.PlaceholderText = "输出路径";
            this.txt_OutputPath.PromptColor = System.Drawing.Color.Gray;
            this.txt_OutputPath.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_OutputPath.PromptText = "";
            this.txt_OutputPath.RegexPattern = "";
            this.txt_OutputPath.Size = new System.Drawing.Size(248, 27);
            this.txt_OutputPath.TabIndex = 2;
            // 
            // txt_InputPath
            // 
            this.txt_InputPath.DecLength = 2;
            this.txt_InputPath.InputType = HZH_Controls.TextInputType.NotControl;
            this.txt_InputPath.Location = new System.Drawing.Point(105, 42);
            this.txt_InputPath.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_InputPath.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txt_InputPath.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txt_InputPath.Name = "txt_InputPath";
            this.txt_InputPath.OldText = null;
            this.txt_InputPath.PlaceholderText = "监听/输入文件路径";
            this.txt_InputPath.PromptColor = System.Drawing.Color.Gray;
            this.txt_InputPath.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_InputPath.PromptText = "";
            this.txt_InputPath.RegexPattern = "";
            this.txt_InputPath.Size = new System.Drawing.Size(248, 27);
            this.txt_InputPath.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.set_panel);
            this.Controls.Add(this.log_panel);
            this.IsShowCloseBtn = true;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowInTaskbar = true;
            this.Text = "解密";
            this.Title = "放心听歌小工具";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Controls.SetChildIndex(this.log_panel, 0);
            this.Controls.SetChildIndex(this.set_panel, 0);
            this.log_panel.ResumeLayout(false);
            this.set_panel.ResumeLayout(false);
            this.set_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCPanelTitle log_panel;
        private RichTextBox log_richTextBox;
        private System.Windows.Forms.Timer log_timer;
        private HZH_Controls.Controls.UCPanelTitle set_panel;
        private Label label5;
        private HZH_Controls.Controls.TextBoxEx txt_RetryDelayInterval;
        private Label label4;
        private HZH_Controls.Controls.TextBoxEx txt_MaxRetries;
        private Label label3;
        private Label label2;
        private Label label1;
        private HZH_Controls.Controls.UCSwitch switch_IsDeleteOrigin;
        private HZH_Controls.Controls.TextBoxEx txt_OutputPath;
        private HZH_Controls.Controls.TextBoxEx txt_InputPath;
        private Label label6;
        private HZH_Controls.Controls.TextBoxEx txt_HeartbeatInterval;
        private Button btnSave;
    }
}