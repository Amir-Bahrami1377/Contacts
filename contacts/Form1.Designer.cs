namespace contacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            btnNewContact = new ToolStripButton();
            btnRefresh = new ToolStripButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dgContacts = new DataGridView();
            ContactID = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            MyName = new DataGridViewTextBoxColumn();
            Family = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Mobile = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            btnEdit = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgContacts).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNewContact, btnRefresh });
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.Name = "toolStrip1";
            // 
            // btnNewContact
            // 
            btnNewContact.DisplayStyle = ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(btnNewContact, "btnNewContact");
            btnNewContact.Name = "btnNewContact";
            btnNewContact.Click += btnNewContact_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(btnRefresh, "btnRefresh");
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgContacts);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // dgContacts
            // 
            dgContacts.AllowUserToAddRows = false;
            dgContacts.AllowUserToDeleteRows = false;
            dgContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgContacts.Columns.AddRange(new DataGridViewColumn[] { ContactID, Address, MyName, Family, Email, Mobile, Age });
            resources.ApplyResources(dgContacts, "dgContacts");
            dgContacts.Name = "dgContacts";
            dgContacts.ReadOnly = true;
            dgContacts.RowTemplate.Height = 29;
            // 
            // ContactID
            // 
            ContactID.DataPropertyName = "ContactID";
            resources.ApplyResources(ContactID, "ContactID");
            ContactID.Name = "ContactID";
            ContactID.ReadOnly = true;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            resources.ApplyResources(Address, "Address");
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // MyName
            // 
            MyName.DataPropertyName = "Name";
            resources.ApplyResources(MyName, "MyName");
            MyName.Name = "MyName";
            MyName.ReadOnly = true;
            // 
            // Family
            // 
            Family.DataPropertyName = "Family";
            resources.ApplyResources(Family, "Family");
            Family.Name = "Family";
            Family.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            resources.ApplyResources(Email, "Email");
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Mobile
            // 
            Mobile.DataPropertyName = "Mobile";
            resources.ApplyResources(Mobile, "Mobile");
            Mobile.Name = "Mobile";
            Mobile.ReadOnly = true;
            // 
            // Age
            // 
            Age.DataPropertyName = "Age";
            resources.ApplyResources(Age, "Age");
            Age.Name = "Age";
            Age.ReadOnly = true;
            // 
            // btnEdit
            // 
            resources.ApplyResources(btnEdit, "btnEdit");
            btnEdit.Name = "btnEdit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            resources.ApplyResources(btnDelete, "btnDelete");
            btnDelete.Name = "btnDelete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            resources.ApplyResources(txtSearch, "txtSearch");
            txtSearch.Name = "txtSearch";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgContacts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgContacts;
        private ToolStripButton btnNewContact;
        private ToolStripButton btnRefresh;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridViewTextBoxColumn ContactID;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn MyName;
        private DataGridViewTextBoxColumn Family;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Mobile;
        private DataGridViewTextBoxColumn Age;
        private TextBox txtSearch;
    }
}