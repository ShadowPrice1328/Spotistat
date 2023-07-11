using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Spotistat
{
    public partial class Spotistat : Form
    {
        readonly SpotifyApiHandler handler = new SpotifyApiHandler();
        readonly TemplateManager templateManager;
        readonly UiManager uiManager;

        public Spotistat()
        {
            InitializeComponent();

            templateManager = new TemplateManager(this);
            uiManager = new UiManager(this, templateManager, handler);

            uiManager.FillDropdown();
        }
        private async void Find_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ExtractId();
                await uiManager.DisplayInfo(id);
            }
            catch (Exception)
            {
                uiManager.FocusError("Wrong URL!");
                return;
            }

            Save.Enabled = true;
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            uiManager.ClearUrlBox();
            uiManager.Default();
        }
        private void UrlBox_Leave(object sender, EventArgs e)
        {
            uiManager.HandleUrlBoxLeave();
        }
        public void UrlBox_Enter(object sender, EventArgs e)
        {
            uiManager.HandleUrlBoxEnter();
        }
        public void UrlBox_TextChanged(object sender, EventArgs e)
        {
            Save.Enabled = false;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            string id = ExtractId();

            List<Template> templates = templateManager.GetTemplates();

            templateManager.SaveTemplate(templates, id, name.Text);
            uiManager.FillDropdown();

            Delete.Enabled = true;
            listbox.Enabled = true;
        }
        private async void Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = listbox.GetItemText(listbox.SelectedItem);
            await uiManager.LoadTemplateInfo(selectedName);

            Delete.Enabled = true;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            string selectedName = listbox.GetItemText(listbox.SelectedItem);

            templateManager.DeleteTemplate(selectedName);
            listbox.Items.Remove(selectedName);

            uiManager.FillDropdown();
        }
        private void Listbox_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(Find, null);
        }
        private string ExtractId()
        {
            string[] parts = UrlBox.Text.Split('/', '?');
            string id = parts[4];
            return id;
        }
    }
}