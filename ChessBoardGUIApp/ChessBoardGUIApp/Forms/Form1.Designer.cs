namespace ChessBoardGUIApp
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
            this.lb_Hint = new System.Windows.Forms.Label();
            this.cb_ListPieces = new System.Windows.Forms.ComboBox();
            this.pn_Grid = new System.Windows.Forms.Panel();
            this.lb_hint2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Hint
            // 
            this.lb_Hint.AutoSize = true;
            this.lb_Hint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_Hint.ForeColor = System.Drawing.Color.White;
            this.lb_Hint.Location = new System.Drawing.Point(15, 11);
            this.lb_Hint.Name = "lb_Hint";
            this.lb_Hint.Size = new System.Drawing.Size(545, 17);
            this.lb_Hint.TabIndex = 0;
            this.lb_Hint.Text = "Select a type of chess piece and then click on the grid. I will show you all lega" +
    "l moves.";
            // 
            // cb_ListPieces
            // 
            this.cb_ListPieces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(173)))));
            this.cb_ListPieces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ListPieces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ListPieces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(235)))));
            this.cb_ListPieces.FormattingEnabled = true;
            this.cb_ListPieces.Items.AddRange(new object[] {
            "Bishop",
            "King",
            "Knight",
            "Queen",
            "Rook"});
            this.cb_ListPieces.Location = new System.Drawing.Point(608, 41);
            this.cb_ListPieces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_ListPieces.Name = "cb_ListPieces";
            this.cb_ListPieces.Size = new System.Drawing.Size(152, 24);
            this.cb_ListPieces.TabIndex = 1;
            // 
            // pn_Grid
            // 
            this.pn_Grid.Location = new System.Drawing.Point(12, 41);
            this.pn_Grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_Grid.Name = "pn_Grid";
            this.pn_Grid.Size = new System.Drawing.Size(533, 492);
            this.pn_Grid.TabIndex = 2;
            // 
            // lb_hint2
            // 
            this.lb_hint2.AutoSize = true;
            this.lb_hint2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_hint2.ForeColor = System.Drawing.Color.White;
            this.lb_hint2.Location = new System.Drawing.Point(8, 550);
            this.lb_hint2.Name = "lb_hint2";
            this.lb_hint2.Size = new System.Drawing.Size(321, 17);
            this.lb_hint2.TabIndex = 3;
            this.lb_hint2.Text = "Grid will auto resize, go ahead and fix it if needed!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(776, 681);
            this.Controls.Add(this.lb_hint2);
            this.Controls.Add(this.pn_Grid);
            this.Controls.Add(this.cb_ListPieces);
            this.Controls.Add(this.lb_Hint);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.Grid_SizeUpdate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Hint;
        private System.Windows.Forms.ComboBox cb_ListPieces;
        private System.Windows.Forms.Panel pn_Grid;
        private System.Windows.Forms.Label lb_hint2;
    }
}

