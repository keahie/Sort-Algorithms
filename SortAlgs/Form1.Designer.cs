namespace SortAlgs
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonRandNumbers = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.buttonBubble = new System.Windows.Forms.Button();
            this.labelValid = new System.Windows.Forms.Label();
            this.buttonBubbleTest = new System.Windows.Forms.Button();
            this.checkBoxTesting = new System.Windows.Forms.CheckBox();
            this.buttonInsertion = new System.Windows.Forms.Button();
            this.buttonInsertionTest = new System.Windows.Forms.Button();
            this.buttonSelection = new System.Windows.Forms.Button();
            this.buttonSelectionTest = new System.Windows.Forms.Button();
            this.buttonTestAll = new System.Windows.Forms.Button();
            this.buttonQuickTest = new System.Windows.Forms.Button();
            this.buttonQuick = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(12, 12);
            this.textBoxInput.MaxLength = 327670000;
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(776, 30);
            this.textBoxInput.TabIndex = 0;
            // 
            // buttonRandNumbers
            // 
            this.buttonRandNumbers.Location = new System.Drawing.Point(12, 415);
            this.buttonRandNumbers.Name = "buttonRandNumbers";
            this.buttonRandNumbers.Size = new System.Drawing.Size(104, 23);
            this.buttonRandNumbers.TabIndex = 1;
            this.buttonRandNumbers.Text = "Generate Numbers";
            this.buttonRandNumbers.UseVisualStyleBackColor = true;
            this.buttonRandNumbers.Click += new System.EventHandler(this.ButtonRandNumbers_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(12, 48);
            this.textBoxOutput.MaxLength = 327670000;
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(776, 30);
            this.textBoxOutput.TabIndex = 2;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCount.Location = new System.Drawing.Point(12, 377);
            this.textBoxCount.Multiline = true;
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(174, 30);
            this.textBoxCount.TabIndex = 3;
            // 
            // buttonBubble
            // 
            this.buttonBubble.Location = new System.Drawing.Point(704, 413);
            this.buttonBubble.Name = "buttonBubble";
            this.buttonBubble.Size = new System.Drawing.Size(75, 23);
            this.buttonBubble.TabIndex = 4;
            this.buttonBubble.Text = "Bubble Sort";
            this.buttonBubble.UseVisualStyleBackColor = true;
            this.buttonBubble.Click += new System.EventHandler(this.ButtonBubble_Click);
            // 
            // labelValid
            // 
            this.labelValid.AutoSize = true;
            this.labelValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValid.Location = new System.Drawing.Point(122, 416);
            this.labelValid.Name = "labelValid";
            this.labelValid.Size = new System.Drawing.Size(52, 20);
            this.labelValid.TabIndex = 5;
            this.labelValid.Text = "Valid: ";
            // 
            // buttonBubbleTest
            // 
            this.buttonBubbleTest.Location = new System.Drawing.Point(694, 384);
            this.buttonBubbleTest.Name = "buttonBubbleTest";
            this.buttonBubbleTest.Size = new System.Drawing.Size(94, 23);
            this.buttonBubbleTest.TabIndex = 6;
            this.buttonBubbleTest.Text = "Bubble Sort Test";
            this.buttonBubbleTest.UseVisualStyleBackColor = true;
            this.buttonBubbleTest.Click += new System.EventHandler(this.ButtonBubbleTest_Click);
            // 
            // checkBoxTesting
            // 
            this.checkBoxTesting.AutoSize = true;
            this.checkBoxTesting.Location = new System.Drawing.Point(12, 354);
            this.checkBoxTesting.Name = "checkBoxTesting";
            this.checkBoxTesting.Size = new System.Drawing.Size(61, 17);
            this.checkBoxTesting.TabIndex = 7;
            this.checkBoxTesting.Text = "Testing";
            this.checkBoxTesting.UseVisualStyleBackColor = true;
            // 
            // buttonInsertion
            // 
            this.buttonInsertion.Location = new System.Drawing.Point(596, 413);
            this.buttonInsertion.Name = "buttonInsertion";
            this.buttonInsertion.Size = new System.Drawing.Size(78, 23);
            this.buttonInsertion.TabIndex = 8;
            this.buttonInsertion.Text = "Insertion Sort";
            this.buttonInsertion.UseVisualStyleBackColor = true;
            this.buttonInsertion.Click += new System.EventHandler(this.ButtonInsertion_Click);
            // 
            // buttonInsertionTest
            // 
            this.buttonInsertionTest.Location = new System.Drawing.Point(581, 384);
            this.buttonInsertionTest.Name = "buttonInsertionTest";
            this.buttonInsertionTest.Size = new System.Drawing.Size(107, 23);
            this.buttonInsertionTest.TabIndex = 9;
            this.buttonInsertionTest.Text = "Insertion Sort Test";
            this.buttonInsertionTest.UseVisualStyleBackColor = true;
            this.buttonInsertionTest.Click += new System.EventHandler(this.ButtonInsertionTest_Click);
            // 
            // buttonSelection
            // 
            this.buttonSelection.Location = new System.Drawing.Point(482, 413);
            this.buttonSelection.Name = "buttonSelection";
            this.buttonSelection.Size = new System.Drawing.Size(81, 23);
            this.buttonSelection.TabIndex = 10;
            this.buttonSelection.Text = "Selection Sort";
            this.buttonSelection.UseVisualStyleBackColor = true;
            this.buttonSelection.Click += new System.EventHandler(this.ButtonSelection_Click);
            // 
            // buttonSelectionTest
            // 
            this.buttonSelectionTest.Location = new System.Drawing.Point(470, 384);
            this.buttonSelectionTest.Name = "buttonSelectionTest";
            this.buttonSelectionTest.Size = new System.Drawing.Size(105, 23);
            this.buttonSelectionTest.TabIndex = 11;
            this.buttonSelectionTest.Text = "Selection Sort Test";
            this.buttonSelectionTest.UseVisualStyleBackColor = true;
            this.buttonSelectionTest.Click += new System.EventHandler(this.ButtonSelectionTest_Click);
            // 
            // buttonTestAll
            // 
            this.buttonTestAll.Location = new System.Drawing.Point(79, 351);
            this.buttonTestAll.Name = "buttonTestAll";
            this.buttonTestAll.Size = new System.Drawing.Size(75, 23);
            this.buttonTestAll.TabIndex = 12;
            this.buttonTestAll.Text = "Test All";
            this.buttonTestAll.UseVisualStyleBackColor = true;
            this.buttonTestAll.Click += new System.EventHandler(this.ButtonTestAll_Click);
            // 
            // buttonQuickTest
            // 
            this.buttonQuickTest.Location = new System.Drawing.Point(374, 384);
            this.buttonQuickTest.Name = "buttonQuickTest";
            this.buttonQuickTest.Size = new System.Drawing.Size(90, 23);
            this.buttonQuickTest.TabIndex = 13;
            this.buttonQuickTest.Text = "Quick Sort Test";
            this.buttonQuickTest.UseVisualStyleBackColor = true;
            this.buttonQuickTest.Click += new System.EventHandler(this.ButtonQuickTest_Click);
            // 
            // buttonQuick
            // 
            this.buttonQuick.Location = new System.Drawing.Point(382, 413);
            this.buttonQuick.Name = "buttonQuick";
            this.buttonQuick.Size = new System.Drawing.Size(75, 23);
            this.buttonQuick.TabIndex = 14;
            this.buttonQuick.Text = "Quick Sort";
            this.buttonQuick.UseVisualStyleBackColor = true;
            this.buttonQuick.Click += new System.EventHandler(this.ButtonQuick_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLog.Location = new System.Drawing.Point(12, 99);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(776, 230);
            this.textBoxLog.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonQuick);
            this.Controls.Add(this.buttonQuickTest);
            this.Controls.Add(this.buttonTestAll);
            this.Controls.Add(this.buttonSelectionTest);
            this.Controls.Add(this.buttonSelection);
            this.Controls.Add(this.buttonInsertionTest);
            this.Controls.Add(this.buttonInsertion);
            this.Controls.Add(this.checkBoxTesting);
            this.Controls.Add(this.buttonBubbleTest);
            this.Controls.Add(this.labelValid);
            this.Controls.Add(this.buttonBubble);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonRandNumbers);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Sortieralgorythmen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonRandNumbers;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button buttonBubble;
        private System.Windows.Forms.Label labelValid;
        private System.Windows.Forms.Button buttonBubbleTest;
        private System.Windows.Forms.CheckBox checkBoxTesting;
        private System.Windows.Forms.Button buttonInsertion;
        private System.Windows.Forms.Button buttonInsertionTest;
        private System.Windows.Forms.Button buttonSelection;
        private System.Windows.Forms.Button buttonSelectionTest;
        private System.Windows.Forms.Button buttonTestAll;
        private System.Windows.Forms.Button buttonQuickTest;
        private System.Windows.Forms.Button buttonQuick;
        private System.Windows.Forms.TextBox textBoxLog;
    }
}

