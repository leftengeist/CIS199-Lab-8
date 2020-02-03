namespace Lab8
{
    partial class Lab8
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
            this.futureValueLbl = new System.Windows.Forms.Label();
            this.yearInterestLbl = new System.Windows.Forms.Label();
            this.yearsLbl = new System.Windows.Forms.Label();
            this.presentValueLbl = new System.Windows.Forms.Label();
            this.outPresentValueLbl = new System.Windows.Forms.Label();
            this.inFutureValueTxt = new System.Windows.Forms.TextBox();
            this.inYearlyInterestTxt = new System.Windows.Forms.TextBox();
            this.inYearsTxt = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // futureValueLbl
            // 
            this.futureValueLbl.AutoSize = true;
            this.futureValueLbl.Location = new System.Drawing.Point(12, 50);
            this.futureValueLbl.Name = "futureValueLbl";
            this.futureValueLbl.Size = new System.Drawing.Size(141, 25);
            this.futureValueLbl.TabIndex = 0;
            this.futureValueLbl.Text = "Future Value:";
            // 
            // yearInterestLbl
            // 
            this.yearInterestLbl.AutoSize = true;
            this.yearInterestLbl.Location = new System.Drawing.Point(12, 93);
            this.yearInterestLbl.Name = "yearInterestLbl";
            this.yearInterestLbl.Size = new System.Drawing.Size(213, 25);
            this.yearInterestLbl.TabIndex = 1;
            this.yearInterestLbl.Text = "Annual Interest Rate:";
            // 
            // yearsLbl
            // 
            this.yearsLbl.AutoSize = true;
            this.yearsLbl.Location = new System.Drawing.Point(12, 138);
            this.yearsLbl.Name = "yearsLbl";
            this.yearsLbl.Size = new System.Drawing.Size(138, 25);
            this.yearsLbl.TabIndex = 2;
            this.yearsLbl.Text = "No. of Years:";
            // 
            // presentValueLbl
            // 
            this.presentValueLbl.AutoSize = true;
            this.presentValueLbl.Location = new System.Drawing.Point(12, 216);
            this.presentValueLbl.Name = "presentValueLbl";
            this.presentValueLbl.Size = new System.Drawing.Size(153, 25);
            this.presentValueLbl.TabIndex = 3;
            this.presentValueLbl.Text = "Present Value:";
            // 
            // outPresentValueLbl
            // 
            this.outPresentValueLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outPresentValueLbl.Location = new System.Drawing.Point(231, 215);
            this.outPresentValueLbl.Name = "outPresentValueLbl";
            this.outPresentValueLbl.Size = new System.Drawing.Size(156, 31);
            this.outPresentValueLbl.TabIndex = 4;
            // 
            // inFutureValueTxt
            // 
            this.inFutureValueTxt.Location = new System.Drawing.Point(231, 47);
            this.inFutureValueTxt.Name = "inFutureValueTxt";
            this.inFutureValueTxt.Size = new System.Drawing.Size(156, 31);
            this.inFutureValueTxt.TabIndex = 5;
            // 
            // inYearlyInterestTxt
            // 
            this.inYearlyInterestTxt.Location = new System.Drawing.Point(231, 90);
            this.inYearlyInterestTxt.Name = "inYearlyInterestTxt";
            this.inYearlyInterestTxt.Size = new System.Drawing.Size(156, 31);
            this.inYearlyInterestTxt.TabIndex = 6;
            // 
            // inYearsTxt
            // 
            this.inYearsTxt.Location = new System.Drawing.Point(231, 135);
            this.inYearsTxt.Name = "inYearsTxt";
            this.inYearsTxt.Size = new System.Drawing.Size(156, 31);
            this.inYearsTxt.TabIndex = 7;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(46, 289);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(119, 40);
            this.calculateBtn.TabIndex = 8;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearBtn.Location = new System.Drawing.Point(231, 289);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(119, 40);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Lab8
            // 
            this.AcceptButton = this.calculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearBtn;
            this.ClientSize = new System.Drawing.Size(406, 397);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.inYearsTxt);
            this.Controls.Add(this.inYearlyInterestTxt);
            this.Controls.Add(this.inFutureValueTxt);
            this.Controls.Add(this.outPresentValueLbl);
            this.Controls.Add(this.presentValueLbl);
            this.Controls.Add(this.yearsLbl);
            this.Controls.Add(this.yearInterestLbl);
            this.Controls.Add(this.futureValueLbl);
            this.Name = "Lab8";
            this.Text = "Lab 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label futureValueLbl;
        private System.Windows.Forms.Label yearInterestLbl;
        private System.Windows.Forms.Label yearsLbl;
        private System.Windows.Forms.Label presentValueLbl;
        private System.Windows.Forms.Label outPresentValueLbl;
        private System.Windows.Forms.TextBox inFutureValueTxt;
        private System.Windows.Forms.TextBox inYearlyInterestTxt;
        private System.Windows.Forms.TextBox inYearsTxt;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}

