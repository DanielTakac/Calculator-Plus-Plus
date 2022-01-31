namespace Calculator__
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
            this.Display = new System.Windows.Forms.Label();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonDecimal = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonBackspace = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.DimGray;
            this.Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Display.ForeColor = System.Drawing.Color.White;
            this.Display.Location = new System.Drawing.Point(8, 9);
            this.Display.Name = "Display";
            this.Display.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Display.Size = new System.Drawing.Size(270, 55);
            this.Display.TabIndex = 0;
            this.Display.Text = "0";
            this.Display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSeven.Location = new System.Drawing.Point(8, 134);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(63, 61);
            this.buttonSeven.TabIndex = 1;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.buttonSeven_Click);
            // 
            // ButtonEight
            // 
            this.ButtonEight.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonEight.Location = new System.Drawing.Point(77, 134);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(63, 61);
            this.ButtonEight.TabIndex = 2;
            this.ButtonEight.Text = "8";
            this.ButtonEight.UseVisualStyleBackColor = false;
            this.ButtonEight.Click += new System.EventHandler(this.ButtonEight_Click);
            // 
            // ButtonNine
            // 
            this.ButtonNine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonNine.Location = new System.Drawing.Point(146, 134);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(63, 61);
            this.ButtonNine.TabIndex = 3;
            this.ButtonNine.Text = "9";
            this.ButtonNine.UseVisualStyleBackColor = false;
            this.ButtonNine.Click += new System.EventHandler(this.ButtonNine_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonMinus.Location = new System.Drawing.Point(215, 201);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(63, 61);
            this.ButtonMinus.TabIndex = 4;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = false;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPlus.Location = new System.Drawing.Point(215, 268);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(63, 61);
            this.ButtonPlus.TabIndex = 8;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = false;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonSix
            // 
            this.ButtonSix.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSix.Location = new System.Drawing.Point(146, 201);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(63, 61);
            this.ButtonSix.TabIndex = 7;
            this.ButtonSix.Text = "6";
            this.ButtonSix.UseVisualStyleBackColor = false;
            this.ButtonSix.Click += new System.EventHandler(this.ButtonSix_Click);
            // 
            // ButtonFive
            // 
            this.ButtonFive.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonFive.Location = new System.Drawing.Point(77, 201);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(63, 61);
            this.ButtonFive.TabIndex = 6;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = false;
            this.ButtonFive.Click += new System.EventHandler(this.ButtonFive_Click);
            // 
            // ButtonFour
            // 
            this.ButtonFour.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonFour.Location = new System.Drawing.Point(8, 201);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(63, 61);
            this.ButtonFour.TabIndex = 5;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = false;
            this.ButtonFour.Click += new System.EventHandler(this.ButtonFour_Click);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonEquals.Location = new System.Drawing.Point(215, 335);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(63, 61);
            this.ButtonEquals.TabIndex = 12;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = false;
            this.ButtonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonThree.Location = new System.Drawing.Point(146, 268);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(63, 61);
            this.ButtonThree.TabIndex = 11;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = false;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonThree_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonTwo.Location = new System.Drawing.Point(77, 268);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(63, 61);
            this.ButtonTwo.TabIndex = 10;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = false;
            this.ButtonTwo.Click += new System.EventHandler(this.ButtonTwo_Click);
            // 
            // ButtonOne
            // 
            this.ButtonOne.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonOne.Location = new System.Drawing.Point(8, 268);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(63, 61);
            this.ButtonOne.TabIndex = 9;
            this.ButtonOne.Text = "1";
            this.ButtonOne.UseVisualStyleBackColor = false;
            this.ButtonOne.Click += new System.EventHandler(this.ButtonOne_Click);
            // 
            // ButtonDecimal
            // 
            this.ButtonDecimal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonDecimal.Location = new System.Drawing.Point(146, 335);
            this.ButtonDecimal.Name = "ButtonDecimal";
            this.ButtonDecimal.Size = new System.Drawing.Size(63, 61);
            this.ButtonDecimal.TabIndex = 15;
            this.ButtonDecimal.Text = ",";
            this.ButtonDecimal.UseVisualStyleBackColor = false;
            this.ButtonDecimal.Click += new System.EventHandler(this.ButtonDecimal_Click);
            // 
            // ButtonZero
            // 
            this.ButtonZero.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonZero.Location = new System.Drawing.Point(8, 335);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(132, 61);
            this.ButtonZero.TabIndex = 14;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = false;
            this.ButtonZero.Click += new System.EventHandler(this.ButtonZero_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonDivide.Location = new System.Drawing.Point(215, 134);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(63, 61);
            this.ButtonDivide.TabIndex = 20;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = false;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonMultiply.Location = new System.Drawing.Point(215, 69);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(63, 61);
            this.ButtonMultiply.TabIndex = 19;
            this.ButtonMultiply.Text = "x";
            this.ButtonMultiply.UseVisualStyleBackColor = false;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // ButtonBackspace
            // 
            this.ButtonBackspace.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonBackspace.Location = new System.Drawing.Point(8, 69);
            this.ButtonBackspace.Name = "ButtonBackspace";
            this.ButtonBackspace.Size = new System.Drawing.Size(132, 61);
            this.ButtonBackspace.TabIndex = 18;
            this.ButtonBackspace.Text = "Back";
            this.ButtonBackspace.UseVisualStyleBackColor = false;
            this.ButtonBackspace.Click += new System.EventHandler(this.ButtonBackspace_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonClear.Location = new System.Drawing.Point(146, 69);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(63, 61);
            this.ButtonClear.TabIndex = 17;
            this.ButtonClear.Text = "C";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(286, 403);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.ButtonMultiply);
            this.Controls.Add(this.ButtonBackspace);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonDecimal);
            this.Controls.Add(this.ButtonZero);
            this.Controls.Add(this.ButtonEquals);
            this.Controls.Add(this.ButtonThree);
            this.Controls.Add(this.ButtonTwo);
            this.Controls.Add(this.ButtonOne);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.ButtonSix);
            this.Controls.Add(this.ButtonFive);
            this.Controls.Add(this.ButtonFour);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.ButtonNine);
            this.Controls.Add(this.ButtonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Calculator++";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button ButtonEight;
        private System.Windows.Forms.Button ButtonNine;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonSix;
        private System.Windows.Forms.Button ButtonFive;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button ButtonEquals;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button ButtonDecimal;
        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonBackspace;
        private System.Windows.Forms.Button ButtonClear;
    }
}

