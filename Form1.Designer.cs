using System.Windows.Forms;
namespace Figures
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button7 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.polygon = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.rect = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.ellipse = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.workArea = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1561, 120);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.trackBar1);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Location = new System.Drawing.Point(34, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 98);
            this.panel4.TabIndex = 6;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar1.Location = new System.Drawing.Point(0, 42);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(197, 56);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(82, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 34);
            this.button7.TabIndex = 6;
            this.button7.TabStop = false;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearButton.FlatAppearance.BorderSize = 2;
            this.clearButton.Location = new System.Drawing.Point(650, 21);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(250, 79);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Location = new System.Drawing.Point(411, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 98);
            this.panel3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(96, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 34);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(54, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 34);
            this.button2.TabIndex = 4;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(12, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 34);
            this.button3.TabIndex = 3;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 34);
            this.button4.TabIndex = 2;
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(96, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 34);
            this.button5.TabIndex = 1;
            this.button5.TabStop = false;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(54, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 34);
            this.button6.TabIndex = 0;
            this.button6.TabStop = false;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(729, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.polygon);
            this.panel2.Controls.Add(this.square);
            this.panel2.Controls.Add(this.rect);
            this.panel2.Controls.Add(this.line);
            this.panel2.Controls.Add(this.ellipse);
            this.panel2.Controls.Add(this.circle);
            this.panel2.Location = new System.Drawing.Point(248, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 98);
            this.panel2.TabIndex = 0;
            // 
            // polygon
            // 
            this.polygon.Image = global::Figures.Properties.Resources.polygon;
            this.polygon.Location = new System.Drawing.Point(96, 52);
            this.polygon.Name = "polygon";
            this.polygon.Size = new System.Drawing.Size(36, 34);
            this.polygon.TabIndex = 5;
            this.polygon.TabStop = false;
            this.polygon.UseVisualStyleBackColor = true;
            this.polygon.Click += new System.EventHandler(this.polygon_Click);
            // 
            // square
            // 
            this.square.Image = global::Figures.Properties.Resources.square;
            this.square.Location = new System.Drawing.Point(54, 52);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(36, 34);
            this.square.TabIndex = 4;
            this.square.TabStop = false;
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // rect
            // 
            this.rect.Image = global::Figures.Properties.Resources.rect;
            this.rect.Location = new System.Drawing.Point(12, 52);
            this.rect.Name = "rect";
            this.rect.Size = new System.Drawing.Size(36, 34);
            this.rect.TabIndex = 3;
            this.rect.TabStop = false;
            this.rect.UseVisualStyleBackColor = true;
            this.rect.Click += new System.EventHandler(this.rect_Click);
            // 
            // line
            // 
            this.line.Image = global::Figures.Properties.Resources.line;
            this.line.Location = new System.Drawing.Point(12, 12);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(36, 34);
            this.line.TabIndex = 0;
            this.line.TabStop = false;
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // ellipse
            // 
            this.ellipse.Image = global::Figures.Properties.Resources.ellipse;
            this.ellipse.Location = new System.Drawing.Point(96, 12);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(36, 34);
            this.ellipse.TabIndex = 1;
            this.ellipse.TabStop = false;
            this.ellipse.UseVisualStyleBackColor = true;
            this.ellipse.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // circle
            // 
            this.circle.Image = global::Figures.Properties.Resources.circle;
            this.circle.Location = new System.Drawing.Point(54, 12);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(36, 34);
            this.circle.TabIndex = 0;
            this.circle.TabStop = false;
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "circle.png");
            this.imageList1.Images.SetKeyName(1, "ellipse.PNG.png");
            this.imageList1.Images.SetKeyName(2, "line.PNG.png");
            this.imageList1.Images.SetKeyName(3, "polygon.png");
            this.imageList1.Images.SetKeyName(4, "rect.PNG.png");
            this.imageList1.Images.SetKeyName(5, "square.png");
            // 
            // workArea
            // 
            this.workArea.BackColor = System.Drawing.Color.White;
            this.workArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workArea.Location = new System.Drawing.Point(0, 120);
            this.workArea.Name = "workArea";
            this.workArea.Size = new System.Drawing.Size(1561, 639);
            this.workArea.TabIndex = 1;
            this.workArea.Click += new System.EventHandler(this.workArea_Click);
            this.workArea.Paint += new System.Windows.Forms.PaintEventHandler(this.workArea_Paint);
            this.workArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.workArea_MouseDown);
            this.workArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.workArea_MouseMove);
            this.workArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.workArea_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 759);
            this.Controls.Add(this.workArea);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button polygon;
        private Button square;
        private Button rect;
        private Button line;
        private Button ellipse;
        private Button circle;
        private ImageList imageList1;
        private Panel workArea;
        private Label label1;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ColorDialog colorDialog1;
        private Button clearButton;
        private Panel panel4;
        private Button button7;
        private TrackBar trackBar1;
    }
}