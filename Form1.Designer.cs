
namespace Spotistat
{
    partial class Spotistat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spotistat));
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.lFollowers = new System.Windows.Forms.Label();
            this.lGenres = new System.Windows.Forms.Label();
            this.lPopularity = new System.Windows.Forms.Label();
            this.genres = new System.Windows.Forms.Label();
            this.popularity = new System.Windows.Forms.Label();
            this.followers = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.lAlbums = new System.Windows.Forms.Label();
            this.albums = new System.Windows.Forms.Label();
            this.lLastalbum = new System.Windows.Forms.Label();
            this.lastalbum = new System.Windows.Forms.Label();
            this.lLastsingle = new System.Windows.Forms.Label();
            this.lastsingle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Save = new System.Windows.Forms.Button();
            this.templateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listbox = new System.Windows.Forms.ComboBox();
            this.templateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // UrlBox
            // 
            this.UrlBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UrlBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UrlBox.Location = new System.Drawing.Point(12, 12);
            this.UrlBox.Multiline = true;
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(441, 56);
            this.UrlBox.TabIndex = 0;
            this.UrlBox.TextChanged += new System.EventHandler(this.UrlBox_TextChanged);
            this.UrlBox.Enter += new System.EventHandler(this.UrlBox_Enter);
            this.UrlBox.Leave += new System.EventHandler(this.UrlBox_Leave);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.name.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(475, 17);
            this.name.MaximumSize = new System.Drawing.Size(304, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(79, 34);
            this.name.TabIndex = 1;
            this.name.Text = "Artist";
            this.name.Visible = false;
            // 
            // Find
            // 
            this.Find.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Find.Location = new System.Drawing.Point(12, 74);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(82, 33);
            this.Find.TabIndex = 2;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // Clear
            // 
            this.Clear.AutoSize = true;
            this.Clear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(394, 38);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(59, 30);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // lFollowers
            // 
            this.lFollowers.AutoSize = true;
            this.lFollowers.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFollowers.Location = new System.Drawing.Point(13, 125);
            this.lFollowers.Name = "lFollowers";
            this.lFollowers.Size = new System.Drawing.Size(95, 22);
            this.lFollowers.TabIndex = 4;
            this.lFollowers.Text = "Followers:";
            // 
            // lGenres
            // 
            this.lGenres.AutoSize = true;
            this.lGenres.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lGenres.Location = new System.Drawing.Point(13, 187);
            this.lGenres.Name = "lGenres";
            this.lGenres.Size = new System.Drawing.Size(81, 22);
            this.lGenres.TabIndex = 6;
            this.lGenres.Text = "Genres:";
            // 
            // lPopularity
            // 
            this.lPopularity.AutoSize = true;
            this.lPopularity.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lPopularity.Location = new System.Drawing.Point(13, 157);
            this.lPopularity.Name = "lPopularity";
            this.lPopularity.Size = new System.Drawing.Size(106, 22);
            this.lPopularity.TabIndex = 7;
            this.lPopularity.Text = "Popularity:";
            // 
            // genres
            // 
            this.genres.AutoSize = true;
            this.genres.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genres.Location = new System.Drawing.Point(119, 187);
            this.genres.MaximumSize = new System.Drawing.Size(450, 0);
            this.genres.Name = "genres";
            this.genres.Size = new System.Drawing.Size(0, 22);
            this.genres.TabIndex = 8;
            // 
            // popularity
            // 
            this.popularity.AutoSize = true;
            this.popularity.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.popularity.Location = new System.Drawing.Point(119, 157);
            this.popularity.MaximumSize = new System.Drawing.Size(450, 0);
            this.popularity.Name = "popularity";
            this.popularity.Size = new System.Drawing.Size(0, 22);
            this.popularity.TabIndex = 9;
            // 
            // followers
            // 
            this.followers.AutoSize = true;
            this.followers.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.followers.Location = new System.Drawing.Point(119, 125);
            this.followers.Name = "followers";
            this.followers.Size = new System.Drawing.Size(0, 22);
            this.followers.TabIndex = 10;
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture.Location = new System.Drawing.Point(475, 67);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(155, 154);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture.TabIndex = 11;
            this.picture.TabStop = false;
            this.picture.Visible = false;
            // 
            // lAlbums
            // 
            this.lAlbums.AutoSize = true;
            this.lAlbums.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lAlbums.Location = new System.Drawing.Point(13, 215);
            this.lAlbums.Name = "lAlbums";
            this.lAlbums.Size = new System.Drawing.Size(82, 22);
            this.lAlbums.TabIndex = 12;
            this.lAlbums.Text = "Albums:";
            // 
            // albums
            // 
            this.albums.AutoSize = true;
            this.albums.BackColor = System.Drawing.SystemColors.Menu;
            this.albums.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albums.Location = new System.Drawing.Point(119, 215);
            this.albums.MaximumSize = new System.Drawing.Size(450, 0);
            this.albums.Name = "albums";
            this.albums.Size = new System.Drawing.Size(0, 22);
            this.albums.TabIndex = 13;
            // 
            // lLastalbum
            // 
            this.lLastalbum.AutoSize = true;
            this.lLastalbum.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lLastalbum.Location = new System.Drawing.Point(13, 243);
            this.lLastalbum.Name = "lLastalbum";
            this.lLastalbum.Size = new System.Drawing.Size(119, 22);
            this.lLastalbum.TabIndex = 14;
            this.lLastalbum.Text = "Last album: ";
            // 
            // lastalbum
            // 
            this.lastalbum.AutoSize = true;
            this.lastalbum.BackColor = System.Drawing.SystemColors.Menu;
            this.lastalbum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastalbum.Location = new System.Drawing.Point(119, 243);
            this.lastalbum.MaximumSize = new System.Drawing.Size(450, 0);
            this.lastalbum.Name = "lastalbum";
            this.lastalbum.Size = new System.Drawing.Size(0, 22);
            this.lastalbum.TabIndex = 15;
            // 
            // lLastsingle
            // 
            this.lLastsingle.AutoSize = true;
            this.lLastsingle.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lLastsingle.Location = new System.Drawing.Point(13, 271);
            this.lLastsingle.Name = "lLastsingle";
            this.lLastsingle.Size = new System.Drawing.Size(111, 22);
            this.lLastsingle.TabIndex = 16;
            this.lLastsingle.Text = "Last single: ";
            // 
            // lastsingle
            // 
            this.lastsingle.AutoSize = true;
            this.lastsingle.BackColor = System.Drawing.SystemColors.Menu;
            this.lastsingle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastsingle.Location = new System.Drawing.Point(119, 271);
            this.lastsingle.MaximumSize = new System.Drawing.Size(450, 0);
            this.lastsingle.Name = "lastsingle";
            this.lastsingle.Size = new System.Drawing.Size(0, 22);
            this.lastsingle.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Save
            // 
            this.Save.AutoSize = true;
            this.Save.Enabled = false;
            this.Save.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(312, 111);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(56, 33);
            this.Save.TabIndex = 18;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // listbox
            // 
            this.listbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 21;
            this.listbox.Location = new System.Drawing.Point(312, 76);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(141, 29);
            this.listbox.TabIndex = 19;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(374, 111);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(79, 33);
            this.Delete.TabIndex = 20;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Spotistat
            // 
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(646, 304);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.lastsingle);
            this.Controls.Add(this.lLastsingle);
            this.Controls.Add(this.lastalbum);
            this.Controls.Add(this.lLastalbum);
            this.Controls.Add(this.albums);
            this.Controls.Add(this.lAlbums);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.followers);
            this.Controls.Add(this.popularity);
            this.Controls.Add(this.genres);
            this.Controls.Add(this.lPopularity);
            this.Controls.Add(this.lGenres);
            this.Controls.Add(this.lFollowers);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.UrlBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Spotistat";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Spotistat";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label lFollowers;
        private System.Windows.Forms.Label lGenres;
        private System.Windows.Forms.Label lPopularity;
        private System.Windows.Forms.Label genres;
        private System.Windows.Forms.Label popularity;
        private System.Windows.Forms.Label followers;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label lAlbums;
        private System.Windows.Forms.Label albums;
        private System.Windows.Forms.Label lLastalbum;
        private System.Windows.Forms.Label lastalbum;
        private System.Windows.Forms.Label lLastsingle;
        private System.Windows.Forms.Label lastsingle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.BindingSource templateBindingSource;
        private System.Windows.Forms.ComboBox listbox;
        private System.Windows.Forms.BindingSource templateBindingSource1;
        private System.Windows.Forms.Button Delete;
    }
}

