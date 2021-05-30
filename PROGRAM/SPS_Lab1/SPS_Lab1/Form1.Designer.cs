
namespace SPS_Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Events = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Venus = new System.Windows.Forms.TabPage();
            this.Country = new System.Windows.Forms.TabPage();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsDataSet = new SPS_Lab1.clientsDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsTableAdapter = new SPS_Lab1.clientsDataSetTableAdapters.eventsTableAdapter();
            this.eventsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.Events.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Events);
            this.tabControl1.Controls.Add(this.Venus);
            this.tabControl1.Controls.Add(this.Country);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 375);
            this.tabControl1.TabIndex = 0;
            this.Hint.SetToolTip(this.tabControl1, "Таблица EVENTS");
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.OnTabSelect);
            // 
            // Events
            // 
            this.Events.Controls.Add(this.dataGridView2);
            this.Events.Location = new System.Drawing.Point(4, 22);
            this.Events.Name = "Events";
            this.Events.Padding = new System.Windows.Forms.Padding(3);
            this.Events.Size = new System.Drawing.Size(915, 349);
            this.Events.TabIndex = 0;
            this.Events.Text = "Events";
            this.Events.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(909, 343);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            // 
            // Venus
            // 
            this.Venus.Location = new System.Drawing.Point(4, 22);
            this.Venus.Name = "Venus";
            this.Venus.Padding = new System.Windows.Forms.Padding(3);
            this.Venus.Size = new System.Drawing.Size(915, 349);
            this.Venus.TabIndex = 1;
            this.Venus.Text = "Venues";
            this.Venus.UseVisualStyleBackColor = true;
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(4, 22);
            this.Country.Name = "Country";
            this.Country.Padding = new System.Windows.Forms.Padding(3);
            this.Country.Size = new System.Drawing.Size(915, 349);
            this.Country.TabIndex = 2;
            this.Country.Text = "Countries";
            this.Country.UseVisualStyleBackColor = true;
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "events";
            this.eventsBindingSource.DataSource = this.clientsDataSetBindingSource;
            // 
            // clientsDataSetBindingSource
            // 
            this.clientsDataSetBindingSource.DataSource = this.clientsDataSet;
            this.clientsDataSetBindingSource.Position = 0;
            // 
            // clientsDataSet
            // 
            this.clientsDataSet.DataSetName = "clientsDataSet";
            this.clientsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // eventsBindingSource1
            // 
            this.eventsBindingSource1.DataMember = "events";
            this.eventsBindingSource1.DataSource = this.clientsDataSetBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Hint
            // 
            this.Hint.ShowAlways = true;
            this.Hint.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Events.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.BindingSource clientsDataSetBindingSource;
        private clientsDataSet clientsDataSet;
        private System.Windows.Forms.TabPage Venus;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private clientsDataSetTableAdapters.eventsTableAdapter eventsTableAdapter;
        private System.Windows.Forms.BindingSource eventsBindingSource1;
        private System.Windows.Forms.TabPage Country;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Events;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolTip Hint;
    }
}

