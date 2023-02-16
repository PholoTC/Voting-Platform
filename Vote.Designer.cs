namespace Voting_Platform
{
    partial class Vote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vote));
            this.label1 = new System.Windows.Forms.Label();
            this.btnVote = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.cbParty = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vOTING_PLATFORMDataSet = new Voting_Platform.VOTING_PLATFORMDataSet();
            this.partyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partyTableAdapter = new Voting_Platform.VOTING_PLATFORMDataSetTableAdapters.PartyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOTING_PLATFORMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 55);
            this.label1.TabIndex = 15;
            this.label1.Text = "Party";
            // 
            // btnVote
            // 
            this.btnVote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVote.ForeColor = System.Drawing.Color.Black;
            this.btnVote.Location = new System.Drawing.Point(549, 467);
            this.btnVote.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(379, 88);
            this.btnVote.TabIndex = 19;
            this.btnVote.Text = "Vote";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(19, 467);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(371, 88);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // cbParty
            // 
            this.cbParty.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partyBindingSource, "PartyId", true));
            this.cbParty.DataSource = this.partyBindingSource;
            this.cbParty.DisplayMember = "PartyName";
            this.cbParty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParty.FormattingEnabled = true;
            this.cbParty.Location = new System.Drawing.Point(472, 347);
            this.cbParty.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cbParty.Name = "cbParty";
            this.cbParty.Size = new System.Drawing.Size(456, 45);
            this.cbParty.TabIndex = 23;
            this.cbParty.ValueMember = "PartyId";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 223);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // vOTING_PLATFORMDataSet
            // 
            this.vOTING_PLATFORMDataSet.DataSetName = "VOTING_PLATFORMDataSet";
            this.vOTING_PLATFORMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partyBindingSource
            // 
            this.partyBindingSource.DataMember = "Party";
            this.partyBindingSource.DataSource = this.vOTING_PLATFORMDataSet;
            // 
            // partyTableAdapter
            // 
            this.partyTableAdapter.ClearBeforeFill = true;
            // 
            // Vote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 649);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbParty);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vote";
            this.Load += new System.EventHandler(this.Vote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOTING_PLATFORMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox cbParty;
        private System.Windows.Forms.PictureBox pictureBox1;
        private VOTING_PLATFORMDataSet vOTING_PLATFORMDataSet;
        private System.Windows.Forms.BindingSource partyBindingSource;
        private VOTING_PLATFORMDataSetTableAdapters.PartyTableAdapter partyTableAdapter;
    }
}