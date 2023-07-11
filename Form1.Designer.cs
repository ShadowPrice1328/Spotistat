
namespace Spotistat
{
    partial class Spotistat
    {
        /// <summary>
        /// Обов'язкова змінна конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Звільнити усі доступні ресурси.
        /// </summary>
        /// <param name="disposing">істинно, якщо керований ресурс повинен бути вилучений; інакше хибно.</param>
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
        /// Обов'язковий метод конструктора - не змінюйте
        /// зміст цього метода за допомогою редактора коду.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spotistat));
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.lFollowers = new System.Windows.Forms.Label();
            this.lGenres = new System.Windows.Forms.Label();
            this.lPopularity = new System.Windows.Forms.Label();
            this.genres = new System.Windows.Forms.Label();
            this.popularity = new System.Windows.Forms.Label();
            this.followers = new System.Windows.Forms.Label();
            this.lAlbums = new System.Windows.Forms.Label();
            this.albums = new System.Windows.Forms.Label();
            this.lLastAlbum = new System.Windows.Forms.Label();
            this.lastAlbum = new System.Windows.Forms.Label();
            this.lLastSingle = new System.Windows.Forms.Label();
            this.lastSingle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Save = new System.Windows.Forms.Button();
            this.templateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listbox = new System.Windows.Forms.ComboBox();
            this.templateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Delete = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // UrlBox
            // 
            this.UrlBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UrlBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UrlBox.Location = new System.Drawing.Point(12, 12);
            this.UrlBox.Multiline = true;
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(451, 56);
            this.UrlBox.TabIndex = 0;
            this.UrlBox.TextChanged += new System.EventHandler(this.UrlBox_TextChanged);
            this.UrlBox.Enter += new System.EventHandler(this.UrlBox_Enter);
            this.UrlBox.Leave += new System.EventHandler(this.UrlBox_Leave);
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
            this.Clear.Size = new System.Drawing.Size(69, 32);
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
            this.lFollowers.Size = new System.Drawing.Size(129, 30);
            this.lFollowers.TabIndex = 4;
            this.lFollowers.Text = "Followers:";
            // 
            // lGenres
            // 
            this.lGenres.AutoSize = true;
            this.lGenres.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lGenres.Location = new System.Drawing.Point(13, 187);
            this.lGenres.Name = "lGenres";
            this.lGenres.Size = new System.Drawing.Size(105, 30);
            this.lGenres.TabIndex = 6;
            this.lGenres.Text = "Genres:";
            // 
            // lPopularity
            // 
            this.lPopularity.AutoSize = true;
            this.lPopularity.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lPopularity.Location = new System.Drawing.Point(13, 157);
            this.lPopularity.Name = "lPopularity";
            this.lPopularity.Size = new System.Drawing.Size(137, 30);
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
            this.genres.Size = new System.Drawing.Size(0, 28);
            this.genres.TabIndex = 8;
            // 
            // popularity
            // 
            this.popularity.AutoSize = true;
            this.popularity.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.popularity.Location = new System.Drawing.Point(119, 157);
            this.popularity.MaximumSize = new System.Drawing.Size(450, 0);
            this.popularity.Name = "popularity";
            this.popularity.Size = new System.Drawing.Size(0, 30);
            this.popularity.TabIndex = 9;
            // 
            // followers
            // 
            this.followers.AutoSize = true;
            this.followers.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.followers.Location = new System.Drawing.Point(119, 125);
            this.followers.Name = "followers";
            this.followers.Size = new System.Drawing.Size(0, 30);
            this.followers.TabIndex = 10;
            // 
            // lAlbums
            // 
            this.lAlbums.AutoSize = true;
            this.lAlbums.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lAlbums.Location = new System.Drawing.Point(13, 215);
            this.lAlbums.Name = "lAlbums";
            this.lAlbums.Size = new System.Drawing.Size(108, 30);
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
            this.albums.Size = new System.Drawing.Size(0, 28);
            this.albums.TabIndex = 13;
            // 
            // lLastAlbum
            // 
            this.lLastAlbum.AutoSize = true;
            this.lLastAlbum.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lLastAlbum.Location = new System.Drawing.Point(13, 243);
            this.lLastAlbum.Name = "lLastAlbum";
            this.lLastAlbum.Size = new System.Drawing.Size(156, 30);
            this.lLastAlbum.TabIndex = 14;
            this.lLastAlbum.Text = "Last album: ";
            // 
            // lastAlbum
            // 
            this.lastAlbum.AutoSize = true;
            this.lastAlbum.BackColor = System.Drawing.SystemColors.Menu;
            this.lastAlbum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastAlbum.Location = new System.Drawing.Point(119, 243);
            this.lastAlbum.MaximumSize = new System.Drawing.Size(450, 0);
            this.lastAlbum.Name = "lastAlbum";
            this.lastAlbum.Size = new System.Drawing.Size(0, 28);
            this.lastAlbum.TabIndex = 15;
            // 
            // lLastSingle
            // 
            this.lLastSingle.AutoSize = true;
            this.lLastSingle.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lLastSingle.Location = new System.Drawing.Point(13, 271);
            this.lLastSingle.Name = "lLastSingle";
            this.lLastSingle.Size = new System.Drawing.Size(148, 30);
            this.lLastSingle.TabIndex = 16;
            this.lLastSingle.Text = "Last single: ";
            // 
            // lastSingle
            // 
            this.lastSingle.AutoSize = true;
            this.lastSingle.BackColor = System.Drawing.SystemColors.Menu;
            this.lastSingle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastSingle.Location = new System.Drawing.Point(119, 271);
            this.lastSingle.MaximumSize = new System.Drawing.Size(450, 0);
            this.lastSingle.Name = "lastSingle";
            this.lastSingle.Size = new System.Drawing.Size(0, 28);
            this.lastSingle.TabIndex = 17;
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
            this.Save.Size = new System.Drawing.Size(67, 33);
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
            this.listbox.ItemHeight = 23;
            this.listbox.Location = new System.Drawing.Point(312, 76);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(141, 31);
            this.listbox.TabIndex = 19;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.Listbox_SelectedIndexChanged);
            this.listbox.Click += new System.EventHandler(this.Listbox_Click);
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
            // name
            // 
            this.name.AutoSize = true;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.name.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(475, 17);
            this.name.MaximumSize = new System.Drawing.Size(304, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(98, 42);
            this.name.TabIndex = 1;
            this.name.Text = "Artist";
            this.name.Visible = false;
            // 
            // Spotistat
            // 
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(646, 304);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.lastSingle);
            this.Controls.Add(this.lLastSingle);
            this.Controls.Add(this.lastAlbum);
            this.Controls.Add(this.lLastAlbum);
            this.Controls.Add(this.albums);
            this.Controls.Add(this.lAlbums);
            this.Controls.Add(this.followers);
            this.Controls.Add(this.popularity);
            this.Controls.Add(this.genres);
            this.Controls.Add(this.lPopularity);
            this.Controls.Add(this.lGenres);
            this.Controls.Add(this.lFollowers);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.UrlBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Spotistat";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Spotistat";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button Find;
        public System.Windows.Forms.Button Clear;
        public System.Windows.Forms.Label lFollowers;
        public System.Windows.Forms.Label lGenres;
        public System.Windows.Forms.Label lPopularity;
        public System.Windows.Forms.Label genres;
        public System.Windows.Forms.Label popularity;
        public System.Windows.Forms.Label followers;
        public System.Windows.Forms.Label lAlbums;
        public System.Windows.Forms.Label albums;
        public System.Windows.Forms.Label lLastAlbum;
        public System.Windows.Forms.Label lastAlbum;
        public System.Windows.Forms.Label lLastSingle;
        public System.Windows.Forms.Label lastSingle;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource templateBindingSource;
        public System.Windows.Forms.ComboBox listbox;
        private System.Windows.Forms.BindingSource templateBindingSource1;
        public System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Label name;
        public System.Windows.Forms.PictureBox picture;
        public System.Windows.Forms.TextBox UrlBox;
        public System.Windows.Forms.Button Save;
    }
}

