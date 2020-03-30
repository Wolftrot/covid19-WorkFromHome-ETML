namespace Form318_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PointerCoordsLabel_display = new System.Windows.Forms.Label();
            this.BrushSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.PointerCoordsLabel = new System.Windows.Forms.Label();
            this.penButton = new System.Windows.Forms.Button();
            this.fontainPenButton = new System.Windows.Forms.Button();
            this.sizeSamplePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BrushSizeLabel = new System.Windows.Forms.Label();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.SelectedColorPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BrushSizeLabel_display = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BrushSizeTrackBar)).BeginInit();
            this.sizeSamplePanel.SuspendLayout();
            this.SelectedColorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PointerCoordsLabel_display
            // 
            this.PointerCoordsLabel_display.AutoSize = true;
            this.PointerCoordsLabel_display.Location = new System.Drawing.Point(145, 620);
            this.PointerCoordsLabel_display.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PointerCoordsLabel_display.Name = "PointerCoordsLabel_display";
            this.PointerCoordsLabel_display.Size = new System.Drawing.Size(14, 20);
            this.PointerCoordsLabel_display.TabIndex = 0;
            this.PointerCoordsLabel_display.Text = "-";
            // 
            // BrushSizeTrackBar
            // 
            this.BrushSizeTrackBar.Location = new System.Drawing.Point(16, 480);
            this.BrushSizeTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BrushSizeTrackBar.Maximum = 50;
            this.BrushSizeTrackBar.Name = "BrushSizeTrackBar";
            this.BrushSizeTrackBar.Size = new System.Drawing.Size(162, 69);
            this.BrushSizeTrackBar.TabIndex = 2;
            this.BrushSizeTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // PointerCoordsLabel
            // 
            this.PointerCoordsLabel.AutoSize = true;
            this.PointerCoordsLabel.Location = new System.Drawing.Point(13, 620);
            this.PointerCoordsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PointerCoordsLabel.Name = "PointerCoordsLabel";
            this.PointerCoordsLabel.Size = new System.Drawing.Size(124, 20);
            this.PointerCoordsLabel.TabIndex = 3;
            this.PointerCoordsLabel.Text = "Pointer Location";
            // 
            // penButton
            // 
            this.penButton.Location = new System.Drawing.Point(17, 15);
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(160, 40);
            this.penButton.TabIndex = 0;
            this.penButton.Text = "Pen";
            this.penButton.UseVisualStyleBackColor = true;
            // 
            // fontainPenButton
            // 
            this.fontainPenButton.Location = new System.Drawing.Point(16, 61);
            this.fontainPenButton.Name = "fontainPenButton";
            this.fontainPenButton.Size = new System.Drawing.Size(161, 45);
            this.fontainPenButton.TabIndex = 1;
            this.fontainPenButton.Text = "Fountain Pen";
            this.fontainPenButton.UseVisualStyleBackColor = true;
            // 
            // sizeSamplePanel
            // 
            this.sizeSamplePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sizeSamplePanel.Controls.Add(this.panel1);
            this.sizeSamplePanel.Location = new System.Drawing.Point(17, 112);
            this.sizeSamplePanel.Name = "sizeSamplePanel";
            this.sizeSamplePanel.Size = new System.Drawing.Size(70, 70);
            this.sizeSamplePanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(82, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 80);
            this.panel1.TabIndex = 1;
            // 
            // BrushSizeLabel
            // 
            this.BrushSizeLabel.AutoSize = true;
            this.BrushSizeLabel.Location = new System.Drawing.Point(13, 455);
            this.BrushSizeLabel.Name = "BrushSizeLabel";
            this.BrushSizeLabel.Size = new System.Drawing.Size(86, 20);
            this.BrushSizeLabel.TabIndex = 5;
            this.BrushSizeLabel.Text = "Brush Size";
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.Color.White;
            this.drawingPanel.Location = new System.Drawing.Point(183, 15);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(875, 600);
            this.drawingPanel.TabIndex = 6;
            // 
            // SelectedColorPanel
            // 
            this.SelectedColorPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectedColorPanel.Controls.Add(this.panel3);
            this.SelectedColorPanel.Location = new System.Drawing.Point(107, 112);
            this.SelectedColorPanel.Name = "SelectedColorPanel";
            this.SelectedColorPanel.Size = new System.Drawing.Size(70, 70);
            this.SelectedColorPanel.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(82, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 80);
            this.panel3.TabIndex = 1;
            // 
            // BrushSizeLabel_display
            // 
            this.BrushSizeLabel_display.AutoSize = true;
            this.BrushSizeLabel_display.Location = new System.Drawing.Point(145, 455);
            this.BrushSizeLabel_display.Name = "BrushSizeLabel_display";
            this.BrushSizeLabel_display.Size = new System.Drawing.Size(14, 20);
            this.BrushSizeLabel_display.TabIndex = 9;
            this.BrushSizeLabel_display.Text = "-";
            this.BrushSizeLabel_display.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(Form318_1.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1070, 649);
            this.Controls.Add(this.BrushSizeLabel_display);
            this.Controls.Add(this.SelectedColorPanel);
            this.Controls.Add(this.fontainPenButton);
            this.Controls.Add(this.penButton);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.BrushSizeLabel);
            this.Controls.Add(this.sizeSamplePanel);
            this.Controls.Add(this.PointerCoordsLabel);
            this.Controls.Add(this.BrushSizeTrackBar);
            this.Controls.Add(this.PointerCoordsLabel_display);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BrushSizeTrackBar)).EndInit();
            this.sizeSamplePanel.ResumeLayout(false);
            this.SelectedColorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PointerCoordsLabel_display;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.TrackBar BrushSizeTrackBar;
        private System.Windows.Forms.Label PointerCoordsLabel;
        private System.Windows.Forms.Button penButton;
        private System.Windows.Forms.Button fontainPenButton;
        private System.Windows.Forms.Panel sizeSamplePanel;
        private System.Windows.Forms.Label BrushSizeLabel;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SelectedColorPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label BrushSizeLabel_display;
    }
}

